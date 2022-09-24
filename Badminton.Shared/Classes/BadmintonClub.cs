using KGySoft.ComponentModel;
using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;

namespace Badminton.Shared.Classes
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

        public delegate void ShowGenerateReportsDialogHandler(ShowGenerateReportsDialogEventArgs args);

        public event ShowGenerateReportsDialogHandler? ShowGenerateReportsDialog;
        public event EventHandler<string>? SaveFailed;

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

            var eventArgs = new ShowGenerateReportsDialogEventArgs(sessionsToReport);
            ShowGenerateReportsDialog?.Invoke(eventArgs);

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
                SaveFailed?.Invoke(this, $"File '{Constants.FileName}' could not be saved. Error: {ex}");
            }
        }

        public static BadmintonClub? Load(Action<BadmintonClub, int> migrationUIHandler)
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
                    migrationUIHandler?.Invoke(badmintonClub, jsonModelVersion);
                }

                return badmintonClub;
            }
            catch (OperationCanceledException ex)
            {
                throw ex;
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
