using System.ComponentModel;
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

        public static void MigrateToLatest(BadmintonClub badmintonClub, int modelVersion, BackgroundWorker backgroundWorker)
        {
            if (modelVersion == 1 && BadmintonClub.LatestModelVersion == 2)
            {
                backgroundWorker.ReportProgress(1);

                CreateBackupBeforeMigration(badmintonClub, modelVersion, BadmintonClub.LatestModelVersion);

                backgroundWorker.ReportProgress(5);

                RegenerateAllElos(badmintonClub);

                backgroundWorker.ReportProgress(10);

                var sessionsToReport = badmintonClub.Sessions
                    .Where(s => s.Ended)
                    .Select((s, i) => new Tuple<int, Session>(i, s))
                    .ToList();

                GenerateReports(sessionsToReport, backgroundWorker);
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
                    EloCalculator.UpdateElo(match);
                }
            }
        }

        public static void GenerateReports(List<Tuple<int, Session>> sessions, BackgroundWorker backgroundWorker)
        {
            var players = sessions
                .SelectMany(s => s.Item2.FinishedMatches.SelectMany(m => m.Players))
                .Concat(sessions.SelectMany(s => s.Item2.Players))
                .Distinct()
                .ToList();

            var reportNumber = 0;
            var totalReports = players.Count + sessions.Count;

            foreach (var player in players)
            {
                if (backgroundWorker.CancellationPending)
                {
                    break;
                }

                Task.Delay(1000).Wait();

                GeneratePlayerReport(sessions, player);
                backgroundWorker.ReportProgress(10 + (int)((++reportNumber / (float)totalReports) * 100));
            }

            foreach (var (_, session) in sessions)
            {
                if (backgroundWorker.CancellationPending)
                {
                    break;
                }

                Task.Delay(1000).Wait();

                GenerateSessionReport(session);
                backgroundWorker.ReportProgress(10 + (int)((++reportNumber / (float)totalReports) * 100));
            }
        }

        public static string ReplaceInvalidChars(string filename)
        {
            return string.Join("_", filename.Split(Path.GetInvalidFileNameChars()));
        }

        private static void GeneratePlayerReport(List<Tuple<int, Session>> sessions, Player player)
        {
            Directory.CreateDirectory("Players");

            var fileName = @$"Players\{ReplaceInvalidChars($"{player.FullName}.xlsx")}";
            var needsHeader = false;

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
                    var eloResult = match.EloResults.SingleOrDefault(er => er.Player == player);

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

        private static void GenerateSessionReport(Session session)
        {
            Directory.CreateDirectory("Sessions");

            var fileName = @$"Sessions\{ReplaceInvalidChars($"Session {session.StartDate:yyyy-MM-dd - ddd d MMMM yyyy}.xlsx")}";

            if (File.Exists(fileName))
            {
                File.Delete(fileName);
            }

            using var workbook = new XLWorkbook();

            var worksheet = workbook.Worksheets.Add("Session Report");

            var header = worksheet.Row(1);
            header.Style.Font.Bold = true;

            worksheet.Cell("A1").Value = "Player";
            worksheet.Cell("B1").Value = "Played";
            worksheet.Cell("C1").Value = "Wins";
            worksheet.Cell("D1").Value = "Losses";
            worksheet.Cell("E1").Value = "Elo";
            worksheet.Cell("F1").Value = "Elo Change";

            var players = session.FinishedMatches
                .SelectMany(m => m.Players)
                .Concat(session.Players)
                .Distinct()
                .ToList();

            var rowNumber = 1;

            foreach (var player in players)
            {
                rowNumber++;
                var colNumber = 1;

                var matches = session.Matches
                    .Where(m => m.Finished && m.Players.Contains(player))
                    .ToList();

                var wins = matches.Count(m =>
                    m.Team1Players.Contains(player) && m.Team1Score > m.Team2Score ||
                    m.Team2Players.Contains(player) && m.Team2Score > m.Team1Score);

                var losses = matches.Count(m =>
                    m.Team1Players.Contains(player) && m.Team1Score < m.Team2Score ||
                    m.Team2Players.Contains(player) && m.Team2Score < m.Team1Score);

                worksheet.Cell(rowNumber, colNumber++).Value = player.FullName;
                worksheet.Cell(rowNumber, colNumber++).Value = matches.Count;
                worksheet.Cell(rowNumber, colNumber++).Value = wins;
                worksheet.Cell(rowNumber, colNumber++).Value = losses;

                var rankedMatches = matches.Where(m => !m.EloNotAffected).ToList();

                if (rankedMatches.Any())
                {
                    var firstElo = rankedMatches.First().EloResults.Single(er => er.Player == player).EloBefore;
                    var lastElo = rankedMatches.Last().EloResults.Single(er => er.Player == player).EloAfter;

                    worksheet.Cell(rowNumber, colNumber++).Value = lastElo;
                    worksheet.Cell(rowNumber, colNumber++).Value = lastElo - firstElo;
                }
            }

            worksheet
                .Range(firstCellRow: 2, firstCellColumn: 1, lastCellRow: rowNumber, lastCellColumn: 6)
                .Sort(columnToSortBy: 6, XLSortOrder.Descending);

            worksheet.Columns().AdjustToContents();

            workbook.SaveAs(fileName);
        }
    }
}
