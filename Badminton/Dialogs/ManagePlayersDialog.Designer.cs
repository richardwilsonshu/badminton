﻿namespace Badminton.Dialogs
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
            this.listBoxPlayers = new System.Windows.Forms.ListBox();
            this.buttonAddNewPlayer = new System.Windows.Forms.Button();
            this.textBoxPlayerName = new System.Windows.Forms.TextBox();
            this.labelNewPlayerName = new System.Windows.Forms.Label();
            this.panelNewPlayer = new System.Windows.Forms.Panel();
            this.comboBoxGender = new System.Windows.Forms.ComboBox();
            this.labelNewPlayerGender = new System.Windows.Forms.Label();
            this.buttonEditPlayer = new System.Windows.Forms.Button();
            this.buttonDeletePlayer = new System.Windows.Forms.Button();
            this.panelNewPlayer.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonAddToSession
            // 
            this.buttonAddToSession.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonAddToSession.Location = new System.Drawing.Point(222, 12);
            this.buttonAddToSession.Name = "buttonAddToSession";
            this.buttonAddToSession.Size = new System.Drawing.Size(115, 86);
            this.buttonAddToSession.TabIndex = 1;
            this.buttonAddToSession.Text = "Add Player To Session";
            this.buttonAddToSession.UseVisualStyleBackColor = true;
            this.buttonAddToSession.Click += new System.EventHandler(this.buttonAddToSession_Click);
            // 
            // listBoxPlayers
            // 
            this.listBoxPlayers.FormattingEnabled = true;
            this.listBoxPlayers.ItemHeight = 15;
            this.listBoxPlayers.Location = new System.Drawing.Point(12, 10);
            this.listBoxPlayers.Name = "listBoxPlayers";
            this.listBoxPlayers.Size = new System.Drawing.Size(204, 274);
            this.listBoxPlayers.TabIndex = 24;
            // 
            // buttonAddNewPlayer
            // 
            this.buttonAddNewPlayer.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonAddNewPlayer.Location = new System.Drawing.Point(9, 56);
            this.buttonAddNewPlayer.Margin = new System.Windows.Forms.Padding(0);
            this.buttonAddNewPlayer.Name = "buttonAddNewPlayer";
            this.buttonAddNewPlayer.Size = new System.Drawing.Size(122, 26);
            this.buttonAddNewPlayer.TabIndex = 25;
            this.buttonAddNewPlayer.Text = "Add New Player";
            this.buttonAddNewPlayer.UseVisualStyleBackColor = true;
            this.buttonAddNewPlayer.Click += new System.EventHandler(this.buttonAddNewPlayer_Click);
            // 
            // textBoxPlayerName
            // 
            this.textBoxPlayerName.Location = new System.Drawing.Point(9, 30);
            this.textBoxPlayerName.Name = "textBoxPlayerName";
            this.textBoxPlayerName.Size = new System.Drawing.Size(194, 23);
            this.textBoxPlayerName.TabIndex = 28;
            this.textBoxPlayerName.TextChanged += new System.EventHandler(this.textBoxPlayerName_TextChanged);
            // 
            // labelNewPlayerName
            // 
            this.labelNewPlayerName.AutoSize = true;
            this.labelNewPlayerName.Location = new System.Drawing.Point(9, 12);
            this.labelNewPlayerName.Name = "labelNewPlayerName";
            this.labelNewPlayerName.Size = new System.Drawing.Size(101, 15);
            this.labelNewPlayerName.TabIndex = 29;
            this.labelNewPlayerName.Text = "New Player Name";
            // 
            // panelNewPlayer
            // 
            this.panelNewPlayer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelNewPlayer.Controls.Add(this.comboBoxGender);
            this.panelNewPlayer.Controls.Add(this.labelNewPlayerGender);
            this.panelNewPlayer.Controls.Add(this.textBoxPlayerName);
            this.panelNewPlayer.Controls.Add(this.labelNewPlayerName);
            this.panelNewPlayer.Controls.Add(this.buttonAddNewPlayer);
            this.panelNewPlayer.Location = new System.Drawing.Point(12, 290);
            this.panelNewPlayer.Name = "panelNewPlayer";
            this.panelNewPlayer.Size = new System.Drawing.Size(325, 92);
            this.panelNewPlayer.TabIndex = 30;
            // 
            // comboBoxGender
            // 
            this.comboBoxGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxGender.FormattingEnabled = true;
            this.comboBoxGender.Location = new System.Drawing.Point(209, 30);
            this.comboBoxGender.Name = "comboBoxGender";
            this.comboBoxGender.Size = new System.Drawing.Size(107, 23);
            this.comboBoxGender.TabIndex = 31;
            // 
            // labelNewPlayerGender
            // 
            this.labelNewPlayerGender.AutoSize = true;
            this.labelNewPlayerGender.Location = new System.Drawing.Point(209, 12);
            this.labelNewPlayerGender.Name = "labelNewPlayerGender";
            this.labelNewPlayerGender.Size = new System.Drawing.Size(107, 15);
            this.labelNewPlayerGender.TabIndex = 30;
            this.labelNewPlayerGender.Text = "New Player Gender";
            // 
            // buttonEditPlayer
            // 
            this.buttonEditPlayer.Location = new System.Drawing.Point(222, 232);
            this.buttonEditPlayer.Name = "buttonEditPlayer";
            this.buttonEditPlayer.Size = new System.Drawing.Size(115, 23);
            this.buttonEditPlayer.TabIndex = 31;
            this.buttonEditPlayer.Text = "Edit";
            this.buttonEditPlayer.UseVisualStyleBackColor = true;
            this.buttonEditPlayer.Click += new System.EventHandler(this.buttonEditPlayer_Click);
            // 
            // buttonDeletePlayer
            // 
            this.buttonDeletePlayer.Location = new System.Drawing.Point(222, 261);
            this.buttonDeletePlayer.Name = "buttonDeletePlayer";
            this.buttonDeletePlayer.Size = new System.Drawing.Size(115, 23);
            this.buttonDeletePlayer.TabIndex = 32;
            this.buttonDeletePlayer.Text = "Delete";
            this.buttonDeletePlayer.UseVisualStyleBackColor = true;
            this.buttonDeletePlayer.Click += new System.EventHandler(this.buttonDeletePlayer_Click);
            // 
            // ManagePlayersDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(349, 393);
            this.Controls.Add(this.buttonDeletePlayer);
            this.Controls.Add(this.buttonEditPlayer);
            this.Controls.Add(this.panelNewPlayer);
            this.Controls.Add(this.listBoxPlayers);
            this.Controls.Add(this.buttonAddToSession);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ManagePlayersDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Players";
            this.panelNewPlayer.ResumeLayout(false);
            this.panelNewPlayer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Button buttonAddToSession;
        private ListBox listBoxPlayers;
        private Button buttonAddNewPlayer;
        private TextBox textBoxPlayerName;
        private Label labelNewPlayerName;
        private Panel panelNewPlayer;
        private ComboBox comboBoxGender;
        private Label labelNewPlayerGender;
        private Button buttonEditPlayer;
        private Button buttonDeletePlayer;
    }
}