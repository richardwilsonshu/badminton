using System.ComponentModel;
using System.Runtime.Serialization;

namespace Badminton.Classes.Models.V1
{
    public class Match
    {
        public BindingList<Player> Team1Players { get; set; } = new BindingList<Player> { };
        public BindingList<Player> Team2Players { get; set; } = new BindingList<Player> { };
        public int Team1Score { get; set; }
        public int Team2Score { get; set; }
        public int CourtNumber { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public bool EloNotAffected { get; set; }
    }
}
