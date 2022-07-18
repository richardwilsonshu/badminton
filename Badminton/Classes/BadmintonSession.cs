using KGySoft.ComponentModel;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace Badminton.Classes
{
    public class BadmintonSession
    {
        public DateTime Start { get; set; }
        public SortableBindingList<Player> AvailablePlayers { get; set; } = new SortableBindingList<Player> { };
        public BindingList<Player> AllPlayers { get; set; } = new BindingList<Player> { };
        public BindingList<Match> Matches { get; set; } = new BindingList<Match> { };
        public Match? Court1Match { get; set; }
        public Match? Court2Match { get; set; }

        public BadmintonSession()
        {
            Start = DateTime.Now;
        }

        [IgnoreDataMember]
        public bool CanGenerateMatch 
        {
            get
            {
                var hasAvailablePlayers = TryGenerateMatch() != null;
                var isCourtFree = Court1Match == null || Court2Match == null;

                return hasAvailablePlayers && isCourtFree;
            }
        }

        [IgnoreDataMember]
        public List<Player> PlayersInSession => AvailablePlayers
            .Concat(Court1Match?.PlayersOnCourt ?? new List<Player>())
            .Concat(Court2Match?.PlayersOnCourt ?? new List<Player>())
            .ToList();

        public Match? TryGenerateMatch()
        {
            if (!AvailablePlayers.Any())
            {
                return null;
            }

            // Find best match based on search filters / settings (TODO) and based on rank

            var waitingPlayer = AvailablePlayers.OrderBy(p => p.LastMatchTime).First();

            var eloSearchDelta = Constants.DefaultEloSearchDelta;

            // There may be only 1 beginner or 1 advanced player in the badminton session.
            // We don't want them to keep waiting until the delta is high enough for them to be matched...
            // TODO !

            var eloDeltasOfNearestPlayers = AvailablePlayers // PlayersInSession
                .Where(p => p != waitingPlayer)
                .Select(p => new { EloDelta = Math.Abs(waitingPlayer.Elo - p.Elo), Player = p })
                .OrderBy(m => m.Player.LastMatchTime)
                .ToList();

            var lastMatch = waitingPlayer.AllMatchesPlayed.LastOrDefault();

            if (lastMatch?.Start > Start)
            {
                var minutesWaiting = (int) (DateTime.Now - waitingPlayer.LastMatchTime).TotalMinutes;

                if (minutesWaiting > Constants.EloSearchDeltaMinuteThreshold)
                {
                    eloSearchDelta += (minutesWaiting - Constants.EloSearchDeltaMinuteThreshold) * Constants.EloSearchDeltaMinuteMultiplier;
                }
            }

            var matchedPlayers = eloDeltasOfNearestPlayers
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

        public void StartMatch(Match match)
        {
            // Commit to starting the Match
            var courtNumber = Court1Match == null ? 1 : 2;

            if (courtNumber == 1)
            {
                Court1Match = match;
            }
            else
            {
                Court2Match = match;
            }

            match.CourtNumber = courtNumber;

            Matches.Add(match);

            match.PlayersOnCourt.ForEach(player => AvailablePlayers.Remove(player));
            AvailablePlayers.ApplySort(nameof(Player.LastMatchTime), ListSortDirection.Ascending);

            match.Begin();
        }

        public void FinishCourt1Match()
        {
            if (Court1Match == null)
            {
                return;
            }

            Court1Match.Finish();

            Court1Match.PlayersOnCourt.ForEach(player => AvailablePlayers.Add(player));
            Court1Match = null;
            AvailablePlayers.ApplySort(nameof(Player.LastMatchTime), ListSortDirection.Ascending);
        }

        public void FinishCourt2Match()
        {
            if (Court2Match == null)
            {
                return;
            }

            Court2Match.Finish();

            Court2Match.PlayersOnCourt.ForEach(player => AvailablePlayers.Add(player));
            Court2Match = null;
            AvailablePlayers.ApplySort(nameof(Player.LastMatchTime), ListSortDirection.Ascending);
        }
    }
}
