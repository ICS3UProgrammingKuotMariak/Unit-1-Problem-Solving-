namespace PizzaCost_KuotM_
{
    partial class frmPizzaCost
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblEnterDiameter = new System.Windows.Forms.Label();
            this.mnuPizzaCost = new System.Windows.Forms.MenuStrip();
            this.mniFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mniExit = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.lblSubtotalAnswer = new System.Windows.Forms.Label();
            this.lblTax = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblTaxAnswer = new System.Windows.Forms.Label();
            this.lblTotalAnswer = new System.Windows.Forms.Label();
            this.lblEnterPizzaAmount = new System.Windows.Forms.Label();
            this.nudDiameter = new System.Windows.Forms.NumericUpDown();
            this.nudPizzas = new System.Windows.Forms.NumericUpDown();
            this.mnuPizzaCost.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDiameter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPizzas)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEnterDiameter
            // 
            this.lblEnterDiameter.AutoSize = true;
            this.lblEnterDiameter.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnterDiameter.Location = new System.Drawing.Point(12, 46);
            this.lblEnterDiameter.Name = "lblEnterDiameter";
            this.lblEnterDiameter.Size = new System.Drawing.Size(417, 25);
            this.lblEnterDiameter.TabIndex = 0;
            this.lblEnterDiameter.Text = "Enter the diameter of the pizza (in inches):";
            // 
            // mnuPizzaCost
            // 
            this.mnuPizzaCost.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniFile});
            this.mnuPizzaCost.Location = new System.Drawing.Point(0, 0);
            this.mnuPizzaCost.Name = "mnuPizzaCost";
            this.mnuPizzaCost.Size = new System.Drawing.Size(541, 24);
            this.mnuPizzaCost.TabIndex = 1;
            this.mnuPizzaCost.Text = "menuStrip1";
            // 
            // mniFile
            // 
            this.mniFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniExit});
            this.mniFile.Name = "mniFile";
            this.mniFile.Size = new System.Drawing.Size(37, 20);
            this.mniFile.Text = "File";
            // 
            // mniExit
            // 
            this.mniExit.Name = "mniExit";
            this.mniExit.Size = new System.Drawing.Size(92, 22);
            this.mniExit.Text = "Exit";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(258, 182);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(142, 54);
            this.btnCalculate.TabIndex = 2;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.AutoSize = true;
            this.lblSubtotal.Location = new System.Drawing.Point(234, 264);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(49, 13);
            this.lblSubtotal.TabIndex = 3;
            this.lblSubtotal.Text = "Subtotal:";
            // 
            // lblSubtotalAnswer
            // 
            this.lblSubtotalAnswer.AutoSize = true;
            this.lblSubtotalAnswer.Location = new System.Drawing.Point(366, 264);
            this.lblSubtotalAnswer.Name = "lblSubtotalAnswer";
            this.lblSubtotalAnswer.Size = new System.Drawing.Size(81, 13);
            this.lblSubtotalAnswer.TabIndex = 4;
            this.lblSubtotalAnswer.Text = "SubtotalAnswer";
            // 
            // lblTax
            // 
            this.lblTax.AutoSize = true;
            this.lblTax.Location = new System.Drawing.Point(255, 287);
            this.lblTax.Name = "lblTax";
            this.lblTax.Size = new System.Drawing.Size(28, 13);
            this.lblTax.TabIndex = 5;
            this.lblTax.Text = "Tax:";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(249, 309);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(34, 13);
            this.lblTotal.TabIndex = 6;
            this.lblTotal.Text = "Total:";
            // 
            // lblTaxAnswer
            // 
            this.lblTaxAnswer.AutoSize = true;
            this.lblTaxAnswer.Location = new System.Drawing.Point(366, 287);
            this.lblTaxAnswer.Name = "lblTaxAnswer";
            this.lblTaxAnswer.Size = new System.Drawing.Size(60, 13);
            this.lblTaxAnswer.TabIndex = 7;
            this.lblTaxAnswer.Text = "TaxAnswer";
            // 
            // lblTotalAnswer
            // 
            this.lblTotalAnswer.AutoSize = true;
            this.lblTotalAnswer.Location = new System.Drawing.Point(366, 309);
            this.lblTotalAnswer.Name = "lblTotalAnswer";
            this.lblTotalAnswer.Size = new System.Drawing.Size(66, 13);
            this.lblTotalAnswer.TabIndex = 8;
            this.lblTotalAnswer.Text = "TotalAnswer";
            // 
            // lblEnterPizzaAmount
            // 
            this.lblEnterPizzaAmount.AutoSize = true;
            this.lblEnterPizzaAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnterPizzaAmount.Location = new System.Drawing.Point(12, 122);
            this.lblEnterPizzaAmount.Name = "lblEnterPizzaAmount";
            this.lblEnterPizzaAmount.Size = new System.Drawing.Size(271, 25);
            this.lblEnterPizzaAmount.TabIndex = 9;
            this.lblEnterPizzaAmount.Text = "Enter the number of Pizzas";
            // 
            // nudDiameter
            // 
            this.nudDiameter.Location = new System.Drawing.Point(29, 89);
            this.nudDiameter.Name = "nudDiameter";
            this.nudDiameter.Size = new System.Drawing.Size(120, 20);
            this.nudDiameter.TabIndex = 10;
            // 
            // nudPizzas
            // 
            this.nudPizzas.Location = new System.Drawing.Point(29, 163);
            this.nudPizzas.Name = "nudPizzas";
            this.nudPizzas.Size = new System.Drawing.Size(120, 20);
            this.nudPizzas.TabIndex = 11;
            // 
            // frmPizzaCost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 377);
            this.Controls.Add(this.nudPizzas);
            this.Controls.Add(this.nudDiameter);
            this.Controls.Add(this.lblEnterPizzaAmount);
            this.Controls.Add(this.lblTotalAnswer);
            this.Controls.Add(this.lblTaxAnswer);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblTax);
            this.Controls.Add(this.lblSubtotalAnswer);
            this.Controls.Add(this.lblSubtotal);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.lblEnterDiameter);
            this.Controls.Add(this.mnuPizzaCost);
            this.MainMenuStrip = this.mnuPizzaCost;
            this.Name = "frmPizzaCost";
            this.Text = "Pizza Cost";
            this.Load += new System.EventHandler(this.frmPizzaCost_Load);
            this.mnuPizzaCost.ResumeLayout(false);
            this.mnuPizzaCost.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDiameter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPizzas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEnterDiameter;
        private System.Windows.Forms.MenuStrip mnuPizzaCost;
        private System.Windows.Forms.ToolStripMenuItem mniFile;
        private System.Windows.Forms.ToolStripMenuItem mniExit;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.Label lblSubtotalAnswer;
        private System.Windows.Forms.Label lblTax;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblTaxAnswer;
        private System.Windows.Forms.Label lblTotalAnswer;
        private System.Windows.Forms.Label lblEnterPizzaAmount;
        private System.Windows.Forms.NumericUpDown nudDiameter;
        private System.Windows.Forms.NumericUpDown nudPizzas;
    }
}

