using Badminton.Classes;
using Badminton.Dialogs;

namespace Badminton.Controls
{
    public partial class SessionTabControl : UserControl
    {
        public event EventHandler? SessionEnded;

        private Session _session = new(new int[] { 1, 2, 3, 4 });

        public SessionTabControl()
        {
            InitializeComponent();
        }

        public void SetSession(Session session) 
        {
            _session = session;
            InitializeCustomControls();
        }

        private void InitializeCustomControls()
        {
            listBoxWaitingPlayers.Bind(_session.WaitingPlayers, nameof(Player.Display), nameof(Player.Id));
            listBoxRestingPlayers.BindPlayers(_session.RestingPlayers);

            EnableOrDisableGenerateGameButtons();

            BindCourt1();
            BindCourt2();

            listBoxWaitingPlayers.CustomTabOffsets.Add(50);
            listBoxWaitingPlayers.UseCustomTabOffsets = true;
        }

        private void BindCourt1()
        {
            var match = _session.GetActiveMatchOnCourt(1);

            if (match == null)
            {
                return;
            }

            listBoxCourt1Side1.BindPlayers(match.Side1Players);
            listBoxCourt1Side2.BindPlayers(match.Side2Players);
            panelCourt1.Enabled = true;
        }
        private void BindCourt2()
        {
            var match = _session.GetActiveMatchOnCourt(2);

            if (match == null)
            {
                return;
            }

            listBoxCourt2Side1.BindPlayers(match.Side1Players);
            listBoxCourt2Side2.BindPlayers(match.Side2Players);
            panelCourt2.Enabled = true;
        }

        private void EnableOrDisableGenerateGameButtons()
        {
            buttonGenerateGame.Enabled = _session.CanGenerateMatch;
        }

        private void buttonAddPlayerToSession_Click(object sender, EventArgs e)
        {
            using var clubPlayersDialog = new ManagePlayersDialog();
            clubPlayersDialog.ShowDialog();
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

            using var finishMatchForm = new FinishMatchDialog(match);

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

            using var finishMatchForm = new FinishMatchDialog(match);

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

        private void timer1_Tick(object sender, EventArgs e)
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

            using var playerDialog = new AddEditPlayerDialog(player);
            playerDialog.ShowDialog();
        }

        private void buttonEndSession_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Are you sure you want to end the current session?", "Confirm End Session", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirmResult == DialogResult.Yes)
            {
                SessionEnded?.Invoke(this, EventArgs.Empty);
            }
        }
    }
}
