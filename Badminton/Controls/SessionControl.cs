﻿using Badminton.Classes;
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
            listBoxWaitingPlayers.Bind(Session.WaitingPlayers, nameof(Player.Display), nameof(Player.FullName));
            listBoxRestingPlayers.BindPlayers(Session.RestingPlayers);

            listBoxWaitingPlayers.CustomTabOffsets.Add(50);
            listBoxWaitingPlayers.UseCustomTabOffsets = true;

            listBoxMatchPreviewTeam1.BindPlayers(Session.MatchPreview.Team1Players);
            listBoxMatchPreviewTeam2.BindPlayers(Session.MatchPreview.Team2Players);

            buttonStartSession.Enabled = !Session.Started;
            buttonEndSession.Enabled = Session.Started;

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
            if (listBoxWaitingPlayers.SelectedItem is not Player player)
            {
                return;
            }

            var confirmResult = MessageBox.Show("Remove this player from current session?", "Confirm Remove", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirmResult == DialogResult.Yes)
            {
                Session.WaitingPlayers.Remove(player);
                _badmintonClub.Players.Add(player);

                Session.WaitingPlayers.ApplySort(nameof(Player.MinutesWaiting), ListSortDirection.Descending);
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
            // See https://stackoverflow.com/a/519557
            listBoxWaitingPlayers.DisplayMember = "";
            listBoxWaitingPlayers.DisplayMember = nameof(Player.Display);

            Session.WaitingPlayers.ApplySort(nameof(Player.MinutesWaiting), ListSortDirection.Descending);

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
            buttonEndSession.Enabled = Session.Started;
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

            matchPicker.PickMatch(null, Session);

            UpdateMatchPreviewState();
        }

        private void buttonFindMens_Click(object sender, EventArgs e)
        {
            var matchPicker = new MatchPicker();

            matchPicker.PickMatch("M", Session);

            UpdateMatchPreviewState();
        }

        private void buttonFindWomens_Click(object sender, EventArgs e)
        {
            var matchPicker = new MatchPicker();

            matchPicker.PickMatch("F", Session);

            UpdateMatchPreviewState();
        }

        private void buttonFindMixed_Click(object sender, EventArgs e)
        {
            var matchPicker = new MatchPicker();

            matchPicker.PickMatch("X", Session);

            UpdateMatchPreviewState();
        }
    }
}
