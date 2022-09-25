using ClosedXML.Excel;

namespace Badminton.Classes.Reports
{
    public static class PlayerIndividualReport
    {
        public static void Generate(List<Tuple<int, Session>> sessions, Player player)
        {
            Directory.CreateDirectory("Players");

            var fileName = @$"Players\{player.FullName.FormatForFileName()}.xlsx";
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
    }
}
