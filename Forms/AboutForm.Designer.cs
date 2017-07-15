namespace Rocksmith2014Backup.Forms
{
    partial class AboutForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutForm));
            this.btnClose = new System.Windows.Forms.Button();
            this.toGithub = new System.Windows.Forms.LinkLabel();
            this.labelAbout = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(171, 80);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 12;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // toGithub
            // 
            this.toGithub.AutoSize = true;
            this.toGithub.Location = new System.Drawing.Point(194, 59);
            this.toGithub.Name = "toGithub";
            this.toGithub.Size = new System.Drawing.Size(38, 13);
            this.toGithub.TabIndex = 11;
            this.toGithub.TabStop = true;
            this.toGithub.Text = "Github";
            this.toGithub.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.toGithub_LinkClicked);
            // 
            // labelAbout
            // 
            this.labelAbout.AutoSize = true;
            this.labelAbout.Location = new System.Drawing.Point(10, 7);
            this.labelAbout.Name = "labelAbout";
            this.labelAbout.Size = new System.Drawing.Size(225, 65);
            this.labelAbout.TabIndex = 10;
            this.labelAbout.Text = "Rocksmith 2014 Backup\r\nDeveloped by Matty (obscurename)\r\nLicensed under GNU GPLv3" +
    "\r\n\r\nApplication source code is available at Github.";
            this.labelAbout.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // AboutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(256, 110);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.toGithub);
            this.Controls.Add(this.labelAbout);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(264, 140);
            this.MinimumSize = new System.Drawing.Size(264, 140);
            this.Name = "AboutForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "About";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button btnClose;
        internal System.Windows.Forms.LinkLabel toGithub;
        internal System.Windows.Forms.Label labelAbout;
    }
}