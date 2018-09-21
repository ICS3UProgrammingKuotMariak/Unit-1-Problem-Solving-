using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovingCat_KuotM_
{
    public partial class frmMovingCat : Form
    {
        public frmMovingCat()
        {
            InitializeComponent();
        }
    // This closes the program
        private void mniExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    // This changes the picture when you click
        private void mniCat1_Click(object sender, EventArgs e)
        {
            this.picCat.Image = Properties.Resources.cat1;
        }
    // This changes the picture when you click
        private void mniCat2_Click(object sender, EventArgs e)
        {
            this.picCat.Image = Properties.Resources.cat2;
        }

        private void frmMovingCat_Load(object sender, EventArgs e)
        {

        }
    }
}
