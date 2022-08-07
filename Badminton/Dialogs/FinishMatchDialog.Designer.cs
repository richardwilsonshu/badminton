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
            this.labelTeam1Players = new System.Windows.Forms.Label();
            this.labelTeam1Score = new System.Windows.Forms.Label();
            this.textBoxTeam1Score = new System.Windows.Forms.TextBox();
            this.textBoxTeam2Score = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelTeam2Players = new System.Windows.Forms.Label();
            this.checkBoxNoElo = new System.Windows.Forms.CheckBox();
            this.buttonAbandon = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonFinish
            // 
            this.buttonFinish.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonFinish.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonFinish.Location = new System.Drawing.Point(170, 329);
            this.buttonFinish.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonFinish.Name = "buttonFinish";
            this.buttonFinish.Size = new System.Drawing.Size(96, 43);
            this.buttonFinish.TabIndex = 5;
            this.buttonFinish.Text = "Finish";
            this.buttonFinish.UseVisualStyleBackColor = true;
            this.buttonFinish.Click += new System.EventHandler(this.buttonFinish_Click);
            // 
            // labelCourtTitle
            // 
            this.labelCourtTitle.AutoSize = true;
            this.labelCourtTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelCourtTitle.Location = new System.Drawing.Point(103, 18);
            this.labelCourtTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCourtTitle.Name = "labelCourtTitle";
            this.labelCourtTitle.Size = new System.Drawing.Size(74, 25);
            this.labelCourtTitle.TabIndex = 2;
            this.labelCourtTitle.Text = "Court 1";
            // 
            // labelTeam1Players
            // 
            this.labelTeam1Players.AutoSize = true;
            this.labelTeam1Players.Location = new System.Drawing.Point(15, 69);
            this.labelTeam1Players.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTeam1Players.Name = "labelTeam1Players";
            this.labelTeam1Players.Size = new System.Drawing.Size(143, 21);
            this.labelTeam1Players.TabIndex = 3;
            this.labelTeam1Players.Text = "Player 1 && Player 2";
            // 
            // labelTeam1Score
            // 
            this.labelTeam1Score.AutoSize = true;
            this.labelTeam1Score.Location = new System.Drawing.Point(22, 112);
            this.labelTeam1Score.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTeam1Score.Name = "labelTeam1Score";
            this.labelTeam1Score.Size = new System.Drawing.Size(52, 21);
            this.labelTeam1Score.TabIndex = 4;
            this.labelTeam1Score.Text = "Score:";
            // 
            // textBoxTeam1Score
            // 
            this.textBoxTeam1Score.Location = new System.Drawing.Point(80, 108);
            this.textBoxTeam1Score.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxTeam1Score.Name = "textBoxTeam1Score";
            this.textBoxTeam1Score.Size = new System.Drawing.Size(127, 29);
            this.textBoxTeam1Score.TabIndex = 1;
            // 
            // textBoxTeam2Score
            // 
            this.textBoxTeam2Score.Location = new System.Drawing.Point(80, 206);
            this.textBoxTeam2Score.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxTeam2Score.Name = "textBoxTeam2Score";
            this.textBoxTeam2Score.Size = new System.Drawing.Size(127, 29);
            this.textBoxTeam2Score.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 210);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 21);
            this.label1.TabIndex = 7;
            this.label1.Text = "Score:";
            // 
            // labelTeam2Players
            // 
            this.labelTeam2Players.AutoSize = true;
            this.labelTeam2Players.Location = new System.Drawing.Point(15, 167);
            this.labelTeam2Players.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTeam2Players.Name = "labelTeam2Players";
            this.labelTeam2Players.Size = new System.Drawing.Size(143, 21);
            this.labelTeam2Players.TabIndex = 6;
            this.labelTeam2Players.Text = "Player 3 && Player 4";
            // 
            // checkBoxNoElo
            // 
            this.checkBoxNoElo.AutoSize = true;
            this.checkBoxNoElo.Location = new System.Drawing.Point(15, 272);
            this.checkBoxNoElo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBoxNoElo.Name = "checkBoxNoElo";
            this.checkBoxNoElo.Size = new System.Drawing.Size(162, 25);
            this.checkBoxNoElo.TabIndex = 3;
            this.checkBoxNoElo.Text = "Not a ranked game";
            this.checkBoxNoElo.UseVisualStyleBackColor = true;
            // 
            // buttonAbandon
            // 
            this.buttonAbandon.DialogResult = System.Windows.Forms.DialogResult.Abort;
            this.buttonAbandon.Location = new System.Drawing.Point(15, 329);
            this.buttonAbandon.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonAbandon.Name = "buttonAbandon";
            this.buttonAbandon.Size = new System.Drawing.Size(96, 43);
            this.buttonAbandon.TabIndex = 8;
            this.buttonAbandon.Text = "Abandon";
            this.buttonAbandon.UseVisualStyleBackColor = true;
            this.buttonAbandon.Click += new System.EventHandler(this.buttonAbandon_Click);
            // 
            // FinishMatchDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 389);
            this.Controls.Add(this.buttonAbandon);
            this.Controls.Add(this.checkBoxNoElo);
            this.Controls.Add(this.textBoxTeam2Score);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelTeam2Players);
            this.Controls.Add(this.textBoxTeam1Score);
            this.Controls.Add(this.labelTeam1Score);
            this.Controls.Add(this.labelTeam1Players);
            this.Controls.Add(this.labelCourtTitle);
            this.Controls.Add(this.buttonFinish);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
        private Label labelTeam1Players;
        private Label labelTeam1Score;
        private TextBox textBoxTeam1Score;
        private TextBox textBoxTeam2Score;
        private Label label1;
        private Label labelTeam2Players;
        private CheckBox checkBoxNoElo;
        private Button buttonAbandon;
    }
}