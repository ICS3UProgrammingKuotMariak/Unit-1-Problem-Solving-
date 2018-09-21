using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NBA_Mascots_KuotM_
{
    public partial class frmNBAMascot : Form
    {
        public frmNBAMascot()
        {
            InitializeComponent();
        }

        private void lblMascot_Click(object sender, EventArgs e)
        {

        }
        // This changes the text and background image
        private void atlantaHawksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblTeam.Text = "Atlanta Hawks";
            lblMascot.Text = "Harry the Hawk";
            this.BackgroundImage = Properties.Resources.HawksMascot;
        }
        // This changes the text and background image
        private void torontoRaptorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblTeam.Text = "Toronto Raptors";
            lblMascot.Text = "The Raptor";
            this.BackgroundImage = Properties.Resources.RaptorMascot;
        }
        // This changes the text and background image
        private void washingtonWizardsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblTeam.Text = "Washington Wizards";
            lblMascot.Text = "G-Wiz/G-Man";
            this.BackgroundImage = Properties.Resources.WashingtonMascot;
        }
        // This changes the text and background image
        private void chicagoBullsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblTeam.Text = "Chicago Bulls";
            lblMascot.Text = "Benny the Bull";
            this.BackgroundImage = Properties.Resources.BullsMascot;

        }

        private void frmNBAMascot_Load(object sender, EventArgs e)
        {

        }
    }
}
