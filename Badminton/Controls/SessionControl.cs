using Badminton.Classes;
using Badminton.Forms;
using System.ComponentModel;

namespace Badminton.Controls
{
    public partial class SessionControl : UserControl
    {
        private Session _session { get; set; }

        public SessionControl(Session session)
        {
            _session = session;

            InitializeComponent();
            InitializeCustomControls();
        }

        private void InitializeCustomControls()
        {
            BindListBox(listBoxWaitingPlayers, _session.WaitingPlayers, nameof(Player.Display), nameof(Player.Id));
            BindPlayersListBox(listBoxRestingPlayers, _session.RestingPlayers);

            EnableOrDisableGenerateGameButtons();

            BindCourt1();
            BindCourt2();

            listBoxWaitingPlayers.CustomTabOffsets.Add(50);
            listBoxWaitingPlayers.UseCustomTabOffsets = true;
        }

        private void BindListBox(ListBox listBox, IBindingList bindingList, string displayMember, string valueMember)
        {
            listBox.DisplayMember = displayMember;
            listBox.ValueMember = valueMember;
            listBox.DataSource = bindingList;
        }

        private void BindPlayersListBox(ListBox listBox, IBindingList bindingList)
        {
            BindListBox(listBox, bindingList, nameof(Player.FullName), nameof(Player.Id));
        }

        private void BindCourt1()
        {
            var match = _session.GetActiveMatchOnCourt(1);

            if (match == null)
            {
                return;
            }

            BindPlayersListBox(listBoxCourt1Side1, match.Side1Players);
            BindPlayersListBox(listBoxCourt1Side2, match.Side2Players);
            panelCourt1.Enabled = true;
        }
        private void BindCourt2()
        {
            var match = _session.GetActiveMatchOnCourt(2);

            if (match == null)
            {
                return;
            }

            BindPlayersListBox(listBoxCourt2Side1, match.Side1Players);
            BindPlayersListBox(listBoxCourt2Side2, match.Side2Players);
            panelCourt2.Enabled = true;
        }

        private void EnableOrDisableGenerateGameButtons()
        {
            buttonGenerateGame.Enabled = _session.CanGenerateMatch;
        }

        private void buttonAddPlayerToSession_Click(object sender, EventArgs e)
        {
            using var newPlayerDialog = new UserForm(_session);
            newPlayerDialog.ShowDialog();
        }

        private void buttonRemovePlayerFromSession_Click(object sender, EventArgs e)
        {
            if (listBoxWaitingPlayers.SelectedItem is not Player player)
            {
                return;
            }

            var confirmResult = MessageBox.Show("Remove this player from current session?", "Confirm Remove", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirmResult == DialogResult.Yes)
            {
                _session.WaitingPlayers.Remove(player);
            }
        }

        private void buttonMoveToWaitingPlayers_Click(object sender, EventArgs e)
        {
            if (listBoxRestingPlayers.SelectedItem is not Player player)
            {
                return;
            }

            _session.RestingPlayers.Remove(player);
            _session.WaitingPlayers.Add(player);

            EnableOrDisableGenerateGameButtons();
        }

        private void buttonRemoveFromWaitingPlayers_Click(object sender, EventArgs e)
        {
            if (listBoxWaitingPlayers.SelectedItem is not Player player)
            {
                return;
            }

            _session.WaitingPlayers.Remove(player);
            _session.RestingPlayers.Add(player);

            EnableOrDisableGenerateGameButtons();
        }

        private void buttonGenerateGame_Click(object sender, EventArgs e)
        {
            var match = _session.TryGenerateMatch();

            if (match == null)
            {
                return;
            }

            _session.Start(match);

            EnableOrDisableGenerateGameButtons();

            if (match.CourtNumber == 1)
            {
                BindCourt1();
            }
            else
            {
                BindCourt2();
            }

            match.Begin();
        }

        private void buttonFinishCourt1_Click(object sender, EventArgs e)
        {
            var match = _session.GetActiveMatchOnCourt(1);

            if (match == null)
            {
                return;
            }

            using var finishMatchForm = new FinishMatchForm(match);

            if (finishMatchForm.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            _session.Finish(match);

            EnableOrDisableGenerateGameButtons();

            panelCourt1.Enabled = false;
            listBoxCourt1Side1.DataSource = null;
            listBoxCourt1Side2.DataSource = null;
        }

        private void buttonFinishCourt2_Click(object sender, EventArgs e)
        {
            var match = _session.GetActiveMatchOnCourt(2);

            if (match == null)
            {
                return;
            }

            using var finishMatchForm = new FinishMatchForm(match);

            if (finishMatchForm.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            _session.Finish(match);

            EnableOrDisableGenerateGameButtons();

            panelCourt2.Enabled = false;
            listBoxCourt2Side1.DataSource = null;
            listBoxCourt2Side2.DataSource = null;
        }

        private void timerMatches_Tick(object sender, EventArgs e)
        {
            // See https://stackoverflow.com/a/519557
            listBoxWaitingPlayers.DisplayMember = "";
            listBoxWaitingPlayers.DisplayMember = nameof(Player.Display);

            var court1Match = _session.GetActiveMatchOnCourt(1);
            var court2Match = _session.GetActiveMatchOnCourt(2);

            if (court1Match?.Started == true)
            {
                var elapsedTime = DateTime.Now - court1Match.StartDate!.Value;
                labelCourt1MatchTime.Text = $"Match time: {elapsedTime:h\\:mm\\:ss}";
            }
            else
            {
                labelCourt1MatchTime.Text = "Match time:";
            }

            if (court2Match?.Started == true)
            {
                var elapsedTime = DateTime.Now - court2Match.StartDate!.Value;
                labelCourt2MatchTime.Text = $"Match time: {elapsedTime:h\\:mm\\:ss}";
            }
            else
            {
                labelCourt2MatchTime.Text = "Match time:";
            }
        }

        private void listBoxWaitingPlayers_DoubleClick(object sender, EventArgs e)
        {
            if (listBoxWaitingPlayers.SelectedItem is not Player player)
            {
                return;
            }

            using var newPlayerDialog = new UserForm(_session, player);
            newPlayerDialog.ShowDialog();
        }

        private void buttonRemoveFromActivePlayers_Click(object sender, EventArgs e)
        {

        }
    }
}
