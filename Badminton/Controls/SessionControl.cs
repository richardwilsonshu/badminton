using Badminton.Classes;
using Badminton.Dialogs;
using System.ComponentModel;
using Badminton.Classes.Models;

namespace Badminton.Controls
{
    public partial class SessionControl : UserControl
    {
        private BadmintonClub _badmintonClub = new();
        private Session Session => _badmintonClub.CurrentSession!;

        public event EventHandler? SessionFinished;

        public SessionControl()
        {
            InitializeComponent();
        }

        public void SetBadmintonClub(BadmintonClub badmintonClub) 
        {
            _badmintonClub = badmintonClub;
            InitializeCustomControls();
        }

        private void InitializeCustomControls()
        {
            dataGridViewWaitingPlayers.DataSource = Session.WaitingPlayers;
            dataGridViewRestingPlayers.DataSource = Session.RestingPlayers;

            dataGridViewMatchPreviewTeam1.DataSource = Session.MatchPreview.Team1Players;
            dataGridViewMatchPreviewTeam2.DataSource = Session.MatchPreview.Team2Players;

            buttonStartSession.Enabled = !Session.Started;
            buttonStartSession.BackColor = Session.Started ? Color.Empty : Color.FromArgb(157, 255, 165);
            buttonEndSession.Enabled = Session.Started;
            buttonEndSession.BackColor = Session.Started ? Color.Red : Color.Empty;

            UpdateMatchPreviewState();

            BindCourt1();
            BindCourt2();
            BindCourt3();
            BindCourt4();

            comboBoxCourtsAvailable.SelectedIndex = Session.CourtsAvailable - 1;
        }

        private void BindCourt1()
        {
            var match = Session.GetActiveMatchOnCourt(1);

            if (match == null)
            {
                return;
            }

            listBoxCourt1Team1.BindPlayers(match.Team1Players);
            listBoxCourt1Team2.BindPlayers(match.Team2Players);
            panelCourt1.Enabled = true;
        }
        private void BindCourt2()
        {
            var match = Session.GetActiveMatchOnCourt(2);

            if (match == null)
            {
                return;
            }

            listBoxCourt2Team1.BindPlayers(match.Team1Players);
            listBoxCourt2Team2.BindPlayers(match.Team2Players);
            panelCourt2.Enabled = true;
        }

        private void BindCourt3()
        {
            var match = Session.GetActiveMatchOnCourt(3);

            if (match == null)
            {
                return;
            }

            listBoxCourt3Team1.BindPlayers(match.Team1Players);
            listBoxCourt3Team2.BindPlayers(match.Team2Players);
            panelCourt3.Enabled = true;
        }

        private void BindCourt4()
        {
            var match = Session.GetActiveMatchOnCourt(4);

            if (match == null)
            {
                return;
            }

            listBoxCourt4Team1.BindPlayers(match.Team1Players);
            listBoxCourt4Team2.BindPlayers(match.Team2Players);
            panelCourt4.Enabled = true;
        }

        private void buttonAddPlayerToSession_Click(object sender, EventArgs e)
        {
            using var managePlayersDialog = new ManagePlayersDialog(_badmintonClub);
            managePlayersDialog.ShowDialog();
        }

        private void buttonRemovePlayerFromSession_Click(object sender, EventArgs e)
        {
            if (dataGridViewWaitingPlayers.SelectedRows.Count <= 0 ||
                dataGridViewWaitingPlayers.SelectedRows[0].DataBoundItem is not Player player)
            {
                return;
            }

            var confirmResult = MessageBox.Show("Remove this player from current session?", "Confirm Remove", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirmResult == DialogResult.Yes)
            {
                Session.WaitingPlayers.Remove(player);
                _badmintonClub.Players.Add(player);

                Session.WaitingPlayers.ApplySort(nameof(Player.SecondsWaiting), ListSortDirection.Descending);
            }
        }

        private void buttonEndRest_Click(object sender, EventArgs e)
        {
            if (dataGridViewRestingPlayers.SelectedRows.Count <= 0 ||
                dataGridViewRestingPlayers.SelectedRows[0].DataBoundItem is not Player player)
            {
                return;
            }

            Session.RestingPlayers.Remove(player);
            Session.WaitingPlayers.Add(player);

            Session.RestingPlayers.ApplySort(nameof(Player.SecondsWaiting), ListSortDirection.Descending);
            Session.WaitingPlayers.ApplySort(nameof(Player.SecondsWaiting), ListSortDirection.Descending);
        }

