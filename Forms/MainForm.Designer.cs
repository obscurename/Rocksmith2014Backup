namespace Rocksmith2014Backup
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.BackupAllFiles = new System.ComponentModel.BackgroundWorker();
            this.mDeleteSelectedBackup = new System.Windows.Forms.MenuItem();
            this.mSep2 = new System.Windows.Forms.MenuItem();
            this.mRestoreSelectedBackup = new System.Windows.Forms.MenuItem();
            this.mSep3 = new System.Windows.Forms.MenuItem();
            this.mCreateBackup = new System.Windows.Forms.MenuItem();
            this.cmTreeview = new System.Windows.Forms.ContextMenu();
            this.mDelAll = new System.Windows.Forms.MenuItem();
            this.mDelSelected = new System.Windows.Forms.MenuItem();
            this.mS = new System.Windows.Forms.MenuItem();
            this.mRestoreBackup = new System.Windows.Forms.MenuItem();
            this.MenuItem2 = new System.Windows.Forms.MenuItem();
            this.mCreate = new System.Windows.Forms.MenuItem();
            this.cmBackups = new System.Windows.Forms.ContextMenu();
            this.mDelete = new System.Windows.Forms.MenuItem();
            this.btnAbout = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.labelBackups = new System.Windows.Forms.Label();
            this.btnLaunchGame = new System.Windows.Forms.Button();
            this.labelSettings = new System.Windows.Forms.Label();
            this.lblSeperator = new System.Windows.Forms.Label();
            this.btnBrowseBackup = new System.Windows.Forms.Button();
            this.txtBackupPath = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnBrowseSteam = new System.Windows.Forms.Button();
            this.txtSteamPath = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lnkSteam3 = new System.Windows.Forms.LinkLabel();
            this.numBackups = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbDelay5 = new System.Windows.Forms.RadioButton();
            this.lbHelp = new System.Windows.Forms.Label();
            this.rbDelay10 = new System.Windows.Forms.RadioButton();
            this.chkAutoBoot = new System.Windows.Forms.CheckBox();
            this.groupAutoboot = new System.Windows.Forms.GroupBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnManage = new System.Windows.Forms.Button();
            this.btnLaunch = new System.Windows.Forms.Button();
            this.lbBootTime = new System.Windows.Forms.Label();
            this.tmrAutoBoot = new System.Windows.Forms.Timer(this.components);
            this.chkDelAfter = new System.Windows.Forms.CheckBox();
            this.btnCheckID = new System.Windows.Forms.Button();
            this.chkIdle = new System.Windows.Forms.CheckBox();
            this.niTray = new System.Windows.Forms.NotifyIcon(this.components);
            this.btnReset = new System.Windows.Forms.Button();
            this.cmFinish = new CommandLink();
            this.treeBackups = new VistaControls.ExplorerTreeview();
            this.btnBackupSettings = new VistaControls.SplitButton();
            this.trayMenu = new System.Windows.Forms.ContextMenu();
            this.mShow = new System.Windows.Forms.MenuItem();
            this.mRun = new System.Windows.Forms.MenuItem();
            this.mSep = new System.Windows.Forms.MenuItem();
            this.mExit = new System.Windows.Forms.MenuItem();
            this.cbExec = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numBackups)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupAutoboot.SuspendLayout();
            this.SuspendLayout();
            // 
            // mDeleteSelectedBackup
            // 
            this.mDeleteSelectedBackup.Enabled = false;
            this.mDeleteSelectedBackup.Index = 4;
            this.mDeleteSelectedBackup.Text = "Delete this backup";
            this.mDeleteSelectedBackup.Click += new System.EventHandler(this.mDeleteSelectedBackup_Click);
            // 
            // mSep2
            // 
            this.mSep2.Index = 3;
            this.mSep2.Text = "-";
            // 
            // mRestoreSelectedBackup
            // 
            this.mRestoreSelectedBackup.Enabled = false;
            this.mRestoreSelectedBackup.Index = 2;
            this.mRestoreSelectedBackup.Text = "Restore this backup";
            this.mRestoreSelectedBackup.Click += new System.EventHandler(this.mRestoreSelectedBackup_Click);
            // 
            // mSep3
            // 
            this.mSep3.Index = 1;
            this.mSep3.Text = "-";
            // 
            // mCreateBackup
            // 
            this.mCreateBackup.Index = 0;
            this.mCreateBackup.Text = "Create backup";
            this.mCreateBackup.Click += new System.EventHandler(this.mCreateBackup_Click);
            // 
            // cmTreeview
            // 
            this.cmTreeview.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.mCreateBackup,
            this.mSep3,
            this.mRestoreSelectedBackup,
            this.mSep2,
            this.mDeleteSelectedBackup});
            // 
            // mDelAll
            // 
            this.mDelAll.Index = 1;
            this.mDelAll.Text = "All backups";
            this.mDelAll.Click += new System.EventHandler(this.mDelAll_Click);
            // 
            // mDelSelected
            // 
            this.mDelSelected.Enabled = false;
            this.mDelSelected.Index = 0;
            this.mDelSelected.Text = "Selected backup";
            this.mDelSelected.Click += new System.EventHandler(this.mDelSelected_Click);
            // 
            // mS
            // 
            this.mS.Index = 3;
            this.mS.Text = "-";
            // 
            // mRestoreBackup
            // 
            this.mRestoreBackup.Enabled = false;
            this.mRestoreBackup.Index = 2;
            this.mRestoreBackup.Text = "Restore backup";
            this.mRestoreBackup.Click += new System.EventHandler(this.mRestoreBackup_Click);
            // 
            // MenuItem2
            // 
            this.MenuItem2.Index = 1;
            this.MenuItem2.Text = "-";
            // 
            // mCreate
            // 
            this.mCreate.Index = 0;
            this.mCreate.Text = "Create backup";
            this.mCreate.Click += new System.EventHandler(this.mCreate_Click);
            // 
            // cmBackups
            // 
            this.cmBackups.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.mCreate,
            this.MenuItem2,
            this.mRestoreBackup,
            this.mS,
            this.mDelete});
            // 
            // mDelete
            // 
            this.mDelete.Index = 4;
            this.mDelete.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.mDelSelected,
            this.mDelAll});
            this.mDelete.Text = "Delete backup...";
            // 
            // btnAbout
            // 
            this.btnAbout.Enabled = false;
            this.btnAbout.Location = new System.Drawing.Point(214, 297);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(58, 24);
            this.btnAbout.TabIndex = 21;
            this.btnAbout.Text = "About";
            this.btnAbout.UseVisualStyleBackColor = true;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // btnSettings
            // 
            this.btnSettings.Enabled = false;
            this.btnSettings.Location = new System.Drawing.Point(188, 268);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(84, 24);
            this.btnSettings.TabIndex = 20;
            this.btnSettings.Text = "Show Settings";
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // labelBackups
            // 
            this.labelBackups.AutoSize = true;
            this.labelBackups.Location = new System.Drawing.Point(4, 5);
            this.labelBackups.Name = "labelBackups";
            this.labelBackups.Size = new System.Drawing.Size(92, 13);
            this.labelBackups.TabIndex = 19;
            this.labelBackups.Text = "Created Backups:";
            // 
            // btnLaunchGame
            // 
            this.btnLaunchGame.Enabled = false;
            this.btnLaunchGame.Location = new System.Drawing.Point(12, 297);
            this.btnLaunchGame.Name = "btnLaunchGame";
            this.btnLaunchGame.Size = new System.Drawing.Size(134, 24);
            this.btnLaunchGame.TabIndex = 25;
            this.btnLaunchGame.Text = "Launch Rocksmith 2014";
            this.btnLaunchGame.UseVisualStyleBackColor = true;
            this.btnLaunchGame.Click += new System.EventHandler(this.btnLaunchGame_Click);
            // 
            // labelSettings
            // 
            this.labelSettings.AutoSize = true;
            this.labelSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSettings.Location = new System.Drawing.Point(292, 7);
            this.labelSettings.Name = "labelSettings";
            this.labelSettings.Size = new System.Drawing.Size(68, 20);
            this.labelSettings.TabIndex = 27;
            this.labelSettings.Text = "Settings";
            // 
            // lblSeperator
            // 
            this.lblSeperator.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSeperator.Location = new System.Drawing.Point(289, 7);
            this.lblSeperator.Name = "lblSeperator";
            this.lblSeperator.Size = new System.Drawing.Size(2, 316);
            this.lblSeperator.TabIndex = 26;
            this.lblSeperator.Text = "Label2";
            // 
            // btnBrowseBackup
            // 
            this.btnBrowseBackup.Location = new System.Drawing.Point(564, 157);
            this.btnBrowseBackup.Name = "btnBrowseBackup";
            this.btnBrowseBackup.Size = new System.Drawing.Size(24, 23);
            this.btnBrowseBackup.TabIndex = 36;
            this.btnBrowseBackup.Text = "...";
            this.btnBrowseBackup.UseVisualStyleBackColor = true;
            this.btnBrowseBackup.Click += new System.EventHandler(this.btnBrowseBackup_Click);
            // 
            // txtBackupPath
            // 
            this.txtBackupPath.Location = new System.Drawing.Point(324, 159);
            this.txtBackupPath.Name = "txtBackupPath";
            this.txtBackupPath.ReadOnly = true;
            this.txtBackupPath.Size = new System.Drawing.Size(235, 20);
            this.txtBackupPath.TabIndex = 35;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(307, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 13);
            this.label5.TabIndex = 34;
            this.label5.Text = "Backup folder path:";
            // 
            // btnBrowseSteam
            // 
            this.btnBrowseSteam.Location = new System.Drawing.Point(564, 102);
            this.btnBrowseSteam.Name = "btnBrowseSteam";
            this.btnBrowseSteam.Size = new System.Drawing.Size(24, 23);
            this.btnBrowseSteam.TabIndex = 33;
            this.btnBrowseSteam.Text = "...";
            this.btnBrowseSteam.UseVisualStyleBackColor = true;
            this.btnBrowseSteam.Click += new System.EventHandler(this.btnBrowseSteam_Click);
            // 
            // txtSteamPath
            // 
            this.txtSteamPath.Location = new System.Drawing.Point(324, 104);
            this.txtSteamPath.Name = "txtSteamPath";
            this.txtSteamPath.ReadOnly = true;
            this.txtSteamPath.Size = new System.Drawing.Size(235, 20);
            this.txtSteamPath.TabIndex = 32;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(307, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 13);
            this.label4.TabIndex = 31;
            this.label4.Text = "Steam installation path:";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(355, 51);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(100, 20);
            this.txtID.TabIndex = 30;
            this.txtID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtID.TextChanged += new System.EventHandler(this.txtID_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(346, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 13);
            this.label3.TabIndex = 28;
            this.label3.Text = "ID:";
            // 
            // lnkSteam3
            // 
            this.lnkSteam3.AutoSize = true;
            this.lnkSteam3.Location = new System.Drawing.Point(307, 33);
            this.lnkSteam3.Name = "lnkSteam3";
            this.lnkSteam3.Size = new System.Drawing.Size(43, 13);
            this.lnkSteam3.TabIndex = 29;
            this.lnkSteam3.TabStop = true;
            this.lnkSteam3.Text = "Steam3";
            // 
            // numBackups
            // 
            this.numBackups.Location = new System.Drawing.Point(341, 195);
            this.numBackups.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numBackups.Name = "numBackups";
            this.numBackups.Size = new System.Drawing.Size(50, 20);
            this.numBackups.TabIndex = 38;
            this.numBackups.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numBackups.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(307, 198);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(185, 65);
            this.label7.TabIndex = 37;
            this.label7.Text = "Keep XXXXXXXX amount of backups\r\n\r\n0 - Unlimited\r\n10 - Default\r\n1000 - Maximum";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbDelay5);
            this.groupBox1.Controls.Add(this.lbHelp);
            this.groupBox1.Controls.Add(this.rbDelay10);
            this.groupBox1.Controls.Add(this.chkAutoBoot);
            this.groupBox1.Location = new System.Drawing.Point(498, 200);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(213, 67);
            this.groupBox1.TabIndex = 39;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Auto Launch Rocksmith";
            // 
            // rbDelay5
            // 
            this.rbDelay5.AutoSize = true;
            this.rbDelay5.Checked = true;
            this.rbDelay5.Location = new System.Drawing.Point(111, 42);
            this.rbDelay5.Name = "rbDelay5";
            this.rbDelay5.Size = new System.Drawing.Size(97, 17);
            this.rbDelay5.TabIndex = 19;
            this.rbDelay5.TabStop = true;
            this.rbDelay5.Text = "5 second delay";
            this.rbDelay5.UseVisualStyleBackColor = true;
            // 
            // lbHelp
            // 
            this.lbHelp.AutoSize = true;
            this.lbHelp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbHelp.Location = new System.Drawing.Point(182, 10);
            this.lbHelp.Name = "lbHelp";
            this.lbHelp.Size = new System.Drawing.Size(29, 13);
            this.lbHelp.TabIndex = 18;
            this.lbHelp.Text = "Help";
            this.lbHelp.Click += new System.EventHandler(this.lbHelp_Click);
            // 
            // rbDelay10
            // 
            this.rbDelay10.AutoSize = true;
            this.rbDelay10.Location = new System.Drawing.Point(6, 42);
            this.rbDelay10.Name = "rbDelay10";
            this.rbDelay10.Size = new System.Drawing.Size(103, 17);
            this.rbDelay10.TabIndex = 16;
            this.rbDelay10.Text = "10 second delay";
            this.rbDelay10.UseVisualStyleBackColor = true;
            // 
            // chkAutoBoot
            // 
            this.chkAutoBoot.AutoSize = true;
            this.chkAutoBoot.Checked = true;
            this.chkAutoBoot.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAutoBoot.Location = new System.Drawing.Point(48, 19);
            this.chkAutoBoot.Name = "chkAutoBoot";
            this.chkAutoBoot.Size = new System.Drawing.Size(118, 17);
            this.chkAutoBoot.TabIndex = 15;
            this.chkAutoBoot.Text = "Enable auto launch";
            this.chkAutoBoot.UseVisualStyleBackColor = true;
            // 
            // groupAutoboot
            // 
            this.groupAutoboot.Controls.Add(this.btnEdit);
            this.groupAutoboot.Controls.Add(this.btnManage);
            this.groupAutoboot.Controls.Add(this.btnLaunch);
            this.groupAutoboot.Controls.Add(this.lbBootTime);
            this.groupAutoboot.Location = new System.Drawing.Point(13, 116);
            this.groupAutoboot.Name = "groupAutoboot";
            this.groupAutoboot.Size = new System.Drawing.Size(258, 99);
            this.groupAutoboot.TabIndex = 41;
            this.groupAutoboot.TabStop = false;
            this.groupAutoboot.Visible = false;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(132, 31);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(108, 24);
            this.btnEdit.TabIndex = 3;
            this.btnEdit.Text = "Edit Settings";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnManage
            // 
            this.btnManage.Location = new System.Drawing.Point(18, 31);
            this.btnManage.Name = "btnManage";
            this.btnManage.Size = new System.Drawing.Size(108, 24);
            this.btnManage.TabIndex = 2;
            this.btnManage.Text = "Manage Backups";
            this.btnManage.UseVisualStyleBackColor = true;
            this.btnManage.Click += new System.EventHandler(this.btnManage_Click);
            // 
            // btnLaunch
            // 
            this.btnLaunch.Location = new System.Drawing.Point(87, 60);
            this.btnLaunch.Name = "btnLaunch";
            this.btnLaunch.Size = new System.Drawing.Size(85, 24);
            this.btnLaunch.TabIndex = 1;
            this.btnLaunch.Text = "Launch Now";
            this.btnLaunch.UseVisualStyleBackColor = true;
            this.btnLaunch.Click += new System.EventHandler(this.btnLaunch_Click);
            // 
            // lbBootTime
            // 
            this.lbBootTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBootTime.Location = new System.Drawing.Point(23, 1);
            this.lbBootTime.Name = "lbBootTime";
            this.lbBootTime.Size = new System.Drawing.Size(214, 22);
            this.lbBootTime.TabIndex = 0;
            this.lbBootTime.Text = "Starting Rocksmith in 0 seconds";
            this.lbBootTime.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tmrAutoBoot
            // 
            this.tmrAutoBoot.Interval = 1000;
            this.tmrAutoBoot.Tick += new System.EventHandler(this.AutoBoot);
            // 
            // chkDelAfter
            // 
            this.chkDelAfter.AutoSize = true;
            this.chkDelAfter.Location = new System.Drawing.Point(301, 275);
            this.chkDelAfter.Name = "chkDelAfter";
            this.chkDelAfter.Size = new System.Drawing.Size(122, 17);
            this.chkDelAfter.TabIndex = 42;
            this.chkDelAfter.Text = "Delete After Restore";
            this.chkDelAfter.UseVisualStyleBackColor = true;
            // 
            // btnCheckID
            // 
            this.btnCheckID.Location = new System.Drawing.Point(461, 48);
            this.btnCheckID.Name = "btnCheckID";
            this.btnCheckID.Size = new System.Drawing.Size(54, 24);
            this.btnCheckID.TabIndex = 43;
            this.btnCheckID.Text = "Check";
            this.btnCheckID.UseVisualStyleBackColor = true;
            this.btnCheckID.Click += new System.EventHandler(this.btnCheckID_Click);
            // 
            // chkIdle
            // 
            this.chkIdle.AutoSize = true;
            this.chkIdle.Location = new System.Drawing.Point(301, 298);
            this.chkIdle.Name = "chkIdle";
            this.chkIdle.Size = new System.Drawing.Size(73, 17);
            this.chkIdle.TabIndex = 44;
            this.chkIdle.Text = "Idle Mode";
            this.chkIdle.UseVisualStyleBackColor = true;
            // 
            // niTray
            // 
            this.niTray.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.niTray.BalloonTipText = "Double-click this icon to return to the program.";
            this.niTray.BalloonTipTitle = "Rocksmith 2014 Backup - Idle Mode";
            this.niTray.Icon = ((System.Drawing.Icon)(resources.GetObject("niTray.Icon")));
            this.niTray.Text = "Rocksmith 2014 Backup";
            this.niTray.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.niTray_MouseDoubleClick);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(627, 296);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(87, 23);
            this.btnReset.TabIndex = 45;
            this.btnReset.Text = "Reset Settings";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // cmFinish
            // 
            this.cmFinish.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmFinish.Location = new System.Drawing.Point(423, 271);
            this.cmFinish.Name = "cmFinish";
            this.cmFinish.Note = "Seems right to me.";
            this.cmFinish.Size = new System.Drawing.Size(150, 51);
            this.cmFinish.TabIndex = 40;
            this.cmFinish.Text = "Apply Settings";
            this.cmFinish.UseVisualStyleBackColor = true;
            this.cmFinish.Click += new System.EventHandler(this.cmFinish_Click);
            // 
            // treeBackups
            // 
            this.treeBackups.Enabled = false;
            this.treeBackups.HotTracking = true;
            this.treeBackups.Location = new System.Drawing.Point(12, 23);
            this.treeBackups.Name = "treeBackups";
            this.treeBackups.ShowLines = false;
            this.treeBackups.Size = new System.Drawing.Size(260, 239);
            this.treeBackups.TabIndex = 24;
            this.treeBackups.BeforeSelect += new System.Windows.Forms.TreeViewCancelEventHandler(this.treeBackups_BeforeSelect);
            this.treeBackups.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeBackups_NodeMouseClick);
            // 
            // btnBackupSettings
            // 
            this.btnBackupSettings.Enabled = false;
            this.btnBackupSettings.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnBackupSettings.Location = new System.Drawing.Point(12, 268);
            this.btnBackupSettings.Name = "btnBackupSettings";
            this.btnBackupSettings.Size = new System.Drawing.Size(70, 24);
            this.btnBackupSettings.TabIndex = 23;
            this.btnBackupSettings.Text = "Backup";
            this.btnBackupSettings.UseVisualStyleBackColor = true;
            this.btnBackupSettings.DropDown_Clicked += new VistaControls.DropDownClicked(this.btnBackupSettings_DropDown_Clicked);
            this.btnBackupSettings.Click += new System.EventHandler(this.btnBackupSettings_Click);
            // 
            // trayMenu
            // 
            this.trayMenu.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.mShow,
            this.mRun,
            this.mSep,
            this.mExit});
            // 
            // mShow
            // 
            this.mShow.Index = 0;
            this.mShow.Text = "Show";
            this.mShow.Click += new System.EventHandler(this.mShow_Click);
            // 
            // mRun
            // 
            this.mRun.Index = 1;
            this.mRun.Text = "Run Rocksmith 2014";
            this.mRun.Click += new System.EventHandler(this.mRun_Click);
            // 
            // mSep
            // 
            this.mSep.Index = 2;
            this.mSep.Text = "-";
            // 
            // mExit
            // 
            this.mExit.Index = 3;
            this.mExit.Text = "Exit";
            this.mExit.Click += new System.EventHandler(this.mExit_Click);
            // 
            // cbExec
            // 
            this.cbExec.FormattingEnabled = true;
            this.cbExec.Items.AddRange(new object[] {
            "Game.exe",
            "Rocksmith.exe",
            "RS2014.exe"});
            this.cbExec.Location = new System.Drawing.Point(564, 48);
            this.cbExec.Name = "cbExec";
            this.cbExec.Size = new System.Drawing.Size(121, 21);
            this.cbExec.TabIndex = 46;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(547, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 13);
            this.label1.TabIndex = 47;
            this.label1.Text = "Rocksmith Executable:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 327);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbExec);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.chkIdle);
            this.Controls.Add(this.btnCheckID);
            this.Controls.Add(this.chkDelAfter);
            this.Controls.Add(this.groupAutoboot);
            this.Controls.Add(this.cmFinish);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.numBackups);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnBrowseBackup);
            this.Controls.Add(this.txtBackupPath);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnBrowseSteam);
            this.Controls.Add(this.txtSteamPath);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lnkSteam3);
            this.Controls.Add(this.labelSettings);
            this.Controls.Add(this.lblSeperator);
            this.Controls.Add(this.btnLaunchGame);
            this.Controls.Add(this.treeBackups);
            this.Controls.Add(this.btnBackupSettings);
            this.Controls.Add(this.btnAbout);
            this.Controls.Add(this.btnSettings);
            this.Controls.Add(this.labelBackups);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(740, 365);
            this.MinimumSize = new System.Drawing.Size(300, 365);
            this.Name = "MainForm";
            this.Opacity = 0D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rocksmith 2014 Backup";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            this.SizeChanged += new System.EventHandler(this.MainForm_SizeChanged);
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.numBackups)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupAutoboot.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private VistaControls.ExplorerTreeview treeBackups;
        internal System.ComponentModel.BackgroundWorker BackupAllFiles;
        internal System.Windows.Forms.MenuItem mDeleteSelectedBackup;
        internal System.Windows.Forms.MenuItem mSep2;
        internal System.Windows.Forms.MenuItem mRestoreSelectedBackup;
        internal System.Windows.Forms.MenuItem mSep3;
        internal System.Windows.Forms.MenuItem mCreateBackup;
        internal System.Windows.Forms.ContextMenu cmTreeview;
        internal System.Windows.Forms.MenuItem mDelAll;
        private VistaControls.SplitButton btnBackupSettings;
        internal System.Windows.Forms.MenuItem mS;
        internal System.Windows.Forms.MenuItem mRestoreBackup;
        internal System.Windows.Forms.MenuItem MenuItem2;
        internal System.Windows.Forms.MenuItem mCreate;
        internal System.Windows.Forms.ContextMenu cmBackups;
        internal System.Windows.Forms.MenuItem mDelete;
        internal System.Windows.Forms.Button btnAbout;
        internal System.Windows.Forms.Button btnSettings;
        internal System.Windows.Forms.Label labelBackups;
        private System.Windows.Forms.Button btnLaunchGame;
        internal System.Windows.Forms.MenuItem mDelSelected;
        internal System.Windows.Forms.Label labelSettings;
        internal System.Windows.Forms.Label lblSeperator;
        private System.Windows.Forms.Button btnBrowseBackup;
        private System.Windows.Forms.TextBox txtBackupPath;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnBrowseSteam;
        private System.Windows.Forms.TextBox txtSteamPath;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel lnkSteam3;
        private System.Windows.Forms.NumericUpDown numBackups;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbDelay5;
        private System.Windows.Forms.Label lbHelp;
        private System.Windows.Forms.RadioButton rbDelay10;
        private System.Windows.Forms.CheckBox chkAutoBoot;
        private CommandLink cmFinish;
        private System.Windows.Forms.GroupBox groupAutoboot;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnManage;
        private System.Windows.Forms.Button btnLaunch;
        private System.Windows.Forms.Label lbBootTime;
        private System.Windows.Forms.Timer tmrAutoBoot;
        private System.Windows.Forms.CheckBox chkDelAfter;
        private System.Windows.Forms.Button btnCheckID;
        private System.Windows.Forms.CheckBox chkIdle;
        private System.Windows.Forms.NotifyIcon niTray;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.ContextMenu trayMenu;
        private System.Windows.Forms.MenuItem mShow;
        private System.Windows.Forms.MenuItem mRun;
        private System.Windows.Forms.MenuItem mSep;
        private System.Windows.Forms.MenuItem mExit;
        private System.Windows.Forms.ComboBox cbExec;
        private System.Windows.Forms.Label label1;
    }
}