namespace Badminton.Classes
{
    public class EloCalculator
    {
        public static void UpdateElo(Match match)
        {
            int K = 20;
            double Ea = 0.0;
            int DeltaElo = 0;
            float WinnerElo = 0;
            float LosserElo = 0;

            if (match.Team1Score > match.Team2Score)
            {
                WinnerElo = (match.Team1Players[0].Elo + match.Team1Players[1].Elo) / 2;
                LosserElo = (match.Team2Players[0].Elo + match.Team2Players[1].Elo) / 2;
            }
            else
            {
                WinnerElo = (match.Team2Players[0].Elo + match.Team2Players[1].Elo) / 2;
                LosserElo = (match.Team1Players[0].Elo + match.Team1Players[1].Elo) / 2;
            }

            Ea = 1.0f / (1.0f + Math.Pow(10.0f, (WinnerElo - LosserElo) / 400));
            DeltaElo = Convert.ToInt32(Ea * K);

            if (match.Team1Score > match.Team2Score)
            {
                UpdatePlayerElo(match, match.Team1Players[0], DeltaElo);
                UpdatePlayerElo(match, match.Team1Players[1], DeltaElo);
                UpdatePlayerElo(match, match.Team2Players[0], -DeltaElo);
                UpdatePlayerElo(match, match.Team2Players[1], -DeltaElo);
            }
            else
            {
                UpdatePlayerElo(match, match.Team1Players[0], -DeltaElo);
                UpdatePlayerElo(match, match.Team1Players[1], -DeltaElo);
                UpdatePlayerElo(match, match.Team2Players[0], DeltaElo);
                UpdatePlayerElo(match, match.Team2Players[1], DeltaElo);
            }
        }

        private static void UpdatePlayerElo(Match match, Player player, int deltaElo)
        {
            var eloResult = new EloResult(player.Elo, player, -1);
            player.Elo += deltaElo;
            eloResult.EloAfter = player.Elo;
            match.EloResults.Add(eloResult);
        }
    }
}
