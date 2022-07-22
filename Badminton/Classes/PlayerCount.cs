namespace Badminton.Classes
{
    public class PlayerCount
    {
        public Player Player { get; set; }
        public int Count { get; set; }

        public PlayerCount(Player player, int count)
        {
            Player = player;
            Count = count;
        }
    }
}
