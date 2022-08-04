using System.Text.RegularExpressions;

namespace Badminton.Classes.Models
{
    public static class Migrator
    {
        public static string MigrateToLatest(string json, int jsonModelVersion)
        {
            if (jsonModelVersion == 1 && BadmintonClub.LatestModelVersion == 2)
            {
                json = Regex.Replace(json, @",""EloResults"":{""\$id"":""\d+""}", "");
                json = json.Replace(@",""DeletedPlayers""", @",""ModelVersion"":2,""DeletedPlayers""");
            }

            return json;
        }
    }
}
