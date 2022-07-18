using Badminton.Classes;
using Badminton.Controls;
using Newtonsoft.Json;
using System.ComponentModel;

namespace Badminton.Forms
{
    public partial class MainForm : Form
    {
        private Classes.Badminton _badminton = new();

        public MainForm()
        {
            InitializeComponent();
            InitializeCustomControls();
        }

        private void InitializeCustomControls()
        {
            SetPlaceholderSessionControl();
        }

        private void LoadSession(Session session)
        {
            _badminton.CurrentSession = session;
            _badminton.Sessions.Add(session);

            var sessionControl = new SessionControl(session);
            sessionControl.Dock = DockStyle.Fill;
            tabPageSession.Controls.Clear();
            tabPageSession.Controls.Add(sessionControl);
        }

        private void SetPlaceholderSessionControl()
        {
            var placeholderSessionControl = new PlaceholderSessionControl();
            placeholderSessionControl.Dock = DockStyle.Fill;
            placeholderSessionControl.SessionChanged += PlaceholderSessionControl_SessionChanged;
            tabPageSession.Controls.Clear();
            tabPageSession.Controls.Add(placeholderSessionControl);
        }

        private void PlaceholderSessionControl_SessionChanged(object? sender, SessionCreatedEventArgs e)
        {
            LoadSession(e.Session);
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

                    if (_badminton.CurrentSession != null)
                    {
                        LoadSession(_badminton.CurrentSession);
                    }
                    else
                    {
                        SetPlaceholderSessionControl();
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