        private void buttonRestPlayer_Click(object sender, EventArgs e)
        {
            if (dataGridViewWaitingPlayers.SelectedRows.Count <= 0 ||
                dataGridViewWaitingPlayers.SelectedRows[0].DataBoundItem is not Player player)
            {
                return;
            }

            Session.WaitingPlayers.Remove(player);
            Session.RestingPlayers.Add(player);

            Session.WaitingPlayers.ApplySort(nameof(Player.SecondsWaiting), ListSortDirection.Descending);
            Session.RestingPlayers.ApplySort(nameof(Player.SecondsWaiting), ListSortDirection.Descending);
        }

        private void buttonFinishCourt1_Click(object sender, EventArgs e)
        {
            var match = Session.GetActiveMatchOnCourt(1);

            if (match == null)
            {
                return;
            }

            var dialogResult = FinishMatch(match);

            if (dialogResult == DialogResult.Cancel)
            {
                return;
            }

            panelCourt1.Enabled = false;
            listBoxCourt1Team1.DataSource = null;
            listBoxCourt1Team2.DataSource = null;
            labelCourt1MatchTime.Text = "Match time:";

            _badmintonClub.Save();
        }

        private void buttonFinishCourt2_Click(object sender, EventArgs e)
        {
            var match = Session.GetActiveMatchOnCourt(2);

            if (match == null)
            {
                return;
            }

            var dialogResult = FinishMatch(match);

            if (dialogResult == DialogResult.Cancel)
            {
                return;
            }

            panelCourt2.Enabled = false;
            listBoxCourt2Team1.DataSource = null;
            listBoxCourt2Team2.DataSource = null;
            labelCourt2MatchTime.Text = "Match time:";

            _badmintonClub.Save();
        }

        private void buttonFinishCourt3_Click(object sender, EventArgs e)
        {
            var match = Session.GetActiveMatchOnCourt(3);

            if (match == null)
            {
                return;
            }

            var dialogResult = FinishMatch(match);

            if (dialogResult == DialogResult.Cancel)
            {
                return;
            }

            panelCourt3.Enabled = false;
            listBoxCourt3Team1.DataSource = null;
            listBoxCourt3Team2.DataSource = null;
            labelCourt3MatchTime.Text = "Match time:";

            _badmintonClub.Save();
        }

        private void buttonFinishCourt4_Click(object sender, EventArgs e)
        {
            var match = Session.GetActiveMatchOnCourt(4);

            if (match == null)
            {
                return;
            }

            var dialogResult = FinishMatch(match);

            if (dialogResult == DialogResult.Cancel)
            {
                return;
            }

            panelCourt4.Enabled = false;
            listBoxCourt4Team1.DataSource = null;
            listBoxCourt4Team2.DataSource = null;
            labelCourt4MatchTime.Text = "Match time:";

            _badmintonClub.Save();
        }

        private DialogResult FinishMatch(Match match)
        {
            using var finishMatchDialog = new FinishMatchDialog(match);

            var dialogResult = finishMatchDialog.ShowDialog();

            if (dialogResult == DialogResult.Abort)
            {
                Session.AbandonMatch(match);
            }
            else if (dialogResult == DialogResult.OK)
            {
                Session.FinishMatch(match);
            }

            return dialogResult;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //Session.WaitingPlayers.ApplySort(nameof(Player.SecondsWaiting), ListSortDirection.Descending);
            dataGridViewWaitingPlayers.Refresh();

            // TODO perhaps find a less repetitive way with lists?
            foreach (var match in Session.ActiveMatches)
            {
                var elapsedTime = DateTime.Now - match.StartDate!.Value;
                var text = $"Match time: {elapsedTime:h\\:mm\\:ss}";

                if (match.CourtNumber == 1)
                {
                    labelCourt1MatchTime.Text = text;
                }
                else if (match.CourtNumber == 2)
                {
                    labelCourt2MatchTime.Text = text;
                }
                else if (match.CourtNumber == 3)
                {
                    labelCourt3MatchTime.Text = text;
                }
                else if (match.CourtNumber == 4)
                {
                    labelCourt4MatchTime.Text = text;
                }
            }
        }

