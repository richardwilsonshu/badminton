using System.ComponentModel;
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

        public static void MigrateToLatest(BadmintonClub badmintonClub, int modelVersion, BackgroundWorker backgroundWorker)
        {
            if (modelVersion == 1 && BadmintonClub.LatestModelVersion == 2)
            {
                backgroundWorker.ReportProgress(1);

                CreateBackupBeforeMigration(badmintonClub, modelVersion, BadmintonClub.LatestModelVersion);

                backgroundWorker.ReportProgress(5);

                RegenerateAllElos(badmintonClub);

                backgroundWorker.ReportProgress(10);

                var sessionsToReport = badmintonClub.Sessions
                    .Where(s => s.Ended)
                    .Select((s, i) => new Tuple<int, Session>(i, s))
                    .ToList();

                BadmintonClub.GenerateReports(sessionsToReport, badmintonClub, backgroundWorker);
            }
        }

        private static void CreateBackupBeforeMigration(BadmintonClub badmintonClub, int currentVersion, int nextVersion)
        {
            var backupFileName = $"V{currentVersion}_before_V{nextVersion}_migration_{Constants.FileName}";

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
                throw;
            }
        }

        public static void RegenerateAllElos(BadmintonClub badmintonClub)
        {
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
                }
            }
        }
    }
}
