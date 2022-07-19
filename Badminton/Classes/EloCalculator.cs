namespace Badminton.Classes
{
    public class EloCalculator
    {
        // Taken from https://www.geeksforgeeks.org/elo-rating-algorithm/
        // Also see https://en.wikipedia.org/wiki/Elo_rating_system#Implementing_Elo's_scheme
        private float CalculateWinProbability(float rating1, float rating2)
        {
            return 1.0f * 1.0f / (1 + 1.0f * (float)(Math.Pow(10, 1.0f * (rating1 - rating2) / 400)));
        }

        // Calculate from scores etc
        //private float Calculate(float player1Elo, float player2Elo)
        //{

        //}
    }
}
