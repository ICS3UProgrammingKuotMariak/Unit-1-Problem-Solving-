/*
 * Created by: Kuot Mariak
 * Created on: 18-09-2018
 * Created for: ICS3U Programming
 * Daily Assignment – Day #10 - Changing Area and Perimeter
 * CalculationsAP
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

namespace CalculationsAP_KuotM_
{
    public partial class frmChangingAreaPerim : Form
    {
        public frmChangingAreaPerim()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Declares the variables
            double length, width,area,perimeter;
            // Convert the string from each textbox to a double
            length = double.Parse(txtlength.Text);
            width = double.Parse(txtwidth.Text);
            // Calcuate the area and the perimeter
            area = length * width;
            perimeter = 2 * length + 2 * width;

            // This converts the area and perimeter into their respective labels
            lblAreaAnswer.Text = Convert.ToString(area) + "cm²";
            lblPerimeterAnswer.Text = Convert.ToString(perimeter) + "cm";

        // This shows the labels when you click
            lblArea.Show();
            lblAreaAnswer.Show();
            lblPerimeter.Show();
            lblPerimeterAnswer.Show();
        }

        private void frmChangingAreaPerim_Load(object sender, EventArgs e)
        {
            lblArea.Hide();
            lblAreaAnswer.Hide();
            lblPerimeter.Hide();
            lblPerimeterAnswer.Hide();
        }

        private void mniExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
