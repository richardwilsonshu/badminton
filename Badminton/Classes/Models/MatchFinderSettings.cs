namespace Badminton.Classes.Models
{
    public class MatchFinderSettings
    {
        public int TeammateWeighting { get; set; } = 100;
        public int OpponentWeighting { get; set; } = 100;
        public int LastMatchWeighting { get; set; } = 100;
        public int AverageWaitingWeighting { get; set; } = 100;
        public int EloTeamVarianceWeighting { get; set; } = 100;
    }
}
