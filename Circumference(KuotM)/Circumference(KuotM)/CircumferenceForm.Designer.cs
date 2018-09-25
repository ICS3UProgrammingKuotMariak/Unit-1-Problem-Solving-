namespace Circumference_KuotM_
{
    partial class frmCircumference
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
            this.mnuCircumference = new System.Windows.Forms.MenuStrip();
            this.mniFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mniExit = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblCircumference = new System.Windows.Forms.Label();
            this.txtRadius = new System.Windows.Forms.TextBox();
            this.lblStateCircumference = new System.Windows.Forms.Label();
            this.lblCircumferenceAnswer = new System.Windows.Forms.Label();
            this.mnuCircumference.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuCircumference
            // 
            this.mnuCircumference.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniFile});
            this.mnuCircumference.Location = new System.Drawing.Point(0, 0);
            this.mnuCircumference.Name = "mnuCircumference";
            this.mnuCircumference.Size = new System.Drawing.Size(492, 24);
            this.mnuCircumference.TabIndex = 0;
            this.mnuCircumference.Text = "menuStrip1";
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
            this.btnCalculate.Location = new System.Drawing.Point(291, 211);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(132, 37);
            this.btnCalculate.TabIndex = 1;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // lblCircumference
            // 
            this.lblCircumference.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCircumference.Location = new System.Drawing.Point(12, 125);
            this.lblCircumference.Name = "lblCircumference";
            this.lblCircumference.Size = new System.Drawing.Size(249, 59);
            this.lblCircumference.TabIndex = 2;
            this.lblCircumference.Text = "Enter the radius of the circle(in cm)";
            this.lblCircumference.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtRadius
            // 
            this.txtRadius.Location = new System.Drawing.Point(301, 149);
            this.txtRadius.Name = "txtRadius";
            this.txtRadius.Size = new System.Drawing.Size(112, 20);
            this.txtRadius.TabIndex = 3;
            // 
            // lblStateCircumference
            // 
            this.lblStateCircumference.AutoSize = true;
            this.lblStateCircumference.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStateCircumference.Location = new System.Drawing.Point(30, 302);
            this.lblStateCircumference.Name = "lblStateCircumference";
            this.lblStateCircumference.Size = new System.Drawing.Size(196, 24);
            this.lblStateCircumference.TabIndex = 4;
            this.lblStateCircumference.Text = "The Circumference is:";
            // 
            // lblCircumferenceAnswer
            // 
            this.lblCircumferenceAnswer.AutoSize = true;
            this.lblCircumferenceAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCircumferenceAnswer.Location = new System.Drawing.Point(279, 302);
            this.lblCircumferenceAnswer.Name = "lblCircumferenceAnswer";
            this.lblCircumferenceAnswer.Size = new System.Drawing.Size(134, 24);
            this.lblCircumferenceAnswer.TabIndex = 6;
            this.lblCircumferenceAnswer.Text = "Circumference";
            // 
            // frmCircumference
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 369);
            this.Controls.Add(this.lblCircumferenceAnswer);
            this.Controls.Add(this.lblStateCircumference);
            this.Controls.Add(this.txtRadius);
            this.Controls.Add(this.lblCircumference);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.mnuCircumference);
            this.MainMenuStrip = this.mnuCircumference;
            this.Name = "frmCircumference";
            this.Text = "Circumference of a Circle";
            this.mnuCircumference.ResumeLayout(false);
            this.mnuCircumference.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuCircumference;
        private System.Windows.Forms.ToolStripMenuItem mniFile;
        private System.Windows.Forms.ToolStripMenuItem mniExit;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblCircumference;
        private System.Windows.Forms.TextBox txtRadius;
        private System.Windows.Forms.Label lblStateCircumference;
        private System.Windows.Forms.Label lblCircumferenceAnswer;
    }
}

