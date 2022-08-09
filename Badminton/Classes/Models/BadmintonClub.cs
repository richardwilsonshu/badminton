using KGySoft.ComponentModel;
using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using Badminton.Classes.Models;
using Badminton.Dialogs;

namespace Badminton.Classes
{
    public class BadmintonClub
    {
        // Edit/Delete/Rename of any data model class/property will require a migration
        // And incrementing this number
        public static int LatestModelVersion = 2;

        public int ModelVersion { get; set; }
        public SortableBindingList<Player> Players { get; set; } = new();
        public SortableBindingList<Player> DeletedPlayers { get; set; } = new();
        public List<Session> Sessions { get; set; } = new();

        [IgnoreDataMember] public Session CurrentSession => Sessions.LastOrDefault() ?? new Session(4);

        public void EndCurrentSession()
        {
            foreach (var player in CurrentSession.Players)
            {
                Players.Add(player);
            }

            CurrentSession.EndDate = DateTime.Now;

            var sessionsToReport = new List<Tuple<int, Session>>
            {
                new Tuple<int, Session>(Sessions.Count - 1, CurrentSession)
            };

            using var progressDialog = new ProgressDialog("Generating Reports...", backgroundWork => Migrator.GenerateReports(sessionsToReport, backgroundWork));
            progressDialog.ShowDialog();

            var placeholderSession = new Session(CurrentSession.CourtsAvailable);
            Sessions.Add(placeholderSession);
        }

        public void Save()
        {
            try
            {
                ModelVersion = LatestModelVersion;

                using var writer = new StreamWriter(File.Open(Constants.FileName, FileMode.Create));
                writer.Write(JsonConvert.SerializeObject(this, new JsonSerializerSettings()
                {
                    PreserveReferencesHandling = PreserveReferencesHandling.Objects,
                    MaxDepth = null
                }));
            }
            catch (Exception ex)
            {
                MessageBox.Show($"File '{Constants.FileName}' could not be saved. Error: {ex}", "Save", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static BadmintonClub? Load()
        {
            if (!File.Exists(Constants.FileName))
            {
                return null;
            }

            try
            {
                using var reader = new StreamReader(File.OpenRead(Constants.FileName));

                var json = reader.ReadToEnd();
                var versionMatch = Regex.Match(json, @"""ModelVersion"":(\d+),");
                var jsonModelVersion = 1;

                if (versionMatch.Success)
                {
                    jsonModelVersion = int.Parse(versionMatch.Groups[1].Value);
                }

                if (jsonModelVersion != LatestModelVersion)
                {
                    json = Migrator.MigrateToLatest(json, jsonModelVersion);
                }

                var badmintonClub = JsonConvert.DeserializeObject<BadmintonClub>(json, new JsonSerializerSettings()
                {
                    PreserveReferencesHandling = PreserveReferencesHandling.Objects,
                    MaxDepth = null
                })!;

                if (jsonModelVersion != LatestModelVersion)
                {
                    var message = $"Migrating from version {jsonModelVersion} to {LatestModelVersion}...";
                    using var progressDialog = new ProgressDialog(message,
                        backgroundWorker =>
                            Migrator.MigrateToLatest(badmintonClub, jsonModelVersion, backgroundWorker));
                    if (progressDialog.ShowDialog() == DialogResult.Cancel)
                    {
                        throw new OperationCanceledException();
                    }
                }

                return badmintonClub;
            }
            catch (OperationCanceledException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"File '{Constants.FileName}' could not be loaded. Error: {ex}", "Load", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        public bool PlayerAlreadyExists(string fullName)
        {
            return CurrentSession.Players
                .Concat(Players)
                .Any(player => player.FullName.ToLower() == fullName.ToLower());
        }

        public void RemovePlayer(Player player)
        {
            if (!Players.Contains(player))
            {
                return;
            }

            player.DeletedDate = DateTime.Now;

            DeletedPlayers.Add(player);
            Players.Remove(player);
        }
    }
}