        private void buttonStartSession_Click(object sender, EventArgs e)
        {
            var numberOfCourts = comboBoxCourtsAvailable.SelectedIndex + 1;

            Session.CourtsAvailable = numberOfCourts;
            Session.Start();
            _badmintonClub.Save();

            UpdateMatchPreviewState();

            buttonStartSession.Enabled = !Session.Started;
            buttonStartSession.BackColor = Session.Started ? Color.Empty : Color.FromArgb(157, 255, 165);
            buttonEndSession.Enabled = Session.Started;
            buttonEndSession.BackColor = Session.Started ? Color.Red : Color.Empty;
        }

        private void buttonEndSession_Click(object sender, EventArgs e)
        {
            if (_badmintonClub.CurrentSession.ActiveMatches.Count > 0)
            {
                MessageBox.Show("Please finish the Active Matches before ending the session", "End Session", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var confirmResult = MessageBox.Show("Are you sure you want to end the current session?", "Confirm End Session", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirmResult == DialogResult.Yes)
            {
                _badmintonClub.EndCurrentSession();
                _badmintonClub.Save();

                SessionFinished?.Invoke(sender, EventArgs.Empty);
            }
        }

        private void buttonAddToTeam1_Click(object sender, EventArgs e)
        {
            if (dataGridViewWaitingPlayers.SelectedRows.Count <= 0 ||
                dataGridViewWaitingPlayers.SelectedRows[0].DataBoundItem is not Player player ||
                Session.MatchPreview.Team1Players.Count >= 2)
            {
                return;
            }

            Session.MatchPreview.Team1Players.Add(player);
            Session.WaitingPlayers.Remove(player);

            UpdateMatchPreviewState();
            SetMatchPreviewMessage(fromMatchPicker: false);
        }

        private void buttonAddToTeam2_Click(object sender, EventArgs e)
        {
            if (dataGridViewWaitingPlayers.SelectedRows.Count <= 0 ||
                dataGridViewWaitingPlayers.SelectedRows[0].DataBoundItem is not Player player ||
                Session.MatchPreview.Team2Players.Count >= 2)
            {
                return;
            }

            Session.MatchPreview.Team2Players.Add(player);
            Session.WaitingPlayers.Remove(player);

            UpdateMatchPreviewState();
            SetMatchPreviewMessage(fromMatchPicker: false);
        }

        private void buttonMatchPreviewTeam1RemovePlayer_Click(object sender, EventArgs e)
        {
            if (dataGridViewMatchPreviewTeam1.SelectedRows.Count <= 0 ||
                dataGridViewMatchPreviewTeam1.SelectedRows[0].DataBoundItem is not Player player)
            {
                return;
            }

            Session.MatchPreview.Team1Players.Remove(player);
            Session.WaitingPlayers.Add(player);

            UpdateMatchPreviewState();
            labelMatchMessage.Text = "";
        }

        private void buttonMatchPreviewTeam2RemovePlayer_Click(object sender, EventArgs e)
        {
            if (dataGridViewMatchPreviewTeam2.SelectedRows.Count <= 0 ||
                dataGridViewMatchPreviewTeam2.SelectedRows[0].DataBoundItem is not Player player)
            {
                return;
            }

            Session.MatchPreview.Team2Players.Remove(player);
            Session.WaitingPlayers.Add(player);

            UpdateMatchPreviewState();
            labelMatchMessage.Text = "";
        }

        private void UpdateMatchPreviewState()
        {
            // Enable / Disable controls based on Match Preview
            buttonAddToTeam1.Enabled = Session.Started && Session.MatchPreview.Team1Players.Count < 2;
            buttonAddToTeam2.Enabled = Session.Started && Session.MatchPreview.Team2Players.Count < 2;

            buttonFindGenderless.Enabled = Session.Started;
            buttonFindMens.Enabled = Session.Started;
            buttonFindWomens.Enabled = Session.Started;
            buttonFindMixed.Enabled = Session.Started;

            // Enable / Disable Match Preview Panel controls

            panelMatchPreview.Enabled = Session.Started;

            buttonMatchPreviewTeam1RemovePlayer.Enabled = Session.MatchPreview.Team1Players.Count > 0;
            buttonMatchPreviewTeam2RemovePlayer.Enabled = Session.MatchPreview.Team2Players.Count > 0;

            buttonStartGame.Enabled =
                Session.MatchPreview.Team1Players.Count == 2 &&
                Session.MatchPreview.Team2Players.Count == 2;
        }

        private void SetMatchPreviewMessage(bool fromMatchPicker)
        {
            if (Session.MatchPreview.Players.Count != 4)
            {
                if (fromMatchPicker)
                {
                    labelMatchMessage.Text = "Not Enough Players for this Game Type";
                }

                return;
            }

            var message = "";

            var team1PlayedWith = Session.MatchPreview.Team1Players[0]
                .GetPlayedWith(Session)
                .Where(pc => pc.Player == Session.MatchPreview.Team1Players[1])
                .Sum(pc => pc.Count);

            if (team1PlayedWith > 0)
            {
                message += $"{Session.MatchPreview.Team1Players[0].FullName} has played with {Session.MatchPreview.Team1Players[1].FullName} -> {team1PlayedWith} time(s)";
            }

            var team2PlayedWith = Session.MatchPreview.Team2Players[0]
                .GetPlayedWith(Session)
                .Where(pc => pc.Player == Session.MatchPreview.Team2Players[1])
                .Sum(pc => pc.Count);

            if (team2PlayedWith > 0)
            {
                message += Environment.NewLine + $"{Session.MatchPreview.Team2Players[0].FullName} has played with {Session.MatchPreview.Team2Players[1].FullName} -> {team2PlayedWith} time(s)";
            }

            var team1Player1Against = Session.MatchPreview.Team1Players[0]
                .GetPlayedAgainst(Session);

            var team1Player1AgainstTeam2Player1 = team1Player1Against
                .Where(pc => pc.Player == Session.MatchPreview.Team2Players[0])
                .Sum(pc => pc.Count);

            if (team1Player1AgainstTeam2Player1 > 0)
            {
                message += Environment.NewLine + $"{Session.MatchPreview.Team1Players[0].FullName} has played against {Session.MatchPreview.Team2Players[0].FullName} -> {team1Player1AgainstTeam2Player1} time(s)";
            }

            var team1Player1AgainstTeam2Player2 = team1Player1Against
                .Where(pc => pc.Player == Session.MatchPreview.Team2Players[1])
                .Sum(pc => pc.Count);

            if (team1Player1AgainstTeam2Player2 > 0)
            {
                message += Environment.NewLine + $"{Session.MatchPreview.Team1Players[0].FullName} has played against {Session.MatchPreview.Team2Players[1].FullName} -> {team1Player1AgainstTeam2Player2} time(s)";
            }

            var team1Player2Against = Session.MatchPreview.Team1Players[1].GetPlayedAgainst(Session);

            var team1Player2AgainstTeam2Player1 = team1Player2Against
                .Where(pc => pc.Player == Session.MatchPreview.Team2Players[0])
                .Sum(pc => pc.Count);

            if (team1Player2AgainstTeam2Player1 > 0)
            {
                message += Environment.NewLine + $"{Session.MatchPreview.Team1Players[1].FullName} has played against {Session.MatchPreview.Team2Players[0].FullName} -> {team1Player2AgainstTeam2Player1} time(s)";
            }

            var team1Player2AgainstTeam2Player2 = team1Player2Against
                .Where(pc => pc.Player == Session.MatchPreview.Team2Players[1])
                .Sum(pc => pc.Count);

            if (team1Player2AgainstTeam2Player2 > 0)
            {
                message += Environment.NewLine + $"{Session.MatchPreview.Team1Players[1].FullName} has played against {Session.MatchPreview.Team2Players[1].FullName} -> {team1Player2AgainstTeam2Player2} time(s)";
            }

            labelMatchMessage.Text = message;
        }

        private void buttonStartGame_Click(object sender, EventArgs e)
        {
            if (Session.AllCourtsInUse)
            {
                MessageBox.Show($"All courts are in use. Please wait for a match to finish!", "No Court Available", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var match = Session.MatchPreview;

            Session.StartMatch();
            UpdateMatchPreviewState();
            labelMatchMessage.Text = "";

            dataGridViewMatchPreviewTeam1.DataSource = Session.MatchPreview.Team1Players;
            dataGridViewMatchPreviewTeam2.DataSource = Session.MatchPreview.Team2Players;

            if (match.CourtNumber == 1)
            {
                BindCourt1();
            }
            else if (match.CourtNumber == 2)
            {
                BindCourt2();
            }
            else if (match.CourtNumber == 3)
            {
                BindCourt3();
            }
            else if (match.CourtNumber == 4)
            {
                BindCourt4();
            }
        }

        private void comboBoxCourtsAvailable_SelectedIndexChanged(object sender, EventArgs e)
        {
            var currentNumber = Session.CourtsAvailable;
            var newNumber = comboBoxCourtsAvailable.SelectedIndex + 1;

            if (newNumber < currentNumber && Session.ActiveMatches.Count > newNumber)
            {
                MessageBox.Show($"Please finish {currentNumber - newNumber} match(es) first!", "Court Availability Change", MessageBoxButtons.OK, MessageBoxIcon.Error);
                comboBoxCourtsAvailable.SelectedIndex = currentNumber - 1;
                return;
            }

            Session.CourtsAvailable = newNumber;
        }

        private void buttonFindGenderless_Click(object sender, EventArgs e)
        {
            var matchPicker = new MatchPicker();

            matchPicker.PickMatch(null, Session, _badmintonClub);

            UpdateMatchPreviewState();
            SetMatchPreviewMessage(fromMatchPicker: true);
        }

        private void buttonFindMens_Click(object sender, EventArgs e)
        {
            var matchPicker = new MatchPicker();

            matchPicker.PickMatch("M", Session, _badmintonClub);

            UpdateMatchPreviewState();
            SetMatchPreviewMessage(fromMatchPicker: true);
        }

        private void buttonFindWomens_Click(object sender, EventArgs e)
        {
            var matchPicker = new MatchPicker();

            matchPicker.PickMatch("F", Session, _badmintonClub);

            UpdateMatchPreviewState();
            SetMatchPreviewMessage(fromMatchPicker: true);
        }

        private void buttonFindMixed_Click(object sender, EventArgs e)
        {
            var matchPicker = new MatchPicker();

            matchPicker.PickMatch("X", Session, _badmintonClub);

            UpdateMatchPreviewState();
            SetMatchPreviewMessage(fromMatchPicker: true);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Directory.Exists("Players"))
            {
                Directory.Delete("Players", true);
            }

            var sessionsToReport = _badmintonClub.Sessions
                .Where(s => s.Ended)
                .Select((s, i) => new Tuple<int, Session>(i, s))
                .ToList();

            using var progressDialog = new ProgressDialog("Generating Reports...", backgroundWork => BadmintonClub.GenerateReports(sessionsToReport, _badmintonClub, backgroundWork));
            progressDialog.ShowDialog();
        }

        private void dataGridViewWaitingPlayers_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            DataGridViewHelpers.PlayerList_RowPrePaint(dataGridViewWaitingPlayers, e);
        }

        private void dataGridViewRestingPlayers_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            DataGridViewHelpers.PlayerList_RowPrePaint(dataGridViewRestingPlayers, e);
        }

        private void dataGridViewMatchPreviewTeam1_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            DataGridViewHelpers.PlayerList_RowPrePaint(dataGridViewMatchPreviewTeam1, e);
        }

