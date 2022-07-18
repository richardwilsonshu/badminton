using Badminton.Classes;
using Newtonsoft.Json;
using System.ComponentModel;

namespace Badminton.Forms
{
    public partial class MainForm : Form
    {
        private Classes.Badminton _badminton = new();
        private Session _session => _badminton.CurrentSession!;

        public MainForm()
        {
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

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using var saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Json files (*.json)|*.json";
            saveFileDialog.Title = "Save";
            saveFileDialog.OverwritePrompt = false;
            saveFileDialog.AddExtension = true;
            saveFileDialog.FileName = "badminton";
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using var writer = new StreamWriter(saveFileDialog.OpenFile());
                    writer.Write(JsonConvert.SerializeObject(_badminton));

                    MessageBox.Show("Saved", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"File '{saveFileDialog.FileName}' could not be saved. Error: {ex}", "Save", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using var openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Json files (*.json)|*.json";
            openFileDialog.Title = "Load";
            openFileDialog.Multiselect = false;
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using var reader = new StreamReader(openFileDialog.OpenFile());
                    _badminton = JsonConvert.DeserializeObject<Classes.Badminton>(reader.ReadToEnd())!;

                    InitializeCustomControls();

                    MessageBox.Show("Loaded", "Load", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"File '{openFileDialog.FileName}' could not be loaded. Error: {ex}", "Load", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
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

        private void buttonRemoveFromActivePlayers_Click(object sender, EventArgs e)
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
    }
}