using KGySoft.ComponentModel;
using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace Badminton.Classes
{
    public class BadmintonClub
    {
        public SortableBindingList<Player> Players { get; set; } = new SortableBindingList<Player>();
        public SortableBindingList<Player> DeletedPlayers { get; set; } = new SortableBindingList<Player>();
        public List<Session> Sessions { get; set; } = new List<Session>();

        [IgnoreDataMember] public Session CurrentSession => Sessions.Last();

        public void EndCurrentSession()
        {
            foreach (var player in CurrentSession.Players)
            {
                Players.Add(player);
            }

            CurrentSession.EndDate = DateTime.Now;

            var placeholderSession = new Session(CurrentSession.CourtsAvailable);
            Sessions.Add(placeholderSession);
        }

        public void Save()
        {
            try
            {
                using var writer = new StreamWriter(File.Open(Constants.FileName, FileMode.Create));
                writer.Write(JsonConvert.SerializeObject(this, new JsonSerializerSettings()
                {
                    PreserveReferencesHandling = PreserveReferencesHandling.Objects
                }));
            }
            catch (Exception ex)
            {
                MessageBox.Show($"File '{Constants.FileName}' could not be saved. Error: {ex}", "Save", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static BadmintonClub? Load()
        {
            try
            {
                if (File.Exists(Constants.FileName))
                {
                    using var reader = new StreamReader(File.OpenRead(Constants.FileName));
                    return JsonConvert.DeserializeObject<BadmintonClub>(reader.ReadToEnd(), new JsonSerializerSettings()
                    {
                        PreserveReferencesHandling = PreserveReferencesHandling.Objects
                    })!;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"File '{Constants.FileName}' could not be loaded. Error: {ex}", "Load", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return null;
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

            player.IsDeleted = true;
            player.DeletedDate = DateTime.Now;

            DeletedPlayers.Add(player);
            Players.Remove(player);
        }
    }
}
