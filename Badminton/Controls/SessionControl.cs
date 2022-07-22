using Badminton.Classes;
using Badminton.Dialogs;
using System.ComponentModel;

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
            listBoxWaitingPlayers.Bind(Session.WaitingPlayers, nameof(Player.Display), nameof(Player.Id));
            listBoxRestingPlayers.BindPlayers(Session.RestingPlayers);

            EnableOrDisableGenerateGameButtons();

            BindCourt1();
            BindCourt2();

            listBoxWaitingPlayers.CustomTabOffsets.Add(50);
            listBoxWaitingPlayers.UseCustomTabOffsets = true;

            comboBoxCourtsAvailable.SelectedIndex = comboBoxCourtsAvailable.Items.Count - 1;

            listBoxMatchPreviewTeam1.BindPlayers(Session.MatchPreview.Team1Players);
            listBoxMatchPreviewTeam2.BindPlayers(Session.MatchPreview.Team2Players);
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

        private void EnableOrDisableGenerateGameButtons()
        {
            // TODO
            //buttonGenerateGame.Enabled = Session.CanGenerateMatch;
        }

        private void buttonAddPlayerToSession_Click(object sender, EventArgs e)
        {
            using var managePlayersDialog = new ManagePlayersDialog(_badmintonClub);
            managePlayersDialog.ShowDialog();
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
                Session.WaitingPlayers.Remove(player);
                _badmintonClub.Players.Add(player);

                _badmintonClub.CurrentSession.WaitingPlayers.ApplySort(nameof(Player.MinutesWaiting), ListSortDirection.Descending);
            }
        }

        private void buttonEndRest_Click(object sender, EventArgs e)
        {
            if (listBoxRestingPlayers.SelectedItem is not Player player)
            {
                return;
            }

            Session.RestingPlayers.Remove(player);
            Session.WaitingPlayers.Add(player);

            Session.RestingPlayers.ApplySort(nameof(Player.MinutesWaiting), ListSortDirection.Descending);
            Session.WaitingPlayers.ApplySort(nameof(Player.MinutesWaiting), ListSortDirection.Descending);

            EnableOrDisableGenerateGameButtons();
        }

        private void buttonRestPlayer_Click(object sender, EventArgs e)
        {
            if (listBoxWaitingPlayers.SelectedItem is not Player player)
            {
                return;
            }

            Session.WaitingPlayers.Remove(player);
            Session.RestingPlayers.Add(player);

            Session.WaitingPlayers.ApplySort(nameof(Player.MinutesWaiting), ListSortDirection.Descending);
            Session.RestingPlayers.ApplySort(nameof(Player.MinutesWaiting), ListSortDirection.Descending);

            EnableOrDisableGenerateGameButtons();
        }

        private void buttonFinishCourt1_Click(object sender, EventArgs e)
        {
            var match = Session.GetActiveMatchOnCourt(1);

            if (match == null)
            {
                return;
            }

            FinishMatch(match);

            panelCourt1.Enabled = false;
            listBoxCourt1Team1.DataSource = null;
            listBoxCourt1Team2.DataSource = null;

            _badmintonClub.Save();
        }

        private void buttonFinishCourt2_Click(object sender, EventArgs e)
        {
            var match = Session.GetActiveMatchOnCourt(2);

            if (match == null)
            {
                return;
            }

            FinishMatch(match);

            panelCourt2.Enabled = false;
            listBoxCourt2Team1.DataSource = null;
            listBoxCourt2Team2.DataSource = null;

            _badmintonClub.Save();
        }

        private void buttonFinishCourt3_Click(object sender, EventArgs e)
        {
            var match = Session.GetActiveMatchOnCourt(3);

            if (match == null)
            {
                return;
            }

            FinishMatch(match);

            panelCourt3.Enabled = false;
            listBoxCourt3Team1.DataSource = null;
            listBoxCourt3Team2.DataSource = null;

            _badmintonClub.Save();
        }

        private void buttonFinishCourt4_Click(object sender, EventArgs e)
        {
            var match = Session.GetActiveMatchOnCourt(4);

            if (match == null)
            {
                return;
            }

            FinishMatch(match);

            panelCourt4.Enabled = false;
            listBoxCourt4Team1.DataSource = null;
            listBoxCourt4Team2.DataSource = null;

            _badmintonClub.Save();
        }

        private void FinishMatch(Match match)
        {
            using var finishMatchDialog = new FinishMatchDialog(match);

            if (finishMatchDialog.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            if (finishMatchDialog.MatchAbandoned)
            {
                Session.AbandonMatch(match);
            }
            else
            {
                Session.FinishMatch(match);
            }

            EnableOrDisableGenerateGameButtons();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // See https://stackoverflow.com/a/519557
            listBoxWaitingPlayers.DisplayMember = "";
            listBoxWaitingPlayers.DisplayMember = nameof(Player.Display);

            // TODO court 3 and 4 ? perhaps find a less repetitive way with lists?
            var court1Match = Session.GetActiveMatchOnCourt(1);
            var court2Match = Session.GetActiveMatchOnCourt(2);

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

        private void buttonStartSession_Click(object sender, EventArgs e)
        {
            var numberOfCourts = comboBoxCourtsAvailable.SelectedIndex + 1;

            _badmintonClub.CurrentSession.CourtsAvailable = numberOfCourts;
            _badmintonClub.CurrentSession.Start();

            buttonStartSession.Enabled = false;
            buttonEndSession.Enabled = true;

            buttonAddToTeam1.Enabled = true;
            buttonAddToTeam2.Enabled = true;

            panelMatchPreview.Enabled = true;

            buttonFindGenderless.Enabled = true;
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
            if (listBoxWaitingPlayers.SelectedItem is not Player player ||
                Session.MatchPreview.Team1Players.Count >= 2)
            {
                return;
            }

            Session.MatchPreview.Team1Players.Add(player);
            Session.WaitingPlayers.Remove(player);

            UpdateMatchPreviewState();
        }

        private void buttonAddToTeam2_Click(object sender, EventArgs e)
        {
            if (listBoxWaitingPlayers.SelectedItem is not Player player ||
                Session.MatchPreview.Team2Players.Count >= 2)
            {
                return;
            }

            Session.MatchPreview.Team2Players.Add(player);
            Session.WaitingPlayers.Remove(player);

            UpdateMatchPreviewState();
        }

        private void buttonMatchPreviewTeam1RemovePlayer_Click(object sender, EventArgs e)
        {
            if (listBoxMatchPreviewTeam1.SelectedItem is not Player player)
            {
                return;
            }

            Session.MatchPreview.Team1Players.Remove(player);
            Session.WaitingPlayers.Add(player);

            UpdateMatchPreviewState();
        }

        private void buttonMatchPreviewTeam2RemovePlayer_Click(object sender, EventArgs e)
        {
            if (listBoxMatchPreviewTeam2.SelectedItem is not Player player)
            {
                return;
            }

            Session.MatchPreview.Team2Players.Remove(player);
            Session.WaitingPlayers.Add(player);

            UpdateMatchPreviewState();
        }

        private void UpdateMatchPreviewState()
        {
            buttonAddToTeam1.Enabled = Session.MatchPreview.Team1Players.Count < 2;
            buttonMatchPreviewTeam1RemovePlayer.Enabled = Session.MatchPreview.Team1Players.Count > 0;

            buttonAddToTeam2.Enabled = Session.MatchPreview.Team2Players.Count < 2;
            buttonMatchPreviewTeam2RemovePlayer.Enabled = Session.MatchPreview.Team2Players.Count > 0;

            buttonStartGame.Enabled = 
                Session.MatchPreview.Team1Players.Count == 2 &&
                Session.MatchPreview.Team2Players.Count == 2;
        }

        private void buttonStartGame_Click(object sender, EventArgs e)
        {
            var match = Session.MatchPreview;

            Session.StartMatch();
            UpdateMatchPreviewState();

            listBoxMatchPreviewTeam1.BindPlayers(Session.MatchPreview.Team1Players);
            listBoxMatchPreviewTeam2.BindPlayers(Session.MatchPreview.Team2Players);

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

        private void buttonFindGenderless_Click(object sender, EventArgs e)
        {
            foreach (var player in Session.WaitingPlayers)
            {
                var playedWith = player.GetPlayedWith(Session);
                var playedAgainst = player.GetPlayedAgainst(Session);

                var firstPlayerNumberOfTimes = playedWith.FirstOrDefault()?.Count ?? 0;
            }
        }
    }
}
