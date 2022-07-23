using Badminton.Classes;

namespace Badminton.Dialogs
{
    public partial class FinishMatchDialog : Form
    {
        private readonly Match _match;

        public FinishMatchDialog(Match match)
        {
            _match = match;

            InitializeComponent();

            labelCourtTitle.Text = $"Court {_match.CourtNumber}";
            labelTeam1Players.Text = string.Join(" && ", _match.Team1Players.Select(p => p.FullName));
            labelTeam2Players.Text = string.Join(" && ", _match.Team2Players.Select(p => p.FullName));
        }

        private void buttonAbandon_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Are you sure you want to abandon the match?", "Confirm Abandon", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirmResult != DialogResult.Yes)
            {
                DialogResult = DialogResult.Cancel;
            }
        }

        private void buttonFinish_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(textBoxTeam1Score.Text, out var team1Score))
            {
                return;
            }
            if (!int.TryParse(textBoxTeam2Score.Text, out var team2Score))
            {
                return;
            }

            _match.Team1Score = team1Score;
            _match.Team2Score = team2Score;
            _match.EloNotAffected = checkBoxNoElo.Checked;
        }
    }
}
