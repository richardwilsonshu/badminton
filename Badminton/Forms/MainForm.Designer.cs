﻿namespace Badminton.Forms
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
            this.sessionTabControl1 = new Badminton.Controls.SessionTabControl();
            this.SuspendLayout();
            // 
            // sessionTabControl1
            // 
            this.sessionTabControl1.AutoSize = true;
            this.sessionTabControl1.Location = new System.Drawing.Point(2, 2);
            this.sessionTabControl1.Name = "sessionTabControl1";
            this.sessionTabControl1.Size = new System.Drawing.Size(936, 500);
            this.sessionTabControl1.TabIndex = 15;
            this.sessionTabControl1.Load += new System.EventHandler(this.sessionTabControl1_Load);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(942, 507);
            this.Controls.Add(this.sessionTabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Badminton";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Controls.SessionTabControl sessionTabControl1;
    }
}