using System.ComponentModel;
using System.Runtime.Serialization;

namespace Badminton.Shared.Classes
{
    public class Match
    {
        public BindingList<Player> Team1Players { get; set; } = new();
        public BindingList<Player> Team2Players { get; set; } = new();
        public int Team1Score { get; set; }
        public int Team2Score { get; set; }
        public int CourtNumber { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public bool EloNotAffected { get; set; }
        public List<EloResult> EloResults { get; set; } = new();

        [IgnoreDataMember] public List<Player> Players => Team1Players.Concat(Team2Players).ToList();
        [IgnoreDataMember] public bool Started => StartDate.HasValue;
        [IgnoreDataMember] public bool Finished => EndDate.HasValue;
    }
}
