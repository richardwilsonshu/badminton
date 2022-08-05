using ClosedXML.Excel;
using Newtonsoft.Json;
using System.Text.RegularExpressions;

namespace Badminton.Classes.Models
{
    public static class Migrator
    {
        public static string MigrateToLatest(string json, int jsonModelVersion)
        {
            if (jsonModelVersion == 1 && BadmintonClub.LatestModelVersion == 2)
            {
                json = Regex.Replace(json, @",""EloResults"":{""\$id"":""\d+""}", "");
                json = json.Replace(@",""DeletedPlayers""", @",""ModelVersion"":2,""DeletedPlayers""");
            }

            return json;
        }

        public static void MigrateToLatest(BadmintonClub badmintonClub, int modelVersion)
        {
            if (modelVersion == 1 && BadmintonClub.LatestModelVersion == 2)
            {
                CreateBackupBeforeMigration(badmintonClub, modelVersion, BadmintonClub.LatestModelVersion);

                RegenerateAllElos(badmintonClub);

                var sessionsToReport = badmintonClub.Sessions
                    .Where(s => s.Ended)
                    .Select((s, i) => new Tuple<int, Session>(i, s))
                    .ToList();

                GenerateReports(sessionsToReport);
            }
        }

        private static void CreateBackupBeforeMigration(BadmintonClub badmintonClub, int currentVersion, int nextVersion)
        {
            var backupFileName = $"V{currentVersion}_before_V{nextVersion}_migration_{Constants.FileName}";

            try
            {
                badmintonClub.ModelVersion = BadmintonClub.LatestModelVersion;

                using var writer = new StreamWriter(File.Open(backupFileName, FileMode.Create));
                writer.Write(JsonConvert.SerializeObject(badmintonClub, new JsonSerializerSettings()
                {
                    PreserveReferencesHandling = PreserveReferencesHandling.Objects
                }));
            }
            catch (Exception ex)
            {
                MessageBox.Show($"File '{backupFileName}' could not be saved. Error: {ex}", "Save", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        public static void RegenerateAllElos(BadmintonClub badmintonClub)
        {
            var allPlayers = badmintonClub.Players
                .Concat(badmintonClub.DeletedPlayers)
                .Concat(badmintonClub.CurrentSession.Players)
                .ToList();

            foreach (var player in allPlayers)
            {
                player.Elo = 1600;
            }

            foreach (var session in badmintonClub.Sessions)
            {
                var finishedRankedMatches = session.Matches.Where(m => m.Finished && !m.EloNotAffected);

                foreach (var match in finishedRankedMatches)
                {
                    foreach (var player in match.Players)
                    {
                        player.EloResults.Add(new EloResult(player.Elo, match, -1));
                    }

                    EloCalculator.UpdateElo(match);

                    foreach (var player in match.Players)
                    {
                        player.EloResults.Single(er => er.Match == match).EloAfter = player.Elo;
                    }
                }
            }
        }

        public static void GenerateReports(List<Tuple<int, Session>> sessions)
        {
            var players = sessions
                .SelectMany(s => s.Item2.FinishedMatches.SelectMany(m => m.Players))
                .Concat(sessions.SelectMany(s => s.Item2.Players))
                .Distinct()
                .ToList();

            foreach (var player in players)
            {
                GeneratePlayerReport(sessions, player);
            }

            // TODO Session Report "Sessions" -> 1 file per session, "Session_date.xlsx"
        }

        public static string ReplaceInvalidChars(string filename)
        {
            return string.Join("_", filename.Split(Path.GetInvalidFileNameChars()));
        }

        private static void GeneratePlayerReport(List<Tuple<int, Session>> sessions, Player player)
        {
            Directory.CreateDirectory("Players");

            var fileName = @$"Players\{ReplaceInvalidChars($"{player.FullName}.xlsx")}";
            bool needsHeader = false;

            using var workbook = File.Exists(fileName) 
                ? new XLWorkbook(fileName) 
                : new XLWorkbook();

            if (!workbook.TryGetWorksheet("Session Report", out var worksheet))
            {
                worksheet = workbook.Worksheets.Add("Session Report");
                needsHeader = true;
            }

            var rowNumber = worksheet.LastRowUsed()?.RowNumber() ?? 0;

            if (rowNumber <= 0)
            {
                needsHeader = true;
            }

            if (needsHeader)
            {
                var header = worksheet.Row(1);
                header.Style.Font.Bold = true;
                header.Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
                header.Style.Border.BottomBorder = XLBorderStyleValues.Thin;

                worksheet.Columns("B:K").Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
                worksheet.Range("B1", "F1").Merge();
                worksheet.Range("G1", "I1").Merge();

                worksheet.Cell("B1").Value = "Match";
                worksheet.Cell("G1").Value = "Score";
                worksheet.Cell("J1").Value = "Elo";
                worksheet.Cell("K1").Value = "Elo Change";
            }

            foreach (var (sessionIndex, session) in sessions)
            {
                rowNumber++;
                worksheet.Cell(rowNumber, 1).Value = $"Session {sessionIndex + 1}";
                worksheet.Cell(rowNumber, 1).Style.Font.Bold = true;

                var matches = session.Matches
                    .Where(m => m.Finished && m.Players.Contains(player))
                    .Select((m, i) => new Tuple<int, Match>(i, m))
                    .ToList();

                foreach (var (matchIndex, match) in matches)
                {
                    rowNumber++;
                    var colNumber = 1;
                    var eloResult = player.EloResults.SingleOrDefault(er => er.Match == match);

                    worksheet.Cell(rowNumber, colNumber++).Value = $"Match {matchIndex + 1}";
                    worksheet.Cell(rowNumber, colNumber++).Value = match.Team1Players[0].FullName;
                    worksheet.Cell(rowNumber, colNumber++).Value = match.Team1Players[1].FullName;
                    worksheet.Cell(rowNumber, colNumber++).Value = "vs";
                    worksheet.Cell(rowNumber, colNumber++).Value = match.Team2Players[0].FullName;
                    worksheet.Cell(rowNumber, colNumber++).Value = match.Team2Players[1].FullName;
                    worksheet.Cell(rowNumber, colNumber++).Value = match.Team1Score;
                    worksheet.Cell(rowNumber, colNumber++).Value = "-";
                    worksheet.Cell(rowNumber, colNumber++).Value = match.Team2Score;

                    if (eloResult != null)
                    {
                        worksheet.Cell(rowNumber, colNumber++).Value = eloResult.EloAfter;
                        worksheet.Cell(rowNumber, colNumber++).Value = eloResult.EloAfter - eloResult.EloBefore;
                    }
                }
            }

            worksheet.Columns().AdjustToContents();

            workbook.SaveAs(fileName);
        }
    }
}
