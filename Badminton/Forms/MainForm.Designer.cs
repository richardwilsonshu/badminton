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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.Session = new System.Windows.Forms.TabControl();
            this.tabPageAdmin = new System.Windows.Forms.TabPage();
            this.labelPlayers = new System.Windows.Forms.Label();
            this.listBoxPlayers = new System.Windows.Forms.ListBox();
            this.buttonAddPlayer = new System.Windows.Forms.Button();
            this.buttonRemovePlayer = new System.Windows.Forms.Button();
            this.tabPageSession = new System.Windows.Forms.TabPage();
            this.menuStrip1.SuspendLayout();
            this.Session.SuspendLayout();
            this.tabPageAdmin.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(1170, 30);
            this.menuStrip1.TabIndex = 14;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadToolStripMenuItem,
            this.saveToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(125, 26);
            this.loadToolStripMenuItem.Text = "Load";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.loadToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(125, 26);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(14, 24);
            // 
            // Session
            // 
            this.Session.Controls.Add(this.tabPageAdmin);
            this.Session.Controls.Add(this.tabPageSession);
            this.Session.Location = new System.Drawing.Point(14, 36);
            this.Session.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Session.Name = "Session";
            this.Session.SelectedIndex = 0;
            this.Session.Size = new System.Drawing.Size(1144, 748);
            this.Session.TabIndex = 17;
            // 
            // tabPageAdmin
            // 
            this.tabPageAdmin.Controls.Add(this.labelPlayers);
            this.tabPageAdmin.Controls.Add(this.listBoxPlayers);
            this.tabPageAdmin.Controls.Add(this.buttonAddPlayer);
            this.tabPageAdmin.Controls.Add(this.buttonRemovePlayer);
            this.tabPageAdmin.Location = new System.Drawing.Point(4, 29);
            this.tabPageAdmin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPageAdmin.Name = "tabPageAdmin";
            this.tabPageAdmin.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPageAdmin.Size = new System.Drawing.Size(1136, 715);
            this.tabPageAdmin.TabIndex = 1;
            this.tabPageAdmin.Text = "Admin";
            this.tabPageAdmin.UseVisualStyleBackColor = true;
            // 
            // labelPlayers
            // 
            this.labelPlayers.AutoSize = true;
            this.labelPlayers.Location = new System.Drawing.Point(7, 43);
            this.labelPlayers.Name = "labelPlayers";
            this.labelPlayers.Size = new System.Drawing.Size(55, 20);
            this.labelPlayers.TabIndex = 19;
            this.labelPlayers.Text = "Players";
            // 
            // listBoxPlayers
            // 
            this.listBoxPlayers.FormattingEnabled = true;
            this.listBoxPlayers.ItemHeight = 20;
            this.listBoxPlayers.Location = new System.Drawing.Point(7, 67);
            this.listBoxPlayers.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listBoxPlayers.Name = "listBoxPlayers";
            this.listBoxPlayers.Size = new System.Drawing.Size(233, 304);
            this.listBoxPlayers.TabIndex = 16;
            // 
            // buttonAddPlayer
            // 
            this.buttonAddPlayer.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonAddPlayer.Location = new System.Drawing.Point(129, 376);
            this.buttonAddPlayer.Margin = new System.Windows.Forms.Padding(0);
            this.buttonAddPlayer.Name = "buttonAddPlayer";
            this.buttonAddPlayer.Size = new System.Drawing.Size(49, 59);
            this.buttonAddPlayer.TabIndex = 17;
            this.buttonAddPlayer.Text = "+";
            this.buttonAddPlayer.UseVisualStyleBackColor = true;
            this.buttonAddPlayer.Click += new System.EventHandler(this.buttonAddPlayer_Click);
            // 
            // buttonRemovePlayer
            // 
            this.buttonRemovePlayer.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonRemovePlayer.Location = new System.Drawing.Point(67, 376);
            this.buttonRemovePlayer.Margin = new System.Windows.Forms.Padding(0);
            this.buttonRemovePlayer.Name = "buttonRemovePlayer";
            this.buttonRemovePlayer.Size = new System.Drawing.Size(49, 59);
            this.buttonRemovePlayer.TabIndex = 18;
            this.buttonRemovePlayer.Text = "-";
            this.buttonRemovePlayer.UseVisualStyleBackColor = true;
            // 
            // tabPageSession
            // 
            this.tabPageSession.Location = new System.Drawing.Point(4, 29);
            this.tabPageSession.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPageSession.Name = "tabPageSession";
            this.tabPageSession.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPageSession.Size = new System.Drawing.Size(1136, 715);
            this.tabPageSession.TabIndex = 0;
            this.tabPageSession.Text = "Session";
            this.tabPageSession.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1170, 797);
            this.Controls.Add(this.Session);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MainForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Badminton";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.Session.ResumeLayout(false);
            this.tabPageAdmin.ResumeLayout(false);
            this.tabPageAdmin.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem loadToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem1;
        private TabControl Session;
        private TabPage tabPageAdmin;
        private TabPage tabPageSession;
        private Label labelPlayers;
        private ListBox listBoxPlayers;
        private Button buttonAddPlayer;
        private Button buttonRemovePlayer;
    }
}