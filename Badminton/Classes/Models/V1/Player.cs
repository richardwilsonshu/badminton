using Badminton.Enums;

namespace Badminton.Classes.Models.V1
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
        public bool IsDeleted { get; set; }
        public DateTime? DeletedDate { get; set; }

        public Dictionary<Session, List<EloResult>> EloResults { get; set; } = new Dictionary<Session, List<EloResult>>();

        public Player(string fullName, Gender gender)
        {
            FullName = fullName;
            Gender = gender;
            Elo = 1600;
            CreatedDate = DateTime.Now;
        }
    }
}
