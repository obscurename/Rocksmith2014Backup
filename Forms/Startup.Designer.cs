namespace RSBackup.Forms
{
    partial class Startup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Startup));
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.sep = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblBkUp = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.lnkSteam3 = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.lblSteam = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.lbAutoFail = new System.Windows.Forms.Label();
            this.cmFinalize = new CommandLink();
            this.simpleSetup = new CommandLink();
            this.customSetup = new CommandLink();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(288, 39);
            this.label1.TabIndex = 2;
            this.label1.Text = "Since this is your first time running Rocksmith 2014 Backup,\r\nyou need to set it " +
    "up. Use one of the two setup methods\r\nto begin.";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(-69, -420);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // sep
            // 
            this.sep.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.sep.Location = new System.Drawing.Point(12, 181);
            this.sep.Name = "sep";
            this.sep.Size = new System.Drawing.Size(268, 2);
            this.sep.TabIndex = 9;
            this.sep.Text = "hey";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(58, 198);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(24, 13);
            this.lblID.TabIndex = 10;
            this.lblID.Text = " ID:";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(83, 216);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(126, 20);
            this.txtID.TabIndex = 11;
            this.txtID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblBkUp
            // 
            this.lblBkUp.AutoSize = true;
            this.lblBkUp.Location = new System.Drawing.Point(21, 242);
            this.lblBkUp.Name = "lblBkUp";
            this.lblBkUp.Size = new System.Drawing.Size(90, 13);
            this.lblBkUp.TabIndex = 12;
            this.lblBkUp.Text = "Backup directory:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(29, 261);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(204, 20);
            this.textBox2.TabIndex = 13;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(239, 259);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(24, 23);
            this.button2.TabIndex = 14;
            this.button2.Text = "...";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // lnkSteam3
            // 
            this.lnkSteam3.AutoSize = true;
            this.lnkSteam3.Location = new System.Drawing.Point(21, 198);
            this.lnkSteam3.Name = "lnkSteam3";
            this.lnkSteam3.Size = new System.Drawing.Size(43, 13);
            this.lnkSteam3.TabIndex = 15;
            this.lnkSteam3.TabStop = true;
            this.lnkSteam3.Text = "Steam3";
            this.lnkSteam3.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkSteam3_LinkClicked);
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(12, 294);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(268, 2);
            this.label2.TabIndex = 16;
            this.label2.Text = "hey";
            // 
            // lblSteam
            // 
            this.lblSteam.AutoSize = true;
            this.lblSteam.Location = new System.Drawing.Point(21, 311);
            this.lblSteam.Name = "lblSteam";
            this.lblSteam.Size = new System.Drawing.Size(135, 13);
            this.lblSteam.TabIndex = 17;
            this.lblSteam.Text = "Steam installation directory:";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(239, 328);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(24, 23);
            this.button3.TabIndex = 19;
            this.button3.Text = "...";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(29, 330);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(204, 20);
            this.textBox3.TabIndex = 18;
            // 
            // lbAutoFail
            // 
            this.lbAutoFail.ForeColor = System.Drawing.Color.Red;
            this.lbAutoFail.Location = new System.Drawing.Point(61, 288);
            this.lbAutoFail.Name = "lbAutoFail";
            this.lbAutoFail.Size = new System.Drawing.Size(171, 15);
            this.lbAutoFail.TabIndex = 21;
            this.lbAutoFail.Text = "Unable to automatically find steam.";
            this.lbAutoFail.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbAutoFail.Visible = false;
            // 
            // cmFinalize
            // 
            this.cmFinalize.AccessibleDescription = "e";
            this.cmFinalize.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmFinalize.Location = new System.Drawing.Point(96, 356);
            this.cmFinalize.Name = "cmFinalize";
            this.cmFinalize.Note = "";
            this.cmFinalize.Size = new System.Drawing.Size(100, 41);
            this.cmFinalize.TabIndex = 20;
            this.cmFinalize.Text = "Finalize";
            this.cmFinalize.UseVisualStyleBackColor = true;
            // 
            // simpleSetup
            // 
            this.simpleSetup.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.simpleSetup.Location = new System.Drawing.Point(17, 56);
            this.simpleSetup.Name = "simpleSetup";
            this.simpleSetup.Note = "Easier setup, easier life.";
            this.simpleSetup.Size = new System.Drawing.Size(204, 56);
            this.simpleSetup.TabIndex = 7;
            this.simpleSetup.Text = "Simple Setup";
            this.simpleSetup.UseVisualStyleBackColor = true;
            this.simpleSetup.Click += new System.EventHandler(this.simpleSetup_Click);
            // 
            // customSetup
            // 
            this.customSetup.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.customSetup.Location = new System.Drawing.Point(17, 116);
            this.customSetup.Name = "customSetup";
            this.customSetup.Note = "I know what I\'m doing. For the most part.";
            this.customSetup.Size = new System.Drawing.Size(259, 54);
            this.customSetup.TabIndex = 8;
            this.customSetup.Text = "Advance Setup";
            this.customSetup.UseVisualStyleBackColor = true;
            this.customSetup.Click += new System.EventHandler(this.customSetup_Click);
            // 
            // Startup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(292, 180);
            this.Controls.Add(this.lbAutoFail);
            this.Controls.Add(this.cmFinalize);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.lblSteam);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lnkSteam3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.lblBkUp);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.sep);
            this.Controls.Add(this.simpleSetup);
            this.Controls.Add(this.customSetup);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(300, 430);
            this.MinimumSize = new System.Drawing.Size(300, 210);
            this.Name = "Startup";
            this.Opacity = 0D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RS2014 Backup";
            this.Load += new System.EventHandler(this.Startup_Load);
            this.Shown += new System.EventHandler(this.Startup_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private CommandLink simpleSetup;
        private CommandLink customSetup;
        private System.Windows.Forms.Label sep;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblBkUp;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.LinkLabel lnkSteam3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblSteam;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox3;
        private CommandLink cmFinalize;
        private System.Windows.Forms.Label lbAutoFail;
    }
}