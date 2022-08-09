using System.ComponentModel;

namespace Badminton.Dialogs
{
    public partial class ProgressDialog : Form
    {
        private readonly Action<BackgroundWorker> _backgroundWork;

        public ProgressDialog(string message, Action<BackgroundWorker> backgroundWork)
        {
            InitializeComponent();

            _backgroundWork = backgroundWork;

            labelMessage.Text = message;

            buttonCancel.Enabled = true;

            progressBar1.Minimum = 0;
            progressBar1.Maximum = 100;
            progressBar1.Value = 0;

            backgroundWorker1.WorkerReportsProgress = true;
            backgroundWorker1.WorkerSupportsCancellation = true;

            DialogResult = DialogResult.Cancel;

            backgroundWorker1.RunWorkerAsync();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            backgroundWorker1.CancelAsync();

            buttonCancel.Enabled = false;
            labelMessage.Text = "Stopping...";
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            _backgroundWork(backgroundWorker1);
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            var percentage = e.ProgressPercentage > 100 ? 100 : e.ProgressPercentage;

            progressBar1.Value = percentage;
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
