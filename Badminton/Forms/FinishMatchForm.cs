using Badminton.Classes;

namespace Badminton.Forms
{
    public partial class FinishMatchForm : Form
    {
        private Match _match;

        public FinishMatchForm(Match match)
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
    }
}
