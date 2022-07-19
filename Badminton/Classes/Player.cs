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

        public List<EloHistory> EloHistory { get; set; } = new List<EloHistory>();
        public List<Match> AllMatchesPlayed { get; set; } = new List<Match>();
        public List<Player> PlayedWith { get; set; } = new List<Player> { };
        public List<Player> PlayedAgainst { get; set; } = new List<Player> { };

        public Player(string fullName, Gender gender)
        {
            Id = Guid.NewGuid();
            FullName = fullName;
            Gender = gender;
            Elo = 1600;
        }

        [IgnoreDataMember] public string Display => $"[{Elo}] ({MinutesSinceLastMatch}m)\t{FullName}";
        [IgnoreDataMember] public DateTime LastMatchTime => AllMatchesPlayed.Any() ? AllMatchesPlayed.Last().EndDate!.Value : DateTime.MinValue;
        [IgnoreDataMember] public int MinutesSinceLastMatch => LastMatchTime != DateTime.MinValue ? (int)(DateTime.Now - LastMatchTime).TotalMinutes : 0;
    }
}
