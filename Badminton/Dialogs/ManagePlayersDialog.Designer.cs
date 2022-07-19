namespace Badminton.Dialogs
{
    partial class ManagePlayersDialog
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
            this.buttonAddToSession = new System.Windows.Forms.Button();
            this.listBoxSessionWaitingPlayers = new System.Windows.Forms.ListBox();
            this.buttonRemoveFromSession = new System.Windows.Forms.Button();
            this.labelSessionPlayers = new System.Windows.Forms.Label();
            this.labelClubPlayers = new System.Windows.Forms.Label();
            this.listBoxPlayers = new System.Windows.Forms.ListBox();
            this.buttonAddPlayer = new System.Windows.Forms.Button();
            this.buttonRemovePlayer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonAddToSession
            // 
            this.buttonAddToSession.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonAddToSession.Location = new System.Drawing.Point(222, 117);
            this.buttonAddToSession.Name = "buttonAddToSession";
            this.buttonAddToSession.Size = new System.Drawing.Size(75, 38);
            this.buttonAddToSession.TabIndex = 1;
            this.buttonAddToSession.Text = ">>";
            this.buttonAddToSession.UseVisualStyleBackColor = true;
            this.buttonAddToSession.Click += new System.EventHandler(this.buttonAddToSession_Click);
            // 
            // listBoxSessionWaitingPlayers
            // 
            this.listBoxSessionWaitingPlayers.FormattingEnabled = true;
            this.listBoxSessionWaitingPlayers.ItemHeight = 15;
            this.listBoxSessionWaitingPlayers.Location = new System.Drawing.Point(303, 40);
            this.listBoxSessionWaitingPlayers.Name = "listBoxSessionWaitingPlayers";
            this.listBoxSessionWaitingPlayers.Size = new System.Drawing.Size(217, 244);
            this.listBoxSessionWaitingPlayers.TabIndex = 2;
            // 
            // buttonRemoveFromSession
            // 
            this.buttonRemoveFromSession.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonRemoveFromSession.Location = new System.Drawing.Point(222, 161);
            this.buttonRemoveFromSession.Name = "buttonRemoveFromSession";
            this.buttonRemoveFromSession.Size = new System.Drawing.Size(75, 38);
            this.buttonRemoveFromSession.TabIndex = 3;
            this.buttonRemoveFromSession.Text = "<<";
            this.buttonRemoveFromSession.UseVisualStyleBackColor = true;
            // 
            // labelSessionPlayers
            // 
            this.labelSessionPlayers.AutoSize = true;
            this.labelSessionPlayers.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelSessionPlayers.Location = new System.Drawing.Point(347, 12);
            this.labelSessionPlayers.Name = "labelSessionPlayers";
            this.labelSessionPlayers.Size = new System.Drawing.Size(140, 25);
            this.labelSessionPlayers.TabIndex = 4;
            this.labelSessionPlayers.Text = "Session Players";
            // 
            // labelClubPlayers
            // 
            this.labelClubPlayers.AutoSize = true;
            this.labelClubPlayers.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelClubPlayers.Location = new System.Drawing.Point(75, 12);
            this.labelClubPlayers.Name = "labelClubPlayers";
            this.labelClubPlayers.Size = new System.Drawing.Size(72, 25);
            this.labelClubPlayers.TabIndex = 27;
            this.labelClubPlayers.Text = "Players";
            // 
            // listBoxPlayers
            // 
            this.listBoxPlayers.FormattingEnabled = true;
            this.listBoxPlayers.ItemHeight = 15;
            this.listBoxPlayers.Location = new System.Drawing.Point(12, 40);
            this.listBoxPlayers.Name = "listBoxPlayers";
            this.listBoxPlayers.Size = new System.Drawing.Size(204, 244);
            this.listBoxPlayers.TabIndex = 24;
            // 
            // buttonAddPlayer
            // 
            this.buttonAddPlayer.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonAddPlayer.Location = new System.Drawing.Point(120, 287);
            this.buttonAddPlayer.Margin = new System.Windows.Forms.Padding(0);
            this.buttonAddPlayer.Name = "buttonAddPlayer";
            this.buttonAddPlayer.Size = new System.Drawing.Size(96, 26);
            this.buttonAddPlayer.TabIndex = 25;
            this.buttonAddPlayer.Text = "Add";
            this.buttonAddPlayer.UseVisualStyleBackColor = true;
            // 
            // buttonRemovePlayer
            // 
            this.buttonRemovePlayer.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonRemovePlayer.Location = new System.Drawing.Point(12, 287);
            this.buttonRemovePlayer.Margin = new System.Windows.Forms.Padding(0);
            this.buttonRemovePlayer.Name = "buttonRemovePlayer";
            this.buttonRemovePlayer.Size = new System.Drawing.Size(96, 26);
            this.buttonRemovePlayer.TabIndex = 26;
            this.buttonRemovePlayer.Text = "Remove";
            this.buttonRemovePlayer.UseVisualStyleBackColor = true;
            this.buttonRemovePlayer.Click += new System.EventHandler(this.buttonRemovePlayer_Click);
            // 
            // ManagePlayersDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(538, 329);
            this.ControlBox = false;
            this.Controls.Add(this.labelClubPlayers);
            this.Controls.Add(this.listBoxPlayers);
            this.Controls.Add(this.buttonAddPlayer);
            this.Controls.Add(this.buttonRemovePlayer);
            this.Controls.Add(this.labelSessionPlayers);
            this.Controls.Add(this.buttonRemoveFromSession);
            this.Controls.Add(this.listBoxSessionWaitingPlayers);
            this.Controls.Add(this.buttonAddToSession);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "ManagePlayersDialog";
            this.Text = "Players";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button buttonAddToSession;
        private ListBox listBoxSessionWaitingPlayers;
        private Button buttonRemoveFromSession;
        private Label labelSessionPlayers;
        private Label labelClubPlayers;
        private ListBox listBoxPlayers;
        private Button buttonAddPlayer;
        private Button buttonRemovePlayer;
    }
}