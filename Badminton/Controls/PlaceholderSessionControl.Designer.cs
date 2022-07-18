namespace Badminton.Controls
{
    partial class PlaceholderSessionControl
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
            this.buttonStartSession = new System.Windows.Forms.Button();
            this.textBoxCourtsAvailable = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonStartSession
            // 
            this.buttonStartSession.Enabled = false;
            this.buttonStartSession.Location = new System.Drawing.Point(17, 58);
            this.buttonStartSession.Name = "buttonStartSession";
            this.buttonStartSession.Size = new System.Drawing.Size(100, 23);
            this.buttonStartSession.TabIndex = 0;
            this.buttonStartSession.Text = "New Session";
            this.buttonStartSession.UseVisualStyleBackColor = true;
            this.buttonStartSession.Click += new System.EventHandler(this.buttonStartSession_Click);
            // 
            // textBoxCourtsAvailable
            // 
            this.textBoxCourtsAvailable.Location = new System.Drawing.Point(119, 17);
            this.textBoxCourtsAvailable.Name = "textBoxCourtsAvailable";
            this.textBoxCourtsAvailable.Size = new System.Drawing.Size(100, 23);
            this.textBoxCourtsAvailable.TabIndex = 1;
            this.textBoxCourtsAvailable.TextChanged += new System.EventHandler(this.textBoxCourtsAvailable_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Courts Available:";
            // 
            // PlaceholderSessionControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxCourtsAvailable);
            this.Controls.Add(this.buttonStartSession);
            this.Name = "PlaceholderSessionControl";
            this.Size = new System.Drawing.Size(347, 331);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button buttonStartSession;
        private TextBox textBoxCourtsAvailable;
        private Label label1;
    }
}
