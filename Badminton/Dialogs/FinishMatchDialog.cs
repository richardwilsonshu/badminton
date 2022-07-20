using Badminton.Classes;

namespace Badminton.Dialogs
{
    public partial class FinishMatchDialog : Form
    {
        private Match _match;

        public FinishMatchDialog(Match match)
        {
            _match = match;

            InitializeComponent();

            labelCourtTitle.Text = $"Court {_match.CourtNumber}";
            labelTeam1Players.Text = string.Join(" & ", _match.Team1Players.Select(p => p.FullName));
            labelTeam2Players.Text = string.Join(" & ", _match.Team2Players.Select(p => p.FullName));
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(textBoxTeam1Score.Text, out var Team1Score))
            {
                return;
            }
            if (!int.TryParse(textBoxTeam2Score.Text, out var Team2Score))
            {
                return;
            }

            _match.Team1Score = Team1Score;
            _match.Team2Score = Team2Score;
            _match.EloNotAffected = checkBoxNoElo.Checked;
        }

        private void textBoxTeam1Score_TextChanged(object sender, EventArgs e)
        {
            // TODO are the scores equal?
        }

        private void textBoxTeam2Score_TextChanged(object sender, EventArgs e)
        {
            // TODO are the scores equal?
        }
    }
}
