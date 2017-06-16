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
        int Boot = 5;

        private void MainForm_Shown(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.FirstTimeSetup == true)
            {
                Directory.CreateDirectory(Properties.Settings.Default.BackupDir);
                // First time setup.
                switch (MessageBox.Show("It appears you've launched this program for the first time. Would you like to automatically detect settings?", "Rocksmith 2014 Backup", MessageBoxButtons.YesNoCancel))
                {
                    case System.Windows.Forms.DialogResult.Yes:
                        DetectSettings();
                        break;
                    case System.Windows.Forms.DialogResult.Cancel:
                        Environment.Exit(0);
                        break;
                }
                //// Expand settings for editing, and disable the backup buttons.
                btnSettings.Text = "Hide Settings";
                this.Size = new Size(740, 360);
                this.Opacity = 100;
            }
            else
            {
                if (File.Exists(Application.StartupPath + "\\skipdelay.txt"))
                {
                    Boot = 0;
                }
                else
                {
                    Boot = Properties.Settings.Default.BootDelay;
                    lbBootTime.Text = "Starting Rocksmith in " + Boot.ToString() + " seconds.";
                    this.Opacity = 100;
                }
                if (!Properties.Settings.Default.AutoBoot == true)
                {
                    btnBackupSettings.Enabled = true;
                    btnSettings.Enabled = true;
                    btnLaunchGame.Enabled = true;
                    btnAbout.Enabled = true;
                    treeBackups.Enabled = true;
                }
                else
                {
                    groupAutoboot.Visible = true;
                    tmrAuto.Start();
                }
            }
            treeBackups.ContextMenu = cmTreeview;
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
        }
        private void SaveSettings()
        {
            int ID = 0;
            if (txtID.Text != "" & Int32.Parse(txtID.Text) > 0)
            {
                ID = Int32.Parse(txtID.Text);
                if (ID > 0)
                {
                    Properties.Settings.Default.SteamID = Int32.Parse(txtID.Text);
                }
            }
            if (txtSteamPath.Text != "")
            {
                Properties.Settings.Default.SteamInstallDir = txtSteamPath.Text;
            }
            if (txtBackupPath.Text != "")
            {
                if (txtBackupPath.Text != Properties.Settings.Default.BackupDir)
                {
                    // Move backups to new directory.
                    foreach (string backupFile in Directory.GetFiles(Properties.Settings.Default.BackupDir))
                    {
                        File.Copy(backupFile, Path.Combine(txtBackupPath.Text));
                    }
                    Properties.Settings.Default.BackupDir = txtBackupPath.Text;
                }
                Properties.Settings.Default.BackupDir = txtBackupPath.Text;
            }
            if (numBackups.Value == Properties.Settings.Default.BackupsToKeep)
            {
                // Intentionally do nothing. Will fix this in the future.
            }
            else
            {
                Properties.Settings.Default.BackupsToKeep = Convert.ToInt32(numBackups.Value);
            }
            if (chkAutoBoot.Checked)
            {
                Properties.Settings.Default.AutoBoot = true;
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
            }
            if (chkDelAfter.Checked == true)
            {
                Properties.Settings.Default.DeleteAfterRestore = true;
            }
            else
            {
                Properties.Settings.Default.DeleteAfterRestore = false;
            }
            Properties.Settings.Default.Save();
            this.Size = new Size(this.MinimumSize.Width, this.MinimumSize.Height);
        }
        private void DetectSettings()
        {
            // Find steam directory, if not found return "null"
            string FoundSteamDir = "";
            if ((string)SteamPath.GetValue("InstallPath".ToString()) != null)
            {
                FoundSteamDir = (string)SteamPath.GetValue("InstallPath".ToString());
                txtSteamPath.Text = FoundSteamDir;
            }
            else
            {
                MessageBox.Show("Steam wasn't detected. Specify your steam install directory in the settings.", "Rocksmith 2014 Backup", MessageBoxButtons.OK);
                txtSteamPath.Text = "";
            }

            // Attempt to find the user profile with Rocksmith 2014
            int ProfilesFound = 0;
            int FoundRocksmithSaves = 0;
            string RocksmithSaveProfile = "";
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
            if (ProfilesFound > 1 & FoundRocksmithSaves > 1)
            {
                MessageBox.Show("I found more than one profile with Rocksmith 2014 played. Please specify your Steam3 ID manually.", "Rocksmith 2014 Backup", MessageBoxButtons.OK);
            }
            if (FoundRocksmithSaves == 1)
            {
                txtID.Text = RocksmithSaveProfile;
            }
            if (FoundRocksmithSaves < 1)
            {
                MessageBox.Show("I coulnd't find any profile with Rocksmith 2014 played. It might be a bug. Specify your Steam3 ID manually,", "Rocksmith 2014 Backup", MessageBoxButtons.OK);
            }
            txtBackupPath.Text = "C:\\Games\\Rocksmith 2014 Backup";
        }
        private void ReloadBackups()
        {
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
            if (Directory.Exists(Properties.Settings.Default.BackupDir + "\\" + treeBackups.SelectedNode.Text))
            {
                Directory.Delete(Properties.Settings.Default.BackupDir + "\\" + treeBackups.SelectedNode.Text, true);
            }
        }
        private void DeleteAllBackups()
        {
            switch (MessageBox.Show("Are you sure you want to delete all your backups?", "Rocksmith 2014 Backup", MessageBoxButtons.YesNo))
            {
                case System.Windows.Forms.DialogResult.Yes:
                    if (Directory.EnumerateFileSystemEntries(Properties.Settings.Default.BackupDir).Any())
                    {
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
            int BackupsMade = 0;
            List<string> getFolders = new List<string>();
            foreach (string findfolders in Directory.GetDirectories(Properties.Settings.Default.BackupDir))
            {
                // Count how many backups were made already.
                BackupsMade += 1;
                getFolders.Add(findfolders);
            }
            if (Properties.Settings.Default.BackupsToKeep == 0)
            {
                BackupsMade = 0;
                getFolders.Clear();
                return;
            }
            if (BackupsMade == Properties.Settings.Default.BackupsToKeep)
            {
                // If there are equal backups as user defined maximum, delete the first folder.
                Directory.Delete(getFolders.First(), true);
                getFolders.Clear();
            }
        }
        private void MakeBackup()
        {
            if (Properties.Settings.Default.SteamID > 0) {
                if (Properties.Settings.Default.BackupsToKeep != 0) {
                DeleteEarliestBackup();
                }
                string BackupName = DateTime.Now.ToString("yyyy-MM-dd-HH-mm-ss");
                Directory.CreateDirectory(Properties.Settings.Default.BackupDir + "\\" + BackupName);
                foreach (string liveFile in Directory.GetFiles(Properties.Settings.Default.SteamInstallDir + "\\Userdata\\" + Properties.Settings.Default.SteamID + "\\" + Properties.Settings.Default.RocksmithSteamID + "\\remote"))
                {
                    File.Copy(liveFile, Path.Combine(Properties.Settings.Default.BackupDir + "\\" + BackupName + "\\" + Path.GetFileName(liveFile)));
                }
                ReloadBackups();
            }else{
                MessageBox.Show("Steam ID is  equal to or less than 0, which is an unavailable ID. Please sppecify an ID above 0.", "Rocksmith 2014 Backup", MessageBoxButtons.OK);
            }
        }
        private void RestoreBackup()
        {
            string SaveDir = Properties.Settings.Default.SteamInstallDir + "\\userdata\\" + Properties.Settings.Default.SteamID.ToString() + "\\" + Properties.Settings.Default.RocksmithSteamID.ToString() + "\\remote";
            string SelectedBackupDir = Properties.Settings.Default.BackupDir + "\\" + treeBackups.SelectedNode.Text;
            foreach (string liveFile in Directory.GetFiles(SaveDir))
            {
                File.Delete(liveFile);
            }
            
            foreach (string backupFile in Directory.GetFiles(SelectedBackupDir))
            {
                File.Copy(backupFile, SaveDir);
            }
            if (Properties.Settings.Default.DeleteAfterRestore == true)
            {
                Directory.Delete(SelectedBackupDir, true);
            }
        }
        private void LaunchGame()
        {
            if (File.Exists(Application.StartupPath + "\\Rocksmith.exe"))
            {
                Process.Start(Application.StartupPath + "\\Rocksmith.exe");
            }
            else if (File.Exists(Application.StartupPath + "\\Game.exe"))
            {
                Process.Start(Application.StartupPath + "\\Game.exe");
            }
            else
            {
                MessageBox.Show("Rocksmith was unable to be launched. Make sure you've renamed it to \"Rocksmith.exe\" or \"Game.exe\" to properly work.", "Unable to launch.", MessageBoxButtons.OK);
            }
        }

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
            LaunchGame();
        }
        private void btnAbout_Click(object sender, EventArgs e)
        {
            Form frmAbout = new AboutForm();
            frmAbout.Show();
        }

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

        private void txtID_TextChanged(object sender, EventArgs e)
        {
            var txtSender = (TextBox)sender;
            var curPos = txtSender.SelectionStart;
            txtSender.Text = Regex.Replace(txtSender.Text, "[^0-9]", "");
            txtSender.SelectionStart = curPos;
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
                    txtBackupPath.Text = fbd.SelectedPath;
                    break;
            }
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
        private void btnManage_Click(object sender, EventArgs e)
        {
            tmrAuto.Stop();
            btnBackupSettings.Enabled = true;
            btnSettings.Enabled = true;
            btnLaunchGame.Enabled = true;
            btnAbout.Enabled = true;
            treeBackups.Enabled = true;
            groupAutoboot.Visible = false;
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            tmrAuto.Stop();
            LoadSettings();
            btnBackupSettings.Enabled = true;
            btnSettings.Enabled = true;
            btnLaunchGame.Enabled = true;
            btnAbout.Enabled = true;
            treeBackups.Enabled = true;
            groupAutoboot.Visible = false;
            this.Size = new Size(740, 360);
            SettingsShown = true;
        }
        private void btnLaunch_Click(object sender, EventArgs e)
        {
            tmrAuto.Stop();
            MakeBackup();
            LaunchGame();
            Environment.Exit(0);
        }

        private void tmrAuto_Tick(object sender, EventArgs e)
        {
            if (Boot > 0)
            {
                Boot -= 1;
                lbBootTime.Text = "Starting Rocksmith in " + Boot.ToString() + " seconds.";
            }
            else
            {
                tmrAuto.Stop();
                MakeBackup();
                LaunchGame();
                Environment.Exit(0);
            }
        }

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

        private void lbHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This option makes a backup & boots into Rocksmith 2014 without having to click extra buttons. This is useful for making automatic backups when you launch Steam by naming this program \"Rocksmith2014.exe\" and putting it into the Rocksmith 2014 folder, while renaming the old Rocksmith 2014 executable to \"Rocksmith.exe\" or \"Game.exe\".\n\nYou can bypass the delay by making a Text file in the same folder as this program with the name \"skipdelay.txt\".", "Rocksmith 2014 Backup", MessageBoxButtons.OK);
        }
    }
}
