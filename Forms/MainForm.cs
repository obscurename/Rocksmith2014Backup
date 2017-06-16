using Microsoft.Win32;
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
        int Boot = 5;

        private void MainForm_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.FirstTimeSetup == true)
            {
                //// First time setup.
                //switch (MessageBox.Show("It appears you've launched this program for the first time. Would you like to automatically detect settings?", "Rocksmith 2014 Backup", MessageBoxButtons.YesNoCancel))
                //{
                //    case System.Windows.Forms.DialogResult.Yes:
                //        DetectSettings();
                //        break;
                //    case System.Windows.Forms.DialogResult.Cancel:
                //        Application.Exit();
                //        break;
                //}
                //// Expand settings for editing, and disable the backup buttons.
            }
            else
            {
                Boot = Properties.Settings.Default.BootDelay;
                if (!Properties.Settings.Default.AutoBoot == true)
                {
                    btnBackupSettings.Enabled = true;
                    btnSettings.Enabled = true;
                    btnLaunchGame.Enabled = true;
                    btnAbout.Enabled = true;
                    treeBackups.Enabled = true;
                }else{
                    groupAutoboot.Visible = true;
                    tmrAuto.Start();

                }

            }

            // Add ContextMenu to TreeView
            treeBackups.ContextMenu = cmTreeview;
            ReloadBackups();
        }

        private void MainForm_SizeChanged(object sender, EventArgs e)
        {
            if (this.Width >= 340)
            {
                btnSettings.Text = "Hide Settings";
            }
            else
            {
                btnSettings.Text = "Show Settings";
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
        }
        private void DetectSettings()
        {
            // Find steam directory, if not found return "null"
            if ((string)SteamPath.GetValue("InstallPath".ToUpper()) != null)
            {
                Properties.Settings.Default.SteamInstallDir = (string)SteamPath.GetValue("InstallPath".ToUpper());
            }
            else
            {
                MessageBox.Show("Steam wasn't detected. Specify your steam install directory in the Setup form.", "Rocksmith 2014 Backup", MessageBoxButtons.OK);
                Properties.Settings.Default.SteamInstallDir = null;
            }

            // Attempt to find the user profile with Rocksmith 2014
            int ProfilesFound = 0;
            int FoundRocksmithSaves = 0;
            int RocksmithSaveProfile = 0;
            foreach (string KeyName in SteamProfiles.GetSubKeyNames())
            {
                ProfilesFound += 1;
                // Attempt to find GameID 221680
                if (!Directory.Exists(SteamPath + "\\Userdata\\" + KeyName + "\\221680\\remote"))
                {
                    return;
                }
                else
                {
                    FoundRocksmithSaves += 1;
                    RocksmithSaveProfile = Int32.Parse(KeyName);
                }
            }
            if (ProfilesFound > 1)
            {
                // More than 1 profiles found.
                if (FoundRocksmithSaves > 1)
                {
                    MessageBox.Show("I found more than one profile with Rocksmith 2014 save files. Please specify your profile in the Setup form.", "Rocksmith 2014 Backup", MessageBoxButtons.OK);
                }
                else if (FoundRocksmithSaves == 1)
                {
                    Properties.Settings.Default.SteamID = RocksmithSaveProfile;
                }
            }
            else if (ProfilesFound < 1)
            {
                // No profiles were found.
                MessageBox.Show("No profiles were detected. Specify your Steam3 ID in the Setup form.", "Rocksmith 2014 Backup", MessageBoxButtons.OK);
                Properties.Settings.Default.SteamID = 0;
            }
            else if (ProfilesFound == 1)
            {
                // Just one profile found. Double check the remote file.
                if (!Directory.Exists(SteamPath + "\\Userdata\\" + Properties.Settings.Default.SteamID + "\\221680\\remote"))
                {
                    MessageBox.Show("Found profile does not have a Rocksmith 2014 save. This doesn't support non-steam, but will function just in case there was an error.\n\nIf this is a bug, please submit a Issue on Github -> https://www.github.com/obscuredname/RocksmithBackup", "Rocksmith 2014 Backup", MessageBoxButtons.OK);
                }
            }

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
                Directory.Delete(Properties.Settings.Default.BackupDir + "\\" + treeBackups.SelectedNode.Text);
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
            if (BackupsMade == Properties.Settings.Default.BackupsToKeep)
            {
                // If there are equal backups as user defined maximum, delete the first folder.
                Directory.Delete(getFolders.First(), true);
                getFolders.Clear();
            }
        }
        private void MakeBackup()
        {
            DeleteEarliestBackup();
            if (Properties.Settings.Default.SteamID > 0) {
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
            if (this.Width >= 340) {
                btnSettings.Text = "Hide Settings";
                this.Size = new Size(740, 360);
            }else{
                btnSettings.Text = "Show Settings";
                this.Size = new Size(290, 360);
            }
        }

        private void btnLaunchGame_Click(object sender, EventArgs e)
        {
            LaunchGame();
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {

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
                Properties.Settings.Default.BackupDir = txtBackupPath.Text;
            }
            if (numBackups.Value == Properties.Settings.Default.BackupsToKeep)
            {
                //Will fix this in the future.
            }else{
                Properties.Settings.Default.BackupsToKeep = Convert.ToInt32(numBackups.Value);
            }
            if (chkAutoBoot.Checked)
            {
                Properties.Settings.Default.AutoBoot = true;
                if (rbDelay5.Checked){
                    Properties.Settings.Default.BootDelay = 5;
                }else if (rbDelay10.Checked){
                    Properties.Settings.Default.BootDelay = 10;
                }else{
                    Properties.Settings.Default.BootDelay = 5;
                }
            }
            Properties.Settings.Default.Save();
            this.Size = new Size(this.MinimumSize.Width, this.MinimumSize.Height);
        }

        private void btnManage_Click(object sender, EventArgs e)
        {
            tmrAuto.Stop();
            groupAutoboot.Visible = false;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            tmrAuto.Stop();
            groupAutoboot.Visible = false;
            this.Size = new Size(740, 360);
        }

        private void btnLaunch_Click(object sender, EventArgs e)
        {
            tmrAuto.Stop();
            LaunchGame();
            Application.Exit();
        }

        private void tmrAuto_Tick(object sender, EventArgs e)
        {
            if (Boot != 0)
            {
                Boot -= 1;
                lbBootTime.Text = "Starting Rocksmith in " + Boot.ToString() + " seconds.";
            }
            else
            {
                LaunchGame();
                Application.Exit();
            }
        }
    }
}
