namespace Badminton.Classes.Models.V1
{
    public class EloResult
    {
        public Session Session { get; set; }
        public Match Match { get; set; }
        public int EloBefore { get; set; }
        public int EloAfter { get; set; }

        public EloResult(Session session, Match match, int eloBefore, int eloAfter)
        {
            Session = session;
            Match = match;
            EloBefore = eloBefore;
            EloAfter = eloAfter;
        }
    }
}
