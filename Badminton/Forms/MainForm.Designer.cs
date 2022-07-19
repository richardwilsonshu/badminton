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
            this.Tabs = new System.Windows.Forms.TabControl();
            this.tabPageAdmin = new System.Windows.Forms.TabPage();
            this.adminTabControl1 = new Badminton.Controls.AdminTabControl();
            this.tabPageActiveSession = new System.Windows.Forms.TabPage();
            this.createSessionTabControl1 = new Badminton.Controls.CreateSessionTabControl();
            this.tabPageNoSession = new System.Windows.Forms.TabPage();
            this.sessionTabControl1 = new Badminton.Controls.SessionTabControl();
            this.menuStrip1.SuspendLayout();
            this.Tabs.SuspendLayout();
            this.tabPageAdmin.SuspendLayout();
            this.tabPageActiveSession.SuspendLayout();
            this.tabPageNoSession.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(977, 24);
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
            // Tabs
            // 
            this.Tabs.Controls.Add(this.tabPageAdmin);
            this.Tabs.Controls.Add(this.tabPageActiveSession);
            this.Tabs.Controls.Add(this.tabPageNoSession);
            this.Tabs.Location = new System.Drawing.Point(12, 27);
            this.Tabs.Name = "Tabs";
            this.Tabs.SelectedIndex = 0;
            this.Tabs.Size = new System.Drawing.Size(956, 548);
            this.Tabs.TabIndex = 17;
            // 
            // tabPageAdmin
            // 
            this.tabPageAdmin.Controls.Add(this.adminTabControl1);
            this.tabPageAdmin.Location = new System.Drawing.Point(4, 24);
            this.tabPageAdmin.Name = "tabPageAdmin";
            this.tabPageAdmin.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAdmin.Size = new System.Drawing.Size(993, 533);
            this.tabPageAdmin.TabIndex = 1;
            this.tabPageAdmin.Text = "Admin";
            this.tabPageAdmin.UseVisualStyleBackColor = true;
            // 
            // adminTabControl1
            // 
            this.adminTabControl1.AutoSize = true;
            this.adminTabControl1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.adminTabControl1.Location = new System.Drawing.Point(6, 6);
            this.adminTabControl1.Name = "adminTabControl1";
            this.adminTabControl1.Size = new System.Drawing.Size(210, 301);
            this.adminTabControl1.TabIndex = 0;
            // 
            // tabPageActiveSession
            // 
            this.tabPageActiveSession.Controls.Add(this.createSessionTabControl1);
            this.tabPageActiveSession.Location = new System.Drawing.Point(4, 24);
            this.tabPageActiveSession.Name = "tabPageActiveSession";
            this.tabPageActiveSession.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageActiveSession.Size = new System.Drawing.Size(993, 533);
            this.tabPageActiveSession.TabIndex = 2;
            this.tabPageActiveSession.Text = "Session";
            this.tabPageActiveSession.UseVisualStyleBackColor = true;
            // 
            // createSessionTabControl1
            // 
            this.createSessionTabControl1.AutoSize = true;
            this.createSessionTabControl1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.createSessionTabControl1.Location = new System.Drawing.Point(6, 6);
            this.createSessionTabControl1.Name = "createSessionTabControl1";
            this.createSessionTabControl1.Size = new System.Drawing.Size(208, 70);
            this.createSessionTabControl1.TabIndex = 0;
            // 
            // tabPageNoSession
            // 
            this.tabPageNoSession.Controls.Add(this.sessionTabControl1);
            this.tabPageNoSession.Location = new System.Drawing.Point(4, 24);
            this.tabPageNoSession.Name = "tabPageNoSession";
            this.tabPageNoSession.Size = new System.Drawing.Size(948, 520);
            this.tabPageNoSession.TabIndex = 3;
            this.tabPageNoSession.Text = "Session";
            this.tabPageNoSession.UseVisualStyleBackColor = true;
            // 
            // sessionTabControl1
            // 
            this.sessionTabControl1.AutoSize = true;
            this.sessionTabControl1.Location = new System.Drawing.Point(3, 3);
            this.sessionTabControl1.Name = "sessionTabControl1";
            this.sessionTabControl1.Size = new System.Drawing.Size(936, 512);
            this.sessionTabControl1.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(977, 581);
            this.ControlBox = false;
            this.Controls.Add(this.Tabs);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Badminton";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.Tabs.ResumeLayout(false);
            this.tabPageAdmin.ResumeLayout(false);
            this.tabPageAdmin.PerformLayout();
            this.tabPageActiveSession.ResumeLayout(false);
            this.tabPageActiveSession.PerformLayout();
            this.tabPageNoSession.ResumeLayout(false);
            this.tabPageNoSession.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem loadToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private TabControl Tabs;
        private TabPage tabPageAdmin;
        private TabPage tabPageActiveSession;
        private TabPage tabPageNoSession;
        private Controls.AdminTabControl adminTabControl1;
        private Controls.CreateSessionTabControl createSessionTabControl1;
        private Controls.SessionTabControl sessionTabControl1;
    }
}