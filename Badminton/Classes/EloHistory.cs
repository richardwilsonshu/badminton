namespace Badminton.Classes
{
    public class EloHistory
    {
        public Match Match { get; set; }
        public int EloResult { get; set; }

        public EloHistory(Match match, int eloResult)
        {
            Match = match;
            EloResult = eloResult;
        }
    }
}
