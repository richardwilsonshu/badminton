namespace Badminton.Dialogs
{
    partial class EditPlayerDialog
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
            this.buttonSaveEdit = new System.Windows.Forms.Button();
            this.comboBoxEditGender = new System.Windows.Forms.ComboBox();
            this.labelEditPlayerGender = new System.Windows.Forms.Label();
            this.textBoxEditPlayerName = new System.Windows.Forms.TextBox();
            this.labelEditPlayerName = new System.Windows.Forms.Label();
            this.buttonCancelEdit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonSaveEdit
            // 
            this.buttonSaveEdit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonSaveEdit.Location = new System.Drawing.Point(273, 203);
            this.buttonSaveEdit.Margin = new System.Windows.Forms.Padding(0);
            this.buttonSaveEdit.Name = "buttonSaveEdit";
            this.buttonSaveEdit.Size = new System.Drawing.Size(138, 36);
            this.buttonSaveEdit.TabIndex = 38;
            this.buttonSaveEdit.Text = "Save";
            this.buttonSaveEdit.UseVisualStyleBackColor = true;
            this.buttonSaveEdit.Click += new System.EventHandler(this.buttonSaveEdit_Click);
            // 
            // comboBoxEditGender
            // 
            this.comboBoxEditGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxEditGender.FormattingEnabled = true;
            this.comboBoxEditGender.Location = new System.Drawing.Point(161, 116);
            this.comboBoxEditGender.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxEditGender.Name = "comboBoxEditGender";
            this.comboBoxEditGender.Size = new System.Drawing.Size(166, 29);
            this.comboBoxEditGender.TabIndex = 37;
            // 
            // labelEditPlayerGender
            // 
            this.labelEditPlayerGender.AutoSize = true;
            this.labelEditPlayerGender.Location = new System.Drawing.Point(15, 120);
            this.labelEditPlayerGender.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelEditPlayerGender.Name = "labelEditPlayerGender";
            this.labelEditPlayerGender.Size = new System.Drawing.Size(138, 21);
            this.labelEditPlayerGender.TabIndex = 36;
            this.labelEditPlayerGender.Text = "Edit Player Gender";
            // 
            // textBoxEditPlayerName
            // 
            this.textBoxEditPlayerName.Location = new System.Drawing.Point(161, 76);
            this.textBoxEditPlayerName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxEditPlayerName.Name = "textBoxEditPlayerName";
            this.textBoxEditPlayerName.Size = new System.Drawing.Size(248, 29);
            this.textBoxEditPlayerName.TabIndex = 34;
            // 
            // labelEditPlayerName
            // 
            this.labelEditPlayerName.AutoSize = true;
            this.labelEditPlayerName.Location = new System.Drawing.Point(23, 80);
            this.labelEditPlayerName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelEditPlayerName.Name = "labelEditPlayerName";
            this.labelEditPlayerName.Size = new System.Drawing.Size(129, 21);
            this.labelEditPlayerName.TabIndex = 35;
            this.labelEditPlayerName.Text = "Edit Player Name";
            // 
            // buttonCancelEdit
            // 
            this.buttonCancelEdit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonCancelEdit.Location = new System.Drawing.Point(15, 203);
            this.buttonCancelEdit.Margin = new System.Windows.Forms.Padding(0);
            this.buttonCancelEdit.Name = "buttonCancelEdit";
            this.buttonCancelEdit.Size = new System.Drawing.Size(138, 36);
            this.buttonCancelEdit.TabIndex = 33;
            this.buttonCancelEdit.Text = "Cancel";
            this.buttonCancelEdit.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(161, 13);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 25);
            this.label1.TabIndex = 39;
            this.label1.Text = "Edit Player";
            // 
            // EditPlayerDialog
            // 
            this.AcceptButton = this.buttonSaveEdit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancelEdit;
            this.ClientSize = new System.Drawing.Size(422, 258);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonSaveEdit);
            this.Controls.Add(this.comboBoxEditGender);
            this.Controls.Add(this.labelEditPlayerGender);
            this.Controls.Add(this.textBoxEditPlayerName);
            this.Controls.Add(this.labelEditPlayerName);
            this.Controls.Add(this.buttonCancelEdit);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditPlayerDialog";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Edit Player";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button buttonSaveEdit;
        private ComboBox comboBoxEditGender;
        private Label labelEditPlayerGender;
        private TextBox textBoxEditPlayerName;
        private Label labelEditPlayerName;
        private Button buttonCancelEdit;
        private Label label1;
    }
}