namespace Badminton.Classes
{
    public static class Constants
    {
        public const int MaxNumberOfCourts = 4;
        public const int MinPlayersForGame = 4; // TODO singles?

        public const int EloIntermediateLower = 900;
        public const int EloAdvancedLower = 1800;

        public const int DefaultEloSearchDelta = 500;
        public const int EloSearchDeltaMinuteThreshold = 5;
        public const int EloSearchDeltaMinuteMultiplier = 50;
    }
}
