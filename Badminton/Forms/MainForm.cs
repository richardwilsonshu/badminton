using Badminton.Classes;
using Newtonsoft.Json;

namespace Badminton.Forms
{
    public partial class MainForm : Form
    {
        private BadmintonClub _badmintonClub = new();

        public MainForm()
        {
            LoadBadmintonClub();

            InitializeComponent();
            InitializeCustomControls();
        }

        private void InitializeCustomControls()
        {
            sessionControl.SetBadmintonClub(_badmintonClub);
            sessionControl.SessionFinished += SessionControl_SessionFinished;
        }

        private void SessionControl_SessionFinished(object? sender, EventArgs e)
        {
            sessionControl.SessionFinished -= SessionControl_SessionFinished;
            Controls.Remove(sessionControl);
            sessionControl.Dispose();
            sessionControl = new Controls.SessionControl();
            sessionControl.SetBadmintonClub(_badmintonClub);
            sessionControl.SessionFinished += SessionControl_SessionFinished;
            Controls.Add(sessionControl);
        }

        // TODO review save/load
        private void SaveBadmintonClub(object sender, EventArgs e)
        {
            try
            {
                using var writer = new StreamWriter(File.Open(Constants.FileName, FileMode.Create));
                writer.Write(JsonConvert.SerializeObject(_badmintonClub));
            }
            catch (Exception ex)
            {
                MessageBox.Show($"File '{Constants.FileName}' could not be saved. Error: {ex}", "Save", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // TODO review save/load
        private void LoadBadmintonClub()
        {
            try
            {
                if (File.Exists(Constants.FileName))
                {
                    using var reader = new StreamReader(File.OpenRead(Constants.FileName));
                    _badmintonClub = JsonConvert.DeserializeObject<BadmintonClub>(reader.ReadToEnd())!;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"File '{Constants.FileName}' could not be loaded. Error: {ex}", "Load", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // I keep clicking this, so I'm leaving it in...
        private void sessionControl_Load(object sender, EventArgs e)
        {

        }
    }
}