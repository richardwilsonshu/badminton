using Badminton.Classes;
using Badminton.Enums;

namespace Badminton.Forms
{
    public partial class UserForm : Form
    {
        public Player? AddedPlayer { get; set; } = null;

        private readonly Player? _existingPlayer;
        private int _originalElo = 0;

        public UserForm(Player? existingPlayer = null)
        {
            _existingPlayer = existingPlayer;

            InitializeComponent();
            InitializeCustomControls();

            if (_existingPlayer != null)
            {
                LoadFromExistingPlayer();
            }
            else
            {
                comboSkillLevel.SelectedValue = SkillLevel.Beginner;
                comboGender.SelectedValue = Gender.Other;
                textBoxElo.Text = "0";
            }
        }

        private void InitializeCustomControls()
        {
            var skillLevelOptions = Enum
                .GetNames<SkillLevel>()
                .Select(sl => new { Text = sl, Value = Enum.Parse<SkillLevel>(sl) })
                .ToList();

            comboSkillLevel.DisplayMember = "Text";
            comboSkillLevel.ValueMember = "Value";
            comboSkillLevel.DataSource = skillLevelOptions;

            var genderOptions = Enum
                .GetNames<Gender>()
                .Select(g => new { Text = g, Value = Enum.Parse<Gender>(g) })
                .ToList();

            comboGender.DisplayMember = "Text";
            comboGender.ValueMember = "Value";
            comboGender.DataSource = genderOptions;
        }

        private void LoadFromExistingPlayer()
        {
            textBoxFirstName.Text = _existingPlayer!.FirstName;
            textBoxLastName.Text = _existingPlayer.LastName;
            comboGender.SelectedValue = _existingPlayer.Gender;
            comboSkillLevel.SelectedValue = _existingPlayer.SkillLevel;
            textBoxElo.Text = _existingPlayer.Elo.ToString();
            labelPlayerAction.Text = "Edit Player";

            _originalElo = _existingPlayer.Elo;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (_existingPlayer == null)
            {
                AddedPlayer = CreatePlayer();
            }
            else
            {
                EditPlayer();
            }

            Close();
        }

        private Player? CreatePlayer()
        {
            if (!int.TryParse(textBoxElo.Text, out var elo))
            {
                return null;
            }

            var newPlayer = new Player(textBoxFirstName.Text, textBoxLastName.Text,
                (Gender)comboGender.SelectedValue, elo);

            return newPlayer;
        }

        private void EditPlayer()
        {
            if (!int.TryParse(textBoxElo.Text, out var elo))
            {
                return;
            }

            if (Math.Abs(elo - _originalElo) > 500)
            {
                var confirmResult = MessageBox.Show("This is a significant change in Elo. Are you sure you want to continue?", "Confirm Edit", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (confirmResult != DialogResult.Yes)
                {
                    return;
                }
            }

            _existingPlayer!.Elo = elo;
            _existingPlayer.FirstName = textBoxFirstName.Text;
            _existingPlayer.LastName = textBoxLastName.Text;
            _existingPlayer.Gender = (Gender)comboGender.SelectedValue;
        }

        private void textBoxFirstName_TextChanged(object sender, EventArgs e)
        {
            EnableDisableSaveButton();
        }

        private void textBoxLastName_TextChanged(object sender, EventArgs e)
        {
            EnableDisableSaveButton();
        }

        private void EnableDisableSaveButton()
        {
            buttonSave.Enabled = 
                textBoxFirstName.Text.Any() && 
                textBoxLastName.Text.Any();
        }

        private void comboSkillLevel_SelectedIndexChanged(object? sender, EventArgs e)
        {
            var skillLevel = (SkillLevel)comboSkillLevel.SelectedValue;

            var elo = skillLevel == SkillLevel.Beginner ? 0
                : skillLevel == SkillLevel.Intermediate ? Constants.EloIntermediateLower
                : skillLevel == SkillLevel.Advanced ? Constants.EloAdvancedLower
                : -1;

            textBoxElo.TextChanged -= textBoxElo_TextChanged;
            textBoxElo.Text = $"{elo}";
            textBoxElo.TextChanged += textBoxElo_TextChanged;
        }

        private void textBoxElo_TextChanged(object? sender, EventArgs e)
        {
            if (!int.TryParse(textBoxElo.Text, out var elo))
            {
                return;
            }

            var skillLevel = elo < Constants.EloIntermediateLower ? SkillLevel.Beginner
                            : elo < Constants.EloAdvancedLower ? SkillLevel.Intermediate
                            : SkillLevel.Advanced;

            comboSkillLevel.SelectedIndexChanged -= comboSkillLevel_SelectedIndexChanged;
            comboSkillLevel.SelectedValue = skillLevel;
            comboSkillLevel.SelectedIndexChanged += comboSkillLevel_SelectedIndexChanged;
        }
    }
}
