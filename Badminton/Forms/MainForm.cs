using Badminton.Classes;
using Newtonsoft.Json;
using System.ComponentModel;

namespace Badminton.Forms
{
    public partial class MainForm : Form
    {
        private BadmintonSession _session = new();

        public MainForm()
        {
            InitializeComponent();
            InitializeCustomControls();
        }

        private void InitializeCustomControls()
        {
            BindListBox(listBoxActivePlayers, _session.AvailablePlayers, nameof(Player.Display), nameof(Player.Id));
            BindPlayersListBox(listBoxClubPlayers, _session.AllPlayers);

            EnableOrDisableGenerateGameButtons();

            BindCourt1();
            BindCourt2();

            listBoxActivePlayers.CustomTabOffsets.Add(50);
            listBoxActivePlayers.UseCustomTabOffsets = true;
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
            if (_session.Court1Match == null)
            {
                return;
            }

            BindPlayersListBox(listBoxCourt1Side1, _session.Court1Match!.Side1Players);
            BindPlayersListBox(listBoxCourt1Side2, _session.Court1Match!.Side2Players);
            panelCourt1.Enabled = true;
        }
        private void BindCourt2()
        {
            if (_session.Court2Match == null)
            {
                return;
            }

            BindPlayersListBox(listBoxCourt2Side1, _session.Court2Match!.Side1Players);
            BindPlayersListBox(listBoxCourt2Side2, _session.Court2Match!.Side2Players);
            panelCourt2.Enabled = true;
        }

        private void EnableOrDisableGenerateGameButtons()
        {
            buttonGenerateGame.Enabled = _session.CanGenerateMatch;
        }

        private void buttonAddPlayer_Click(object sender, EventArgs e)
        {
            using var newPlayerDialog = new UserForm(_session);
            newPlayerDialog.ShowDialog();
        }

        private void buttonRemovePlayer_Click(object sender, EventArgs e)
        {
            if (listBoxClubPlayers.SelectedItem is not Player player)
            {
                return;
            }

            var confirmResult = MessageBox.Show("Delete this player?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirmResult == DialogResult.Yes)
            {
                _session.AllPlayers.Remove(player);
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
                    writer.Write(JsonConvert.SerializeObject(_session));

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
                    _session = JsonConvert.DeserializeObject<BadmintonSession>(reader.ReadToEnd())!;

                    InitializeCustomControls();

                    MessageBox.Show("Loaded", "Load", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"File '{openFileDialog.FileName}' could not be loaded. Error: {ex}", "Load", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void buttonMoveToActivePlayers_Click(object sender, EventArgs e)
        {
            if (listBoxClubPlayers.SelectedItem is not Player player)
            {
                return;
            }

            _session.AllPlayers.Remove(player);
            _session.AvailablePlayers.Add(player);

            EnableOrDisableGenerateGameButtons();
        }

        private void buttonRemoveFromActivePlayers_Click(object sender, EventArgs e)
        {
            if (listBoxActivePlayers.SelectedItem is not Player player)
            {
                return;
            }

            _session.AvailablePlayers.Remove(player);
            _session.AllPlayers.Add(player);

            EnableOrDisableGenerateGameButtons();
        }

        private void buttonGenerateGame_Click(object sender, EventArgs e)
        {
            var match = _session.TryGenerateMatch();

            if (match == null)
            {
                return;
            }

            _session.StartMatch(match);

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
            using var finishMatchForm = new FinishMatchForm(_session.Court1Match!);

            if (finishMatchForm.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            _session.FinishCourt1Match();

            EnableOrDisableGenerateGameButtons();

            panelCourt1.Enabled = false;
            listBoxCourt1Side1.DataSource = null;
            listBoxCourt1Side2.DataSource = null;
        }

        private void buttonFinishCourt2_Click(object sender, EventArgs e)
        {
            using var finishMatchForm = new FinishMatchForm(_session.Court1Match!);

            if (finishMatchForm.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            _session.FinishCourt2Match();

            EnableOrDisableGenerateGameButtons();

            panelCourt2.Enabled = false;
            listBoxCourt2Side1.DataSource = null;
            listBoxCourt2Side2.DataSource = null;
        }

        private void timerMatches_Tick(object sender, EventArgs e)
        {
            // See https://stackoverflow.com/a/519557
            listBoxActivePlayers.DisplayMember = "";
            listBoxActivePlayers.DisplayMember = nameof(Player.Display);

            if (_session.Court1Match != null)
            {
                var elapsedTime = DateTime.Now - _session.Court1Match.Start!.Value;
                labelCourt1MatchTime.Text = $"Match time: {elapsedTime:h\\:mm\\:ss}";
            }
            else
            {
                labelCourt1MatchTime.Text = "Match time:";
            }

            if (_session.Court2Match != null)
            {
                var elapsedTime = DateTime.Now - _session.Court2Match.Start!.Value;
                labelCourt2MatchTime.Text = $"Match time: {elapsedTime:h\\:mm\\:ss}";
            }
            else
            {
                labelCourt2MatchTime.Text = "Match time:";
            }
        }

        private void listBoxActivePlayers_DoubleClick(object sender, EventArgs e)
        {
            if (listBoxActivePlayers.SelectedItem is not Player player)
            {
                return;
            }

            using var newPlayerDialog = new UserForm(_session, player);
            newPlayerDialog.ShowDialog();
        }
    }
}