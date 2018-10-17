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
            const int small = 10;
            const int medium = 14;
            const int large = 16;
            const int extralarge = 18;

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
            if (diameter == small)
                {
                    picPizza.Image = Properties.Resources._10inch_pizza;
                }
                else if (diameter == medium)
                {
                    picPizza.Image = Properties.Resources._14inch_pizza;
                }
                else if (diameter == large)
                {
                    picPizza.Image = Properties.Resources._16inch_pizza;
                }
                else if (diameter == extralarge)
                {
                    picPizza.Image = Properties.Resources._18inch_pizza;
                }
            else
                {
                    picPizza.Image = null;
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
