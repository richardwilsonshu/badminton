using Badminton.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Badminton.Dialogs
{
    public partial class MatchFinderSettingsDialog : Form
    {
        private BadmintonClub _badmintonClub;

        public MatchFinderSettingsDialog(BadmintonClub badmintonClub)
        {
            InitializeComponent();

            _badmintonClub = badmintonClub;

            var settings = _badmintonClub.MatchFinderSettings;

            trackBarTeammateWeighting.Value = settings.TeammateWeighting;
            labelTeammateWeightingValue.Text = $"{settings.TeammateWeighting}%";

            trackBarOpponentWeighting.Value = settings.OpponentWeighting;
            labelOpponentWeightingValue.Text = $"{settings.OpponentWeighting}%";

            trackBarLastMatchWeighting.Value = settings.LastMatchWeighting;
            labelLastMatchWeightingValue.Text = $"{settings.LastMatchWeighting}%";

            trackBarAverageWaitingWeighting.Value = settings.AverageWaitingWeighting;
            labelAverageWaitingWeightingValue.Text = $"{settings.AverageWaitingWeighting}%";

            trackBarElo.Value = settings.EloTeamVarianceWeighting;
            labelEloValue.Text = $"{settings.EloTeamVarianceWeighting}%";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void labelEditPlayerName_Click(object sender, EventArgs e)
        {

        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            var settings = _badmintonClub.MatchFinderSettings;

            settings.TeammateWeighting = trackBarTeammateWeighting.Value;
            settings.OpponentWeighting = trackBarOpponentWeighting.Value;
            settings.LastMatchWeighting = trackBarLastMatchWeighting.Value;
            settings.AverageWaitingWeighting = trackBarAverageWaitingWeighting.Value;
            settings.EloTeamVarianceWeighting = trackBarElo.Value;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            labelTeammateWeightingValue.Text = $"{((TrackBar)sender).Value}%";
        }

        private void trackBarOpponentWeighting_Scroll(object sender, EventArgs e)
        {
            labelOpponentWeightingValue.Text = $"{((TrackBar)sender).Value}%";
        }

        private void trackBarLastMatchWeighting_Scroll(object sender, EventArgs e)
        {
            labelLastMatchWeightingValue.Text = $"{((TrackBar)sender).Value}%";
        }

        private void trackBarAverageWaitingWeighting_Scroll(object sender, EventArgs e)
        {
            labelAverageWaitingWeightingValue.Text = $"{((TrackBar)sender).Value}%";
        }

        private void trackBarElo_Scroll(object sender, EventArgs e)
        {
            labelEloValue.Text = $"{((TrackBar)sender).Value}%";
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Reset all weighting?", "Confirm Weightings Reset", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirmResult == DialogResult.Yes)
            {
                trackBarTeammateWeighting.Value = 100;
                labelTeammateWeightingValue.Text = "100%";

                trackBarOpponentWeighting.Value = 100;
                labelOpponentWeightingValue.Text = "100%";

                trackBarLastMatchWeighting.Value = 100;
                labelLastMatchWeightingValue.Text = "100%";

                trackBarAverageWaitingWeighting.Value = 100;
                labelAverageWaitingWeightingValue.Text = "100%";

                trackBarElo.Value = 100;
                labelEloValue.Text = "100%";
            }
        }

        private void labelTeammateWeightingName_Click(object sender, EventArgs e)
        {

        }
    }
}
