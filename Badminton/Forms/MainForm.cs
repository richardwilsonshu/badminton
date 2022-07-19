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
        }

        private void LoadSession(Session session)
        {
            _badmintonClub.CurrentSession = session;
            _badmintonClub.Sessions.Add(session);
        }

        private void SaveBadmintonClub(object sender, EventArgs e)
        {
            try
            {
                using var writer = new StreamWriter(File.Open(Constants.FileName, FileMode.Create));
                writer.Write(JsonConvert.SerializeObject(_badmintonClub));

                MessageBox.Show("Saved", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"File '{Constants.FileName}' could not be saved. Error: {ex}", "Save", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadBadmintonClub()
        {
            try
            {
                using var reader = new StreamReader(File.OpenRead(Constants.FileName));
                _badmintonClub = JsonConvert.DeserializeObject<BadmintonClub>(reader.ReadToEnd())!;

                if (_badmintonClub.CurrentSession != null)
                {
                    LoadSession(_badmintonClub.CurrentSession);
                }

                MessageBox.Show("Loaded", "Load", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"File '{Constants.FileName}' could not be loaded. Error: {ex}", "Load", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void sessionTabControl1_Load(object sender, EventArgs e)
        {

        }
    }
}