namespace Badminton.Classes
{
    public class EloResult
    {
        public Match Match { get; set; }
        public int EloAfter { get; set; }

        public EloResult(Match match, int eloAfter)
        {
            Match = match;
            EloAfter = eloAfter;
        }
    }
}
