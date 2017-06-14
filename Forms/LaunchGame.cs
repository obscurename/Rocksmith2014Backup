using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RSBackup.Forms
{
    public partial class LaunchGame : Form
    {

        int Delay = 10;

        public LaunchGame()
        {
            InitializeComponent();
        }

        private void LaunchGame_Load(object sender, EventArgs e)
        {
            tmrDelay.Start();
        }

        private void tmrDelay_Tick(object sender, EventArgs e)
        {
            if (Delay == 0)
            {
                //Launch Rocksmith
                tmrDelay.Stop();
                
            } else {
                Delay -= 1;
                lbTime.Text = "Launching Rocksmith 2014 in " + Delay + " seconds";
            }
        }
    }
}
