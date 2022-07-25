using Badminton.Classes;

namespace Badminton.Forms
{
    public partial class MainForm : Form
    {
        private BadmintonClub _badmintonClub = new();

        public MainForm()
        {
            var loadedBadmintonClub = BadmintonClub.Load();

            if (loadedBadmintonClub != null)
            {
                _badmintonClub = loadedBadmintonClub;
            }

            if (!_badmintonClub.Sessions.Any())
            {
                var placeholderSession = new Session(4);
                _badmintonClub.Sessions.Add(placeholderSession);
            }

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

        // I keep clicking this, so I'm leaving it in...
        private void sessionControl_Load(object sender, EventArgs e)
        {

        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            _badmintonClub.Save();
        }
    }
}