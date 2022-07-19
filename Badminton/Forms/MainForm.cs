using Badminton.Classes;
using Newtonsoft.Json;

namespace Badminton.Forms
{
    public partial class MainForm : Form
    {
        private BadmintonClub _badmintonClub = new();
        private List<TabPage> _hiddenPages = new();

        public MainForm()
        {
            InitializeComponent();
            InitializeCustomControls();
        }

        private void InitializeCustomControls()
        {
            EnablePage(tabPageActiveSession, false);
        }

        /// <remarks>See https://stackoverflow.com/a/3365490 for more info</remarks>
        private void EnablePage(TabPage page, bool enable)
        {
            if (enable)
            {
                Tabs.TabPages.Add(page);
                _hiddenPages.Remove(page);
            }
            else
            {
                Tabs.TabPages.Remove(page);
                _hiddenPages.Add(page);
            }
        }

        private void ShowHideTabs()
        {
            if (_badmintonClub.CurrentSession != null)
            {
                EnablePage(tabPageNoSession, false);
                EnablePage(tabPageActiveSession, true);
            }
            else
            {
                EnablePage(tabPageActiveSession, false);
                EnablePage(tabPageNoSession, true);
            }
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            foreach (var page in _hiddenPages)
            {
                page.Dispose();
            }
            base.OnFormClosed(e);
        }

        private void LoadSession(Session session)
        {
            _badmintonClub.CurrentSession = session;
            _badmintonClub.Sessions.Add(session);

            ShowHideTabs();
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
                    writer.Write(JsonConvert.SerializeObject(_badmintonClub));

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
                    _badmintonClub = JsonConvert.DeserializeObject<BadmintonClub>(reader.ReadToEnd())!;

                    if (_badmintonClub.CurrentSession != null)
                    {
                        LoadSession(_badmintonClub.CurrentSession);
                    }

                    ShowHideTabs();

                    MessageBox.Show("Loaded", "Load", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"File '{openFileDialog.FileName}' could not be loaded. Error: {ex}", "Load", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}