        private void dataGridViewMatchPreviewTeam2_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            DataGridViewHelpers.PlayerList_RowPrePaint(dataGridViewMatchPreviewTeam2, e);
        }

        //private static float FontSize = 9F;

        //private void button2_Click(object sender, EventArgs e)
        //{
        //    //this.ParentForm.PerformAutoScale();

        //    //this.ParentForm.Font = new Font("Segoe UI", this.ParentForm.Font.Size + 1, FontStyle.Regular);

        //    //this.ParentForm.Scale(new SizeF(1.1F, 1.1F));
        //    if (this.ParentForm is MainForm mainForm)
        //    {
        //        mainForm.AdjustFontSize(ParentForm.Controls, 1);
        //    }
        //    //FontSize++;
        //}

        //private void buttonDecreaseFont_Click(object sender, EventArgs e)
        //{
        //    if (this.ParentForm is MainForm mainForm)
        //    {
        //        mainForm.AdjustFontSize(ParentForm.Controls, -1);
        //    }
        //}

        private void buttonScaleDown_Click(object sender, EventArgs e)
        {
            Scale(new SizeF(0.9F, 0.9F));
        }

        private void buttonScaleUp_Click(object sender, EventArgs e)
        {
            Scale(new SizeF(1.1F, 1.1F));
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            button1_Click(null, null);
        }

        private void buttonSettings_Click(object sender, EventArgs e)
        {
            using var dialog = new MatchFinderSettingsDialog(_badmintonClub);

            dialog.ShowDialog();
        }
    }
}
