using Badminton.Enums;
using System.Runtime.Serialization;

namespace Badminton.Classes
{
    public class Player
    {
        public string FullName { get; set; }
        public Gender Gender { get; set; }
        public int Elo { get; set; }

        public DateTime CreatedDate { get; set; }
        // For reporting / statistics we will want to keep the player
        // If the player has not participated in any matches etc, then we can consider hard deleting them instead
        public DateTime? WaitingSinceDate { get; set; }
        public DateTime? DeletedDate { get; set; }

        public Player(string fullName, Gender gender)
        {
            FullName = fullName;
            Gender = gender;
            Elo = 1600;
            CreatedDate = DateTime.Now;
        }

        /// <remarks>using int.MaxValue so that players that haven't played yet are prioritized and ordered first</remarks>
        [IgnoreDataMember] public int MinutesWaiting => WaitingSinceDate.HasValue ? (int)(DateTime.Now - WaitingSinceDate.Value).TotalMinutes : int.MaxValue;
        [IgnoreDataMember] public int SecondsWaiting => WaitingSinceDate.HasValue ? (int)(DateTime.Now - WaitingSinceDate.Value).TotalSeconds : int.MaxValue;
        [IgnoreDataMember] public string MinutesDisplay => MinutesWaiting == int.MaxValue ? "" : $"{MinutesWaiting} mins";
        [IgnoreDataMember] public string GenderDisplay => Gender == Gender.Male ? "M" : "F";


        //[IgnoreDataMember] public int AverageWaitTimeMins { get; set; } // TODO? - calculate every minute?

        public List<PlayerCount> GetPlayedAgainst(Session session)
        {
            return session.Matches
                .Where(match => match.Players.Contains(this))
                .SelectMany(match => match.Team1Players.Contains(this) ? match.Team2Players : match.Team1Players)
                .GroupBy(player => player)
                .Select(group => new PlayerCount(group.Key, group.Count()))
                .ToList();
        }

        public List<PlayerCount> GetPlayedWith(Session session)
        {
            return session.Matches
                .Where(match => match.Players.Contains(this))
                .SelectMany(match => match.Team1Players.Contains(this) ? match.Team1Players : match.Team2Players)
                .GroupBy(player => player)
                .Where(group => group.Key != this)
                .Select(group => new PlayerCount(group.Key, group.Count()))
                .ToList();
        }

        // TODO - not used, but could be useful later
        public int GetAverageWaitTime(Session session)
        {
            var finishedMatches = session.FinishedMatches.Where(m => m.Players.Contains(this)).ToList();

            if (!finishedMatches.Any())
            {
                return 0; // TODO large number?
                //Match picking may want to heavily prioritise those that have not played any match in the current sesison?
                // Or have another property "MatchesPlayedThisSession"? And other 'Sesison' variables that get updated on a timer / events and NOT persisted?
            }

            var totalWaitTime = -1D;

            for (var i = 0; i < finishedMatches.Count; i++)
            {
                if (i == 0)
                {
                    totalWaitTime = (finishedMatches[i].StartDate!.Value - session.StartDate!.Value).TotalMinutes;
                    continue;
                }

                totalWaitTime += (finishedMatches[i].StartDate!.Value - finishedMatches[i - 1].EndDate!.Value).TotalMinutes;
            }

            return (int)(totalWaitTime / finishedMatches.Count);
        }
    }
}
