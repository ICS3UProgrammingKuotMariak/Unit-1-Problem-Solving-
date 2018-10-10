using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FallingObjects_KuotM_
{
    public partial class frmFallingObjects : Form
    {
        public frmFallingObjects()
        {
            InitializeComponent();
        }

        private void frmFallingObjects_Load(object sender, EventArgs e)
        {
            // This hides the labels
            lblStateHeight.Hide();
            lblHeightAnswer.Hide();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            // This declares the variables
            double time, 
        }
    }
}
