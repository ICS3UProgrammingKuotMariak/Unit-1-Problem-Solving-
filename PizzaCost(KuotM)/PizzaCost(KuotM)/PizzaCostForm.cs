/*
 * Created by: Kuot Mariak
 * Created on: 27-09-2018
 * Created for: ICS3U Programming
 * Daily Assignment – Day #12 - PizzaCost
 * Pizza Cost
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

namespace PizzaCost_KuotM_
{
    public partial class frmPizzaCost : Form
    {
        public frmPizzaCost()
        {
            InitializeComponent();
        }

        private void frmPizzaCost_Load(object sender, EventArgs e)
        {

            lblSubtotal.Hide();
            lblSubtotalAnswer.Hide();
            lblTax.Hide();
            lblTaxAnswer.Hide();
            lblTotal.Hide();
            lblTotalAnswer.Hide();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            // This declares the variables
            double diameter, tax, subtotal, total;

            // This sets the maximun and minimum values
            nudDiameter.Minimum = 6;
            nudDiameter.Maximum = 22;

            // This converts the string from the nud to a double
            diameter = double.Parse(nudDiameter.Text);

            // Calculates Subtotal
            subtotal = 0.99 + 0.75 + 0.50 * diameter;

            // Calculates Tax
            tax = subtotal * 0.13;

            // Calculates Total
            total = subtotal * 1.13;

            // This converts the subtotal, tax and total to their respective labels
            lblSubtotalAnswer.Text = Convert.ToString(subtotal) + "$";
            lblTaxAnswer.Text = Convert.ToString(tax) + "$";
            lblTotalAnswer.Text = Convert.ToString(total) + "$";

            // This shows the labels
            lblSubtotal.Hide();
            lblSubtotalAnswer.Hide();
            lblTax.Hide();
            lblTaxAnswer.Hide();
            lblTotal.Hide();
            lblTotalAnswer.Hide();











        }
    }
}
