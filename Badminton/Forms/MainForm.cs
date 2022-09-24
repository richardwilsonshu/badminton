using System.Diagnostics;
using Badminton.Dialogs;
using Badminton.Shared.Classes;

namespace Badminton.Forms
{
    public partial class MainForm : Form
    {
        private readonly BadmintonClub _badmintonClub = new();

        public MainForm()
        {
            if (Process.GetProcessesByName("badminton").Length > 1)
            {
                // Is already running
                MessageBox.Show($"Another instance is already running", "Load", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }

            BadmintonClub? loadedBadmintonClub = null;

            try
            {
                loadedBadmintonClub = BadmintonClub.Load(MigrateWithDialog);
            }
            catch (OperationCanceledException)
            {
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"File '{Constants.FileName}' could not be loaded. Error: {ex}", "Load", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }

            if (loadedBadmintonClub != null)
            {
                _badmintonClub = loadedBadmintonClub;

                _badmintonClub.SaveFailed += LoadedBadmintonClub_SaveFailed;
                _badmintonClub.ShowGenerateReportsDialog += _badmintonClub_ShowGenerateReportsDialog;
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

        private void MigrateWithDialog(BadmintonClub badmintonClub, int jsonModelVersion)
        {
            var message = $"Migrating from version {jsonModelVersion} to {BadmintonClub.LatestModelVersion}...";

            using var progressDialog = new ProgressDialog(message,
                backgroundWorker =>
                    Migrator.MigrateToLatest(badmintonClub, jsonModelVersion, backgroundWorker));

            if (progressDialog.ShowDialog() == DialogResult.Cancel)
            {
                throw new OperationCanceledException();
            }
        }

        private void _badmintonClub_ShowGenerateReportsDialog(ShowGenerateReportsDialogEventArgs args)
        {
            using var progressDialog = new ProgressDialog("Generating Reports...", backgroundWork => Migrator.GenerateReports(args.SessionsToReport, backgroundWork));
            progressDialog.ShowDialog();
        }

        private void LoadedBadmintonClub_SaveFailed(object? sender, string message)
        {
            MessageBox.Show(message, "Save", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

            if (LastWindowState == FormWindowState.Normal && WindowState == FormWindowState.Maximized)
            {
                var scaleSize = new SizeF
                {
                    Width = Width / (float)InitialWidth,
                    Height = Height / (float)InitialHeight
                };

                //var fontScale = scaleSize.Width < scaleSize.Height 
                //    ? scaleSize.Width 
                //    : scaleSize.Height;

                //AdjustFontSize(this.Controls, scaleSize.Width);

                Scale(scaleSize);

                //this.SetAutoScrollMargin(Width, Height);
            }
            else if (LastWindowState == FormWindowState.Maximized && WindowState == FormWindowState.Normal)
            {
                var scaleSize = new SizeF
                {
                    Width = InitialWidth / (float)Width,
                    Height = InitialHeight / (float)Height
                };

                //var fontScale = scaleSize.Width < scaleSize.Height
                //    ? scaleSize.Width
                //    : scaleSize.Height;

                //AdjustFontSize(this.Controls, -scaleSize.Width);

                Scale(scaleSize);

                Width = InitialWidth;
                Height = InitialHeight;

                //this.SetAutoScrollMargin(Width, Height);
            }

            LastWindowState = WindowState;

            // For whatever reason, un-maximizing the window leaves a small area at the bottom
            // that doesn't expand fully until the window is moved.
            // The following did nothing to try resolve this:

            //this.PerformAutoScale();
            //this.PerformLayout();
            //this.Refresh();
            //this.OnResize(e);
            //this.Size = this.Size;
            //this.ResizeRedraw = true;
        }
    }
}