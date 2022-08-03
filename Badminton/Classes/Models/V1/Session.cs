using KGySoft.ComponentModel;

namespace Badminton.Classes.Models.V1
{
    public class Session
    {
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public SortableBindingList<Player> WaitingPlayers { get; set; } = new SortableBindingList<Player> { };
        public SortableBindingList<Player> RestingPlayers { get; set; } = new SortableBindingList<Player> { };
        public List<Match> Matches { get; set; } = new List<Match> { };
        public Match MatchPreview { get; set; } = new Match();
        public int CourtsAvailable { get; set; }

        public Session(int numberOfCourts)
        {
            CourtsAvailable = numberOfCourts;
        }
    }
}
