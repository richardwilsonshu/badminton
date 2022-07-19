using Badminton.Classes;
using System.ComponentModel;

namespace Badminton.Dialogs
{
    public partial class ManagePlayersDialog : Form
    {
        private BindingList<Player> _players = new BindingList<Player>();

        public ManagePlayersDialog()
        {
            InitializeComponent();
        }

        public void SetPlayers(BindingList<Player> players)
        {
            _players = players;
            listBoxPlayers.BindPlayers(players);
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

        private void buttonAddToSession_Click(object sender, EventArgs e)
        {

        }
    }
}
