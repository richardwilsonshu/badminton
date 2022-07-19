namespace Badminton.Classes
{
    public class PlayerEventArgs : EventArgs
    {
        public Player Player { get; set; }

        public PlayerEventArgs(Player player)
        {
            Player = player;
        }
    }
}
