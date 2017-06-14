namespace RSBackup
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.btnHelp = new System.Windows.Forms.Button();
            this.btnAbout = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.labelBackups = new System.Windows.Forms.Label();
            this.cmBackups = new System.Windows.Forms.ContextMenu();
            this.mCreate = new System.Windows.Forms.MenuItem();
            this.MenuItem2 = new System.Windows.Forms.MenuItem();
            this.mRenameBackup = new System.Windows.Forms.MenuItem();
            this.mRestoreBackup = new System.Windows.Forms.MenuItem();
            this.mS = new System.Windows.Forms.MenuItem();
            this.mDelete = new System.Windows.Forms.MenuItem();
            this.mDelSelected = new System.Windows.Forms.MenuItem();
            this.mDelAll = new System.Windows.Forms.MenuItem();
            this.cmTreeview = new System.Windows.Forms.ContextMenu();
            this.mCreateBackup = new System.Windows.Forms.MenuItem();
            this.mSep3 = new System.Windows.Forms.MenuItem();
            this.mRenameSelectedBackup = new System.Windows.Forms.MenuItem();
            this.mRestoreSelectedBackup = new System.Windows.Forms.MenuItem();
            this.mSep2 = new System.Windows.Forms.MenuItem();
            this.mDeleteSelectedBackup = new System.Windows.Forms.MenuItem();
            this.BackupAllFiles = new System.ComponentModel.BackgroundWorker();
            this.btnBackupSettings = new VistaControls.SplitButton();
            this.treeBackups = new VistaControls.ExplorerTreeview();
            this.SuspendLayout();
            // 
            // btnHelp
            // 
            this.btnHelp.Location = new System.Drawing.Point(174, 298);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(42, 23);
            this.btnHelp.TabIndex = 15;
            this.btnHelp.Text = "Help";
            this.btnHelp.UseVisualStyleBackColor = true;
            // 
            // btnAbout
            // 
            this.btnAbout.Location = new System.Drawing.Point(222, 298);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(48, 23);
            this.btnAbout.TabIndex = 12;
            this.btnAbout.Text = "About";
            this.btnAbout.UseVisualStyleBackColor = true;
            // 
            // btnSettings
            // 
            this.btnSettings.Location = new System.Drawing.Point(209, 269);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(62, 23);
            this.btnSettings.TabIndex = 11;
            this.btnSettings.Text = "Settings";
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // labelBackups
            // 
            this.labelBackups.AutoSize = true;
            this.labelBackups.Location = new System.Drawing.Point(6, 6);
            this.labelBackups.Name = "labelBackups";
            this.labelBackups.Size = new System.Drawing.Size(98, 13);
            this.labelBackups.TabIndex = 10;
            this.labelBackups.Text = "Available Backups:";
            // 
            // cmBackups
            // 
            this.cmBackups.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.mCreate,
            this.MenuItem2,
            this.mRenameBackup,
            this.mRestoreBackup,
            this.mS,
            this.mDelete});
            // 
            // mCreate
            // 
            this.mCreate.Index = 0;
            this.mCreate.Text = "Create backup";
            // 
            // MenuItem2
            // 
            this.MenuItem2.Index = 1;
            this.MenuItem2.Text = "-";
            // 
            // mRenameBackup
            // 
            this.mRenameBackup.Enabled = false;
            this.mRenameBackup.Index = 2;
            this.mRenameBackup.Text = "Rename backup";
            // 
            // mRestoreBackup
            // 
            this.mRestoreBackup.Enabled = false;
            this.mRestoreBackup.Index = 3;
            this.mRestoreBackup.Text = "Restore backup";
            // 
            // mS
            // 
            this.mS.Index = 4;
            this.mS.Text = "-";
            // 
            // mDelete
            // 
            this.mDelete.Index = 5;
            this.mDelete.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.mDelSelected,
            this.mDelAll});
            this.mDelete.Text = "Delete backup...";
            // 
            // mDelSelected
            // 
            this.mDelSelected.Index = 0;
            this.mDelSelected.Text = "Selected backup";
            // 
            // mDelAll
            // 
            this.mDelAll.Index = 1;
            this.mDelAll.Text = "All backups";
            // 
            // cmTreeview
            // 
            this.cmTreeview.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.mCreateBackup,
            this.mSep3,
            this.mRenameSelectedBackup,
            this.mRestoreSelectedBackup,
            this.mSep2,
            this.mDeleteSelectedBackup});
            // 
            // mCreateBackup
            // 
            this.mCreateBackup.Index = 0;
            this.mCreateBackup.Text = "Create backup";
            // 
            // mSep3
            // 
            this.mSep3.Index = 1;
            this.mSep3.Text = "-";
            // 
            // mRenameSelectedBackup
            // 
            this.mRenameSelectedBackup.Enabled = false;
            this.mRenameSelectedBackup.Index = 2;
            this.mRenameSelectedBackup.Text = "Rename this backup";
            // 
            // mRestoreSelectedBackup
            // 
            this.mRestoreSelectedBackup.Enabled = false;
            this.mRestoreSelectedBackup.Index = 3;
            this.mRestoreSelectedBackup.Text = "Restore this backup";
            // 
            // mSep2
            // 
            this.mSep2.Index = 4;
            this.mSep2.Text = "-";
            // 
            // mDeleteSelectedBackup
            // 
            this.mDeleteSelectedBackup.Index = 5;
            this.mDeleteSelectedBackup.Text = "Delete this backup";
            // 
            // btnBackupSettings
            // 
            this.btnBackupSettings.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnBackupSettings.Location = new System.Drawing.Point(15, 269);
            this.btnBackupSettings.Name = "btnBackupSettings";
            this.btnBackupSettings.Size = new System.Drawing.Size(75, 23);
            this.btnBackupSettings.TabIndex = 17;
            this.btnBackupSettings.Text = "Backup";
            this.btnBackupSettings.UseVisualStyleBackColor = true;
            // 
            // treeBackups
            // 
            this.treeBackups.HotTracking = true;
            this.treeBackups.Location = new System.Drawing.Point(15, 22);
            this.treeBackups.Name = "treeBackups";
            this.treeBackups.ShowLines = false;
            this.treeBackups.Size = new System.Drawing.Size(255, 241);
            this.treeBackups.TabIndex = 18;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 330);
            this.Controls.Add(this.treeBackups);
            this.Controls.Add(this.btnBackupSettings);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.btnAbout);
            this.Controls.Add(this.btnSettings);
            this.Controls.Add(this.labelBackups);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(290, 360);
            this.MinimumSize = new System.Drawing.Size(290, 360);
            this.Name = "frmMain";
            this.Text = "Rocksmith 2014 Backup";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button btnHelp;
        internal System.Windows.Forms.Button btnAbout;
        internal System.Windows.Forms.Button btnSettings;
        internal System.Windows.Forms.Label labelBackups;
        internal System.Windows.Forms.ContextMenu cmBackups;
        internal System.Windows.Forms.MenuItem mCreate;
        internal System.Windows.Forms.MenuItem MenuItem2;
        internal System.Windows.Forms.MenuItem mRenameBackup;
        internal System.Windows.Forms.MenuItem mRestoreBackup;
        internal System.Windows.Forms.MenuItem mS;
        internal System.Windows.Forms.MenuItem mDelete;
        internal System.Windows.Forms.MenuItem mDelSelected;
        internal System.Windows.Forms.MenuItem mDelAll;
        internal System.Windows.Forms.ContextMenu cmTreeview;
        internal System.Windows.Forms.MenuItem mCreateBackup;
        internal System.Windows.Forms.MenuItem mSep3;
        internal System.Windows.Forms.MenuItem mRenameSelectedBackup;
        internal System.Windows.Forms.MenuItem mRestoreSelectedBackup;
        internal System.Windows.Forms.MenuItem mSep2;
        internal System.Windows.Forms.MenuItem mDeleteSelectedBackup;
        internal System.ComponentModel.BackgroundWorker BackupAllFiles;
        private VistaControls.SplitButton btnBackupSettings;
        private VistaControls.ExplorerTreeview treeBackups;

    }
}