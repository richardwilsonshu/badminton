using Badminton.Enums;
using System.Runtime.Serialization;

namespace Badminton.Classes
{
    public class Player
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Gender Gender { get; set; }
        public int Elo { get; set; }

        public List<EloHistory> EloHistory { get; set; } = new List<EloHistory>();
        public List<Match> AllMatchesPlayed { get; set; } = new List<Match>();

        public Player(string firstName, string lastName, Gender gender, int elo)
        {
            Id = Guid.NewGuid();
            FirstName = firstName;
            LastName = lastName;
            Gender = gender;
            Elo = elo;
        }

        [IgnoreDataMember] public string FullName => $"{FirstName} {LastName}";
        [IgnoreDataMember] public string Display => $"[{Elo}] ({MinutesSinceLastMatch}m)\t{FullName}";
        [IgnoreDataMember] public DateTime LastMatchTime => AllMatchesPlayed.Any() ? AllMatchesPlayed.Last().End!.Value : DateTime.MinValue;
        [IgnoreDataMember] public int MinutesSinceLastMatch => LastMatchTime != DateTime.MinValue ? (int)(DateTime.Now - LastMatchTime).TotalMinutes : 0;
        [IgnoreDataMember]
        public SkillLevel SkillLevel =>
            Elo < Constants.EloIntermediateLower ? SkillLevel.Beginner
          : Elo < Constants.EloAdvancedLower ? SkillLevel.Intermediate
          : SkillLevel.Advanced;

        public int CalculateEloKFactor()
        {
            if (AllMatchesPlayed.Count < 40)
            {
                return 40;
            } 
            else if (EloHistory.Select(eh => eh.EloResult).Max() < 2400)
            {
                return 20;
            }
            else
            {
                return 10;
            }
        }
    }
}
