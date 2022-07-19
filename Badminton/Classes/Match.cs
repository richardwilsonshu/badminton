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
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public bool EloNotAffected { get; set; }

        [IgnoreDataMember] public List<Player> PlayersOnCourt => Side1Players.Concat(Side2Players).ToList();
        [IgnoreDataMember] public bool Started => StartDate.HasValue;
        [IgnoreDataMember] public bool Finished => EndDate.HasValue;

        public void Begin()
        {
            StartDate = DateTime.Now;
        }

        // TODO Handle this in Session class instead?
        public void Finish()
        {
            EndDate = DateTime.Now;

            foreach (Player player in PlayersOnCourt)
            {
                player.AllMatchesPlayed.Add(this);
            }

            var side1Wins = Side1Score > Side2Score;

            //var eloCalculator = new EloCalculator();
            //eloCalculator.
        }
    }
}
