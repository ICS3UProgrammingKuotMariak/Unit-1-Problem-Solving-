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
            // This hides the labels and picture box
            lblSubtotal.Hide();
            lblSubtotalAnswer.Hide();
            lblTax.Hide();
            lblTaxAnswer.Hide();
            lblTotal.Hide();
            lblTotalAnswer.Hide();
            picPizza.Hide();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            // This declares the variables
            double diameter, tax, subtotal, total, pizzas;

            // This sets the maximun and minimum values
            nudDiameter.Minimum = 10;
            nudDiameter.Maximum = 18;
            nudPizzas.Minimum = 1;
            nudPizzas.Maximum = 10;

            // This converts the string from the nud to a double
            diameter = double.Parse(nudDiameter.Text);
            pizzas = double.Parse(nudPizzas.Text);

            // Calculates Subtotal
            subtotal = 0.99 + 0.75 + 0.50 * diameter * pizzas;

            // Calculates Tax
            tax = subtotal * 0.13;

            // Calculates Total
            total = subtotal * 1.13;

            // This rounds to 2 decimal places
            subtotal = Math.Round(subtotal, 2);
            tax = Math.Round(tax, 2);
            total = Math.Round(total, 2);

            // This converts the subtotal, tax and total to their respective labels
            lblSubtotalAnswer.Text = Convert.ToString(subtotal) + "$";
            lblTaxAnswer.Text = Convert.ToString(tax) + "$";
            lblTotalAnswer.Text = Convert.ToString(total) + "$";

            // Changes image in picture box
            {
                if (diameter == 10)
                {
                    picPizza.Image = Properties.Resources._10inch_pizza;
                }
                else if (diameter == 14)
                {
                    picPizza.Image = Properties.Resources._14inch_pizza;
                }
                else if (diameter == 16)
                {
                    picPizza.Image = Properties.Resources._16inch_pizza;
                }
                else if (diameter == 18)
                {
                    picPizza.Image = Properties.Resources._18inch_pizza;
                }
            }

            // This shows the labels and picture box
            lblSubtotal.Show();
            lblSubtotalAnswer.Show();
            lblTax.Show();
            lblTaxAnswer.Show();
            lblTotal.Show();
            lblTotalAnswer.Show();
            picPizza.Show();
        }

        private void mniExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
