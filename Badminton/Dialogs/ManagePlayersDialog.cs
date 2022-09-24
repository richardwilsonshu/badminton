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
            listBoxPlayers.DisplayMember = nameof(Player.FullName);
            listBoxPlayers.ValueMember = nameof(Player.FullName);

            ApplyPlayersFilter();

            var genderOptions = Enum
                .GetNames<Gender>()
                .Select(g => new { Text = g, Value = (Gender?)Enum.Parse<Gender>(g) })
                .ToList();

            genderOptions.Insert(0, new { Text = "Please Select", Value = (Gender?)null });

            comboBoxGender.DisplayMember = "Text";
            comboBoxGender.ValueMember = "Value";
            comboBoxGender.DataSource = genderOptions;
        }

        private void buttonAddNewPlayer_Click(object sender, EventArgs e)
        {
            var fullName = textBoxPlayerName.Text;
            var gender = (Gender?)comboBoxGender.SelectedValue;

            if (string.IsNullOrWhiteSpace(fullName) || gender == null)
            {
                return;
            }

            if (_badmintonClub.PlayerAlreadyExists(fullName))
            {
                MessageBox.Show($"'{fullName}' is already taken. Please change your name!", "Name Taken", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var newPlayer = new Player(fullName, gender.Value);

            _badmintonClub.Players.Add(newPlayer);
            ApplyPlayersFilter();

            textBoxPlayerName.Text = "";
            comboBoxGender.SelectedIndex = 0;
        }

        private void buttonAddToSession_Click(object sender, EventArgs e)
        {
            if (listBoxPlayers.SelectedItem is not Player player || 
                _badmintonClub.CurrentSession == null)
            {
                return;
            }

            _badmintonClub.Players.Remove(player);
            ApplyPlayersFilter();

            player.WaitingSinceDate = DateTime.Now.AddMinutes(-99);
            _badmintonClub.CurrentSession.WaitingPlayers.Add(player);

            _badmintonClub.CurrentSession.WaitingPlayers.ApplySort(nameof(Player.SecondsWaiting), ListSortDirection.Descending);
        }

        private void textBoxPlayerName_TextChanged(object sender, EventArgs e)
        {
            //buttonAddNewPlayer.Enabled = textBoxPlayerName.TextLength > 0;
        }

        private void buttonEditPlayer_Click(object sender, EventArgs e)
        {
            if (listBoxPlayers.SelectedItem is not Player player)
            {
                return;
            }

            using var editPlayerDialog = new EditPlayerDialog(_badmintonClub, player);
            editPlayerDialog.ShowDialog();

            listBoxPlayers.DisplayMember = "";
            listBoxPlayers.DisplayMember = nameof(Player.FullName);
        }

        private void buttonDeletePlayer_Click(object sender, EventArgs e)
        {
            if (listBoxPlayers.SelectedItem is not Player player)
            {
                return;
            }

            var confirmResult = MessageBox.Show("Remove this player from the club?", "Confirm Remove", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirmResult == DialogResult.Yes)
            {
                _badmintonClub.RemovePlayer(player);
            }
        }

        private void btnClearFilter_Click(object sender, EventArgs e)
        {
            textBoxFilter.Clear();
            ApplyPlayersFilter();
        }

        private void textBoxFilter_TextChanged(object sender, EventArgs e)
        {
            ApplyPlayersFilter();
        }

        private void ApplyPlayersFilter()
        {
            listBoxPlayers.Items.Clear();

            var filteredPlayers = _badmintonClub.Players.ToList();

            if (!string.IsNullOrWhiteSpace(textBoxFilter.Text))
            {
                filteredPlayers = filteredPlayers.Where(p => p.FullName.ToLower().Contains(textBoxFilter.Text.ToLower())).ToList();
            }

            foreach (var player in filteredPlayers)
            {
                listBoxPlayers.Items.Add(player);
            }
        }
    }
}
