namespace Badminton.Dialogs
{
    partial class MatchFinderSettingsDialog
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
            this.labelTitle = new System.Windows.Forms.Label();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.trackBarTeammateWeighting = new System.Windows.Forms.TrackBar();
            this.labelTeammateWeightingValue = new System.Windows.Forms.Label();
            this.labelTeammateWeightingName = new System.Windows.Forms.Label();
            this.labelOpponentWeightingName = new System.Windows.Forms.Label();
            this.labelOpponentWeightingValue = new System.Windows.Forms.Label();
            this.trackBarOpponentWeighting = new System.Windows.Forms.TrackBar();
            this.labelLastMatchWeightingName = new System.Windows.Forms.Label();
            this.labelLastMatchWeightingValue = new System.Windows.Forms.Label();
            this.trackBarLastMatchWeighting = new System.Windows.Forms.TrackBar();
            this.labelAverageWaitingWeightingName = new System.Windows.Forms.Label();
            this.labelAverageWaitingWeightingValue = new System.Windows.Forms.Label();
            this.trackBarAverageWaitingWeighting = new System.Windows.Forms.TrackBar();
            this.labelEloName = new System.Windows.Forms.Label();
            this.labelEloValue = new System.Windows.Forms.Label();
            this.trackBarElo = new System.Windows.Forms.TrackBar();
            this.groupBoxWeightings = new System.Windows.Forms.GroupBox();
            this.buttonReset = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarTeammateWeighting)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarOpponentWeighting)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarLastMatchWeighting)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarAverageWaitingWeighting)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarElo)).BeginInit();
            this.groupBoxWeightings.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTitle.Location = new System.Drawing.Point(165, 24);
            this.labelTitle.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(195, 25);
            this.labelTitle.TabIndex = 46;
            this.labelTitle.Text = "Match Finder Settings";
            this.labelTitle.Click += new System.EventHandler(this.label1_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonSave.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonSave.Location = new System.Drawing.Point(415, 319);
            this.buttonSave.Margin = new System.Windows.Forms.Padding(0);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(116, 38);
            this.buttonSave.TabIndex = 45;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonCancel.Location = new System.Drawing.Point(14, 319);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(0);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(116, 38);
            this.buttonCancel.TabIndex = 40;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // trackBarTeammateWeighting
            // 
            this.trackBarTeammateWeighting.LargeChange = 20;
            this.trackBarTeammateWeighting.Location = new System.Drawing.Point(172, 36);
            this.trackBarTeammateWeighting.Maximum = 200;
            this.trackBarTeammateWeighting.Name = "trackBarTeammateWeighting";
            this.trackBarTeammateWeighting.Size = new System.Drawing.Size(271, 45);
            this.trackBarTeammateWeighting.TabIndex = 47;
            this.trackBarTeammateWeighting.TickFrequency = 20;
            this.trackBarTeammateWeighting.Value = 100;
            this.trackBarTeammateWeighting.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // labelTeammateWeightingValue
            // 
            this.labelTeammateWeightingValue.AutoSize = true;
            this.labelTeammateWeightingValue.Location = new System.Drawing.Point(449, 36);
            this.labelTeammateWeightingValue.Name = "labelTeammateWeightingValue";
            this.labelTeammateWeightingValue.Size = new System.Drawing.Size(50, 21);
            this.labelTeammateWeightingValue.TabIndex = 48;
            this.labelTeammateWeightingValue.Text = "100%";
            // 
            // labelTeammateWeightingName
            // 
            this.labelTeammateWeightingName.AutoSize = true;
            this.labelTeammateWeightingName.Location = new System.Drawing.Point(22, 36);
            this.labelTeammateWeightingName.Name = "labelTeammateWeightingName";
            this.labelTeammateWeightingName.Size = new System.Drawing.Size(144, 21);
            this.labelTeammateWeightingName.TabIndex = 49;
            this.labelTeammateWeightingName.Text = "Teammate diversity";
            this.labelTeammateWeightingName.Click += new System.EventHandler(this.labelTeammateWeightingName_Click);
            // 
            // labelOpponentWeightingName
            // 
            this.labelOpponentWeightingName.AutoSize = true;
            this.labelOpponentWeightingName.Location = new System.Drawing.Point(23, 79);
            this.labelOpponentWeightingName.Name = "labelOpponentWeightingName";
            this.labelOpponentWeightingName.Size = new System.Drawing.Size(143, 21);
            this.labelOpponentWeightingName.TabIndex = 52;
            this.labelOpponentWeightingName.Text = "Opponent diversity";
            // 
            // labelOpponentWeightingValue
            // 
            this.labelOpponentWeightingValue.AutoSize = true;
            this.labelOpponentWeightingValue.Location = new System.Drawing.Point(449, 79);
            this.labelOpponentWeightingValue.Name = "labelOpponentWeightingValue";
            this.labelOpponentWeightingValue.Size = new System.Drawing.Size(50, 21);
            this.labelOpponentWeightingValue.TabIndex = 51;
            this.labelOpponentWeightingValue.Text = "100%";
            // 
            // trackBarOpponentWeighting
            // 
            this.trackBarOpponentWeighting.LargeChange = 20;
            this.trackBarOpponentWeighting.Location = new System.Drawing.Point(172, 79);
            this.trackBarOpponentWeighting.Maximum = 200;
            this.trackBarOpponentWeighting.Name = "trackBarOpponentWeighting";
            this.trackBarOpponentWeighting.Size = new System.Drawing.Size(271, 45);
            this.trackBarOpponentWeighting.TabIndex = 50;
            this.trackBarOpponentWeighting.TickFrequency = 20;
            this.trackBarOpponentWeighting.Value = 100;
            this.trackBarOpponentWeighting.Scroll += new System.EventHandler(this.trackBarOpponentWeighting_Scroll);
            // 
            // labelLastMatchWeightingName
            // 
            this.labelLastMatchWeightingName.AutoSize = true;
            this.labelLastMatchWeightingName.Location = new System.Drawing.Point(26, 125);
            this.labelLastMatchWeightingName.Name = "labelLastMatchWeightingName";
            this.labelLastMatchWeightingName.Size = new System.Drawing.Size(140, 21);
            this.labelLastMatchWeightingName.TabIndex = 55;
            this.labelLastMatchWeightingName.Text = "Last match waiting";
            // 
            // labelLastMatchWeightingValue
            // 
            this.labelLastMatchWeightingValue.AutoSize = true;
            this.labelLastMatchWeightingValue.Location = new System.Drawing.Point(449, 125);
            this.labelLastMatchWeightingValue.Name = "labelLastMatchWeightingValue";
            this.labelLastMatchWeightingValue.Size = new System.Drawing.Size(50, 21);
            this.labelLastMatchWeightingValue.TabIndex = 54;
            this.labelLastMatchWeightingValue.Text = "100%";
            // 
            // trackBarLastMatchWeighting
            // 
            this.trackBarLastMatchWeighting.LargeChange = 20;
            this.trackBarLastMatchWeighting.Location = new System.Drawing.Point(172, 125);
            this.trackBarLastMatchWeighting.Maximum = 200;
            this.trackBarLastMatchWeighting.Name = "trackBarLastMatchWeighting";
            this.trackBarLastMatchWeighting.Size = new System.Drawing.Size(271, 45);
            this.trackBarLastMatchWeighting.TabIndex = 53;
            this.trackBarLastMatchWeighting.TickFrequency = 20;
            this.trackBarLastMatchWeighting.Value = 100;
            this.trackBarLastMatchWeighting.Scroll += new System.EventHandler(this.trackBarLastMatchWeighting_Scroll);
            // 
            // labelAverageWaitingWeightingName
            // 
            this.labelAverageWaitingWeightingName.AutoSize = true;
            this.labelAverageWaitingWeightingName.Location = new System.Drawing.Point(44, 169);
            this.labelAverageWaitingWeightingName.Name = "labelAverageWaitingWeightingName";
            this.labelAverageWaitingWeightingName.Size = new System.Drawing.Size(122, 21);
            this.labelAverageWaitingWeightingName.TabIndex = 58;
            this.labelAverageWaitingWeightingName.Text = "Average waiting";
            // 
            // labelAverageWaitingWeightingValue
            // 
            this.labelAverageWaitingWeightingValue.AutoSize = true;
            this.labelAverageWaitingWeightingValue.Location = new System.Drawing.Point(450, 169);
            this.labelAverageWaitingWeightingValue.Name = "labelAverageWaitingWeightingValue";
            this.labelAverageWaitingWeightingValue.Size = new System.Drawing.Size(50, 21);
            this.labelAverageWaitingWeightingValue.TabIndex = 57;
            this.labelAverageWaitingWeightingValue.Text = "100%";
            // 
            // trackBarAverageWaitingWeighting
            // 
            this.trackBarAverageWaitingWeighting.LargeChange = 20;
            this.trackBarAverageWaitingWeighting.Location = new System.Drawing.Point(173, 169);
            this.trackBarAverageWaitingWeighting.Maximum = 200;
            this.trackBarAverageWaitingWeighting.Name = "trackBarAverageWaitingWeighting";
            this.trackBarAverageWaitingWeighting.Size = new System.Drawing.Size(271, 45);
            this.trackBarAverageWaitingWeighting.TabIndex = 56;
            this.trackBarAverageWaitingWeighting.TickFrequency = 20;
            this.trackBarAverageWaitingWeighting.Value = 100;
            this.trackBarAverageWaitingWeighting.Scroll += new System.EventHandler(this.trackBarAverageWaitingWeighting_Scroll);
            // 
            // labelEloName
            // 
            this.labelEloName.AutoSize = true;
            this.labelEloName.Location = new System.Drawing.Point(34, 214);
            this.labelEloName.Name = "labelEloName";
            this.labelEloName.Size = new System.Drawing.Size(132, 21);
            this.labelEloName.TabIndex = 61;
            this.labelEloName.Text = "Elo team variance";
            // 
            // labelEloValue
            // 
            this.labelEloValue.AutoSize = true;
            this.labelEloValue.Location = new System.Drawing.Point(449, 214);
            this.labelEloValue.Name = "labelEloValue";
            this.labelEloValue.Size = new System.Drawing.Size(50, 21);
            this.labelEloValue.TabIndex = 60;
            this.labelEloValue.Text = "100%";
            // 
            // trackBarElo
            // 
            this.trackBarElo.LargeChange = 20;
            this.trackBarElo.Location = new System.Drawing.Point(172, 214);
            this.trackBarElo.Maximum = 200;
            this.trackBarElo.Name = "trackBarElo";
            this.trackBarElo.Size = new System.Drawing.Size(271, 45);
            this.trackBarElo.TabIndex = 59;
            this.trackBarElo.TickFrequency = 20;
            this.trackBarElo.Value = 100;
            this.trackBarElo.Scroll += new System.EventHandler(this.trackBarElo_Scroll);
            // 
            // groupBoxWeightings
            // 
            this.groupBoxWeightings.Controls.Add(this.labelEloName);
            this.groupBoxWeightings.Controls.Add(this.trackBarTeammateWeighting);
            this.groupBoxWeightings.Controls.Add(this.labelEloValue);
            this.groupBoxWeightings.Controls.Add(this.labelTeammateWeightingValue);
            this.groupBoxWeightings.Controls.Add(this.trackBarElo);
            this.groupBoxWeightings.Controls.Add(this.labelTeammateWeightingName);
            this.groupBoxWeightings.Controls.Add(this.labelAverageWaitingWeightingName);
            this.groupBoxWeightings.Controls.Add(this.trackBarOpponentWeighting);
            this.groupBoxWeightings.Controls.Add(this.labelAverageWaitingWeightingValue);
            this.groupBoxWeightings.Controls.Add(this.labelOpponentWeightingValue);
            this.groupBoxWeightings.Controls.Add(this.trackBarAverageWaitingWeighting);
            this.groupBoxWeightings.Controls.Add(this.labelOpponentWeightingName);
            this.groupBoxWeightings.Controls.Add(this.labelLastMatchWeightingName);
            this.groupBoxWeightings.Controls.Add(this.trackBarLastMatchWeighting);
            this.groupBoxWeightings.Controls.Add(this.labelLastMatchWeightingValue);
            this.groupBoxWeightings.Location = new System.Drawing.Point(14, 52);
            this.groupBoxWeightings.Name = "groupBoxWeightings";
            this.groupBoxWeightings.Size = new System.Drawing.Size(515, 264);
            this.groupBoxWeightings.TabIndex = 62;
            this.groupBoxWeightings.TabStop = false;
            this.groupBoxWeightings.Text = "Weightings";
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(208, 319);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(116, 38);
            this.buttonReset.TabIndex = 63;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // MatchFinderSettingsDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(540, 366);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.groupBoxWeightings);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonCancel);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MatchFinderSettingsDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Match Finder Settings";
            ((System.ComponentModel.ISupportInitialize)(this.trackBarTeammateWeighting)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarOpponentWeighting)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarLastMatchWeighting)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarAverageWaitingWeighting)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarElo)).EndInit();
            this.groupBoxWeightings.ResumeLayout(false);
            this.groupBoxWeightings.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelTitle;
        private Button buttonSave;
        private Button buttonCancel;
        private TrackBar trackBarTeammateWeighting;
        private Label labelTeammateWeightingValue;
        private Label labelTeammateWeightingName;
        private Label labelOpponentWeightingName;
        private Label labelOpponentWeightingValue;
        private TrackBar trackBarOpponentWeighting;
        private Label labelLastMatchWeightingName;
        private Label labelLastMatchWeightingValue;
        private TrackBar trackBarLastMatchWeighting;
        private Label labelAverageWaitingWeightingName;
        private Label labelAverageWaitingWeightingValue;
        private TrackBar trackBarAverageWaitingWeighting;
        private Label labelEloName;
        private Label labelEloValue;
        private TrackBar trackBarElo;
        private GroupBox groupBoxWeightings;
        private Button buttonReset;
    }
}