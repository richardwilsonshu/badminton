using Badminton.Classes;
using Badminton.Enums;
using System.ComponentModel;

namespace Badminton.Dialogs
{
    public partial class ManagePlayersDialog : Form
    {
        private BadmintonClub _badmintonClub = new();

        public ManagePlayersDialog(BadmintonClub badmintonClub)
        {
            InitializeComponent();
            InitializeCustomControls();

            SetBadmintonClub(badmintonClub);
        }

        private void InitializeCustomControls()
        {
            var genderOptions = Enum
                .GetNames<Gender>()
                .Select(g => new { Text = g, Value = Enum.Parse<Gender>(g) })
                .ToList();

            comboBoxGender.DisplayMember = "Text";
            comboBoxGender.ValueMember = "Value";
            comboBoxGender.DataSource = genderOptions;
        }

        public void SetBadmintonClub(BadmintonClub badmintonClub)
        {
            _badmintonClub = badmintonClub;
            listBoxPlayers.BindPlayers(badmintonClub.Players);
        }

        private void buttonAddPlayer_Click(object sender, EventArgs e)
        {
            // TODO get from textbox and combo
            //var newPlayer = playerDialog.AddedPlayer!;

            //_players.Add(newPlayer);
        }

        private void buttonAddToSession_Click(object sender, EventArgs e)
        {
            if (listBoxPlayers.SelectedItem is not Player player)
            {
                return;
            }

            _badmintonClub.Players.Add(player);
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
