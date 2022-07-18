using Badminton.Classes;

namespace Badminton.Controls
{
    public partial class PlaceholderSessionControl : UserControl
    {
        public delegate void SessionCreatedEventHandler(object? sender, SessionCreatedEventArgs e);

        public event SessionCreatedEventHandler? SessionChanged;

        public PlaceholderSessionControl()
        {
            InitializeComponent();
        }

        private void buttonStartSession_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(textBoxCourtsAvailable.Text, out var numberOfCourts))
            {
                return;
            }

            var courts = Enumerable.Range(0, numberOfCourts).ToArray();

            var session = new Session(courts);

            SessionChanged?.Invoke(this, new SessionCreatedEventArgs(session));
        }

        private void textBoxCourtsAvailable_TextChanged(object sender, EventArgs e)
        {
            buttonStartSession.Enabled = int.TryParse(textBoxCourtsAvailable.Text, out var numberOfCourts) && 
                                         numberOfCourts > 0 && numberOfCourts <= Constants.MaxNumberOfCourts;
        }
    }
}
