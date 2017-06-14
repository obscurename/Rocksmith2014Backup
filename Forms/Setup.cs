using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RSBackup.Forms
{
    public partial class Setup : Form
    {
        public Setup()
        {
            InitializeComponent();
        }

        private void Setup_Load(object sender, EventArgs e)
        {

        }

        private void lbHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Autoboot Rocksmith 2014 on launch instead of going to the backup manager.\n\nWhen No delay is selected, the only way to bypass it is to create a new text document named \"skipdelay.txt\" in the same folder as this program.", "Rocksmith 2014 Backup", MessageBoxButtons.OK);
        }

        private void chkID_CheckedChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Thought you could disable the one string that requires the user input?", "Not on my watch", MessageBoxButtons.OK);
        }

        private void chkSteamPath_CheckedChanged(object sender, EventArgs e)
        {
            txtSteamPath.Text = Properties.Settings.Default.SteamLocation;
            btnBrowseSteam.Enabled ^= true;
        }

        private void chkBackupPath_CheckedChanged(object sender, EventArgs e)
        {
            txtBackupPath.Text = Properties.Settings.Default.BackupLocation;
            btnBrowseBackup.Enabled ^= true;
        }

        private void lnkSteam3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Generally, a Steam3 ID is U:X:YYYYYYYY. The numbers required are the numbers where the Y's are." + Environment.NewLine + Environment.NewLine + "You'll be directed to a website to find your Steam3 ID.", "Steam3 ID");
            Process.Start("https://steamid.co/");
        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {
            var txtSender = (TextBox)sender;
            var curPos = txtSender.SelectionStart;
            txtSender.Text = Regex.Replace(txtSender.Text, "[^0-9]", "");
            txtSender.SelectionStart = curPos;
        }

    }
}
