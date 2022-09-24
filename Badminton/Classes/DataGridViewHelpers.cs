using Badminton.Shared.Classes;
using Badminton.Shared.Enums;

namespace Badminton.Classes
{
    public static class DataGridViewHelpers
    {
        public static void PlayerList_RowPrePaint(DataGridView dataGridView, DataGridViewRowPrePaintEventArgs e)
        {
            var player = dataGridView.Rows[e.RowIndex].DataBoundItem as Player;

            if (player?.Gender == Gender.Male)
            {
                dataGridView.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightBlue;
            }
            else
            {
                dataGridView.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightPink;
            }
        }
    }
}
