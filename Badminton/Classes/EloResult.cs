namespace Badminton.Classes
{
    public class EloResult
    {
        public Match Match { get; set; }
        public int EloBefore { get; set; }
        public int EloAfter { get; set; }

        public EloResult(Match match, int eloBefore, int eloAfter)
        {
            Match = match;
            EloBefore = eloBefore;
            EloAfter = eloAfter;
        }
    }
}
