using Badminton.Classes;
using Badminton.Enums;
using System.ComponentModel;

namespace Badminton.Dialogs
{
    public partial class ManagePlayersDialog : Form
    {
        private BadmintonClub _badmintonClub;

        public ManagePlayersDialog(BadmintonClub badmintonClub)
        {
            InitializeComponent();

            _badmintonClub = badmintonClub;

            InitializeCustomControls();
        }

        private void InitializeCustomControls()
        {
            listBoxPlayers.BindPlayers(_badmintonClub.Players);

            var genderOptions = Enum
                .GetNames<Gender>()
                .Select(g => new { Text = g, Value = Enum.Parse<Gender>(g) })
                .ToList();

            comboBoxGender.DisplayMember = "Text";
            comboBoxGender.ValueMember = "Value";
            comboBoxGender.DataSource = genderOptions;
        }

        private void buttonAddNewPlayer_Click(object sender, EventArgs e)
        {
            var fullName = textBoxPlayerName.Text;
            var gender = (Gender)comboBoxGender.SelectedValue;

            if (string.IsNullOrWhiteSpace(fullName))
            {
                return;
            }

            if (_badmintonClub.PlayerAlreadyExists(fullName))
            {
                MessageBox.Show($"'{fullName}' is already taken. Please change your name!", "Name Taken", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var newPlayer = new Player(fullName, gender);

            _badmintonClub.Players.Add(newPlayer);

            textBoxPlayerName.Text = "";
        }

        private void buttonAddToSession_Click(object sender, EventArgs e)
        {
            if (listBoxPlayers.SelectedItem is not Player player || 
                _badmintonClub.CurrentSession == null)
            {
                return;
            }

            _badmintonClub.Players.Remove(player);

            player.WaitingSinceDate = DateTime.Now;
            _badmintonClub.CurrentSession.WaitingPlayers.Add(player);

            _badmintonClub.CurrentSession.WaitingPlayers.ApplySort(nameof(Player.SecondsWaiting), ListSortDirection.Descending);
        }

        private void textBoxPlayerName_TextChanged(object sender, EventArgs e)
        {
            buttonAddNewPlayer.Enabled = textBoxPlayerName.TextLength > 0;
        }
    }
}
