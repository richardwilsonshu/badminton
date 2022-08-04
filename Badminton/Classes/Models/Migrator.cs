using Newtonsoft.Json;
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

        public static void MigrateToLatest(BadmintonClub badmintonClub, int modelVersion)
        {
            if (modelVersion == 1 && BadmintonClub.LatestModelVersion == 2)
            {
                // Create backup of V1 just in case...
                var backupFileName = $"V1_before_V2_migration_{Constants.FileName}";

                try
                {
                    badmintonClub.ModelVersion = BadmintonClub.LatestModelVersion;

                    using var writer = new StreamWriter(File.Open(backupFileName, FileMode.Create));
                    writer.Write(JsonConvert.SerializeObject(badmintonClub, new JsonSerializerSettings()
                    {
                        PreserveReferencesHandling = PreserveReferencesHandling.Objects
                    }));
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"File '{backupFileName}' could not be saved. Error: {ex}", "Save", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                // ! Re-calculate ALL Elos !

                var allPlayers = badmintonClub.Players
                    .Concat(badmintonClub.DeletedPlayers)
                    .Concat(badmintonClub.CurrentSession.Players)
                    .ToList();

                foreach (var player in allPlayers)
                {
                    player.Elo = 1600;
                }

                foreach (var session in badmintonClub.Sessions)
                {
                    var finishedRankedMatches = session.Matches.Where(m => m.Finished && !m.EloNotAffected);

                    foreach (var match in finishedRankedMatches)
                    {
                        EloCalculator.UpdateElo(match);

                        foreach (var player in match.Players)
                        {
                            player.EloResults.Add(new EloResult(match, player.Elo));
                        }
                    }
                }

                // Generate Reports


            }
        }
    }
}
