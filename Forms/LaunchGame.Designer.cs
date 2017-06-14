namespace RSBackup.Forms
{
    partial class LaunchGame
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LaunchGame));
            this.tmrDelay = new System.Windows.Forms.Timer(this.components);
            this.lbTime = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.sep = new System.Windows.Forms.Label();
            this.btnManage = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnLaunch = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tmrDelay
            // 
            this.tmrDelay.Interval = 1000;
            this.tmrDelay.Tick += new System.EventHandler(this.tmrDelay_Tick);
            // 
            // lbTime
            // 
            this.lbTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTime.Location = new System.Drawing.Point(8, 10);
            this.lbTime.Name = "lbTime";
            this.lbTime.Size = new System.Drawing.Size(316, 40);
            this.lbTime.TabIndex = 0;
            this.lbTime.Text = "Launching Rocksmith 2014 in 10 Seconds";
            this.lbTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(212, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Click a button below to cancel or skip timer.";
            // 
            // sep
            // 
            this.sep.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.sep.Location = new System.Drawing.Point(15, 94);
            this.sep.Name = "sep";
            this.sep.Size = new System.Drawing.Size(302, 2);
            this.sep.TabIndex = 2;
            this.sep.Text = "hey";
            // 
            // btnManage
            // 
            this.btnManage.Location = new System.Drawing.Point(64, 111);
            this.btnManage.Name = "btnManage";
            this.btnManage.Size = new System.Drawing.Size(99, 30);
            this.btnManage.TabIndex = 3;
            this.btnManage.Text = "Manage Backups";
            this.btnManage.UseVisualStyleBackColor = true;
            // 
            // btnSettings
            // 
            this.btnSettings.Location = new System.Drawing.Point(169, 111);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(99, 30);
            this.btnSettings.TabIndex = 4;
            this.btnSettings.Text = "Edit Settings";
            this.btnSettings.UseVisualStyleBackColor = true;
            // 
            // btnLaunch
            // 
            this.btnLaunch.Location = new System.Drawing.Point(112, 151);
            this.btnLaunch.Name = "btnLaunch";
            this.btnLaunch.Size = new System.Drawing.Size(109, 30);
            this.btnLaunch.TabIndex = 5;
            this.btnLaunch.Text = "Launch Rocksmith";
            this.btnLaunch.UseVisualStyleBackColor = true;
            // 
            // LaunchGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 190);
            this.Controls.Add(this.btnLaunch);
            this.Controls.Add(this.btnSettings);
            this.Controls.Add(this.btnManage);
            this.Controls.Add(this.sep);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbTime);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LaunchGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Launching Rocksmith 2014";
            this.Load += new System.EventHandler(this.LaunchGame_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer tmrDelay;
        private System.Windows.Forms.Label lbTime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label sep;
        private System.Windows.Forms.Button btnManage;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Button btnLaunch;
    }
}