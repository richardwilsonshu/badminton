namespace Badminton.Dialogs
{
    partial class FinishMatchDialog
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
            this.buttonFinish = new System.Windows.Forms.Button();
            this.labelCourtTitle = new System.Windows.Forms.Label();
            this.labelSide1Players = new System.Windows.Forms.Label();
            this.labelSide1Score = new System.Windows.Forms.Label();
            this.textBoxSide1Score = new System.Windows.Forms.TextBox();
            this.textBoxSide2Score = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelSide2Players = new System.Windows.Forms.Label();
            this.checkBoxNoElo = new System.Windows.Forms.CheckBox();
            this.buttonAbandon = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonFinish
            // 
            this.buttonFinish.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonFinish.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonFinish.Location = new System.Drawing.Point(132, 235);
            this.buttonFinish.Name = "buttonFinish";
            this.buttonFinish.Size = new System.Drawing.Size(75, 31);
            this.buttonFinish.TabIndex = 5;
            this.buttonFinish.Text = "Finish";
            this.buttonFinish.UseVisualStyleBackColor = true;
            this.buttonFinish.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // labelCourtTitle
            // 
            this.labelCourtTitle.AutoSize = true;
            this.labelCourtTitle.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelCourtTitle.Location = new System.Drawing.Point(77, 9);
            this.labelCourtTitle.Name = "labelCourtTitle";
            this.labelCourtTitle.Size = new System.Drawing.Size(74, 25);
            this.labelCourtTitle.TabIndex = 2;
            this.labelCourtTitle.Text = "Court 1";
            // 
            // labelSide1Players
            // 
            this.labelSide1Players.AutoSize = true;
            this.labelSide1Players.Location = new System.Drawing.Point(12, 49);
            this.labelSide1Players.Name = "labelSide1Players";
            this.labelSide1Players.Size = new System.Drawing.Size(105, 15);
            this.labelSide1Players.TabIndex = 3;
            this.labelSide1Players.Text = "Player 1 && Player 2";
            // 
            // labelSide1Score
            // 
            this.labelSide1Score.AutoSize = true;
            this.labelSide1Score.Location = new System.Drawing.Point(17, 80);
            this.labelSide1Score.Name = "labelSide1Score";
            this.labelSide1Score.Size = new System.Drawing.Size(39, 15);
            this.labelSide1Score.TabIndex = 4;
            this.labelSide1Score.Text = "Score:";
            // 
            // textBoxSide1Score
            // 
            this.textBoxSide1Score.Location = new System.Drawing.Point(62, 77);
            this.textBoxSide1Score.Name = "textBoxSide1Score";
            this.textBoxSide1Score.Size = new System.Drawing.Size(100, 23);
            this.textBoxSide1Score.TabIndex = 1;
            this.textBoxSide1Score.TextChanged += new System.EventHandler(this.textBoxSide1Score_TextChanged);
            // 
            // textBoxSide2Score
            // 
            this.textBoxSide2Score.Location = new System.Drawing.Point(62, 147);
            this.textBoxSide2Score.Name = "textBoxSide2Score";
            this.textBoxSide2Score.Size = new System.Drawing.Size(100, 23);
            this.textBoxSide2Score.TabIndex = 2;
            this.textBoxSide2Score.TextChanged += new System.EventHandler(this.textBoxSide2Score_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Score:";
            // 
            // labelSide2Players
            // 
            this.labelSide2Players.AutoSize = true;
            this.labelSide2Players.Location = new System.Drawing.Point(12, 119);
            this.labelSide2Players.Name = "labelSide2Players";
            this.labelSide2Players.Size = new System.Drawing.Size(105, 15);
            this.labelSide2Players.TabIndex = 6;
            this.labelSide2Players.Text = "Player 3 && Player 4";
            // 
            // checkBoxNoElo
            // 
            this.checkBoxNoElo.AutoSize = true;
            this.checkBoxNoElo.Location = new System.Drawing.Point(12, 194);
            this.checkBoxNoElo.Name = "checkBoxNoElo";
            this.checkBoxNoElo.Size = new System.Drawing.Size(127, 19);
            this.checkBoxNoElo.TabIndex = 3;
            this.checkBoxNoElo.Text = "Not a ranked game";
            this.checkBoxNoElo.UseVisualStyleBackColor = true;
            // 
            // buttonAbandon
            // 
            this.buttonAbandon.DialogResult = System.Windows.Forms.DialogResult.Abort;
            this.buttonAbandon.Location = new System.Drawing.Point(12, 235);
            this.buttonAbandon.Name = "buttonAbandon";
            this.buttonAbandon.Size = new System.Drawing.Size(75, 31);
            this.buttonAbandon.TabIndex = 8;
            this.buttonAbandon.Text = "Abandon";
            this.buttonAbandon.UseVisualStyleBackColor = true;
            // 
            // FinishMatchDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(219, 278);
            this.Controls.Add(this.buttonAbandon);
            this.Controls.Add(this.checkBoxNoElo);
            this.Controls.Add(this.textBoxSide2Score);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelSide2Players);
            this.Controls.Add(this.textBoxSide1Score);
            this.Controls.Add(this.labelSide1Score);
            this.Controls.Add(this.labelSide1Players);
            this.Controls.Add(this.labelCourtTitle);
            this.Controls.Add(this.buttonFinish);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FinishMatchDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Finish Match";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button buttonFinish;
        private Label labelCourtTitle;
        private Label labelSide1Players;
        private Label labelSide1Score;
        private TextBox textBoxSide1Score;
        private TextBox textBoxSide2Score;
        private Label label1;
        private Label labelSide2Players;
        private CheckBox checkBoxNoElo;
        private Button buttonAbandon;
    }
}