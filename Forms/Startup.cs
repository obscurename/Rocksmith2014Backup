using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;
using System.Diagnostics;
using Microsoft.Win32;

namespace RSBackup.Forms
{
    public partial class Startup : Form
    {
        public Startup()
        {
            InitializeComponent();
        }

        Form mainForm = new frmMain();
        Form setupForm = new Setup();
        Form launchForm = new LaunchGame();
        RegistryKey SteamPath = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Valve\\Steam");
        RegistryKey SteamProfiles = Registry.CurrentUser.OpenSubKey("Software\\Valve\\Steam\\Users");
        
        private void Startup_Load(object sender, EventArgs e)
        {
            // Check first time setup, if not exit this. Otherwise, reset opacity.
            if (Properties.Settings.Default.FirstTimeSetup == false)
            {
                return;
            } else {
                this.Opacity = 100;

                // Find steam directory, if not found return "null"
                if ((string)SteamPath.GetValue("InstallPath".ToUpper()) != null)
                {
                     Properties.Settings.Default.SteamLocation = (string)SteamPath.GetValue("InstallPath".ToUpper());
                }else{
                    MessageBox.Show("Steam wasn't detected. Specify your steam install directory in the Setup form.", "Rocksmith 2014 Backup", MessageBoxButtons.OK);
                    simpleSetup.Enabled = false;
                    Properties.Settings.Default.SteamLocation = null;
                }

                // Attempt to find the user profile with Rocksmith 2014
                int ProfilesFound = 0;
                int FoundRocksmithSaves = 0;
                foreach (string KeyName in SteamProfiles.GetSubKeyNames())
                {
                 ProfilesFound +=1;   
                    // Attempt to find GameID 221680
                    if (!Directory.Exists(SteamPath + "\\Userdata\\" + KeyName + "\\221680\\remote")){
                        return;
                    }else{
                        FoundRocksmithSaves += 1;
                        Properties.Settings.Default.SteamID = Int32.Parse(KeyName);
                    }
                }
                if(ProfilesFound > 1){
                    // More than 1 profiles found.
                    if (FoundRocksmithSaves > 1)
                    {
                        MessageBox.Show("I found more than one profile with Rocksmith 2014 save files. Please specify your profile in the Setup form.", "Rocksmith 2014 Backup", MessageBoxButtons.OK);
                        simpleSetup.Enabled = false;
                    }
                }else if(ProfilesFound < 1){
                    // No profiles were found.
                    MessageBox.Show("No profiles were detected. Specify your Steam3 ID in the Setup form.", "Rocksmith 2014 Backup", MessageBoxButtons.OK);
                    simpleSetup.Enabled = false;
                    Properties.Settings.Default.SteamID = 0;
                }else{
                    // Just one profile found. Double check the remote file.
                    if (!Directory.Exists(SteamPath + "\\Userdata\\" + Properties.Settings.Default.SteamID + "\\221680\\remote"))
                    {
                        MessageBox.Show("Found profile does not have a Rocksmith 2014 save. This doesn't support non-steam, but will function just in case there was an error.\n\nIf this is a bug, please submit a Issue on Github -> https://www.github.com/obscuredname/RocksmithBackup", "Rocksmith 2014 Backup", MessageBoxButtons.OK);
                        simpleSetup.Enabled = false;
                    }
                }
            }
        }

        private void Startup_Shown(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.FirstTimeSetup == false) {
                if (!Properties.Settings.Default.AutoBoot == true) { 
                // Auto boot enabled. Check for "skipdelay.txt"
                    if (File.Exists(Application.StartupPath + "\\skipdelay.txt"))
                    {   

                    }else{
                        // File not found, have a delay.
                        launchForm.Show();
                        this.Hide();
                    }
                }
                else
                {
                    mainForm.Show();
                    this.Hide();
                }
            }
        }

        private void simpleSetup_Click(object sender, EventArgs e)
        {
            this.Hide();
            setupForm.Show();
        }

        private void customSetup_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.AdvanceSetup = true;
            this.Hide();
            setupForm.Show();
        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {
            var txtSender = (TextBox)sender;
            var curPos = txtSender.SelectionStart;
            txtSender.Text = Regex.Replace(txtSender.Text, "[^0-9]", "");
            txtSender.SelectionStart = curPos;
        }

        private void lnkSteam3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Generally, a Steam3 ID is U:X:YYYYYYYY. The numbers required are the numbers where the Y's are." + Environment.NewLine + Environment.NewLine + "You'll be directed to a website to find your Steam3 ID.", "Steam3 ID");
            Process.Start("https://steamid.co/");
        }

        
    }
}
