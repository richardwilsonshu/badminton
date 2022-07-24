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
        public SortableBindingList<Player> RestingPlayers { get; set; } = new SortableBindingList<Player> { };
        public List<Match> Matches { get; set; } = new List<Match> { };
        public Match MatchPreview { get; set; } = new Match();
        public int CourtsAvailable { get; set; }

        public Session(int numberOfCourts)
        {
            CourtsAvailable = numberOfCourts;
        }

        [IgnoreDataMember] public bool Started => StartDate.HasValue;
        [IgnoreDataMember] public bool Ended => EndDate.HasValue;
        [IgnoreDataMember]
        public List<Match> ActiveMatches => Matches.Where(m => m.Started && !m.Finished).ToList();

        [IgnoreDataMember]
        public int[] CourtsInUse => ActiveMatches.Select(m => m.CourtNumber).ToArray();

        [IgnoreDataMember] public bool AllCourtsInUse => ActiveMatches.Count == CourtsAvailable;

        [IgnoreDataMember]
        public List<Player> Players => WaitingPlayers
            .Concat(RestingPlayers)
            .Concat(ActiveMatches.SelectMany(m => m.Players))
            .Concat(MatchPreview.Players)
            .ToList();

        public Match? GetActiveMatchOnCourt(int courtNumber)
        {
            return ActiveMatches.FirstOrDefault(m => m.CourtNumber == courtNumber);
        }

        public void Start()
        {
            StartDate = DateTime.Now;
        }

        public void StartMatch()
        {
            var match = MatchPreview;
            var courtNumber = Enumerable.Range(1, CourtsAvailable).Except(CourtsInUse).FirstOrDefault();

            if (courtNumber == 0)
            {
                return;
            }

            match.StartDate = DateTime.Now;
            match.CourtNumber = courtNumber;
            match.Players.ForEach(player => WaitingPlayers.Remove(player));
            WaitingPlayers.ApplySort(nameof(Player.MinutesWaiting), ListSortDirection.Descending);
            Matches.Add(match);
            MatchPreview = new Match();
        }

        public void FinishMatch(Match match)
        {
            if (match == null)
            {
                return;
            }

            match.EndDate = DateTime.Now;

            foreach (var player in match.Players)
            {
                player.WaitingSinceDate = match.EndDate;
            }

            if (!match.EloNotAffected)
            {
                EloCalculator.UpdateElo(match);
            }

            match.Players.ForEach(player => WaitingPlayers.Add(player));
            WaitingPlayers.ApplySort(nameof(Player.MinutesWaiting), ListSortDirection.Descending);
        }

        public void AbandonMatch(Match match)
        {
            match.Players.ForEach(player => WaitingPlayers.Add(player));
            WaitingPlayers.ApplySort(nameof(Player.MinutesWaiting), ListSortDirection.Descending);

            Matches.Remove(match);
        }
    }
}
