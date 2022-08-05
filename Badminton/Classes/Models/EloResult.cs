namespace Badminton.Classes
{
    public class EloResult
    {
        public int EloBefore { get; set; }
        public Player Player { get; set; }
        public int EloAfter { get; set; }

        public EloResult(int eloBefore, Player player, int eloAfter)
        {
            EloBefore = eloBefore;
            Player = player;
            EloAfter = eloAfter;
        }
    }
}
