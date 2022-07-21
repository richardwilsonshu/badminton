using Badminton.Enums;
using System.Runtime.Serialization;

namespace Badminton.Classes
{
    public class Player
    {
        public Guid Id { get; set; }
        public string FullName { get; set; }
        public Gender Gender { get; set; }
        public int Elo { get; set; }

        public DateTime CreatedDate { get; set; }
        // For reporting / statistics we will want to keep the player
        // If the player has not participated in any matches etc, then we can consider hard deleting them instead
        public bool IsDeleted { get; set; }
        public DateTime? DeletedDate { get; set; }

        public Dictionary<Session, List<EloHistory>> EloHistory { get; set; } = new Dictionary<Session, List<EloHistory>>();
        public Dictionary<Session, List<Match>> MatchesPlayed { get; set; } = new Dictionary<Session, List<Match>>();
        public Dictionary<Session, List<Player>> PlayedWith { get; set; } = new Dictionary<Session, List<Player>>();
        public Dictionary<Session, List<Player>> PlayedAgainst { get; set; } = new Dictionary<Session, List<Player>>();

        public Player(string fullName, Gender gender)
        {
            Id = Guid.NewGuid();
            FullName = fullName;
            Gender = gender;
            Elo = 1600;
            CreatedDate = DateTime.Now;
        }

        [IgnoreDataMember] public string Display => $"[{Elo}] ({MinutesSinceLastMatch}m)\t{FullName}";
        [IgnoreDataMember] public DateTime LastMatchTime => MatchesPlayed.LastOrDefault().Value?.Last()?.EndDate.GetValueOrDefault() ?? DateTime.MinValue;
        [IgnoreDataMember] public int MinutesSinceLastMatch => LastMatchTime != DateTime.MinValue ? (int)(DateTime.Now - LastMatchTime).TotalMinutes : 0;

        public void AddMatchPlayed(Session session, Match match)
        {
            if (!MatchesPlayed.ContainsKey(session))
            {
                MatchesPlayed[session] = new List<Match>();
            }

            MatchesPlayed[session].Add(match);
        }
    }
}
