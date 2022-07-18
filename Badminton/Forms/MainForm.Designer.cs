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
            this.listBoxWaitingPlayers = new System.Windows.Forms.ListBox();
            this.buttonAddPlayerToSession = new System.Windows.Forms.Button();
            this.buttonRemovePlayerFromSession = new System.Windows.Forms.Button();
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
            this.listBoxRestingPlayers = new System.Windows.Forms.ListBox();
            this.buttonMoveToActivePlayers = new System.Windows.Forms.Button();
            this.buttonRemoveFromActivePlayers = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.timerMatches = new System.Windows.Forms.Timer(this.components);
            this.labelWaitingPlayers = new System.Windows.Forms.Label();
            this.labelRestingPlayers = new System.Windows.Forms.Label();
            this.Session = new System.Windows.Forms.TabControl();
            this.tabPageSession = new System.Windows.Forms.TabPage();
            this.tabPageAdmin = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.labelPlayers = new System.Windows.Forms.Label();
            this.listBoxPlayers = new System.Windows.Forms.ListBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.panelCourt1.SuspendLayout();
            this.panelCourt2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.Session.SuspendLayout();
            this.tabPageSession.SuspendLayout();
            this.tabPageAdmin.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxWaitingPlayers
            // 
            this.listBoxWaitingPlayers.FormattingEnabled = true;
            this.listBoxWaitingPlayers.ItemHeight = 15;
            this.listBoxWaitingPlayers.Location = new System.Drawing.Point(6, 24);
            this.listBoxWaitingPlayers.Name = "listBoxWaitingPlayers";
            this.listBoxWaitingPlayers.Size = new System.Drawing.Size(204, 229);
            this.listBoxWaitingPlayers.TabIndex = 0;
            this.listBoxWaitingPlayers.DoubleClick += new System.EventHandler(this.listBoxWaitingPlayers_DoubleClick);
            // 
            // buttonAddPlayerToSession
            // 
            this.buttonAddPlayerToSession.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonAddPlayerToSession.Location = new System.Drawing.Point(113, 256);
            this.buttonAddPlayerToSession.Margin = new System.Windows.Forms.Padding(0);
            this.buttonAddPlayerToSession.Name = "buttonAddPlayerToSession";
            this.buttonAddPlayerToSession.Size = new System.Drawing.Size(43, 44);
            this.buttonAddPlayerToSession.TabIndex = 1;
            this.buttonAddPlayerToSession.Text = "+";
            this.buttonAddPlayerToSession.UseVisualStyleBackColor = true;
            this.buttonAddPlayerToSession.Click += new System.EventHandler(this.buttonAddPlayerToSession_Click);
            // 
            // buttonRemovePlayerFromSession
            // 
            this.buttonRemovePlayerFromSession.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonRemovePlayerFromSession.Location = new System.Drawing.Point(59, 256);
            this.buttonRemovePlayerFromSession.Margin = new System.Windows.Forms.Padding(0);
            this.buttonRemovePlayerFromSession.Name = "buttonRemovePlayerFromSession";
            this.buttonRemovePlayerFromSession.Size = new System.Drawing.Size(43, 44);
            this.buttonRemovePlayerFromSession.TabIndex = 2;
            this.buttonRemovePlayerFromSession.Text = "-";
            this.buttonRemovePlayerFromSession.UseVisualStyleBackColor = true;
            this.buttonRemovePlayerFromSession.Click += new System.EventHandler(this.buttonRemovePlayerFromSession_Click);
            // 
            // buttonGenerateGame
            // 
            this.buttonGenerateGame.Enabled = false;
            this.buttonGenerateGame.Location = new System.Drawing.Point(216, 9);
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
            this.panelCourt1.Location = new System.Drawing.Point(631, 6);
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
            this.panelCourt2.Location = new System.Drawing.Point(631, 131);
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
            // listBoxRestingPlayers
            // 
            this.listBoxRestingPlayers.FormattingEnabled = true;
            this.listBoxRestingPlayers.ItemHeight = 15;
            this.listBoxRestingPlayers.Location = new System.Drawing.Point(6, 318);
            this.listBoxRestingPlayers.Name = "listBoxRestingPlayers";
            this.listBoxRestingPlayers.Size = new System.Drawing.Size(204, 184);
            this.listBoxRestingPlayers.TabIndex = 11;
            // 
            // buttonMoveToActivePlayers
            // 
            this.buttonMoveToActivePlayers.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonMoveToActivePlayers.Location = new System.Drawing.Point(167, 256);
            this.buttonMoveToActivePlayers.Margin = new System.Windows.Forms.Padding(0);
            this.buttonMoveToActivePlayers.Name = "buttonMoveToActivePlayers";
            this.buttonMoveToActivePlayers.Size = new System.Drawing.Size(43, 44);
            this.buttonMoveToActivePlayers.TabIndex = 12;
            this.buttonMoveToActivePlayers.Text = "^";
            this.buttonMoveToActivePlayers.UseVisualStyleBackColor = true;
            this.buttonMoveToActivePlayers.Click += new System.EventHandler(this.buttonMoveToWaitingPlayers_Click);
            // 
            // buttonRemoveFromActivePlayers
            // 
            this.buttonRemoveFromActivePlayers.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonRemoveFromActivePlayers.Location = new System.Drawing.Point(6, 256);
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
            this.menuStrip1.Size = new System.Drawing.Size(965, 24);
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
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(12, 20);
            // 
            // timerMatches
            // 
            this.timerMatches.Enabled = true;
            this.timerMatches.Interval = 1000;
            this.timerMatches.Tick += new System.EventHandler(this.timerMatches_Tick);
            // 
            // labelWaitingPlayers
            // 
            this.labelWaitingPlayers.AutoSize = true;
            this.labelWaitingPlayers.Location = new System.Drawing.Point(6, 6);
            this.labelWaitingPlayers.Name = "labelWaitingPlayers";
            this.labelWaitingPlayers.Size = new System.Drawing.Size(88, 15);
            this.labelWaitingPlayers.TabIndex = 15;
            this.labelWaitingPlayers.Text = "Waiting Players";
            // 
            // labelRestingPlayers
            // 
            this.labelRestingPlayers.AutoSize = true;
            this.labelRestingPlayers.Location = new System.Drawing.Point(6, 300);
            this.labelRestingPlayers.Name = "labelRestingPlayers";
            this.labelRestingPlayers.Size = new System.Drawing.Size(86, 15);
            this.labelRestingPlayers.TabIndex = 16;
            this.labelRestingPlayers.Text = "Resting Players";
            // 
            // Session
            // 
            this.Session.Controls.Add(this.tabPageAdmin);
            this.Session.Controls.Add(this.tabPageSession);
            this.Session.Location = new System.Drawing.Point(12, 27);
            this.Session.Name = "Session";
            this.Session.SelectedIndex = 0;
            this.Session.Size = new System.Drawing.Size(941, 534);
            this.Session.TabIndex = 17;
            // 
            // tabPageSession
            // 
            this.tabPageSession.Controls.Add(this.panelCourt1);
            this.tabPageSession.Controls.Add(this.labelRestingPlayers);
            this.tabPageSession.Controls.Add(this.panelCourt2);
            this.tabPageSession.Controls.Add(this.labelWaitingPlayers);
            this.tabPageSession.Controls.Add(this.buttonRemoveFromActivePlayers);
            this.tabPageSession.Controls.Add(this.listBoxWaitingPlayers);
            this.tabPageSession.Controls.Add(this.buttonMoveToActivePlayers);
            this.tabPageSession.Controls.Add(this.buttonAddPlayerToSession);
            this.tabPageSession.Controls.Add(this.listBoxRestingPlayers);
            this.tabPageSession.Controls.Add(this.buttonRemovePlayerFromSession);
            this.tabPageSession.Controls.Add(this.buttonGenerateGame);
            this.tabPageSession.Location = new System.Drawing.Point(4, 24);
            this.tabPageSession.Name = "tabPageSession";
            this.tabPageSession.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSession.Size = new System.Drawing.Size(933, 506);
            this.tabPageSession.TabIndex = 0;
            this.tabPageSession.Text = "Session";
            this.tabPageSession.UseVisualStyleBackColor = true;
            // 
            // tabPageAdmin
            // 
            this.tabPageAdmin.Controls.Add(this.labelPlayers);
            this.tabPageAdmin.Controls.Add(this.listBoxPlayers);
            this.tabPageAdmin.Controls.Add(this.button2);
            this.tabPageAdmin.Controls.Add(this.button3);
            this.tabPageAdmin.Controls.Add(this.button1);
            this.tabPageAdmin.Location = new System.Drawing.Point(4, 24);
            this.tabPageAdmin.Name = "tabPageAdmin";
            this.tabPageAdmin.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAdmin.Size = new System.Drawing.Size(933, 506);
            this.tabPageAdmin.TabIndex = 1;
            this.tabPageAdmin.Text = "Admin";
            this.tabPageAdmin.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(805, 477);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Start New Session";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // labelPlayers
            // 
            this.labelPlayers.AutoSize = true;
            this.labelPlayers.Location = new System.Drawing.Point(6, 32);
            this.labelPlayers.Name = "labelPlayers";
            this.labelPlayers.Size = new System.Drawing.Size(44, 15);
            this.labelPlayers.TabIndex = 19;
            this.labelPlayers.Text = "Players";
            // 
            // listBoxPlayers
            // 
            this.listBoxPlayers.FormattingEnabled = true;
            this.listBoxPlayers.ItemHeight = 15;
            this.listBoxPlayers.Location = new System.Drawing.Point(6, 50);
            this.listBoxPlayers.Name = "listBoxPlayers";
            this.listBoxPlayers.Size = new System.Drawing.Size(204, 229);
            this.listBoxPlayers.TabIndex = 16;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(113, 282);
            this.button2.Margin = new System.Windows.Forms.Padding(0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(43, 44);
            this.button2.TabIndex = 17;
            this.button2.Text = "+";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button3.Location = new System.Drawing.Point(59, 282);
            this.button3.Margin = new System.Windows.Forms.Padding(0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(43, 44);
            this.button3.TabIndex = 18;
            this.button3.Text = "-";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 570);
            this.Controls.Add(this.Session);
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
            this.Session.ResumeLayout(false);
            this.tabPageSession.ResumeLayout(false);
            this.tabPageSession.PerformLayout();
            this.tabPageAdmin.ResumeLayout(false);
            this.tabPageAdmin.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox listBoxWaitingPlayers;
        private Button buttonAddPlayerToSession;
        private Button buttonRemovePlayerFromSession;
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
        private ListBox listBoxRestingPlayers;
        private Button buttonMoveToActivePlayers;
        private Button buttonRemoveFromActivePlayers;
        private Label labelCourt1MatchTime;
        private Label labelCourt2MatchTime;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem loadToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.Timer timerMatches;
        private Label labelWaitingPlayers;
        private Label labelRestingPlayers;
        private ToolStripMenuItem toolStripMenuItem1;
        private TabControl Session;
        private TabPage tabPageAdmin;
        private TabPage tabPageSession;
        private Label labelPlayers;
        private ListBox listBoxPlayers;
        private Button button2;
        private Button button3;
        private Button button1;
    }
}