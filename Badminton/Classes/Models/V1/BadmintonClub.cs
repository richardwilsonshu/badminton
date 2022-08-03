using KGySoft.ComponentModel;

namespace Badminton.Classes.Models.V1
{
    public class BadmintonClub
    {
        public SortableBindingList<Player> Players { get; set; } = new SortableBindingList<Player>();
        public SortableBindingList<Player> DeletedPlayers { get; set; } = new SortableBindingList<Player>();
        public List<Session> Sessions { get; set; } = new List<Session>();
    }
}
