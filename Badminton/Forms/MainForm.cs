using Badminton.Classes;
using Newtonsoft.Json;

namespace Badminton.Forms
{
    public partial class MainForm : Form
    {
        private BadmintonClub _badmintonClub = new();

        public MainForm()
        {
            InitializeComponent();
            InitializeCustomControls();
        }

        private void InitializeCustomControls()
        {
        }

        private void LoadSession(Session session)
        {
            _badmintonClub.CurrentSession = session;
            _badmintonClub.Sessions.Add(session);
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