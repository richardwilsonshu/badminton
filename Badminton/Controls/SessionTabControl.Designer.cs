namespace Badminton.Controls
{
    partial class SessionTabControl
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
            this.listBoxCourt1Side2 = new System.Windows.Forms.ListBox();
            this.labelCourt1 = new System.Windows.Forms.Label();
            this.listBoxCourt1Side1 = new System.Windows.Forms.ListBox();
            this.labelVsCourt1 = new System.Windows.Forms.Label();
            this.labelRestingPlayers = new System.Windows.Forms.Label();
            this.panelCourt2 = new System.Windows.Forms.Panel();
            this.labelCourt2MatchTime = new System.Windows.Forms.Label();
            this.buttonFinishCourt2 = new System.Windows.Forms.Button();
            this.listBoxCourt2Side2 = new System.Windows.Forms.ListBox();
            this.labelCourt2 = new System.Windows.Forms.Label();
            this.listBoxCourt2Side1 = new System.Windows.Forms.ListBox();
            this.labelVsCourt2 = new System.Windows.Forms.Label();
            this.labelWaitingPlayers = new System.Windows.Forms.Label();
            this.buttonRemoveFromWaitingPlayers = new System.Windows.Forms.Button();
            this.listBoxWaitingPlayers = new System.Windows.Forms.ListBox();
            this.buttonMoveToWaitingPlayers = new System.Windows.Forms.Button();
            this.buttonAddPlayerToSession = new System.Windows.Forms.Button();
            this.listBoxRestingPlayers = new System.Windows.Forms.ListBox();
            this.buttonRemovePlayerFromSession = new System.Windows.Forms.Button();
            this.buttonGenerateGame = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.buttonEndSession = new System.Windows.Forms.Button();
            this.panelCourt1.SuspendLayout();
            this.panelCourt2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelCourt1
            // 
            this.panelCourt1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelCourt1.Controls.Add(this.labelCourt1MatchTime);
            this.panelCourt1.Controls.Add(this.buttonFinishCourt1);
            this.panelCourt1.Controls.Add(this.listBoxCourt1Side2);
            this.panelCourt1.Controls.Add(this.labelCourt1);
            this.panelCourt1.Controls.Add(this.listBoxCourt1Side1);
            this.panelCourt1.Controls.Add(this.labelVsCourt1);
            this.panelCourt1.Enabled = false;
            this.panelCourt1.Location = new System.Drawing.Point(637, 13);
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
            // listBoxCourt1Side2
            // 
            this.listBoxCourt1Side2.FormattingEnabled = true;
            this.listBoxCourt1Side2.ItemHeight = 15;
            this.listBoxCourt1Side2.Location = new System.Drawing.Point(164, 38);
            this.listBoxCourt1Side2.Name = "listBoxCourt1Side2";
            this.listBoxCourt1Side2.Size = new System.Drawing.Size(116, 34);
            this.listBoxCourt1Side2.TabIndex = 5;
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
            // listBoxCourt1Side1
            // 
            this.listBoxCourt1Side1.FormattingEnabled = true;
            this.listBoxCourt1Side1.ItemHeight = 15;
            this.listBoxCourt1Side1.Location = new System.Drawing.Point(18, 38);
            this.listBoxCourt1Side1.Name = "listBoxCourt1Side1";
            this.listBoxCourt1Side1.Size = new System.Drawing.Size(116, 34);
            this.listBoxCourt1Side1.TabIndex = 4;
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
            this.labelRestingPlayers.Location = new System.Drawing.Point(12, 307);
            this.labelRestingPlayers.Name = "labelRestingPlayers";
            this.labelRestingPlayers.Size = new System.Drawing.Size(86, 15);
            this.labelRestingPlayers.TabIndex = 27;
            this.labelRestingPlayers.Text = "Resting Players";
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
            this.panelCourt2.Location = new System.Drawing.Point(637, 138);
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
            // labelWaitingPlayers
            // 
            this.labelWaitingPlayers.AutoSize = true;
            this.labelWaitingPlayers.Location = new System.Drawing.Point(12, 13);
            this.labelWaitingPlayers.Name = "labelWaitingPlayers";
            this.labelWaitingPlayers.Size = new System.Drawing.Size(88, 15);
            this.labelWaitingPlayers.TabIndex = 26;
            this.labelWaitingPlayers.Text = "Waiting Players";
            // 
            // buttonRemoveFromWaitingPlayers
            // 
            this.buttonRemoveFromWaitingPlayers.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonRemoveFromWaitingPlayers.Location = new System.Drawing.Point(12, 263);
            this.buttonRemoveFromWaitingPlayers.Margin = new System.Windows.Forms.Padding(0);
            this.buttonRemoveFromWaitingPlayers.Name = "buttonRemoveFromWaitingPlayers";
            this.buttonRemoveFromWaitingPlayers.Size = new System.Drawing.Size(43, 44);
            this.buttonRemoveFromWaitingPlayers.TabIndex = 25;
            this.buttonRemoveFromWaitingPlayers.Text = "v";
            this.buttonRemoveFromWaitingPlayers.UseVisualStyleBackColor = true;
            this.buttonRemoveFromWaitingPlayers.Click += new System.EventHandler(this.buttonRemoveFromWaitingPlayers_Click);
            // 
            // listBoxWaitingPlayers
            // 
            this.listBoxWaitingPlayers.FormattingEnabled = true;
            this.listBoxWaitingPlayers.ItemHeight = 15;
            this.listBoxWaitingPlayers.Location = new System.Drawing.Point(12, 31);
            this.listBoxWaitingPlayers.Name = "listBoxWaitingPlayers";
            this.listBoxWaitingPlayers.Size = new System.Drawing.Size(204, 229);
            this.listBoxWaitingPlayers.TabIndex = 17;
            this.listBoxWaitingPlayers.DoubleClick += new System.EventHandler(this.listBoxWaitingPlayers_DoubleClick);
            // 
            // buttonMoveToWaitingPlayers
            // 
            this.buttonMoveToWaitingPlayers.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonMoveToWaitingPlayers.Location = new System.Drawing.Point(173, 263);
            this.buttonMoveToWaitingPlayers.Margin = new System.Windows.Forms.Padding(0);
            this.buttonMoveToWaitingPlayers.Name = "buttonMoveToWaitingPlayers";
            this.buttonMoveToWaitingPlayers.Size = new System.Drawing.Size(43, 44);
            this.buttonMoveToWaitingPlayers.TabIndex = 24;
            this.buttonMoveToWaitingPlayers.Text = "^";
            this.buttonMoveToWaitingPlayers.UseVisualStyleBackColor = true;
            this.buttonMoveToWaitingPlayers.Click += new System.EventHandler(this.buttonMoveToWaitingPlayers_Click);
            // 
            // buttonAddPlayerToSession
            // 
            this.buttonAddPlayerToSession.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonAddPlayerToSession.Location = new System.Drawing.Point(222, 52);
            this.buttonAddPlayerToSession.Margin = new System.Windows.Forms.Padding(0);
            this.buttonAddPlayerToSession.Name = "buttonAddPlayerToSession";
            this.buttonAddPlayerToSession.Size = new System.Drawing.Size(43, 44);
            this.buttonAddPlayerToSession.TabIndex = 18;
            this.buttonAddPlayerToSession.Text = "+";
            this.buttonAddPlayerToSession.UseVisualStyleBackColor = true;
            this.buttonAddPlayerToSession.Click += new System.EventHandler(this.buttonAddPlayerToSession_Click);
            // 
            // listBoxRestingPlayers
            // 
            this.listBoxRestingPlayers.FormattingEnabled = true;
            this.listBoxRestingPlayers.ItemHeight = 15;
            this.listBoxRestingPlayers.Location = new System.Drawing.Point(12, 325);
            this.listBoxRestingPlayers.Name = "listBoxRestingPlayers";
            this.listBoxRestingPlayers.Size = new System.Drawing.Size(204, 184);
            this.listBoxRestingPlayers.TabIndex = 23;
            // 
            // buttonRemovePlayerFromSession
            // 
            this.buttonRemovePlayerFromSession.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonRemovePlayerFromSession.Location = new System.Drawing.Point(65, 263);
            this.buttonRemovePlayerFromSession.Margin = new System.Windows.Forms.Padding(0);
            this.buttonRemovePlayerFromSession.Name = "buttonRemovePlayerFromSession";
            this.buttonRemovePlayerFromSession.Size = new System.Drawing.Size(43, 44);
            this.buttonRemovePlayerFromSession.TabIndex = 19;
            this.buttonRemovePlayerFromSession.Text = "-";
            this.buttonRemovePlayerFromSession.UseVisualStyleBackColor = true;
            this.buttonRemovePlayerFromSession.Click += new System.EventHandler(this.buttonRemovePlayerFromSession_Click);
            // 
            // buttonGenerateGame
            // 
            this.buttonGenerateGame.Enabled = false;
            this.buttonGenerateGame.Location = new System.Drawing.Point(222, 16);
            this.buttonGenerateGame.Name = "buttonGenerateGame";
            this.buttonGenerateGame.Size = new System.Drawing.Size(118, 31);
            this.buttonGenerateGame.TabIndex = 20;
            this.buttonGenerateGame.Text = "Generate Game";
            this.buttonGenerateGame.UseVisualStyleBackColor = true;
            this.buttonGenerateGame.Click += new System.EventHandler(this.buttonGenerateGame_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // buttonEndSession
            // 
            this.buttonEndSession.Enabled = false;
            this.buttonEndSession.Location = new System.Drawing.Point(815, 478);
            this.buttonEndSession.Name = "buttonEndSession";
            this.buttonEndSession.Size = new System.Drawing.Size(118, 31);
            this.buttonEndSession.TabIndex = 28;
            this.buttonEndSession.Text = "End Session";
            this.buttonEndSession.UseVisualStyleBackColor = true;
            this.buttonEndSession.Click += new System.EventHandler(this.buttonEndSession_Click);
            // 
            // SessionTabControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.buttonEndSession);
            this.Controls.Add(this.panelCourt1);
            this.Controls.Add(this.labelRestingPlayers);
            this.Controls.Add(this.panelCourt2);
            this.Controls.Add(this.labelWaitingPlayers);
            this.Controls.Add(this.buttonRemoveFromWaitingPlayers);
            this.Controls.Add(this.listBoxWaitingPlayers);
            this.Controls.Add(this.buttonMoveToWaitingPlayers);
            this.Controls.Add(this.buttonAddPlayerToSession);
            this.Controls.Add(this.listBoxRestingPlayers);
            this.Controls.Add(this.buttonRemovePlayerFromSession);
            this.Controls.Add(this.buttonGenerateGame);
            this.Name = "SessionTabControl";
            this.Size = new System.Drawing.Size(941, 520);
            this.panelCourt1.ResumeLayout(false);
            this.panelCourt1.PerformLayout();
            this.panelCourt2.ResumeLayout(false);
            this.panelCourt2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panelCourt1;
        private Label labelCourt1MatchTime;
        private Button buttonFinishCourt1;
        private ListBox listBoxCourt1Side2;
        private Label labelCourt1;
        private ListBox listBoxCourt1Side1;
        private Label labelVsCourt1;
        private Label labelRestingPlayers;
        private Panel panelCourt2;
        private Label labelCourt2MatchTime;
        private Button buttonFinishCourt2;
        private ListBox listBoxCourt2Side2;
        private Label labelCourt2;
        private ListBox listBoxCourt2Side1;
        private Label labelVsCourt2;
        private Label labelWaitingPlayers;
        private Button buttonRemoveFromWaitingPlayers;
        private ListBox listBoxWaitingPlayers;
        private Button buttonMoveToWaitingPlayers;
        private Button buttonAddPlayerToSession;
        private ListBox listBoxRestingPlayers;
        private Button buttonRemovePlayerFromSession;
        private Button buttonGenerateGame;
        private System.Windows.Forms.Timer timer1;
        private Button buttonEndSession;
    }
}
