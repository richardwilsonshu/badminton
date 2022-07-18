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
        public bool CanGenerateMatch 
        {
            get
            {
                var hasAvailablePlayers = TryGenerateMatch() != null;
                var isCourtFree = CourtsAvailableToday.Except(CourtsInUse).Any();
                return hasAvailablePlayers && isCourtFree;
            }
        }

        [IgnoreDataMember]
        public List<Player> PlayersInSession => WaitingPlayers
            .Concat(RestingPlayers)
            .Concat(ActiveMatches.SelectMany(m => m.PlayersOnCourt))
            .ToList();

        public Match? GetActiveMatchOnCourt(int courtNumber)
        {
            return ActiveMatches.FirstOrDefault(m => m.CourtNumber == courtNumber);
        }

        public Match? TryGenerateMatch()
        {
            if (!WaitingPlayers.Any())
            {
                return null;
            }

            // Find best match based on search filters / settings (TODO) and based on rank

            var waitingPlayer = WaitingPlayers.OrderBy(p => p.LastMatchTime).First();

            var eloSearchDelta = Constants.DefaultEloSearchDelta;

            // There may be only 1 beginner or 1 advanced player in the badminton session.
            // We don't want them to keep waiting until the delta is high enough for them to be matched...
            // TODO !

            var eloDeltasOfAllPlayers = WaitingPlayers // PlayersInSession
                .Where(p => p != waitingPlayer)
                .Select(p => new { EloDelta = Math.Abs(waitingPlayer.Elo - p.Elo), Player = p })
                .OrderBy(m => m.Player.LastMatchTime)
                .ToList();

            var lastMatch = waitingPlayer.AllMatchesPlayed.LastOrDefault();

            if (lastMatch?.StartDate > StartDate)
            {
                var minutesWaiting = (int) (DateTime.Now - waitingPlayer.LastMatchTime).TotalMinutes;

                if (minutesWaiting > Constants.EloSearchDeltaMinuteThreshold)
                {
                    eloSearchDelta += (minutesWaiting - Constants.EloSearchDeltaMinuteThreshold) * Constants.EloSearchDeltaMinuteMultiplier;
                }
            }

            var matchedPlayers = eloDeltasOfAllPlayers
                .Where(m => m.EloDelta >= -eloSearchDelta && m.EloDelta <= eloSearchDelta)
                .Take(Constants.MinPlayersForGame - 1)
                .ToList();

            matchedPlayers.Insert(0, new { EloDelta = 0, Player = waitingPlayer });

            if (matchedPlayers.Count != Constants.MinPlayersForGame)
            {
                return null;
            }

            matchedPlayers = matchedPlayers.OrderBy(m => m.EloDelta).ToList();

            var match = new Match
            {
                Side1Players = new BindingList<Player> { matchedPlayers[0].Player, matchedPlayers[3].Player },
                Side2Players = new BindingList<Player> { matchedPlayers[1].Player, matchedPlayers[2].Player },
            };

            return match;
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
