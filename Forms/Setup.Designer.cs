namespace RSBackup.Forms
{
    partial class Setup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Setup));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lnkSteam3 = new System.Windows.Forms.LinkLabel();
            this.txtID = new System.Windows.Forms.TextBox();
            this.chkID = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.chkSteamPath = new System.Windows.Forms.CheckBox();
            this.txtSteamPath = new System.Windows.Forms.TextBox();
            this.btnBrowseSteam = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btnBrowseBackup = new System.Windows.Forms.Button();
            this.txtBackupPath = new System.Windows.Forms.TextBox();
            this.chkBackupPath = new System.Windows.Forms.CheckBox();
            this.chkAutoBoot = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.lbHelp = new System.Windows.Forms.Label();
            this.rbDelayOff = new System.Windows.Forms.RadioButton();
            this.rbDelayOn = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.cmFinish = new CommandLink();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Settings";
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(34, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(2, 167);
            this.label2.TabIndex = 2;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(83, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "ID:";
            // 
            // lnkSteam3
            // 
            this.lnkSteam3.AutoSize = true;
            this.lnkSteam3.Location = new System.Drawing.Point(44, 40);
            this.lnkSteam3.Name = "lnkSteam3";
            this.lnkSteam3.Size = new System.Drawing.Size(43, 13);
            this.lnkSteam3.TabIndex = 4;
            this.lnkSteam3.TabStop = true;
            this.lnkSteam3.Text = "Steam3";
            this.lnkSteam3.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkSteam3_LinkClicked);
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(92, 58);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(100, 20);
            this.txtID.TabIndex = 5;
            this.txtID.Text = "XXXXXXXXXX";
            this.txtID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtID.TextChanged += new System.EventHandler(this.txtID_TextChanged);
            // 
            // chkID
            // 
            this.chkID.AutoSize = true;
            this.chkID.Checked = true;
            this.chkID.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkID.Enabled = false;
            this.chkID.Location = new System.Drawing.Point(12, 40);
            this.chkID.Name = "chkID";
            this.chkID.Size = new System.Drawing.Size(14, 13);
            this.chkID.TabIndex = 6;
            this.chkID.UseVisualStyleBackColor = true;
            this.chkID.CheckedChanged += new System.EventHandler(this.chkID_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Steam installation path:";
            // 
            // chkSteamPath
            // 
            this.chkSteamPath.AutoSize = true;
            this.chkSteamPath.Location = new System.Drawing.Point(12, 93);
            this.chkSteamPath.Name = "chkSteamPath";
            this.chkSteamPath.Size = new System.Drawing.Size(14, 13);
            this.chkSteamPath.TabIndex = 8;
            this.chkSteamPath.UseVisualStyleBackColor = true;
            this.chkSteamPath.CheckedChanged += new System.EventHandler(this.chkSteamPath_CheckedChanged);
            // 
            // txtSteamPath
            // 
            this.txtSteamPath.Enabled = false;
            this.txtSteamPath.Location = new System.Drawing.Point(61, 111);
            this.txtSteamPath.Name = "txtSteamPath";
            this.txtSteamPath.ReadOnly = true;
            this.txtSteamPath.Size = new System.Drawing.Size(235, 20);
            this.txtSteamPath.TabIndex = 9;
            // 
            // btnBrowseSteam
            // 
            this.btnBrowseSteam.Enabled = false;
            this.btnBrowseSteam.Location = new System.Drawing.Point(301, 109);
            this.btnBrowseSteam.Name = "btnBrowseSteam";
            this.btnBrowseSteam.Size = new System.Drawing.Size(24, 23);
            this.btnBrowseSteam.TabIndex = 10;
            this.btnBrowseSteam.Text = "...";
            this.btnBrowseSteam.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(44, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Backup folder path:";
            // 
            // btnBrowseBackup
            // 
            this.btnBrowseBackup.Location = new System.Drawing.Point(301, 164);
            this.btnBrowseBackup.Name = "btnBrowseBackup";
            this.btnBrowseBackup.Size = new System.Drawing.Size(24, 23);
            this.btnBrowseBackup.TabIndex = 13;
            this.btnBrowseBackup.Text = "...";
            this.btnBrowseBackup.UseVisualStyleBackColor = true;
            // 
            // txtBackupPath
            // 
            this.txtBackupPath.Location = new System.Drawing.Point(61, 166);
            this.txtBackupPath.Name = "txtBackupPath";
            this.txtBackupPath.ReadOnly = true;
            this.txtBackupPath.Size = new System.Drawing.Size(235, 20);
            this.txtBackupPath.TabIndex = 12;
            // 
            // chkBackupPath
            // 
            this.chkBackupPath.AutoSize = true;
            this.chkBackupPath.Checked = true;
            this.chkBackupPath.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkBackupPath.Location = new System.Drawing.Point(12, 147);
            this.chkBackupPath.Name = "chkBackupPath";
            this.chkBackupPath.Size = new System.Drawing.Size(14, 13);
            this.chkBackupPath.TabIndex = 14;
            this.chkBackupPath.UseVisualStyleBackColor = true;
            this.chkBackupPath.CheckedChanged += new System.EventHandler(this.chkBackupPath_CheckedChanged);
            // 
            // chkAutoBoot
            // 
            this.chkAutoBoot.AutoSize = true;
            this.chkAutoBoot.Checked = true;
            this.chkAutoBoot.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAutoBoot.Location = new System.Drawing.Point(86, 19);
            this.chkAutoBoot.Name = "chkAutoBoot";
            this.chkAutoBoot.Size = new System.Drawing.Size(117, 17);
            this.chkAutoBoot.TabIndex = 15;
            this.chkAutoBoot.Text = "Enable auto launch";
            this.chkAutoBoot.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.lbHelp);
            this.groupBox1.Controls.Add(this.rbDelayOff);
            this.groupBox1.Controls.Add(this.rbDelayOn);
            this.groupBox1.Controls.Add(this.chkAutoBoot);
            this.groupBox1.Location = new System.Drawing.Point(22, 203);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(288, 67);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Auto Launch Rocksmith";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(114, 42);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(96, 17);
            this.radioButton1.TabIndex = 19;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "5 second delay";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // lbHelp
            // 
            this.lbHelp.AutoSize = true;
            this.lbHelp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbHelp.Location = new System.Drawing.Point(257, 10);
            this.lbHelp.Name = "lbHelp";
            this.lbHelp.Size = new System.Drawing.Size(29, 13);
            this.lbHelp.TabIndex = 18;
            this.lbHelp.Text = "Help";
            this.lbHelp.Click += new System.EventHandler(this.lbHelp_Click);
            // 
            // rbDelayOff
            // 
            this.rbDelayOff.AutoSize = true;
            this.rbDelayOff.Location = new System.Drawing.Point(216, 42);
            this.rbDelayOff.Name = "rbDelayOff";
            this.rbDelayOff.Size = new System.Drawing.Size(66, 17);
            this.rbDelayOff.TabIndex = 17;
            this.rbDelayOff.Text = "No delay";
            this.rbDelayOff.UseVisualStyleBackColor = true;
            // 
            // rbDelayOn
            // 
            this.rbDelayOn.AutoSize = true;
            this.rbDelayOn.Location = new System.Drawing.Point(6, 42);
            this.rbDelayOn.Name = "rbDelayOn";
            this.rbDelayOn.Size = new System.Drawing.Size(102, 17);
            this.rbDelayOn.TabIndex = 16;
            this.rbDelayOn.Text = "10 second delay";
            this.rbDelayOn.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Location = new System.Drawing.Point(14, 279);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(305, 2);
            this.label6.TabIndex = 18;
            this.label6.Text = "label6";
            // 
            // cmFinish
            // 
            this.cmFinish.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmFinish.Location = new System.Drawing.Point(91, 286);
            this.cmFinish.Name = "cmFinish";
            this.cmFinish.Note = "Seems right to me.";
            this.cmFinish.Size = new System.Drawing.Size(150, 51);
            this.cmFinish.TabIndex = 17;
            this.cmFinish.Text = "Finalize Setup";
            this.cmFinish.UseVisualStyleBackColor = true;
            // 
            // Setup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 350);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmFinish);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.chkBackupPath);
            this.Controls.Add(this.btnBrowseBackup);
            this.Controls.Add(this.txtBackupPath);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnBrowseSteam);
            this.Controls.Add(this.txtSteamPath);
            this.Controls.Add(this.chkSteamPath);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chkID);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lnkSteam3);
            this.Controls.Add(this.label2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(340, 380);
            this.MinimumSize = new System.Drawing.Size(340, 380);
            this.Name = "Setup";
            this.Text = "Settings - Rocksmith 2014 Backup";
            this.Load += new System.EventHandler(this.Setup_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel lnkSteam3;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.CheckBox chkID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox chkSteamPath;
        private System.Windows.Forms.TextBox txtSteamPath;
        private System.Windows.Forms.Button btnBrowseSteam;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnBrowseBackup;
        private System.Windows.Forms.TextBox txtBackupPath;
        private System.Windows.Forms.CheckBox chkBackupPath;
        private System.Windows.Forms.CheckBox chkAutoBoot;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbHelp;
        private System.Windows.Forms.RadioButton rbDelayOff;
        private System.Windows.Forms.RadioButton rbDelayOn;
        private CommandLink cmFinish;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label6;
    }
}