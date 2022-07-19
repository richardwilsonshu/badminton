using Badminton.Classes;
using System.ComponentModel;

namespace Badminton.Dialogs
{
    public partial class ManagePlayersDialog : Form
    {
        private BindingList<Player> _players = new BindingList<Player>();
        private BindingList<Player> _playersInSession = new BindingList<Player>();

        private BadmintonClub _badmintonClub = new();

        public ManagePlayersDialog(BadmintonClub badmintonClub)
        {
            InitializeComponent();

            SetBadmintonClub(badmintonClub);
        }

        public void SetBadmintonClub(BadmintonClub badmintonClub)
        {
            _badmintonClub = badmintonClub;

            // Different lists, but same Player references. (Shallow copy)
            _players = new BindingList<Player>(new List<Player>(badmintonClub.Players));
            _playersInSession = new BindingList<Player>(new List<Player>(_badmintonClub.CurrentSession!.PlayersInSession));

            listBoxPlayers.BindPlayers(_players);
            listBoxSessionPlayers.BindPlayers(_playersInSession);
        }

        private void buttonRemovePlayer_Click(object sender, EventArgs e)
        {
            if (listBoxPlayers.SelectedItem is not Player player)
            {
                return;
            }

            var confirmResult = MessageBox.Show("Remove this player?", "Confirm Remove", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirmResult == DialogResult.Yes)
            {
                _players.Remove(player);
            }
        }

        private void buttonAddPlayer_Click(object sender, EventArgs e)
        {
            using var playerDialog = new AddEditPlayerDialog();

            if (playerDialog.ShowDialog() == DialogResult.OK)
            {
                var newPlayer = playerDialog.AddedPlayer!;

                _players.Add(newPlayer);
            }
        }

        private void buttonAddToSession_Click(object sender, EventArgs e)
        {
            if (listBoxPlayers.SelectedItem is not Player player || 
                _badmintonClub.CurrentSession!.PlayersInSession.All(p => p.Id != player.Id))
            {
                return;
            }

            _playersInSession.Add(player);
        }

        private void buttonRemoveFromSession_Click(object sender, EventArgs e)
        {
            if (listBoxPlayers.SelectedItem is not Player player)
            {
                return;
            }

            _playersInSession.Remove(player);
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            var playersToAdd = _players.Except(_badmintonClub.Players).ToList();
            var playersToRemove = _badmintonClub.Players.Except(_players).ToList();

            foreach (var player in playersToAdd)
            {
                _badmintonClub.Players.Add(player);
            }
            foreach (var player in playersToRemove)
            {
                _badmintonClub.Players.Remove(player);
            }

            var session = _badmintonClub.CurrentSession!;
            var playersToAddToSession = _playersInSession.Except(session.PlayersInSession).ToList();
            var playersToRemoveFromSession = session.PlayersInSession.Except(_playersInSession).ToList();

            foreach (var player in playersToAddToSession)
            {
                session.WaitingPlayers.Add(player);
            }
            foreach (var player in playersToRemoveFromSession)
            {
                if (session.WaitingPlayers.Contains(player))
                {
                    session.WaitingPlayers.Remove(player);
                }
                else
                {
                    session.RestingPlayers.Remove(player);
                }
            }
        }
    }
}
