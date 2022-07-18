using System.ComponentModel;
using System.Runtime.Serialization;

namespace Badminton.Classes
{
    public class Match
    {
        public BindingList<Player> Side1Players { get; set; } = new BindingList<Player> { };
        public BindingList<Player> Side2Players { get; set; } = new BindingList<Player> { };
        public int Side1Score { get; set; }
        public int Side2Score { get; set; }
        public int CourtNumber { get; set; }
        public DateTime? Start { get; set; }
        public DateTime? End { get; set; }
        public bool EloNotAffected { get; set; }

        [IgnoreDataMember] public List<Player> PlayersOnCourt => Side1Players.Concat(Side2Players).ToList();
        [IgnoreDataMember] public bool Started => Start.HasValue;
        [IgnoreDataMember] public bool Finished => End.HasValue;

        public void Begin()
        {
            Start = DateTime.Now;
        }

        public void Finish()
        {
            End = DateTime.Now;

            foreach (Player player in PlayersOnCourt)
            {
                player.AllMatchesPlayed.Add(this);
            }

            if (Side1Score == Side2Score)
            {
                return;
            }

            var side1Wins = Side1Score > Side2Score;

            CalculateAndUpdateElo(side1Wins);
        }

        // Taken from https://www.geeksforgeeks.org/elo-rating-algorithm/
        // Also see https://en.wikipedia.org/wiki/Elo_rating_system#Implementing_Elo's_scheme
        private float CalculateWinProbability(float rating1, float rating2)
        {
            return 1.0f * 1.0f / (1 + 1.0f * (float)(Math.Pow(10, 1.0f * (rating1 - rating2) / 400)));
        }

        /// <summary>Function to calculate Elo rating</summary>
        /// <param name="K">K is a constant</param>
        private void CalculateAndUpdateElo(bool side1Wins)
        {
            var side1TotalElo = Side1Players.Sum(p => p.Elo);
            var side2TotalElo = Side2Players.Sum(p => p.Elo);

            float side2WinProbability = CalculateWinProbability(side1TotalElo, side2TotalElo);
            float side1WinProbability = CalculateWinProbability(side2TotalElo, side1TotalElo);

            int side1EloAmount = 0;
            int side2EloAmount = 0;

            if (side1Wins)
            {
                side1EloAmount = (int) (1 - side1WinProbability);
                side2EloAmount = (int) (0 - side2WinProbability);
            }
            else
            {
                side1EloAmount = (int) (0 - side1WinProbability);
                side2EloAmount = (int) (1 - side2WinProbability);
            }

            foreach (var player in Side1Players)
            {
                var k = player.CalculateEloKFactor();
                player.Elo += k * side1EloAmount;
                player.EloHistory.Add(new EloHistory(this, player.Elo));
            }
            foreach (var player in Side2Players)
            {
                var k = player.CalculateEloKFactor();
                player.Elo += k * side2EloAmount;
                player.EloHistory.Add(new EloHistory(this, player.Elo));
            }

        }
    }
}
