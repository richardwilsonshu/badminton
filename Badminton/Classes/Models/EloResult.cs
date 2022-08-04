namespace Badminton.Classes
{
    public class EloResult
    {
        public int EloBefore { get; set; }
        public Match Match { get; set; }
        public int EloAfter { get; set; }

        public EloResult(int eloBefore, Match match, int eloAfter)
        {
            EloBefore = eloBefore;
            Match = match;
            EloAfter = eloAfter;
        }
    }
}
