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
                // Create backup of V1 just in case...
                var backupFileName = $"V1_before_V2_migration_{Constants.FileName}";

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
                }

                // ! Re-calculate ALL Elos !

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

                GenerateReports(badmintonClub);
            }
        }

        public static void GenerateReports(BadmintonClub badmintonClub)
        {
            // Generate Reports
            #region Reports

            using var workbook = new XLWorkbook();

            var worksheet = workbook.Worksheets.Add("Session Report");

            var header = worksheet.Row(1);
            header.Style.Font.Bold = true;
            header.Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
            header.Style.Border.BottomBorder = XLBorderStyleValues.Thin;

            worksheet.Range("B1", "F1").Merge();
            worksheet.Range("G1", "I1").Merge();

            worksheet.Cell("B1").Value = "Match";
            worksheet.Cell("G1").Value = "Score";
            worksheet.Cell("J1").Value = "Elo";
            worksheet.Cell("K1").Value = "Elo Change";

            var sessionNumber = 0;
            var rowNumber = 0;
            var finishedSessions = badmintonClub.Sessions.Where(session => session.Ended).ToList();

            foreach (var session in finishedSessions)
            {
                sessionNumber++;
                rowNumber++;

                worksheet.Cell(rowNumber, 1).Value = $"Session {sessionNumber}";

                //foreach (var player in session.Players)
                //{
                //    //var matchesPlayed = session.Matches
                //    //    .Where(m => m.Finished && m.Players.Contains(player))
                //    //    .OrderBy(m => m.EndDate)
                //    //    .ToList();

                //    //var startingElo = 0;
                //    //var endingElo = 0;

                //    //if (matchesPlayed.Any())
                //    //{
                //    //    startingElo = player.EloResults.Single(er => er.Match == matchesPlayed.First()).EloBefore;
                //    //    endingElo = player.EloResults.Single(er => er.Match == matchesPlayed.Last()).EloAfter;
                //    //}

                //    //var sessionReportPlayer = new SessionReportPlayer(player)
                //    //{
                //    //    Played = matchesPlayed.Count,
                //    //    Wins = matchesPlayed.Count(m => m.Team1Players.Contains(player) && m.Team1Score > m.Team2Score),
                //    //    Losses = matchesPlayed.Count(m => m.Team1Players.Contains(player) && m.Team1Score < m.Team2Score),
                //    //    EloChange = endingElo - startingElo
                //    //};
                //}

                var matchNumber = 0;
                var finishedMatches = session.Matches.Where(m => m.Finished).ToList();

                foreach (var match in finishedMatches)
                {
                    matchNumber++;
                    rowNumber++;
                    var colNumber = 1;

                    worksheet.Cell(rowNumber, colNumber++).Value = $"Match {matchNumber}";
                    worksheet.Cell(rowNumber, colNumber++).Value = match.Team1Players[0].FullName;
                    worksheet.Cell(rowNumber, colNumber++).Value = match.Team1Players[1].FullName;
                    worksheet.Cell(rowNumber, colNumber++).Value = "vs";
                    worksheet.Cell(rowNumber, colNumber++).Value = match.Team2Players[0].FullName;
                    worksheet.Cell(rowNumber, colNumber++).Value = match.Team2Players[1].FullName;
                    worksheet.Cell(rowNumber, colNumber++).Value = match.Team1Score;
                    worksheet.Cell(rowNumber, colNumber++).Value = "-";
                    worksheet.Cell(rowNumber, colNumber++).Value = match.Team2Score;

                    var matchEloAverage = match.Players.Sum(p => p.EloResults.Single(er => er.Match == match).EloAfter) / match.Players.Count;

                    worksheet.Cell(rowNumber, colNumber++).Value = matchEloAverage;

                    // NOTE: All Elos get the same change
                    var team1Player1Result = match.Team1Players[0].EloResults.Single(er => er.Match == match);
                    var eloChange = team1Player1Result.EloAfter - team1Player1Result.EloBefore;

                    worksheet.Cell(rowNumber, colNumber++).Value = eloChange;
                }
            }

            worksheet.Columns().AdjustToContents();

            workbook.SaveAs($"Report_{DateTime.Now:yyyyMMddTHHmmss}.xlsx");

            #endregion
        }
    }
}
