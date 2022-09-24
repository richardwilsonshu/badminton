using Badminton.Shared.Classes;
using Badminton.Shared.Enums;
using System.Data;

namespace Badminton.Dialogs
{
    public partial class EditPlayerDialog : Form
    {
        private readonly BadmintonClub _badmintonClub;
        private readonly Player _player;

        public EditPlayerDialog(BadmintonClub badmintonClub, Player player)
        {
            _badmintonClub = badmintonClub;
            _player = player;

            InitializeComponent();
            InitializeCustomControls();

            textBoxEditPlayerName.Text = _player.FullName;
            comboBoxEditGender.SelectedValue = _player.Gender;
        }

        private void InitializeCustomControls()
        {
            var genderOptions = Enum
                .GetNames<Gender>()
                .Select(g => new { Text = g, Value = (Gender?)Enum.Parse<Gender>(g) })
                .ToList();

            genderOptions.Insert(0, new { Text = "Please Select", Value = (Gender?)null });

            comboBoxEditGender.DisplayMember = "Text";
            comboBoxEditGender.ValueMember = "Value";
            comboBoxEditGender.DataSource = genderOptions;
        }

        private void buttonSaveEdit_Click(object sender, EventArgs e)
        {
            var fullName = textBoxEditPlayerName.Text;
            var gender = (Gender?)comboBoxEditGender.SelectedValue;

            if (string.IsNullOrWhiteSpace(fullName) || gender == null)
            {
                return;
            }

            var nameChanged = fullName != _player.FullName;

            if (nameChanged && _badmintonClub.PlayerAlreadyExists(fullName))
            {
                MessageBox.Show($"'{fullName}' is already taken. Please change your name!", "Name Taken", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _player.FullName = fullName;
            _player.Gender = gender.Value;

            Close();
        }
    }
}
