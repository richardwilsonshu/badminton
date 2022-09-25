using ClosedXML.Excel;

namespace Badminton.Classes.Reports
{
    public static class SessionReport
    {
        public static void Generate(Session session)
        {
            Directory.CreateDirectory("Sessions");

            var fileName = @$"Sessions\Session {session.StartDate:yyyy-MM-dd - ddd d MMMM yyyy}.xlsx".FormatForFileName();

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
