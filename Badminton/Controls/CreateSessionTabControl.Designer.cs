namespace Badminton.Controls
{
    partial class CreateSessionTabControl
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
            this.labelCourtsAvailable = new System.Windows.Forms.Label();
            this.textBoxCourtsAvailable = new System.Windows.Forms.TextBox();
            this.buttonStartSession = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelCourtsAvailable
            // 
            this.labelCourtsAvailable.AutoSize = true;
            this.labelCourtsAvailable.Location = new System.Drawing.Point(3, 6);
            this.labelCourtsAvailable.Name = "labelCourtsAvailable";
            this.labelCourtsAvailable.Size = new System.Drawing.Size(96, 15);
            this.labelCourtsAvailable.TabIndex = 8;
            this.labelCourtsAvailable.Text = "Courts Available:";
            // 
            // textBoxCourtsAvailable
            // 
            this.textBoxCourtsAvailable.Location = new System.Drawing.Point(105, 3);
            this.textBoxCourtsAvailable.Name = "textBoxCourtsAvailable";
            this.textBoxCourtsAvailable.Size = new System.Drawing.Size(100, 23);
            this.textBoxCourtsAvailable.TabIndex = 7;
            this.textBoxCourtsAvailable.TextChanged += new System.EventHandler(this.textBoxCourtsAvailable_TextChanged);
            // 
            // buttonStartSession
            // 
            this.buttonStartSession.Enabled = false;
            this.buttonStartSession.Location = new System.Drawing.Point(3, 44);
            this.buttonStartSession.Name = "buttonStartSession";
            this.buttonStartSession.Size = new System.Drawing.Size(100, 23);
            this.buttonStartSession.TabIndex = 6;
            this.buttonStartSession.Text = "New Session";
            this.buttonStartSession.UseVisualStyleBackColor = true;
            this.buttonStartSession.Click += new System.EventHandler(this.buttonStartSession_Click);
            // 
            // CreateSessionTabControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.labelCourtsAvailable);
            this.Controls.Add(this.textBoxCourtsAvailable);
            this.Controls.Add(this.buttonStartSession);
            this.Name = "CreateSessionTabControl";
            this.Size = new System.Drawing.Size(208, 70);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelCourtsAvailable;
        private TextBox textBoxCourtsAvailable;
        private Button buttonStartSession;
    }
}
