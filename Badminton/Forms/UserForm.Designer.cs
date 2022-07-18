namespace Badminton.Forms
{
    partial class UserForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelFirstName = new System.Windows.Forms.Label();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.labelLastName = new System.Windows.Forms.Label();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.labelPlayerAction = new System.Windows.Forms.Label();
            this.labelSkillLevel = new System.Windows.Forms.Label();
            this.comboSkillLevel = new System.Windows.Forms.ComboBox();
            this.comboGender = new System.Windows.Forms.ComboBox();
            this.labelGender = new System.Windows.Forms.Label();
            this.labelOr = new System.Windows.Forms.Label();
            this.textBoxElo = new System.Windows.Forms.TextBox();
            this.labelElo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelFirstName
            // 
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.Location = new System.Drawing.Point(15, 56);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(67, 15);
            this.labelFirstName.TabIndex = 0;
            this.labelFirstName.Text = "First Name:";
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Location = new System.Drawing.Point(103, 53);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(100, 23);
            this.textBoxFirstName.TabIndex = 1;
            this.textBoxFirstName.TextChanged += new System.EventHandler(this.textBoxFirstName_TextChanged);
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Location = new System.Drawing.Point(103, 82);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(100, 23);
            this.textBoxLastName.TabIndex = 3;
            this.textBoxLastName.TextChanged += new System.EventHandler(this.textBoxLastName_TextChanged);
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.Location = new System.Drawing.Point(16, 85);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(66, 15);
            this.labelLastName.TabIndex = 2;
            this.labelLastName.Text = "Last Name:";
            // 
            // buttonSave
            // 
            this.buttonSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonSave.Enabled = false;
            this.buttonSave.Location = new System.Drawing.Point(128, 200);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 11;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(15, 200);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 10;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // labelPlayerAction
            // 
            this.labelPlayerAction.AutoSize = true;
            this.labelPlayerAction.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelPlayerAction.Location = new System.Drawing.Point(56, 9);
            this.labelPlayerAction.Name = "labelPlayerAction";
            this.labelPlayerAction.Size = new System.Drawing.Size(103, 25);
            this.labelPlayerAction.TabIndex = 6;
            this.labelPlayerAction.Text = "Add Player";
            // 
            // labelSkillLevel
            // 
            this.labelSkillLevel.AutoSize = true;
            this.labelSkillLevel.Location = new System.Drawing.Point(21, 143);
            this.labelSkillLevel.Name = "labelSkillLevel";
            this.labelSkillLevel.Size = new System.Drawing.Size(61, 15);
            this.labelSkillLevel.TabIndex = 6;
            this.labelSkillLevel.Text = "Skill Level:";
            // 
            // comboSkillLevel
            // 
            this.comboSkillLevel.FormattingEnabled = true;
            this.comboSkillLevel.Location = new System.Drawing.Point(103, 140);
            this.comboSkillLevel.Name = "comboSkillLevel";
            this.comboSkillLevel.Size = new System.Drawing.Size(100, 23);
            this.comboSkillLevel.TabIndex = 7;
            this.comboSkillLevel.SelectedIndexChanged += new System.EventHandler(this.comboSkillLevel_SelectedIndexChanged);
            // 
            // comboGender
            // 
            this.comboGender.FormattingEnabled = true;
            this.comboGender.Location = new System.Drawing.Point(103, 111);
            this.comboGender.Name = "comboGender";
            this.comboGender.Size = new System.Drawing.Size(100, 23);
            this.comboGender.TabIndex = 5;
            // 
            // labelGender
            // 
            this.labelGender.AutoSize = true;
            this.labelGender.Location = new System.Drawing.Point(34, 114);
            this.labelGender.Name = "labelGender";
            this.labelGender.Size = new System.Drawing.Size(48, 15);
            this.labelGender.TabIndex = 4;
            this.labelGender.Text = "Gender:";
            // 
            // labelOr
            // 
            this.labelOr.AutoSize = true;
            this.labelOr.Location = new System.Drawing.Point(79, 160);
            this.labelOr.Name = "labelOr";
            this.labelOr.Size = new System.Drawing.Size(18, 15);
            this.labelOr.TabIndex = 12;
            this.labelOr.Text = "or";
            // 
            // textBoxElo
            // 
            this.textBoxElo.Location = new System.Drawing.Point(103, 171);
            this.textBoxElo.Name = "textBoxElo";
            this.textBoxElo.Size = new System.Drawing.Size(100, 23);
            this.textBoxElo.TabIndex = 9;
            this.textBoxElo.TextChanged += new System.EventHandler(this.textBoxElo_TextChanged);
            // 
            // labelElo
            // 
            this.labelElo.AutoSize = true;
            this.labelElo.Location = new System.Drawing.Point(56, 174);
            this.labelElo.Name = "labelElo";
            this.labelElo.Size = new System.Drawing.Size(26, 15);
            this.labelElo.TabIndex = 8;
            this.labelElo.Text = "Elo:";
            // 
            // UserForm
            // 
            this.AcceptButton = this.buttonSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(221, 239);
            this.ControlBox = false;
            this.Controls.Add(this.textBoxElo);
            this.Controls.Add(this.labelElo);
            this.Controls.Add(this.labelOr);
            this.Controls.Add(this.comboGender);
            this.Controls.Add(this.labelGender);
            this.Controls.Add(this.comboSkillLevel);
            this.Controls.Add(this.labelSkillLevel);
            this.Controls.Add(this.labelPlayerAction);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.textBoxLastName);
            this.Controls.Add(this.labelLastName);
            this.Controls.Add(this.textBoxFirstName);
            this.Controls.Add(this.labelFirstName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "UserForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Player";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelFirstName;
        private TextBox textBoxFirstName;
        private TextBox textBoxLastName;
        private Label labelLastName;
        private Button buttonSave;
        private Button buttonCancel;
        private Label labelPlayerAction;
        private Label labelSkillLevel;
        private ComboBox comboSkillLevel;
        private ComboBox comboGender;
        private Label labelGender;
        private Label labelOr;
        private TextBox textBoxElo;
        private Label labelElo;
    }
}