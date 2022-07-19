using Badminton.Classes;

namespace Badminton.Controls
{
    public partial class CreateSessionTabControl : UserControl
    {
        public event EventHandler? SessionChanged;

        private BadmintonClub _badmintonClub = new();

        public CreateSessionTabControl()
        {
            InitializeComponent();
        }

        public void SetBadmintonClub(BadmintonClub club)
        {
            _badmintonClub = club;
        }

        private void textBoxCourtsAvailable_TextChanged(object sender, EventArgs e)
        {
            buttonStartSession.Enabled = int.TryParse(textBoxCourtsAvailable.Text, out var numberOfCourts) &&
                 numberOfCourts > 0 && numberOfCourts <= Constants.MaxNumberOfCourts;
        }

        private void buttonStartSession_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(textBoxCourtsAvailable.Text, out var numberOfCourts))
            {
                return;
            }

            var courts = Enumerable.Range(0, numberOfCourts).ToArray();

            var session = new Session(courts);

            _badmintonClub.CurrentSession = session;
            _badmintonClub.Sessions.Add(session);

            // TODO show/hide tabs
            SessionChanged?.Invoke(this, EventArgs.Empty);
        }
    }
}
