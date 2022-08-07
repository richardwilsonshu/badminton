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

            //IncreaseFontSize(Controls);
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

        private int InitialWidth = 0;
        private int InitialHeight = 0;
        private FormWindowState LastWindowState;

        private void MainForm_Shown(object sender, EventArgs e)
        {
            InitialWidth = Width;
            InitialHeight = Height;
            LastWindowState = WindowState;

            //WindowState = FormWindowState.Maximized;
        }

        public void AdjustFontSize(Control.ControlCollection controls, float amount)
        {
            foreach (Control c in controls)
            {
                if (c.Controls != null)
                {
                    AdjustFontSize(c.Controls, amount);
                }

                float size = c.Font.Size + amount;
                c.Font = new Font("Segoe UI", size, c.Font.Style);

                if (c is DataGridView dgv)
                {
                    dgv.PerformLayout();
                    dgv.Refresh();
                }
            }
        }

        private void MainForm_SizeChanged(object sender, EventArgs e)
        {
            if (WindowState == LastWindowState)
            {
                return;
            }

            LastWindowState = WindowState;

            if (WindowState == FormWindowState.Maximized)
            {
                //var scaleSize = new SizeF
                //{
                //    Width = Width / (float)InitialWidth,
                //    Height = Height / (float)InitialHeight
                //};

                //var fontScale = scaleSize.Width < scaleSize.Height 
                //    ? scaleSize.Width 
                //    : scaleSize.Height;

                //AdjustFontSize(this.Controls, scaleSize.Width);

                //Scale(scaleSize);

                this.SetAutoScrollMargin(Width, Height);
            }
            else if (WindowState == FormWindowState.Normal)
            {
                //var scaleSize = new SizeF
                //{
                //    Width = InitialWidth / (float)Width,
                //    Height = InitialHeight / (float)Height
                //};

                //var fontScale = scaleSize.Width < scaleSize.Height
                //    ? scaleSize.Width
                //    : scaleSize.Height;

                //AdjustFontSize(this.Controls, -scaleSize.Width);

                //Scale(scaleSize);

                Width = InitialWidth;
                Height = InitialHeight;

                this.SetAutoScrollMargin(Width, Height);
            }
        }
    }
}