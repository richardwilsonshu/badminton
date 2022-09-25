using ClosedXML.Excel;

namespace Badminton.Classes.Reports
{
    public static class LeaderboardReport
    {
        public static void Generate(BadmintonClub badmintonClub)
        {
            var fileName = "Leaderboard.xlsx";

            if (File.Exists(fileName))
            {
                File.Delete(fileName);
            }

            using var workbook = new XLWorkbook();

            var worksheet = workbook.Worksheets.Add("Leaderboard Report");

            var header = worksheet.Row(1);
            header.Style.Font.Bold = true;

            worksheet.Cell("A1").Value = "Player";
            worksheet.Cell("B1").Value = "Played";
            worksheet.Cell("C1").Value = "Wins";
            worksheet.Cell("D1").Value = "Losses";
            worksheet.Cell("E1").Value = "Elo";
            worksheet.Cell("F1").Value = "Last Played";

            var players = badmintonClub.CurrentSession.Players
                .Concat(badmintonClub.Players)
                .Distinct()
                .ToList();

            var rowNumber = 1;

            var finishedMatches = badmintonClub.Sessions.SelectMany(s => s.FinishedMatches);

            foreach (var player in players)
            {
                rowNumber++;
                var colNumber = 1;

                var matches = finishedMatches.Where(m => m.Players.Contains(player)).ToList();

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
                worksheet.Cell(rowNumber, colNumber++).Value = player.Elo;
                worksheet.Cell(rowNumber, colNumber++).Value = player.WaitingSinceDate.HasValue ? $"{player.WaitingSinceDate.Value:dd/MM/yyyy}" : "";
            }

            worksheet
                .Range(firstCellRow: 2, firstCellColumn: 1, lastCellRow: rowNumber, lastCellColumn: 6)
                .Sort(columnToSortBy: 5, XLSortOrder.Descending);

            worksheet.Columns().AdjustToContents();

            workbook.SaveAs(fileName);
        }
    }
}
