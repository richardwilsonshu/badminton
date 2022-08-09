namespace Badminton.Dialogs
{
    public partial class ProgressDialog : Form
    {
        public ProgressDialog(string message)
        {
            InitializeComponent();

            labelMessage.Text = message;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {

        }
    }
}
