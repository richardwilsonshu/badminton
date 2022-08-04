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
            Font = new Font("Segoe UI", 12F, FontStyle.Regular);

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

        private void MainForm_Shown(object sender, EventArgs e)
        {
            // Set fullscreen on startup
            //this.TopMost = true;
            //this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;

            // And scale based on screen size
            float scaleX = ((float)Screen.PrimaryScreen.WorkingArea.Width / 1095);
            float scaleY = ((float)Screen.PrimaryScreen.WorkingArea.Height / 723);
            SizeF aSf = new SizeF(scaleX * 0.75f, scaleY * 0.75f);
            this.Scale(aSf);

            //this.Scale(new SizeF(1.4f, 1.4f));
        }
    }
}