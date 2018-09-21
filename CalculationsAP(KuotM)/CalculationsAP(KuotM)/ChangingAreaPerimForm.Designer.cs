namespace CalculationsAP_KuotM_
{
    partial class frmChangingAreaPerim
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.mnu = new System.Windows.Forms.MenuStrip();
            this.mniFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mniExit = new System.Windows.Forms.ToolStripMenuItem();
            this.lblLength = new System.Windows.Forms.Label();
            this.lblWidth = new System.Windows.Forms.Label();
            this.lblPerimeter = new System.Windows.Forms.Label();
            this.lblArea = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblPerimeterAnswer = new System.Windows.Forms.Label();
            this.lblAreaAnswer = new System.Windows.Forms.Label();
            this.mnu.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(131, 72);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(131, 148);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 1;
            // 
            // mnu
            // 
            this.mnu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniFile});
            this.mnu.Location = new System.Drawing.Point(0, 0);
            this.mnu.Name = "mnu";
            this.mnu.Size = new System.Drawing.Size(369, 24);
            this.mnu.TabIndex = 2;
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
            // lblLength
            // 
            this.lblLength.AutoSize = true;
            this.lblLength.Location = new System.Drawing.Point(44, 72);
            this.lblLength.Name = "lblLength";
            this.lblLength.Size = new System.Drawing.Size(54, 13);
            this.lblLength.TabIndex = 3;
            this.lblLength.Text = "Length(m)";
            // 
            // lblWidth
            // 
            this.lblWidth.AutoSize = true;
            this.lblWidth.Location = new System.Drawing.Point(44, 148);
            this.lblWidth.Name = "lblWidth";
            this.lblWidth.Size = new System.Drawing.Size(49, 13);
            this.lblWidth.TabIndex = 4;
            this.lblWidth.Text = "Width(m)";
            // 
            // lblPerimeter
            // 
            this.lblPerimeter.AutoSize = true;
            this.lblPerimeter.Location = new System.Drawing.Point(33, 222);
            this.lblPerimeter.Name = "lblPerimeter";
            this.lblPerimeter.Size = new System.Drawing.Size(86, 13);
            this.lblPerimeter.TabIndex = 5;
            this.lblPerimeter.Text = "The Perimeter is:";
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Location = new System.Drawing.Point(34, 265);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(64, 13);
            this.lblArea.TabIndex = 6;
            this.lblArea.Text = "The Area is:";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(262, 104);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 7;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblPerimeterAnswer
            // 
            this.lblPerimeterAnswer.AutoSize = true;
            this.lblPerimeterAnswer.Location = new System.Drawing.Point(236, 222);
            this.lblPerimeterAnswer.Name = "lblPerimeterAnswer";
            this.lblPerimeterAnswer.Size = new System.Drawing.Size(86, 13);
            this.lblPerimeterAnswer.TabIndex = 8;
            this.lblPerimeterAnswer.Text = "PerimeterAnswer";
            // 
            // lblAreaAnswer
            // 
            this.lblAreaAnswer.AutoSize = true;
            this.lblAreaAnswer.Location = new System.Drawing.Point(236, 265);
            this.lblAreaAnswer.Name = "lblAreaAnswer";
            this.lblAreaAnswer.Size = new System.Drawing.Size(64, 13);
            this.lblAreaAnswer.TabIndex = 9;
            this.lblAreaAnswer.Text = "AreaAnswer";
            // 
            // frmChangingAreaPerim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 309);
            this.Controls.Add(this.lblAreaAnswer);
            this.Controls.Add(this.lblPerimeterAnswer);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.lblArea);
            this.Controls.Add(this.lblPerimeter);
            this.Controls.Add(this.lblWidth);
            this.Controls.Add(this.lblLength);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.mnu);
            this.MainMenuStrip = this.mnu;
            this.Name = "frmChangingAreaPerim";
            this.Text = "Changing Area & Perimeter";
            this.Load += new System.EventHandler(this.frmChangingAreaPerim_Load);
            this.mnu.ResumeLayout(false);
            this.mnu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.MenuStrip mnu;
        private System.Windows.Forms.Label lblLength;
        private System.Windows.Forms.Label lblWidth;
        private System.Windows.Forms.Label lblPerimeter;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.ToolStripMenuItem mniFile;
        private System.Windows.Forms.ToolStripMenuItem mniExit;
        private System.Windows.Forms.Label lblPerimeterAnswer;
        private System.Windows.Forms.Label lblAreaAnswer;
    }
}

