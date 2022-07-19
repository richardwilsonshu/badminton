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
            labelSide1Players.Text = string.Join(" & ", _match.Side1Players.Select(p => p.FullName));
            labelSide2Players.Text = string.Join(" & ", _match.Side2Players.Select(p => p.FullName));
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(textBoxSide1Score.Text, out var side1Score))
            {
                return;
            }
            if (!int.TryParse(textBoxSide2Score.Text, out var side2Score))
            {
                return;
            }

            _match.Side1Score = side1Score;
            _match.Side2Score = side2Score;
            _match.EloNotAffected = checkBoxNoElo.Checked;
        }

        private void textBoxSide1Score_TextChanged(object sender, EventArgs e)
        {
            // TODO are the scores equal?
        }

        private void textBoxSide2Score_TextChanged(object sender, EventArgs e)
        {
            // TODO are the scores equal?
        }
    }
}
