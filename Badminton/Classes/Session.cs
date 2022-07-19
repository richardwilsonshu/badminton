using KGySoft.ComponentModel;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace Badminton.Classes
{
    public class Session
    {
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public SortableBindingList<Player> WaitingPlayers { get; set; } = new SortableBindingList<Player> { };
        public BindingList<Player> RestingPlayers { get; set; } = new BindingList<Player> { };
        public BindingList<Match> Matches { get; set; } = new BindingList<Match> { };
        public int[] CourtsAvailableToday { get; set; } = new int[] { 1, 2, 3, 4 };

        public Session(int[] courtsAvailable)
        {
            StartDate = DateTime.Now;
            CourtsAvailableToday = courtsAvailable;
        }

        [IgnoreDataMember]
        public List<Match> ActiveMatches => Matches.Where(m => m.Started && !m.Finished).ToList();

        [IgnoreDataMember]
        public int[] CourtsInUse => ActiveMatches.Select(m => m.CourtNumber).ToArray();

        [IgnoreDataMember]
        public List<Player> PlayersInSession => WaitingPlayers
            .Concat(RestingPlayers)
            .Concat(ActiveMatches.SelectMany(m => m.PlayersOnCourt))
            .ToList();

        public Match? GetActiveMatchOnCourt(int courtNumber)
        {
            return ActiveMatches.FirstOrDefault(m => m.CourtNumber == courtNumber);
        }

        public void Start(Match match)
        {
            var courtNumber = CourtsAvailableToday.Except(CourtsInUse).FirstOrDefault();

            if (courtNumber == 0)
            {
                return;
            }

            match.CourtNumber = courtNumber;
            match.PlayersOnCourt.ForEach(player => WaitingPlayers.Remove(player));
            WaitingPlayers.ApplySort(nameof(Player.LastMatchTime), ListSortDirection.Ascending);
            Matches.Add(match);
            match.Begin();
        }

        public void Finish(Match match)
        {
            if (match == null)
            {
                return;
            }

            match.Finish();
            match.PlayersOnCourt.ForEach(player => WaitingPlayers.Add(player));
            WaitingPlayers.ApplySort(nameof(Player.LastMatchTime), ListSortDirection.Ascending);
        }
    }
}
