using Microsoft.Win32;
using Rocksmith2014Backup.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rocksmith2014Backup
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        RegistryKey SteamPath = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Valve\\Steam");
        RegistryKey SteamProfiles = Registry.CurrentUser.OpenSubKey("Software\\Valve\\Steam\\Users");
        bool SettingsShown = false;
        int Boot;
        int BackupsMade = 0;
        List<string> getBackupFolders = new List<string>();

        #region Form
        // These are the code for the form when shown + size changed.
        private void MainForm_Shown(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.FirstTimeSetup == true)
            {
                // First time setup.
                switch (MessageBox.Show("It appears you've launched this program for the first time. Would you like to automatically detect settings?", "Rocksmith 2014 Backup", MessageBoxButtons.YesNoCancel))
                {
                    case System.Windows.Forms.DialogResult.Yes:
                        DetectSettings();
                        SaveSettings();
                        break;
                    case System.Windows.Forms.DialogResult.Cancel:
                        Environment.Exit(0);
                        break;
                }
                // Expand settings for editing, and disable the backup buttons.
                btnSettings.Text = "Hide Settings";
                this.Size = new Size(740, 360);
                this.Opacity = 100;
            }
            else if (Properties.Settings.Default.IdleMode == true)
            {
                lbBootTime.Text = "Idle mode enabled";
                btnLaunch.Text = "Play game";
                niTray.Visible = true;
                this.WindowState = FormWindowState.Minimized;
                this.Opacity = 100;
            }
            else if(Properties.Settings.Default.AutoBoot == true && Properties.Settings.Default.IdleMode == false)
            {
                if (File.Exists(Application.StartupPath + "\\skipdelay.txt"))
                {
                    Boot = 0;
                }
                else
                {
                    groupAutoboot.Visible = true;
                    Boot = Properties.Settings.Default.BootDelay;
                    lbBootTime.Text = "Starting Rocksmith in " + Boot.ToString() + " seconds";
                    this.Opacity = 100;
                }
                if (!Properties.Settings.Default.AutoBoot == true)
                {
                    ToggleFormControls();
                }
                else
                {
                    tmrAutoBoot.Start();
                }
            }
            treeBackups.ContextMenu = cmTreeview;
            niTray.ContextMenu = trayMenu;
            ReloadBackups();
            LoadSettings();
        }
        private void MainForm_SizeChanged(object sender, EventArgs e)
        {
            if (this.Width >= 340)
            {
                btnSettings.Text = "Hide Settings";
                SettingsShown = true;
            }
            else
            {
                btnSettings.Text = "Show Settings";
                SettingsShown = false;
            }
        }
        private void ToggleFormControls()
        {
            btnBackupSettings.Enabled ^= true;
            btnSettings.Enabled ^= true;
            btnLaunchGame.Enabled ^= true;
            btnAbout.Enabled ^= true;
            treeBackups.Enabled ^= true;
            groupAutoboot.Visible ^= true;
        }
        #endregion

        #region Executing Code
        // These are all the important code, for 90% of the application. The buttons just call these.
        private void LoadSettings()
        {
            txtID.Text = Properties.Settings.Default.SteamID.ToString();
            txtSteamPath.Text = Properties.Settings.Default.SteamInstallDir;
            txtBackupPath.Text = Properties.Settings.Default.BackupDir;
            chkAutoBoot.Checked = Properties.Settings.Default.AutoBoot;
            numBackups.Value = Convert.ToDecimal(Properties.Settings.Default.BackupsToKeep);
            if (Properties.Settings.Default.BootDelay == 5)
            {
                rbDelay5.Checked = true;
            }else if (Properties.Settings.Default.BootDelay == 10){
                rbDelay10.Checked = true;
            }else{
                rbDelay5.Checked = true;
                Properties.Settings.Default.BootDelay = 5;
                Properties.Settings.Default.Save();
            }
            chkDelAfter.Checked = Properties.Settings.Default.DeleteAfterRestore;
            chkIdle.Checked = Properties.Settings.Default.IdleMode;
        }
        private void SaveSettings()
        {

            if (txtID.Text != "" & Int32.Parse(txtID.Text) > 0)
            {
                Properties.Settings.Default.SteamID = Int32.Parse(txtID.Text);
            }

            if (txtSteamPath.Text != "")
            {
                Properties.Settings.Default.SteamInstallDir = txtSteamPath.Text;
            }

            if (txtBackupPath.Text != "")
            {
                if (txtBackupPath.Text != Properties.Settings.Default.BackupDir)
                {
                    // Create backup Directory
                    Directory.CreateDirectory(txtBackupPath.Text);

                    // If backups are present, create the new directories from old backups.
                    if (Directory.EnumerateDirectories(Properties.Settings.Default.BackupDir).Any())
                    {
                        foreach (string backupDir in Directory.GetDirectories(Properties.Settings.Default.BackupDir))
                        {
                            // Create the directory.
                            Directory.CreateDirectory(txtBackupPath.Text + "\\" + backupDir);
                            // Move backups to new directory.
                            foreach (string backupFile in Directory.GetFiles(backupDir))
                            {
                                File.Move(backupFile, txtBackupPath.Text + backupDir + "\\" + Path.GetFileName(backupFile));
                            }
                        }
                    }

                    // Delete old backup directory.
                    Directory.Delete(Properties.Settings.Default.BackupDir);
                    Properties.Settings.Default.BackupDir = txtBackupPath.Text;
                }
            }

            if (Convert.ToInt32(numBackups.Value) != Properties.Settings.Default.BackupsToKeep)
            {
                Properties.Settings.Default.BackupsToKeep = Convert.ToInt32(numBackups.Value);
            }

            if (chkAutoBoot.Checked == true)
            {
                if (rbDelay5.Checked)
                {
                    Properties.Settings.Default.BootDelay = 5;
                }
                else if (rbDelay10.Checked)
                {
                    Properties.Settings.Default.BootDelay = 10;
                }
                else
                {
                    Properties.Settings.Default.BootDelay = 5;
                }
            }else{
                Properties.Settings.Default.BootDelay = 5;
            }

            Properties.Settings.Default.AutoBoot = chkAutoBoot.Checked;
            Properties.Settings.Default.DeleteAfterRestore = chkDelAfter.Checked;

            if (chkIdle.Checked == true)
            {
                niTray.Visible = true;
            }
            Properties.Settings.Default.IdleMode = chkIdle.Checked;

            Properties.Settings.Default.Save();
            this.Size = new Size(this.MinimumSize.Width, this.MinimumSize.Height);
            SettingsShown = false;
        }
        private void ResetSettings()
        {
            Properties.Settings.Default.FirstTimeSetup = true;
            Properties.Settings.Default.AutoBoot = false;
            Properties.Settings.Default.BootDelay = 5;
            Properties.Settings.Default.BackupsToKeep = 10;
            Properties.Settings.Default.SteamID = 0;
            Properties.Settings.Default.SteamInstallDir = "C:\\Program Files (x86)\\Steam";
            Properties.Settings.Default.BackupDir = "C:\\Games\\Rocksmith 2014 Backup";
            Properties.Settings.Default.DeleteAfterRestore = false;
            Properties.Settings.Default.IdleMode = false;
            Properties.Settings.Default.Save();
        }
        private void DetectSettings()
        {
            // Find steam directory, if not found return nothing.
            string FoundSteamDir = "";
            if ((string)SteamPath.GetValue("InstallPath".ToString()) != null)
            {
                FoundSteamDir = (string)SteamPath.GetValue("InstallPath".ToString());
                txtSteamPath.Text = FoundSteamDir;
            }
            else
            {
                MessageBox.Show("Steam wasn't detected. Specify your steam install directory in the settings.", "Rocksmith 2014 Backup", MessageBoxButtons.OK);
                txtSteamPath.Text = null;
            }

            // Attempt to find the user profile with Rocksmith 2014 using increasing integers to determine.
            int ProfilesFound = 0;
            int FoundRocksmithSaves = 0;
            string RocksmithSaveProfile = null;
            foreach (string KeyName in SteamProfiles.GetSubKeyNames())
            {
                ProfilesFound += 1;
                // Attempt to find GameID 221680
                if (Directory.Exists(FoundSteamDir + "\\userdata\\" + KeyName + "\\221680\\remote"))
                {
                    FoundRocksmithSaves += 1;
                    RocksmithSaveProfile = KeyName;
                }
            }

            if (FoundRocksmithSaves > 1)
            {
                // More than one save was found.
                MessageBox.Show("I found more than one profile with Rocksmith 2014 played. Please specify your Steam3 ID manually.", "Rocksmith 2014 Backup", MessageBoxButtons.OK);
            }else if (FoundRocksmithSaves == 1)
            {
                // Only one save was found.
                txtID.Text = RocksmithSaveProfile;
            }else if (FoundRocksmithSaves < 1)
            {
                // No saves were found.
                MessageBox.Show("I coulnd't find any profile with Rocksmith 2014 played. It might be a bug. Specify your Steam3 ID manually,", "Rocksmith 2014 Backup", MessageBoxButtons.OK);
            }

            // Set default backup location.
            txtBackupPath.Text = "C:\\Games\\Rocksmith 2014 Backup";
            // Get user input if they want to set a custom backup directory, otherwise just stick with that one.
            switch (MessageBox.Show("Would you like to specify a custom directory to store backups?\n\nDefault will be set to C:\\Games\\Rocksmith 2014 Backup", "Rocksmith 2014 Backup", MessageBoxButtons.YesNo))
            {
                case System.Windows.Forms.DialogResult.Yes:
                    FolderBrowserDialog fbd = new FolderBrowserDialog { RootFolder = Environment.SpecialFolder.MyComputer, Description = "Select a directory to store backups." };
                    switch (fbd.ShowDialog())
                    {
                        case System.Windows.Forms.DialogResult.OK:
                            txtBackupPath.Text = fbd.SelectedPath;
                            break;
                    }
                    break;
                case System.Windows.Forms.DialogResult.No:
                    if (!Directory.Exists(Properties.Settings.Default.BackupDir))
                    {
                        Directory.CreateDirectory(Properties.Settings.Default.BackupDir);
                    }

                    break;
            }
        }
        private void ReloadBackups()
        {
            // Clears the TreeView, creates the root and checks for backups made.
            treeBackups.Nodes.Clear();
            treeBackups.Nodes.Add("RocksmithBackups", "Rocksmith Backups").Tag = "RootBackups";

            if (Directory.EnumerateFileSystemEntries(Properties.Settings.Default.BackupDir).Any())
            {
                foreach (string BackupMade in Directory.GetDirectories(Properties.Settings.Default.BackupDir))
                {
                    DirectoryInfo GetBackupInfo = new DirectoryInfo(BackupMade);
                    TreeNode[] GetBackups = treeBackups.Nodes.Find("RocksmithBackups", false);
                    GetBackups[0].Nodes.Add(GetBackupInfo.Name, GetBackupInfo.Name);
                }
            }
        }
        private void DeleteSelectedBackup()
        {
            string getSelectedBackup = Properties.Settings.Default.BackupDir + "\\" + treeBackups.SelectedNode.Text;

            // If the directory exists, then delete it then remove it.
            if (Directory.Exists(getSelectedBackup))
            {
                Directory.Delete(getSelectedBackup, true);
            }else{
                MessageBox.Show("Unable to delete the selected backup, verify it exists and try again.", "Rocksmith 2014 Backup", MessageBoxButtons.OK);
            }
        }
        private void DeleteAllBackups()
        {
            switch (MessageBox.Show("Are you sure you want to delete all your backups?", "Rocksmith 2014 Backup", MessageBoxButtons.YesNo))
            {
                // Delete ALL backup folders.
                case System.Windows.Forms.DialogResult.Yes:
                    // Look for any files within the backup directory.
                    if (Directory.EnumerateFileSystemEntries(Properties.Settings.Default.BackupDir).Any())
                    {
                        // If there are, delete them all.
                        foreach (string BackupMade in Directory.GetDirectories(Properties.Settings.Default.BackupDir))
                        {
                            Directory.Delete(BackupMade, true);
                            ReloadBackups();
                        }
                    }
                    break;
            }
        }
        private void DeleteEarliestBackup()
        {
            // If Backups to keep is set to 0, then just return.
            if (Properties.Settings.Default.BackupsToKeep == 0)
            {
                return;
            }

            foreach (string findfolders in Directory.GetDirectories(Properties.Settings.Default.BackupDir))
            {
                // Count how many backups were made already.
                BackupsMade += 1;
                getBackupFolders.Add(findfolders);
            }

            if (BackupsMade == Properties.Settings.Default.BackupsToKeep)
            {
                // If there are equal backups as user defined maximum, delete the first folder (based on name).
                Directory.Delete(getBackupFolders.First(), true);
                getBackupFolders.Clear();
            }
        }
        private void MakeBackup()
        {
            string BackupName = DateTime.Now.ToString("yyyy-MM-dd-HH-mm-ss");
            if (Properties.Settings.Default.SteamID > 0) {
                // If the backups to keep are not set to 0 (unlimited), call DeleteEarliestBackup.
                if (Properties.Settings.Default.BackupsToKeep != 0) {
                    DeleteEarliestBackup();
                }
                // Create a new folder with the backup name (See above) and copy each file within the save folder into the backup folder.
                Directory.CreateDirectory(Properties.Settings.Default.BackupDir + "\\" + BackupName);
                foreach (string liveFile in Directory.GetFiles(Properties.Settings.Default.SteamInstallDir + "\\Userdata\\" + Properties.Settings.Default.SteamID + "\\" + Properties.Settings.Default.RocksmithSteamID + "\\remote"))
                {
                    File.Copy(liveFile, Path.Combine(Properties.Settings.Default.BackupDir + "\\" + BackupName + "\\" + Path.GetFileName(liveFile)));
                }
                // Reload backups.
                ReloadBackups();
            }else{
                MessageBox.Show("Steam ID is  equal to or less than 0, which is an unavailable ID. Please sppecify an ID above 0.", "Rocksmith 2014 Backup", MessageBoxButtons.OK);
            }
        }
        private void RestoreBackup()
        {
            string SaveDir = Properties.Settings.Default.SteamInstallDir + "\\userdata\\" + Properties.Settings.Default.SteamID.ToString() + "\\" + Properties.Settings.Default.RocksmithSteamID.ToString() + "\\remote";
            string SelectedBackupDir = Properties.Settings.Default.BackupDir + "\\" + treeBackups.SelectedNode.Text;
            string restBackupDir = Properties.Settings.Default.BackupDir + "\\RestoreBackup";

            // If the RestoreBackup does not exist, create it. Otherwise, delete the files within it.
            if (Directory.Exists(restBackupDir) != true)
            {
                Directory.CreateDirectory(restBackupDir);
            }

            if (Directory.EnumerateFileSystemEntries(restBackupDir).Any())
            {
                // Delete old restore backup
                foreach (string backupFileMade in Directory.GetFiles(restBackupDir))
                {
                    File.Delete(backupFileMade);
                }
            }

            foreach (string liveFile in Directory.GetFiles(SaveDir))
            {
                // Move the live save file to the restore backup.
                File.Move(liveFile, restBackupDir + "\\" + Path.GetFileName(liveFile));
            }
            
            foreach (string backupFile in Directory.GetFiles(SelectedBackupDir))
            {
                if (Properties.Settings.Default.DeleteAfterRestore == true)
                {
                    File.Move(backupFile, SaveDir + "\\" + Path.GetFileName(backupFile));
                    Directory.Delete(SelectedBackupDir, true);
                }else{
                    File.Copy(backupFile, SaveDir + "\\" + Path.GetFileName(backupFile));
                }
            }
        }
        private void LaunchGame()
        {
            // All of this is self explanitory.
            retrylaunch:
            if (File.Exists(Application.StartupPath + "\\Rocksmith.exe"))
            {
                Process.Start(Application.StartupPath + "\\Rocksmith.exe");
                return;
            }
            else if (File.Exists(Application.StartupPath + "\\Game.exe"))
            {
                Process.Start(Application.StartupPath + "\\Game.exe");
                return;
            }
            else
            {
                switch (MessageBox.Show("Rocksmith 2014 was unable to be launched. Make sure you've renamed it to \"Rocksmith.exe\" or \"Game.exe\" to properly work.", "Rocksmith 2014 Backup", MessageBoxButtons.RetryCancel))
                {
                    case System.Windows.Forms.DialogResult.Retry:
                        goto retrylaunch;
                    case System.Windows.Forms.DialogResult.Cancel:
                        return;
                }
            }
        }

        // Except for this. This is the timer for autoboot.
        private void AutoBoot(object sender, EventArgs e)
        {
            // If Boot is greater than 0, go down a second, otherwise launch the game and close.
            if (Boot > 0)
            {
                Boot -= 1;
                lbBootTime.Text = "Starting Rocksmith in " + Boot.ToString() + " seconds";
            }
            else
            {
                tmrAutoBoot.Stop();
                MakeBackup();
                LaunchGame();
                Environment.Exit(0);
            }
        }
        #endregion

        #region Main Form Buttons
        // These are the 4 buttons on the main form.
        private void btnBackupSettings_Click(object sender, EventArgs e)
        {
            MakeBackup();
        }
        private void btnBackupSettings_DropDown_Clicked()
        {
            cmBackups.Show(btnBackupSettings, new Point(btnBackupSettings.Width - 25, btnBackupSettings.Height));
        }
        private void btnSettings_Click(object sender, EventArgs e)
        {
            if (SettingsShown == false) {
                btnSettings.Text = "Hide Settings";
                this.Size = new Size(740, 360);
                SettingsShown = true;
            }else{
                btnSettings.Text = "Show Settings";
                this.Size = new Size(290, 360);
                SettingsShown = false;
            }
        }
        private void btnLaunchGame_Click(object sender, EventArgs e)
        {
            MakeBackup();
            LaunchGame();
        }
        private void btnAbout_Click(object sender, EventArgs e)
        {
            Form frmAbout = new AboutForm();
            frmAbout.Show();
        }
        #endregion

        #region TreeView Code
        // These are for usability on the TreeForm, Right click to select and disallow root node selection.
        private void treeBackups_BeforeSelect(object sender, TreeViewCancelEventArgs e)
        {
            if (e.Node.Parent == null)
            {
                e.Cancel = true;
                return;
            }else{
                mRestoreBackup.Enabled = true;
                mDeleteSelectedBackup.Enabled = true;
                mDelSelected.Enabled = true;
                mRestoreBackup.Enabled = true;
                mRestoreSelectedBackup.Enabled = true;
            }
        }
        private void treeBackups_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                treeBackups.SelectedNode = e.Node;
            }
        }
        #endregion

        #region Settings
        // The controls for the Settings.
        private void txtID_TextChanged(object sender, EventArgs e)
        {
            var txtSender = (TextBox)sender;
            var curPos = txtSender.SelectionStart;
            txtSender.Text = Regex.Replace(txtSender.Text, "[^0-9]", "");
            txtSender.SelectionStart = curPos;
        }
        private void btnCheckID_Click(object sender, EventArgs e)
        {
            retryIDCheck:
            if (txtSteamPath.Text == "")
            {
                MessageBox.Show("Please specify a Steam directory below before trying to check your Steam3 ID.", "Rocksmith 2014 Backup", MessageBoxButtons.OK);
                return;
            }
            if (txtID.Text != "")
            {
                if (Directory.Exists(txtSteamPath.Text + "\\userdata\\" + txtID.Text + "\\221680\\remote"))
                {
                    if (Directory.EnumerateFileSystemEntries(txtSteamPath.Text + "\\userdata\\" + txtID.Text +"\\221680\\remote").Any())
                    {
                        MessageBox.Show("Steam3 ID \"" + txtID.Text + "\" has Rocksmith 2014 save files present.", "Rocksmith 2014 Backup", MessageBoxButtons.OK);
                    }else{
                        switch (MessageBox.Show("Steam3 ID \"" + txtID.Text + "\" does not have Rocksmith 2014 saves present.", "Rocksmith 2014 Backup", MessageBoxButtons.RetryCancel))
                        {
                            case System.Windows.Forms.DialogResult.Retry:
                                goto retryIDCheck;
                        }
                    }
                } else {
                    switch (MessageBox.Show("Steam3 ID \"" + txtID.Text + "\" is not a local profile for Steam.", "Rocksmith 2014 Backup", MessageBoxButtons.RetryCancel))
                    {
                        case System.Windows.Forms.DialogResult.Retry:
                            goto retryIDCheck;
                    }
                }
            }
        }
        private void btnBrowseSteam_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog { RootFolder = Environment.SpecialFolder.CommonProgramFiles, Description = "Select your Steam installation directory." };
            switch (fbd.ShowDialog())
            {
                case System.Windows.Forms.DialogResult.OK:
                    txtSteamPath.Text = fbd.SelectedPath;
                    break;
            }
        }
        private void btnBrowseBackup_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog { RootFolder = Environment.SpecialFolder.MyComputer, Description = "Select a folder where backups will be stored." };
            switch (fbd.ShowDialog())
            {
                case System.Windows.Forms.DialogResult.OK:
                    txtBackupPath.Text = fbd.SelectedPath + "\\Rocksmith 2014 Backup";
                    break;
            }
        }
        private void lbHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This option makes a backup & boots into Rocksmith 2014 without having to click extra buttons. This is useful for making automatic backups when you launch Steam by naming this program \"Rocksmith2014.exe\" and putting it into the Rocksmith 2014 folder, while renaming the old Rocksmith 2014 executable to \"Rocksmith.exe\" or \"Game.exe\".\n\nYou can bypass the delay by making a Text file in the same folder as this program with the name \"skipdelay.txt\".", "Rocksmith 2014 Backup", MessageBoxButtons.OK);
        }
        private void cmFinish_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.FirstTimeSetup == true)
            {
                if (txtID.Text == "")
                {
                    if (Int32.Parse(txtID.Text) == 0)
                    {
                        MessageBox.Show("Please enter a valid Steam3ID", "Rocksmith 2014 Backup", MessageBoxButtons.OK);
                        return;
                    }
                    MessageBox.Show("Please enter a valid Steam3ID", "Rocksmith 2014 Backup", MessageBoxButtons.OK);
                    return;
                }
                if (txtSteamPath.Text == "")
                {
                    MessageBox.Show("Please enter your Steam installation path", "Rocksmith 2014 Backup", MessageBoxButtons.OK);
                    return;
                }
                if (txtBackupPath.Text == "")
                {
                    // Just use default.
                    if (Properties.Settings.Default.BackupDir == "")
                    {
                        Properties.Settings.Default.BackupDir = "C:\\Games\\Rocksmith 2014 Backup";
                    }
                }
                btnBackupSettings.Enabled = true;
                btnSettings.Enabled = true;
                btnLaunchGame.Enabled = true;
                btnAbout.Enabled = true;
                treeBackups.Enabled = true;
                Properties.Settings.Default.FirstTimeSetup = false;
            }
            SaveSettings();
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.ResetDebug == true)
            {
                ResetSettings();
                Environment.Exit(0);
                return;
            }
            switch (MessageBox.Show("Really reset settings to default? Application will exit", "Rocksmith 2014 Backup", MessageBoxButtons.YesNo))
            {
                case System.Windows.Forms.DialogResult.Yes:
                    ResetSettings();
                    Application.Restart();
                    break;
            }
        }
        #endregion

        #region AutoBoot Options
        // These are the options that appear on AutoBoot.
        private void btnManage_Click(object sender, EventArgs e)
        {
            tmrAutoBoot.Stop();
            ToggleFormControls();
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            tmrAutoBoot.Stop();
            LoadSettings();
            ToggleFormControls();
            this.Size = new Size(740, 360);
            SettingsShown = true;
        }
        private void btnLaunch_Click(object sender, EventArgs e)
        {
            tmrAutoBoot.Stop();
            MakeBackup();
            LaunchGame();
            Environment.Exit(0);
        }
        #endregion

        #region SplitButton ContextMenu
        // The options on the SplitButton drop-down menu.
        private void mCreate_Click(object sender, EventArgs e)
        {
            MakeBackup();
        }
        private void mRestoreBackup_Click(object sender, EventArgs e)
        {
            RestoreBackup();
        }
        private void mDelSelected_Click(object sender, EventArgs e)
        {
            DeleteSelectedBackup();
        }
        private void mDelAll_Click(object sender, EventArgs e)
        {
            DeleteAllBackups();
        }
        #endregion

        #region TreeView ContextMenu
        // The TreeView ContextMenu.
        private void mCreateBackup_Click(object sender, EventArgs e)
        {
            MakeBackup();
        }
        private void mRestoreSelectedBackup_Click(object sender, EventArgs e)
        {
            RestoreBackup();
        }
        private void mDeleteSelectedBackup_Click(object sender, EventArgs e)
        {
            DeleteSelectedBackup();
        }
        #endregion

        #region Idle-Mode
        private void MainForm_Resize(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.IdleMode == false)
            {
                return;
            }
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.Hide();
                niTray.ShowBalloonTip(5000);
            }
        }
        private void niTray_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
        }

        private void mShow_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            this.Show();
        }
        private void mRun_Click(object sender, EventArgs e)
        {
            MakeBackup();
            LaunchGame();
        }
        private void mExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
        #endregion
    }
}
