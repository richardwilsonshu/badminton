namespace Badminton.Controls
{
    partial class SessionControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panelCourt1 = new System.Windows.Forms.Panel();
            this.labelCourt1MatchTime = new System.Windows.Forms.Label();
            this.buttonFinishCourt1 = new System.Windows.Forms.Button();
            this.listBoxCourt1Team2 = new System.Windows.Forms.ListBox();
            this.labelCourt1 = new System.Windows.Forms.Label();
            this.listBoxCourt1Team1 = new System.Windows.Forms.ListBox();
            this.labelVsCourt1 = new System.Windows.Forms.Label();
            this.labelRestingPlayers = new System.Windows.Forms.Label();
            this.panelCourt2 = new System.Windows.Forms.Panel();
            this.labelCourt2MatchTime = new System.Windows.Forms.Label();
            this.buttonFinishCourt2 = new System.Windows.Forms.Button();
            this.listBoxCourt2Team2 = new System.Windows.Forms.ListBox();
            this.labelCourt2 = new System.Windows.Forms.Label();
            this.listBoxCourt2Team1 = new System.Windows.Forms.ListBox();
            this.labelVsCourt2 = new System.Windows.Forms.Label();
            this.labelWaitingPlayers = new System.Windows.Forms.Label();
            this.buttonRestPlayer = new System.Windows.Forms.Button();
            this.listBoxWaitingPlayers = new System.Windows.Forms.ListBox();
            this.buttonEndRest = new System.Windows.Forms.Button();
            this.buttonAddPlayerToSession = new System.Windows.Forms.Button();
            this.listBoxRestingPlayers = new System.Windows.Forms.ListBox();
            this.buttonRemovePlayerFromSession = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.buttonEndSession = new System.Windows.Forms.Button();
            this.buttonFindMens = new System.Windows.Forms.Button();
            this.panelMatchPreview = new System.Windows.Forms.Panel();
            this.buttonMatchPreviewTeam2RemovePlayer = new System.Windows.Forms.Button();
            this.labelMatchPreviewTeam2 = new System.Windows.Forms.Label();
            this.labelMatchPreviewTeam1 = new System.Windows.Forms.Label();
            this.buttonMatchPreviewTeam1RemovePlayer = new System.Windows.Forms.Button();
            this.buttonStartGame = new System.Windows.Forms.Button();
            this.listBoxMatchPreviewTeam2 = new System.Windows.Forms.ListBox();
            this.labelMatchPreview = new System.Windows.Forms.Label();
            this.listBoxMatchPreviewTeam1 = new System.Windows.Forms.ListBox();
            this.labelMatchPreviewVs = new System.Windows.Forms.Label();
            this.buttonFindWomens = new System.Windows.Forms.Button();
            this.buttonFindMixed = new System.Windows.Forms.Button();
            this.buttonFindGenderless = new System.Windows.Forms.Button();
            this.buttonAddToTeam1 = new System.Windows.Forms.Button();
            this.buttonAddToTeam2 = new System.Windows.Forms.Button();
            this.panelCourt3 = new System.Windows.Forms.Panel();
            this.labelCourt3MatchTime = new System.Windows.Forms.Label();
            this.buttonFinishCourt3 = new System.Windows.Forms.Button();
            this.listBoxCourt3Team2 = new System.Windows.Forms.ListBox();
            this.labelCourt3 = new System.Windows.Forms.Label();
            this.listBoxCourt3Team1 = new System.Windows.Forms.ListBox();
            this.labelCourt3Vs = new System.Windows.Forms.Label();
            this.panelCourt4 = new System.Windows.Forms.Panel();
            this.labelCourt4MatchTime = new System.Windows.Forms.Label();
            this.buttonFinishCourt4 = new System.Windows.Forms.Button();
            this.listBoxCourt4Team2 = new System.Windows.Forms.ListBox();
            this.labelCourt4 = new System.Windows.Forms.Label();
            this.listBoxCourt4Team1 = new System.Windows.Forms.ListBox();
            this.labelCourt4Vs = new System.Windows.Forms.Label();
            this.buttonStartSession = new System.Windows.Forms.Button();
            this.comboBoxCourtsAvailable = new System.Windows.Forms.ComboBox();
            this.labelMatchMessage = new System.Windows.Forms.Label();
            this.panelCourt1.SuspendLayout();
            this.panelCourt2.SuspendLayout();
            this.panelMatchPreview.SuspendLayout();
            this.panelCourt3.SuspendLayout();
            this.panelCourt4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelCourt1
            // 
            this.panelCourt1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelCourt1.Controls.Add(this.labelCourt1MatchTime);
            this.panelCourt1.Controls.Add(this.buttonFinishCourt1);
            this.panelCourt1.Controls.Add(this.listBoxCourt1Team2);
            this.panelCourt1.Controls.Add(this.labelCourt1);
            this.panelCourt1.Controls.Add(this.listBoxCourt1Team1);
            this.panelCourt1.Controls.Add(this.labelVsCourt1);
            this.panelCourt1.Enabled = false;
            this.panelCourt1.Location = new System.Drawing.Point(637, 1);
            this.panelCourt1.Name = "panelCourt1";
            this.panelCourt1.Size = new System.Drawing.Size(296, 119);
            this.panelCourt1.TabIndex = 21;
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
            // buttonFinishCourt1
            // 
            this.buttonFinishCourt1.Location = new System.Drawing.Point(164, 78);
            this.buttonFinishCourt1.Name = "buttonFinishCourt1";
            this.buttonFinishCourt1.Size = new System.Drawing.Size(118, 31);
            this.buttonFinishCourt1.TabIndex = 9;
            this.buttonFinishCourt1.Text = "Finish";
            this.buttonFinishCourt1.UseVisualStyleBackColor = true;
            this.buttonFinishCourt1.Click += new System.EventHandler(this.buttonFinishCourt1_Click);
            // 
            // listBoxCourt1Team2
            // 
            this.listBoxCourt1Team2.FormattingEnabled = true;
            this.listBoxCourt1Team2.ItemHeight = 15;
            this.listBoxCourt1Team2.Location = new System.Drawing.Point(164, 38);
            this.listBoxCourt1Team2.Name = "listBoxCourt1Team2";
            this.listBoxCourt1Team2.Size = new System.Drawing.Size(116, 34);
            this.listBoxCourt1Team2.TabIndex = 5;
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
            // listBoxCourt1Team1
            // 
            this.listBoxCourt1Team1.FormattingEnabled = true;
            this.listBoxCourt1Team1.ItemHeight = 15;
            this.listBoxCourt1Team1.Location = new System.Drawing.Point(18, 38);
            this.listBoxCourt1Team1.Name = "listBoxCourt1Team1";
            this.listBoxCourt1Team1.Size = new System.Drawing.Size(116, 34);
            this.listBoxCourt1Team1.TabIndex = 4;
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
            // labelRestingPlayers
            // 
            this.labelRestingPlayers.AutoSize = true;
            this.labelRestingPlayers.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelRestingPlayers.Location = new System.Drawing.Point(12, 379);
            this.labelRestingPlayers.Name = "labelRestingPlayers";
            this.labelRestingPlayers.Size = new System.Drawing.Size(120, 21);
            this.labelRestingPlayers.TabIndex = 27;
            this.labelRestingPlayers.Text = "Resting Players";
            // 
            // panelCourt2
            // 
            this.panelCourt2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelCourt2.Controls.Add(this.labelCourt2MatchTime);
            this.panelCourt2.Controls.Add(this.buttonFinishCourt2);
            this.panelCourt2.Controls.Add(this.listBoxCourt2Team2);
            this.panelCourt2.Controls.Add(this.labelCourt2);
            this.panelCourt2.Controls.Add(this.listBoxCourt2Team1);
            this.panelCourt2.Controls.Add(this.labelVsCourt2);
            this.panelCourt2.Enabled = false;
            this.panelCourt2.Location = new System.Drawing.Point(637, 126);
            this.panelCourt2.Name = "panelCourt2";
            this.panelCourt2.Size = new System.Drawing.Size(296, 119);
            this.panelCourt2.TabIndex = 22;
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
            // listBoxCourt2Team2
            // 
            this.listBoxCourt2Team2.FormattingEnabled = true;
            this.listBoxCourt2Team2.ItemHeight = 15;
            this.listBoxCourt2Team2.Location = new System.Drawing.Point(164, 38);
            this.listBoxCourt2Team2.Name = "listBoxCourt2Team2";
            this.listBoxCourt2Team2.Size = new System.Drawing.Size(116, 34);
            this.listBoxCourt2Team2.TabIndex = 5;
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
            // listBoxCourt2Team1
            // 
            this.listBoxCourt2Team1.FormattingEnabled = true;
            this.listBoxCourt2Team1.ItemHeight = 15;
            this.listBoxCourt2Team1.Location = new System.Drawing.Point(18, 38);
            this.listBoxCourt2Team1.Name = "listBoxCourt2Team1";
            this.listBoxCourt2Team1.Size = new System.Drawing.Size(116, 34);
            this.listBoxCourt2Team1.TabIndex = 4;
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
            // labelWaitingPlayers
            // 
            this.labelWaitingPlayers.AutoSize = true;
            this.labelWaitingPlayers.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelWaitingPlayers.Location = new System.Drawing.Point(12, 44);
            this.labelWaitingPlayers.Name = "labelWaitingPlayers";
            this.labelWaitingPlayers.Size = new System.Drawing.Size(120, 21);
            this.labelWaitingPlayers.TabIndex = 26;
            this.labelWaitingPlayers.Text = "Waiting Players";
            // 
            // buttonRestPlayer
            // 
            this.buttonRestPlayer.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonRestPlayer.Location = new System.Drawing.Point(12, 342);
            this.buttonRestPlayer.Margin = new System.Windows.Forms.Padding(0);
            this.buttonRestPlayer.Name = "buttonRestPlayer";
            this.buttonRestPlayer.Size = new System.Drawing.Size(99, 31);
            this.buttonRestPlayer.TabIndex = 25;
            this.buttonRestPlayer.Text = "Rest Player";
            this.buttonRestPlayer.UseVisualStyleBackColor = true;
            this.buttonRestPlayer.Click += new System.EventHandler(this.buttonRestPlayer_Click);
            // 
            // listBoxWaitingPlayers
            // 
            this.listBoxWaitingPlayers.FormattingEnabled = true;
            this.listBoxWaitingPlayers.ItemHeight = 15;
            this.listBoxWaitingPlayers.Location = new System.Drawing.Point(12, 68);
            this.listBoxWaitingPlayers.Name = "listBoxWaitingPlayers";
            this.listBoxWaitingPlayers.Size = new System.Drawing.Size(204, 259);
            this.listBoxWaitingPlayers.TabIndex = 17;
            // 
            // buttonEndRest
            // 
            this.buttonEndRest.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonEndRest.Location = new System.Drawing.Point(117, 342);
            this.buttonEndRest.Margin = new System.Windows.Forms.Padding(0);
            this.buttonEndRest.Name = "buttonEndRest";
            this.buttonEndRest.Size = new System.Drawing.Size(99, 31);
            this.buttonEndRest.TabIndex = 24;
            this.buttonEndRest.Text = "End Rest";
            this.buttonEndRest.UseVisualStyleBackColor = true;
            this.buttonEndRest.Click += new System.EventHandler(this.buttonEndRest_Click);
            // 
            // buttonAddPlayerToSession
            // 
            this.buttonAddPlayerToSession.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonAddPlayerToSession.Location = new System.Drawing.Point(12, 9);
            this.buttonAddPlayerToSession.Margin = new System.Windows.Forms.Padding(0);
            this.buttonAddPlayerToSession.Name = "buttonAddPlayerToSession";
            this.buttonAddPlayerToSession.Size = new System.Drawing.Size(99, 31);
            this.buttonAddPlayerToSession.TabIndex = 18;
            this.buttonAddPlayerToSession.Text = "Add Player";
            this.buttonAddPlayerToSession.UseVisualStyleBackColor = true;
            this.buttonAddPlayerToSession.Click += new System.EventHandler(this.buttonAddPlayerToSession_Click);
            // 
            // listBoxRestingPlayers
            // 
            this.listBoxRestingPlayers.FormattingEnabled = true;
            this.listBoxRestingPlayers.ItemHeight = 15;
            this.listBoxRestingPlayers.Location = new System.Drawing.Point(12, 403);
            this.listBoxRestingPlayers.Name = "listBoxRestingPlayers";
            this.listBoxRestingPlayers.Size = new System.Drawing.Size(204, 94);
            this.listBoxRestingPlayers.TabIndex = 23;
            // 
            // buttonRemovePlayerFromSession
            // 
            this.buttonRemovePlayerFromSession.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonRemovePlayerFromSession.Location = new System.Drawing.Point(117, 9);
            this.buttonRemovePlayerFromSession.Margin = new System.Windows.Forms.Padding(0);
            this.buttonRemovePlayerFromSession.Name = "buttonRemovePlayerFromSession";
            this.buttonRemovePlayerFromSession.Size = new System.Drawing.Size(99, 31);
            this.buttonRemovePlayerFromSession.TabIndex = 19;
            this.buttonRemovePlayerFromSession.Text = "Remove Player";
            this.buttonRemovePlayerFromSession.UseVisualStyleBackColor = true;
            this.buttonRemovePlayerFromSession.Click += new System.EventHandler(this.buttonRemovePlayerFromSession_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // buttonEndSession
            // 
            this.buttonEndSession.BackColor = System.Drawing.Color.Red;
            this.buttonEndSession.Enabled = false;
            this.buttonEndSession.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonEndSession.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonEndSession.Location = new System.Drawing.Point(360, 9);
            this.buttonEndSession.Name = "buttonEndSession";
            this.buttonEndSession.Size = new System.Drawing.Size(129, 31);
            this.buttonEndSession.TabIndex = 28;
            this.buttonEndSession.Text = "End Session";
            this.buttonEndSession.UseVisualStyleBackColor = false;
            this.buttonEndSession.Click += new System.EventHandler(this.buttonEndSession_Click);
            // 
            // buttonFindMens
            // 
            this.buttonFindMens.Enabled = false;
            this.buttonFindMens.Location = new System.Drawing.Point(294, 146);
            this.buttonFindMens.Name = "buttonFindMens";
            this.buttonFindMens.Size = new System.Drawing.Size(135, 31);
            this.buttonFindMens.TabIndex = 29;
            this.buttonFindMens.Text = "Find Mens";
            this.buttonFindMens.UseVisualStyleBackColor = true;
            this.buttonFindMens.Click += new System.EventHandler(this.buttonFindMens_Click);
            // 
            // panelMatchPreview
            // 
            this.panelMatchPreview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelMatchPreview.Controls.Add(this.buttonMatchPreviewTeam2RemovePlayer);
            this.panelMatchPreview.Controls.Add(this.labelMatchPreviewTeam2);
            this.panelMatchPreview.Controls.Add(this.labelMatchPreviewTeam1);
            this.panelMatchPreview.Controls.Add(this.buttonMatchPreviewTeam1RemovePlayer);
            this.panelMatchPreview.Controls.Add(this.buttonStartGame);
            this.panelMatchPreview.Controls.Add(this.listBoxMatchPreviewTeam2);
            this.panelMatchPreview.Controls.Add(this.labelMatchPreview);
            this.panelMatchPreview.Controls.Add(this.listBoxMatchPreviewTeam1);
            this.panelMatchPreview.Controls.Add(this.labelMatchPreviewVs);
            this.panelMatchPreview.Enabled = false;
            this.panelMatchPreview.Location = new System.Drawing.Point(294, 183);
            this.panelMatchPreview.Name = "panelMatchPreview";
            this.panelMatchPreview.Size = new System.Drawing.Size(296, 169);
            this.panelMatchPreview.TabIndex = 23;
            // 
            // buttonMatchPreviewTeam2RemovePlayer
            // 
            this.buttonMatchPreviewTeam2RemovePlayer.Enabled = false;
            this.buttonMatchPreviewTeam2RemovePlayer.Location = new System.Drawing.Point(164, 90);
            this.buttonMatchPreviewTeam2RemovePlayer.Name = "buttonMatchPreviewTeam2RemovePlayer";
            this.buttonMatchPreviewTeam2RemovePlayer.Size = new System.Drawing.Size(116, 31);
            this.buttonMatchPreviewTeam2RemovePlayer.TabIndex = 13;
            this.buttonMatchPreviewTeam2RemovePlayer.Text = "Remove Player";
            this.buttonMatchPreviewTeam2RemovePlayer.UseVisualStyleBackColor = true;
            this.buttonMatchPreviewTeam2RemovePlayer.Click += new System.EventHandler(this.buttonMatchPreviewTeam2RemovePlayer_Click);
            // 
            // labelMatchPreviewTeam2
            // 
            this.labelMatchPreviewTeam2.AutoSize = true;
            this.labelMatchPreviewTeam2.Location = new System.Drawing.Point(201, 32);
            this.labelMatchPreviewTeam2.Name = "labelMatchPreviewTeam2";
            this.labelMatchPreviewTeam2.Size = new System.Drawing.Size(44, 15);
            this.labelMatchPreviewTeam2.TabIndex = 12;
            this.labelMatchPreviewTeam2.Text = "Team 2";
            // 
            // labelMatchPreviewTeam1
            // 
            this.labelMatchPreviewTeam1.AutoSize = true;
            this.labelMatchPreviewTeam1.Location = new System.Drawing.Point(54, 32);
            this.labelMatchPreviewTeam1.Name = "labelMatchPreviewTeam1";
            this.labelMatchPreviewTeam1.Size = new System.Drawing.Size(44, 15);
            this.labelMatchPreviewTeam1.TabIndex = 11;
            this.labelMatchPreviewTeam1.Text = "Team 1";
            // 
            // buttonMatchPreviewTeam1RemovePlayer
            // 
            this.buttonMatchPreviewTeam1RemovePlayer.Enabled = false;
            this.buttonMatchPreviewTeam1RemovePlayer.Location = new System.Drawing.Point(18, 90);
            this.buttonMatchPreviewTeam1RemovePlayer.Name = "buttonMatchPreviewTeam1RemovePlayer";
            this.buttonMatchPreviewTeam1RemovePlayer.Size = new System.Drawing.Size(116, 31);
            this.buttonMatchPreviewTeam1RemovePlayer.TabIndex = 10;
            this.buttonMatchPreviewTeam1RemovePlayer.Text = "Remove Player";
            this.buttonMatchPreviewTeam1RemovePlayer.UseVisualStyleBackColor = true;
            this.buttonMatchPreviewTeam1RemovePlayer.Click += new System.EventHandler(this.buttonMatchPreviewTeam1RemovePlayer_Click);
            // 
            // buttonStartGame
            // 
            this.buttonStartGame.Enabled = false;
            this.buttonStartGame.Location = new System.Drawing.Point(89, 127);
            this.buttonStartGame.Name = "buttonStartGame";
            this.buttonStartGame.Size = new System.Drawing.Size(118, 31);
            this.buttonStartGame.TabIndex = 9;
            this.buttonStartGame.Text = "Start";
            this.buttonStartGame.UseVisualStyleBackColor = true;
            this.buttonStartGame.Click += new System.EventHandler(this.buttonStartGame_Click);
            // 
            // listBoxMatchPreviewTeam2
            // 
            this.listBoxMatchPreviewTeam2.FormattingEnabled = true;
            this.listBoxMatchPreviewTeam2.ItemHeight = 15;
            this.listBoxMatchPreviewTeam2.Location = new System.Drawing.Point(164, 50);
            this.listBoxMatchPreviewTeam2.Name = "listBoxMatchPreviewTeam2";
            this.listBoxMatchPreviewTeam2.Size = new System.Drawing.Size(116, 34);
            this.listBoxMatchPreviewTeam2.TabIndex = 5;
            // 
            // labelMatchPreview
            // 
            this.labelMatchPreview.AutoSize = true;
            this.labelMatchPreview.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelMatchPreview.Location = new System.Drawing.Point(105, 10);
            this.labelMatchPreview.Name = "labelMatchPreview";
            this.labelMatchPreview.Size = new System.Drawing.Size(91, 15);
            this.labelMatchPreview.TabIndex = 7;
            this.labelMatchPreview.Text = "Match Preview";
            // 
            // listBoxMatchPreviewTeam1
            // 
            this.listBoxMatchPreviewTeam1.FormattingEnabled = true;
            this.listBoxMatchPreviewTeam1.ItemHeight = 15;
            this.listBoxMatchPreviewTeam1.Location = new System.Drawing.Point(18, 50);
            this.listBoxMatchPreviewTeam1.Name = "listBoxMatchPreviewTeam1";
            this.listBoxMatchPreviewTeam1.Size = new System.Drawing.Size(116, 34);
            this.listBoxMatchPreviewTeam1.TabIndex = 4;
            // 
            // labelMatchPreviewVs
            // 
            this.labelMatchPreviewVs.AutoSize = true;
            this.labelMatchPreviewVs.Location = new System.Drawing.Point(140, 59);
            this.labelMatchPreviewVs.Name = "labelMatchPreviewVs";
            this.labelMatchPreviewVs.Size = new System.Drawing.Size(18, 15);
            this.labelMatchPreviewVs.TabIndex = 6;
            this.labelMatchPreviewVs.Text = "vs";
            // 
            // buttonFindWomens
            // 
            this.buttonFindWomens.Enabled = false;
            this.buttonFindWomens.Location = new System.Drawing.Point(461, 146);
            this.buttonFindWomens.Name = "buttonFindWomens";
            this.buttonFindWomens.Size = new System.Drawing.Size(129, 31);
            this.buttonFindWomens.TabIndex = 30;
            this.buttonFindWomens.Text = "Find Womens";
            this.buttonFindWomens.UseVisualStyleBackColor = true;
            this.buttonFindWomens.Click += new System.EventHandler(this.buttonFindWomens_Click);
            // 
            // buttonFindMixed
            // 
            this.buttonFindMixed.Enabled = false;
            this.buttonFindMixed.Location = new System.Drawing.Point(294, 358);
            this.buttonFindMixed.Name = "buttonFindMixed";
            this.buttonFindMixed.Size = new System.Drawing.Size(135, 31);
            this.buttonFindMixed.TabIndex = 31;
            this.buttonFindMixed.Text = "Find Mixed";
            this.buttonFindMixed.UseVisualStyleBackColor = true;
            this.buttonFindMixed.Click += new System.EventHandler(this.buttonFindMixed_Click);
            // 
            // buttonFindGenderless
            // 
            this.buttonFindGenderless.Enabled = false;
            this.buttonFindGenderless.Location = new System.Drawing.Point(461, 358);
            this.buttonFindGenderless.Name = "buttonFindGenderless";
            this.buttonFindGenderless.Size = new System.Drawing.Size(129, 31);
            this.buttonFindGenderless.TabIndex = 32;
            this.buttonFindGenderless.Text = "Find Genderless";
            this.buttonFindGenderless.UseVisualStyleBackColor = true;
            this.buttonFindGenderless.Click += new System.EventHandler(this.buttonFindGenderless_Click);
            // 
            // buttonAddToTeam1
            // 
            this.buttonAddToTeam1.Enabled = false;
            this.buttonAddToTeam1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonAddToTeam1.Location = new System.Drawing.Point(219, 68);
            this.buttonAddToTeam1.Margin = new System.Windows.Forms.Padding(0);
            this.buttonAddToTeam1.Name = "buttonAddToTeam1";
            this.buttonAddToTeam1.Size = new System.Drawing.Size(118, 30);
            this.buttonAddToTeam1.TabIndex = 33;
            this.buttonAddToTeam1.Text = "Add To Team 1";
            this.buttonAddToTeam1.UseVisualStyleBackColor = true;
            this.buttonAddToTeam1.Click += new System.EventHandler(this.buttonAddToTeam1_Click);
            // 
            // buttonAddToTeam2
            // 
            this.buttonAddToTeam2.Enabled = false;
            this.buttonAddToTeam2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonAddToTeam2.Location = new System.Drawing.Point(219, 98);
            this.buttonAddToTeam2.Margin = new System.Windows.Forms.Padding(0);
            this.buttonAddToTeam2.Name = "buttonAddToTeam2";
            this.buttonAddToTeam2.Size = new System.Drawing.Size(118, 30);
            this.buttonAddToTeam2.TabIndex = 34;
            this.buttonAddToTeam2.Text = "Add To Team 2";
            this.buttonAddToTeam2.UseVisualStyleBackColor = true;
            this.buttonAddToTeam2.Click += new System.EventHandler(this.buttonAddToTeam2_Click);
            // 
            // panelCourt3
            // 
            this.panelCourt3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelCourt3.Controls.Add(this.labelCourt3MatchTime);
            this.panelCourt3.Controls.Add(this.buttonFinishCourt3);
            this.panelCourt3.Controls.Add(this.listBoxCourt3Team2);
            this.panelCourt3.Controls.Add(this.labelCourt3);
            this.panelCourt3.Controls.Add(this.listBoxCourt3Team1);
            this.panelCourt3.Controls.Add(this.labelCourt3Vs);
            this.panelCourt3.Enabled = false;
            this.panelCourt3.Location = new System.Drawing.Point(637, 251);
            this.panelCourt3.Name = "panelCourt3";
            this.panelCourt3.Size = new System.Drawing.Size(296, 119);
            this.panelCourt3.TabIndex = 23;
            // 
            // labelCourt3MatchTime
            // 
            this.labelCourt3MatchTime.AutoSize = true;
            this.labelCourt3MatchTime.Location = new System.Drawing.Point(18, 86);
            this.labelCourt3MatchTime.Name = "labelCourt3MatchTime";
            this.labelCourt3MatchTime.Size = new System.Drawing.Size(71, 15);
            this.labelCourt3MatchTime.TabIndex = 11;
            this.labelCourt3MatchTime.Text = "Match time:";
            // 
            // buttonFinishCourt3
            // 
            this.buttonFinishCourt3.Location = new System.Drawing.Point(164, 78);
            this.buttonFinishCourt3.Name = "buttonFinishCourt3";
            this.buttonFinishCourt3.Size = new System.Drawing.Size(118, 31);
            this.buttonFinishCourt3.TabIndex = 9;
            this.buttonFinishCourt3.Text = "Finish";
            this.buttonFinishCourt3.UseVisualStyleBackColor = true;
            this.buttonFinishCourt3.Click += new System.EventHandler(this.buttonFinishCourt3_Click);
            // 
            // listBoxCourt3Team2
            // 
            this.listBoxCourt3Team2.FormattingEnabled = true;
            this.listBoxCourt3Team2.ItemHeight = 15;
            this.listBoxCourt3Team2.Location = new System.Drawing.Point(164, 38);
            this.listBoxCourt3Team2.Name = "listBoxCourt3Team2";
            this.listBoxCourt3Team2.Size = new System.Drawing.Size(116, 34);
            this.listBoxCourt3Team2.TabIndex = 5;
            // 
            // labelCourt3
            // 
            this.labelCourt3.AutoSize = true;
            this.labelCourt3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelCourt3.Location = new System.Drawing.Point(125, 7);
            this.labelCourt3.Name = "labelCourt3";
            this.labelCourt3.Size = new System.Drawing.Size(48, 15);
            this.labelCourt3.TabIndex = 7;
            this.labelCourt3.Text = "Court 3";
            // 
            // listBoxCourt3Team1
            // 
            this.listBoxCourt3Team1.FormattingEnabled = true;
            this.listBoxCourt3Team1.ItemHeight = 15;
            this.listBoxCourt3Team1.Location = new System.Drawing.Point(18, 38);
            this.listBoxCourt3Team1.Name = "listBoxCourt3Team1";
            this.listBoxCourt3Team1.Size = new System.Drawing.Size(116, 34);
            this.listBoxCourt3Team1.TabIndex = 4;
            // 
            // labelCourt3Vs
            // 
            this.labelCourt3Vs.AutoSize = true;
            this.labelCourt3Vs.Location = new System.Drawing.Point(140, 47);
            this.labelCourt3Vs.Name = "labelCourt3Vs";
            this.labelCourt3Vs.Size = new System.Drawing.Size(18, 15);
            this.labelCourt3Vs.TabIndex = 6;
            this.labelCourt3Vs.Text = "vs";
            // 
            // panelCourt4
            // 
            this.panelCourt4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelCourt4.Controls.Add(this.labelCourt4MatchTime);
            this.panelCourt4.Controls.Add(this.buttonFinishCourt4);
            this.panelCourt4.Controls.Add(this.listBoxCourt4Team2);
            this.panelCourt4.Controls.Add(this.labelCourt4);
            this.panelCourt4.Controls.Add(this.listBoxCourt4Team1);
            this.panelCourt4.Controls.Add(this.labelCourt4Vs);
            this.panelCourt4.Enabled = false;
            this.panelCourt4.Location = new System.Drawing.Point(637, 376);
            this.panelCourt4.Name = "panelCourt4";
            this.panelCourt4.Size = new System.Drawing.Size(296, 119);
            this.panelCourt4.TabIndex = 24;
            // 
            // labelCourt4MatchTime
            // 
            this.labelCourt4MatchTime.AutoSize = true;
            this.labelCourt4MatchTime.Location = new System.Drawing.Point(18, 86);
            this.labelCourt4MatchTime.Name = "labelCourt4MatchTime";
            this.labelCourt4MatchTime.Size = new System.Drawing.Size(71, 15);
            this.labelCourt4MatchTime.TabIndex = 11;
            this.labelCourt4MatchTime.Text = "Match time:";
            // 
            // buttonFinishCourt4
            // 
            this.buttonFinishCourt4.Location = new System.Drawing.Point(164, 78);
            this.buttonFinishCourt4.Name = "buttonFinishCourt4";
            this.buttonFinishCourt4.Size = new System.Drawing.Size(118, 31);
            this.buttonFinishCourt4.TabIndex = 9;
            this.buttonFinishCourt4.Text = "Finish";
            this.buttonFinishCourt4.UseVisualStyleBackColor = true;
            this.buttonFinishCourt4.Click += new System.EventHandler(this.buttonFinishCourt4_Click);
            // 
            // listBoxCourt4Team2
            // 
            this.listBoxCourt4Team2.FormattingEnabled = true;
            this.listBoxCourt4Team2.ItemHeight = 15;
            this.listBoxCourt4Team2.Location = new System.Drawing.Point(164, 38);
            this.listBoxCourt4Team2.Name = "listBoxCourt4Team2";
            this.listBoxCourt4Team2.Size = new System.Drawing.Size(116, 34);
            this.listBoxCourt4Team2.TabIndex = 5;
            // 
            // labelCourt4
            // 
            this.labelCourt4.AutoSize = true;
            this.labelCourt4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelCourt4.Location = new System.Drawing.Point(125, 7);
            this.labelCourt4.Name = "labelCourt4";
            this.labelCourt4.Size = new System.Drawing.Size(48, 15);
            this.labelCourt4.TabIndex = 7;
            this.labelCourt4.Text = "Court 4";
            // 
            // listBoxCourt4Team1
            // 
            this.listBoxCourt4Team1.FormattingEnabled = true;
            this.listBoxCourt4Team1.ItemHeight = 15;
            this.listBoxCourt4Team1.Location = new System.Drawing.Point(18, 38);
            this.listBoxCourt4Team1.Name = "listBoxCourt4Team1";
            this.listBoxCourt4Team1.Size = new System.Drawing.Size(116, 34);
            this.listBoxCourt4Team1.TabIndex = 4;
            // 
            // labelCourt4Vs
            // 
            this.labelCourt4Vs.AutoSize = true;
            this.labelCourt4Vs.Location = new System.Drawing.Point(140, 47);
            this.labelCourt4Vs.Name = "labelCourt4Vs";
            this.labelCourt4Vs.Size = new System.Drawing.Size(18, 15);
            this.labelCourt4Vs.TabIndex = 6;
            this.labelCourt4Vs.Text = "vs";
            // 
            // buttonStartSession
            // 
            this.buttonStartSession.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(255)))), ((int)(((byte)(165)))));
            this.buttonStartSession.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonStartSession.Location = new System.Drawing.Point(219, 9);
            this.buttonStartSession.Name = "buttonStartSession";
            this.buttonStartSession.Size = new System.Drawing.Size(135, 31);
            this.buttonStartSession.TabIndex = 37;
            this.buttonStartSession.Text = "Start Session";
            this.buttonStartSession.UseVisualStyleBackColor = false;
            this.buttonStartSession.Click += new System.EventHandler(this.buttonStartSession_Click);
            // 
            // comboBoxCourtsAvailable
            // 
            this.comboBoxCourtsAvailable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCourtsAvailable.FormattingEnabled = true;
            this.comboBoxCourtsAvailable.Items.AddRange(new object[] {
            "1 Court Available",
            "2 Courts Available",
            "3 Courts Available",
            "4 Courts Available"});
            this.comboBoxCourtsAvailable.Location = new System.Drawing.Point(510, 9);
            this.comboBoxCourtsAvailable.Name = "comboBoxCourtsAvailable";
            this.comboBoxCourtsAvailable.Size = new System.Drawing.Size(121, 23);
            this.comboBoxCourtsAvailable.TabIndex = 38;
            this.comboBoxCourtsAvailable.SelectedIndexChanged += new System.EventHandler(this.comboBoxCourtsAvailable_SelectedIndexChanged);
            // 
            // labelMatchMessage
            // 
            this.labelMatchMessage.AutoSize = true;
            this.labelMatchMessage.Location = new System.Drawing.Point(222, 403);
            this.labelMatchMessage.Name = "labelMatchMessage";
            this.labelMatchMessage.Size = new System.Drawing.Size(0, 15);
            this.labelMatchMessage.TabIndex = 39;
            // 
            // SessionControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.labelMatchMessage);
            this.Controls.Add(this.comboBoxCourtsAvailable);
            this.Controls.Add(this.buttonStartSession);
            this.Controls.Add(this.panelCourt4);
            this.Controls.Add(this.panelCourt3);
            this.Controls.Add(this.buttonAddToTeam2);
            this.Controls.Add(this.buttonAddToTeam1);
            this.Controls.Add(this.buttonFindGenderless);
            this.Controls.Add(this.buttonFindMixed);
            this.Controls.Add(this.buttonFindWomens);
            this.Controls.Add(this.panelMatchPreview);
            this.Controls.Add(this.buttonFindMens);
            this.Controls.Add(this.buttonEndSession);
            this.Controls.Add(this.panelCourt1);
            this.Controls.Add(this.labelRestingPlayers);
            this.Controls.Add(this.panelCourt2);
            this.Controls.Add(this.labelWaitingPlayers);
            this.Controls.Add(this.buttonRestPlayer);
            this.Controls.Add(this.listBoxWaitingPlayers);
            this.Controls.Add(this.buttonEndRest);
            this.Controls.Add(this.buttonAddPlayerToSession);
            this.Controls.Add(this.listBoxRestingPlayers);
            this.Controls.Add(this.buttonRemovePlayerFromSession);
            this.Name = "SessionControl";
            this.Size = new System.Drawing.Size(941, 501);
            this.panelCourt1.ResumeLayout(false);
            this.panelCourt1.PerformLayout();
            this.panelCourt2.ResumeLayout(false);
            this.panelCourt2.PerformLayout();
            this.panelMatchPreview.ResumeLayout(false);
            this.panelMatchPreview.PerformLayout();
            this.panelCourt3.ResumeLayout(false);
            this.panelCourt3.PerformLayout();
            this.panelCourt4.ResumeLayout(false);
            this.panelCourt4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panelCourt1;
        private Label labelCourt1MatchTime;
        private Button buttonFinishCourt1;
        private ListBox listBoxCourt1Team2;
        private Label labelCourt1;
        private ListBox listBoxCourt1Team1;
        private Label labelVsCourt1;
        private Label labelRestingPlayers;
        private Panel panelCourt2;
        private Label labelCourt2MatchTime;
        private Button buttonFinishCourt2;
        private ListBox listBoxCourt2Team2;
        private Label labelCourt2;
        private ListBox listBoxCourt2Team1;
        private Label labelVsCourt2;
        private Label labelWaitingPlayers;
        private Button buttonRestPlayer;
        private ListBox listBoxWaitingPlayers;
        private Button buttonEndRest;
        private Button buttonAddPlayerToSession;
        private ListBox listBoxRestingPlayers;
        private Button buttonRemovePlayerFromSession;
        private System.Windows.Forms.Timer timer1;
        private Button buttonEndSession;
        private Button buttonFindMens;
        private Panel panelMatchPreview;
        private Label labelMatchPreviewTeam2;
        private Label labelMatchPreviewTeam1;
        private Button buttonMatchPreviewTeam1RemovePlayer;
        private Button buttonStartGame;
        private ListBox listBoxMatchPreviewTeam2;
        private Label labelMatchPreview;
        private ListBox listBoxMatchPreviewTeam1;
        private Label labelMatchPreviewVs;
        private Button buttonFindWomens;
        private Button buttonFindMixed;
        private Button buttonFindGenderless;
        private Button buttonAddToTeam1;
        private Button buttonAddToTeam2;
        private Panel panelCourt3;
        private Label labelCourt3MatchTime;
        private Button buttonFinishCourt3;
        private ListBox listBoxCourt3Team2;
        private Label labelCourt3;
        private ListBox listBoxCourt3Team1;
        private Label labelCourt3Vs;
        private Button buttonMatchPreviewTeam2RemovePlayer;
        private Panel panelCourt4;
        private Label labelCourt4MatchTime;
        private Button buttonFinishCourt4;
        private ListBox listBoxCourt4Team2;
        private Label labelCourt4;
        private ListBox listBoxCourt4Team1;
        private Label labelCourt4Vs;
        private Button buttonStartSession;
        private ComboBox comboBoxCourtsAvailable;
        private Label labelMatchMessage;
    }
}
