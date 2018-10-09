/*
 * Created by: Kuot Mariak
 * Created on: 19-09-2018
 * Created for: ICS3U Programming
 * Daily Assignment – Day #10 - Circumference
 * Circumference
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Circumference_KuotM_
{
    public partial class frmCircumference : Form
    {
        public frmCircumference()
        {
            InitializeComponent();
        }
        // This decleares the variables
        double radius;
        double circumference;

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            // This shows the labels when clicked
            lblCircumferenceAnswer.Show();
            lblStateCircumference.Show();

            // This converts the string from the text box to a double
            radius = double.Parse(txtRadius.Text);

            // Calculates the Circumference
            circumference = 2 * Math.PI * radius;

            // This rounds it to two decimal places


            // This converts the circumference to a label
            lblCircumferenceAnswer.Text = Convert.ToString(circumference);
            
        }

        private void frmCircumference_Load(object sender, EventArgs e)
        {
            lblCircumferenceAnswer.Hide();
            lblStateCircumference.Hide();
        }

        private void mniExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
