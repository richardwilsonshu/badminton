namespace Badminton.Forms
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.listBoxActivePlayers = new System.Windows.Forms.ListBox();
            this.buttonAddPlayer = new System.Windows.Forms.Button();
            this.buttonRemovePlayer = new System.Windows.Forms.Button();
            this.buttonGenerateGame = new System.Windows.Forms.Button();
            this.listBoxCourt1Side1 = new System.Windows.Forms.ListBox();
            this.listBoxCourt1Side2 = new System.Windows.Forms.ListBox();
            this.labelVsCourt1 = new System.Windows.Forms.Label();
            this.labelCourt1 = new System.Windows.Forms.Label();
            this.panelCourt1 = new System.Windows.Forms.Panel();
            this.labelCourt1MatchTime = new System.Windows.Forms.Label();
            this.buttonStartFinishCourt1 = new System.Windows.Forms.Button();
            this.panelCourt2 = new System.Windows.Forms.Panel();
            this.labelCourt2MatchTime = new System.Windows.Forms.Label();
            this.buttonFinishCourt2 = new System.Windows.Forms.Button();
            this.listBoxCourt2Side2 = new System.Windows.Forms.ListBox();
            this.labelCourt2 = new System.Windows.Forms.Label();
            this.listBoxCourt2Side1 = new System.Windows.Forms.ListBox();
            this.labelVsCourt2 = new System.Windows.Forms.Label();
            this.listBoxClubPlayers = new System.Windows.Forms.ListBox();
            this.buttonMoveToActivePlayers = new System.Windows.Forms.Button();
            this.buttonRemoveFromActivePlayers = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timerMatches = new System.Windows.Forms.Timer(this.components);
            this.labelAvailablePlayers = new System.Windows.Forms.Label();
            this.labelAllPlayers = new System.Windows.Forms.Label();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.panelCourt1.SuspendLayout();
            this.panelCourt2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxActivePlayers
            // 
            this.listBoxActivePlayers.FormattingEnabled = true;
            this.listBoxActivePlayers.ItemHeight = 15;
            this.listBoxActivePlayers.Location = new System.Drawing.Point(12, 42);
            this.listBoxActivePlayers.Name = "listBoxActivePlayers";
            this.listBoxActivePlayers.Size = new System.Drawing.Size(204, 229);
            this.listBoxActivePlayers.TabIndex = 0;
            this.listBoxActivePlayers.DoubleClick += new System.EventHandler(this.listBoxActivePlayers_DoubleClick);
            // 
            // buttonAddPlayer
            // 
            this.buttonAddPlayer.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonAddPlayer.Location = new System.Drawing.Point(173, 483);
            this.buttonAddPlayer.Margin = new System.Windows.Forms.Padding(0);
            this.buttonAddPlayer.Name = "buttonAddPlayer";
            this.buttonAddPlayer.Size = new System.Drawing.Size(43, 44);
            this.buttonAddPlayer.TabIndex = 1;
            this.buttonAddPlayer.Text = "+";
            this.buttonAddPlayer.UseVisualStyleBackColor = true;
            this.buttonAddPlayer.Click += new System.EventHandler(this.buttonAddPlayer_Click);
            // 
            // buttonRemovePlayer
            // 
            this.buttonRemovePlayer.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonRemovePlayer.Location = new System.Drawing.Point(12, 483);
            this.buttonRemovePlayer.Margin = new System.Windows.Forms.Padding(0);
            this.buttonRemovePlayer.Name = "buttonRemovePlayer";
            this.buttonRemovePlayer.Size = new System.Drawing.Size(43, 44);
            this.buttonRemovePlayer.TabIndex = 2;
            this.buttonRemovePlayer.Text = "-";
            this.buttonRemovePlayer.UseVisualStyleBackColor = true;
            this.buttonRemovePlayer.Click += new System.EventHandler(this.buttonRemovePlayer_Click);
            // 
            // buttonGenerateGame
            // 
            this.buttonGenerateGame.Enabled = false;
            this.buttonGenerateGame.Location = new System.Drawing.Point(222, 27);
            this.buttonGenerateGame.Name = "buttonGenerateGame";
            this.buttonGenerateGame.Size = new System.Drawing.Size(118, 31);
            this.buttonGenerateGame.TabIndex = 3;
            this.buttonGenerateGame.Text = "Generate Game";
            this.buttonGenerateGame.UseVisualStyleBackColor = true;
            this.buttonGenerateGame.Click += new System.EventHandler(this.buttonGenerateGame_Click);
            // 
            // listBoxCourt1Side1
            // 
            this.listBoxCourt1Side1.FormattingEnabled = true;
            this.listBoxCourt1Side1.ItemHeight = 15;
            this.listBoxCourt1Side1.Location = new System.Drawing.Point(18, 38);
            this.listBoxCourt1Side1.Name = "listBoxCourt1Side1";
            this.listBoxCourt1Side1.Size = new System.Drawing.Size(116, 34);
            this.listBoxCourt1Side1.TabIndex = 4;
            // 
            // listBoxCourt1Side2
            // 
            this.listBoxCourt1Side2.FormattingEnabled = true;
            this.listBoxCourt1Side2.ItemHeight = 15;
            this.listBoxCourt1Side2.Location = new System.Drawing.Point(164, 38);
            this.listBoxCourt1Side2.Name = "listBoxCourt1Side2";
            this.listBoxCourt1Side2.Size = new System.Drawing.Size(116, 34);
            this.listBoxCourt1Side2.TabIndex = 5;
            // 
            // labelVsCourt1
            // 
            this.labelVsCourt1.AutoSize = true;
            this.labelVsCourt1.Location = new System.Drawing.Point(140, 47);
            this.labelVsCourt1.Name = "labelVsCourt1";
            this.labelVsCourt1.Size = new System.Drawing.Size(18, 15);
            this.labelVsCourt1.TabIndex = 6;
            this.labelVsCourt1.Text = "vs";
            // 
            // labelCourt1
            // 
            this.labelCourt1.AutoSize = true;
            this.labelCourt1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelCourt1.Location = new System.Drawing.Point(125, 7);
            this.labelCourt1.Name = "labelCourt1";
            this.labelCourt1.Size = new System.Drawing.Size(48, 15);
            this.labelCourt1.TabIndex = 7;
            this.labelCourt1.Text = "Court 1";
            // 
            // panelCourt1
            // 
            this.panelCourt1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelCourt1.Controls.Add(this.labelCourt1MatchTime);
            this.panelCourt1.Controls.Add(this.buttonStartFinishCourt1);
            this.panelCourt1.Controls.Add(this.listBoxCourt1Side2);
            this.panelCourt1.Controls.Add(this.labelCourt1);
            this.panelCourt1.Controls.Add(this.listBoxCourt1Side1);
            this.panelCourt1.Controls.Add(this.labelVsCourt1);
            this.panelCourt1.Enabled = false;
            this.panelCourt1.Location = new System.Drawing.Point(492, 27);
            this.panelCourt1.Name = "panelCourt1";
            this.panelCourt1.Size = new System.Drawing.Size(296, 119);
            this.panelCourt1.TabIndex = 8;
            // 
            // labelCourt1MatchTime
            // 
            this.labelCourt1MatchTime.AutoSize = true;
            this.labelCourt1MatchTime.Location = new System.Drawing.Point(18, 86);
            this.labelCourt1MatchTime.Name = "labelCourt1MatchTime";
            this.labelCourt1MatchTime.Size = new System.Drawing.Size(71, 15);
            this.labelCourt1MatchTime.TabIndex = 10;
            this.labelCourt1MatchTime.Text = "Match time:";
            // 
            // buttonStartFinishCourt1
            // 
            this.buttonStartFinishCourt1.Location = new System.Drawing.Point(164, 78);
            this.buttonStartFinishCourt1.Name = "buttonStartFinishCourt1";
            this.buttonStartFinishCourt1.Size = new System.Drawing.Size(118, 31);
            this.buttonStartFinishCourt1.TabIndex = 9;
            this.buttonStartFinishCourt1.Text = "Finish";
            this.buttonStartFinishCourt1.UseVisualStyleBackColor = true;
            this.buttonStartFinishCourt1.Click += new System.EventHandler(this.buttonFinishCourt1_Click);
            // 
            // panelCourt2
            // 
            this.panelCourt2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelCourt2.Controls.Add(this.labelCourt2MatchTime);
            this.panelCourt2.Controls.Add(this.buttonFinishCourt2);
            this.panelCourt2.Controls.Add(this.listBoxCourt2Side2);
            this.panelCourt2.Controls.Add(this.labelCourt2);
            this.panelCourt2.Controls.Add(this.listBoxCourt2Side1);
            this.panelCourt2.Controls.Add(this.labelVsCourt2);
            this.panelCourt2.Enabled = false;
            this.panelCourt2.Location = new System.Drawing.Point(492, 152);
            this.panelCourt2.Name = "panelCourt2";
            this.panelCourt2.Size = new System.Drawing.Size(296, 119);
            this.panelCourt2.TabIndex = 10;
            // 
            // labelCourt2MatchTime
            // 
            this.labelCourt2MatchTime.AutoSize = true;
            this.labelCourt2MatchTime.Location = new System.Drawing.Point(18, 86);
            this.labelCourt2MatchTime.Name = "labelCourt2MatchTime";
            this.labelCourt2MatchTime.Size = new System.Drawing.Size(71, 15);
            this.labelCourt2MatchTime.TabIndex = 11;
            this.labelCourt2MatchTime.Text = "Match time:";
            // 
            // buttonFinishCourt2
            // 
            this.buttonFinishCourt2.Location = new System.Drawing.Point(164, 78);
            this.buttonFinishCourt2.Name = "buttonFinishCourt2";
            this.buttonFinishCourt2.Size = new System.Drawing.Size(118, 31);
            this.buttonFinishCourt2.TabIndex = 9;
            this.buttonFinishCourt2.Text = "Finish";
            this.buttonFinishCourt2.UseVisualStyleBackColor = true;
            this.buttonFinishCourt2.Click += new System.EventHandler(this.buttonFinishCourt2_Click);
            // 
            // listBoxCourt2Side2
            // 
            this.listBoxCourt2Side2.FormattingEnabled = true;
            this.listBoxCourt2Side2.ItemHeight = 15;
            this.listBoxCourt2Side2.Location = new System.Drawing.Point(164, 38);
            this.listBoxCourt2Side2.Name = "listBoxCourt2Side2";
            this.listBoxCourt2Side2.Size = new System.Drawing.Size(116, 34);
            this.listBoxCourt2Side2.TabIndex = 5;
            // 
            // labelCourt2
            // 
            this.labelCourt2.AutoSize = true;
            this.labelCourt2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelCourt2.Location = new System.Drawing.Point(125, 7);
            this.labelCourt2.Name = "labelCourt2";
            this.labelCourt2.Size = new System.Drawing.Size(48, 15);
            this.labelCourt2.TabIndex = 7;
            this.labelCourt2.Text = "Court 2";
            // 
            // listBoxCourt2Side1
            // 
            this.listBoxCourt2Side1.FormattingEnabled = true;
            this.listBoxCourt2Side1.ItemHeight = 15;
            this.listBoxCourt2Side1.Location = new System.Drawing.Point(18, 38);
            this.listBoxCourt2Side1.Name = "listBoxCourt2Side1";
            this.listBoxCourt2Side1.Size = new System.Drawing.Size(116, 34);
            this.listBoxCourt2Side1.TabIndex = 4;
            // 
            // labelVsCourt2
            // 
            this.labelVsCourt2.AutoSize = true;
            this.labelVsCourt2.Location = new System.Drawing.Point(140, 47);
            this.labelVsCourt2.Name = "labelVsCourt2";
            this.labelVsCourt2.Size = new System.Drawing.Size(18, 15);
            this.labelVsCourt2.TabIndex = 6;
            this.labelVsCourt2.Text = "vs";
            // 
            // listBoxClubPlayers
            // 
            this.listBoxClubPlayers.FormattingEnabled = true;
            this.listBoxClubPlayers.ItemHeight = 15;
            this.listBoxClubPlayers.Location = new System.Drawing.Point(12, 336);
            this.listBoxClubPlayers.Name = "listBoxClubPlayers";
            this.listBoxClubPlayers.Size = new System.Drawing.Size(204, 139);
            this.listBoxClubPlayers.TabIndex = 11;
            // 
            // buttonMoveToActivePlayers
            // 
            this.buttonMoveToActivePlayers.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonMoveToActivePlayers.Location = new System.Drawing.Point(173, 274);
            this.buttonMoveToActivePlayers.Margin = new System.Windows.Forms.Padding(0);
            this.buttonMoveToActivePlayers.Name = "buttonMoveToActivePlayers";
            this.buttonMoveToActivePlayers.Size = new System.Drawing.Size(43, 44);
            this.buttonMoveToActivePlayers.TabIndex = 12;
            this.buttonMoveToActivePlayers.Text = "^";
            this.buttonMoveToActivePlayers.UseVisualStyleBackColor = true;
            this.buttonMoveToActivePlayers.Click += new System.EventHandler(this.buttonMoveToActivePlayers_Click);
            // 
            // buttonRemoveFromActivePlayers
            // 
            this.buttonRemoveFromActivePlayers.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonRemoveFromActivePlayers.Location = new System.Drawing.Point(12, 274);
            this.buttonRemoveFromActivePlayers.Margin = new System.Windows.Forms.Padding(0);
            this.buttonRemoveFromActivePlayers.Name = "buttonRemoveFromActivePlayers";
            this.buttonRemoveFromActivePlayers.Size = new System.Drawing.Size(43, 44);
            this.buttonRemoveFromActivePlayers.TabIndex = 13;
            this.buttonRemoveFromActivePlayers.Text = "v";
            this.buttonRemoveFromActivePlayers.UseVisualStyleBackColor = true;
            this.buttonRemoveFromActivePlayers.Click += new System.EventHandler(this.buttonRemoveFromActivePlayers_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 14;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadToolStripMenuItem,
            this.saveToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.loadToolStripMenuItem.Text = "Load";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.loadToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // timerMatches
            // 
            this.timerMatches.Enabled = true;
            this.timerMatches.Interval = 1000;
            this.timerMatches.Tick += new System.EventHandler(this.timerMatches_Tick);
            // 
            // labelAvailablePlayers
            // 
            this.labelAvailablePlayers.AutoSize = true;
            this.labelAvailablePlayers.Location = new System.Drawing.Point(12, 24);
            this.labelAvailablePlayers.Name = "labelAvailablePlayers";
            this.labelAvailablePlayers.Size = new System.Drawing.Size(95, 15);
            this.labelAvailablePlayers.TabIndex = 15;
            this.labelAvailablePlayers.Text = "Available Players";
            // 
            // labelAllPlayers
            // 
            this.labelAllPlayers.AutoSize = true;
            this.labelAllPlayers.Location = new System.Drawing.Point(12, 318);
            this.labelAllPlayers.Name = "labelAllPlayers";
            this.labelAllPlayers.Size = new System.Drawing.Size(61, 15);
            this.labelAllPlayers.TabIndex = 16;
            this.labelAllPlayers.Text = "All Players";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(122, 20);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 536);
            this.Controls.Add(this.labelAllPlayers);
            this.Controls.Add(this.labelAvailablePlayers);
            this.Controls.Add(this.buttonRemoveFromActivePlayers);
            this.Controls.Add(this.buttonMoveToActivePlayers);
            this.Controls.Add(this.listBoxClubPlayers);
            this.Controls.Add(this.panelCourt2);
            this.Controls.Add(this.panelCourt1);
            this.Controls.Add(this.buttonGenerateGame);
            this.Controls.Add(this.buttonRemovePlayer);
            this.Controls.Add(this.buttonAddPlayer);
            this.Controls.Add(this.listBoxActivePlayers);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Badminton";
            this.panelCourt1.ResumeLayout(false);
            this.panelCourt1.PerformLayout();
            this.panelCourt2.ResumeLayout(false);
            this.panelCourt2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox listBoxActivePlayers;
        private Button buttonAddPlayer;
        private Button buttonRemovePlayer;
        private Button buttonGenerateGame;
        private ListBox listBoxCourt1Side1;
        private ListBox listBoxCourt1Side2;
        private Label labelVsCourt1;
        private Label labelCourt1;
        private Panel panelCourt1;
        private Button buttonStartFinishCourt1;
        private Panel panelCourt2;
        private Button buttonFinishCourt2;
        private ListBox listBoxCourt2Side2;
        private Label labelCourt2;
        private ListBox listBoxCourt2Side1;
        private Label labelVsCourt2;
        private ListBox listBoxClubPlayers;
        private Button buttonMoveToActivePlayers;
        private Button buttonRemoveFromActivePlayers;
        private Label labelCourt1MatchTime;
        private Label labelCourt2MatchTime;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem loadToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.Timer timerMatches;
        private Label labelAvailablePlayers;
        private Label labelAllPlayers;
        private ToolStripMenuItem toolStripMenuItem1;
    }
}