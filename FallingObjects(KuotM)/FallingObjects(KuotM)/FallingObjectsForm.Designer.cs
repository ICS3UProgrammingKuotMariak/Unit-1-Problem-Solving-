namespace FallingObjects_KuotM_
{
    partial class frmFallingObjects
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
            this.lblEnterTime = new System.Windows.Forms.Label();
            this.nudSeconds = new System.Windows.Forms.NumericUpDown();
            this.lblStateHeight = new System.Windows.Forms.Label();
            this.lblHeightAnswer = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.mnuFallingObjects = new System.Windows.Forms.MenuStrip();
            this.mniFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mniExit = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.nudSeconds)).BeginInit();
            this.mnuFallingObjects.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblEnterTime
            // 
            this.lblEnterTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnterTime.Location = new System.Drawing.Point(12, 91);
            this.lblEnterTime.Name = "lblEnterTime";
            this.lblEnterTime.Size = new System.Drawing.Size(288, 59);
            this.lblEnterTime.TabIndex = 0;
            this.lblEnterTime.Text = "Enter the time(in seconds) since you released the object";
            // 
            // nudSeconds
            // 
            this.nudSeconds.Location = new System.Drawing.Point(321, 108);
            this.nudSeconds.Name = "nudSeconds";
            this.nudSeconds.Size = new System.Drawing.Size(142, 20);
            this.nudSeconds.TabIndex = 1;
            // 
            // lblStateHeight
            // 
            this.lblStateHeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStateHeight.Location = new System.Drawing.Point(12, 263);
            this.lblStateHeight.Name = "lblStateHeight";
            this.lblStateHeight.Size = new System.Drawing.Size(253, 53);
            this.lblStateHeight.TabIndex = 2;
            this.lblStateHeight.Text = "The height of the object above the ground is:";
            // 
            // lblHeightAnswer
            // 
            this.lblHeightAnswer.AutoSize = true;
            this.lblHeightAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeightAnswer.Location = new System.Drawing.Point(317, 275);
            this.lblHeightAnswer.Name = "lblHeightAnswer";
            this.lblHeightAnswer.Size = new System.Drawing.Size(65, 24);
            this.lblHeightAnswer.TabIndex = 3;
            this.lblHeightAnswer.Text = "Height";
            this.lblHeightAnswer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(292, 162);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(171, 70);
            this.btnCalculate.TabIndex = 4;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // mnuFallingObjects
            // 
            this.mnuFallingObjects.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniFile});
            this.mnuFallingObjects.Location = new System.Drawing.Point(0, 0);
            this.mnuFallingObjects.Name = "mnuFallingObjects";
            this.mnuFallingObjects.Size = new System.Drawing.Size(475, 24);
            this.mnuFallingObjects.TabIndex = 5;
            this.mnuFallingObjects.Text = "menuStrip1";
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
            this.mniExit.Size = new System.Drawing.Size(152, 22);
            this.mniExit.Text = "Exit";
            // 
            // frmFallingObjects
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 333);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.lblHeightAnswer);
            this.Controls.Add(this.lblStateHeight);
            this.Controls.Add(this.nudSeconds);
            this.Controls.Add(this.lblEnterTime);
            this.Controls.Add(this.mnuFallingObjects);
            this.MainMenuStrip = this.mnuFallingObjects;
            this.Name = "frmFallingObjects";
            this.Text = "Falling Objects";
            this.Load += new System.EventHandler(this.frmFallingObjects_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudSeconds)).EndInit();
            this.mnuFallingObjects.ResumeLayout(false);
            this.mnuFallingObjects.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEnterTime;
        private System.Windows.Forms.NumericUpDown nudSeconds;
        private System.Windows.Forms.Label lblStateHeight;
        private System.Windows.Forms.Label lblHeightAnswer;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.MenuStrip mnuFallingObjects;
        private System.Windows.Forms.ToolStripMenuItem mniFile;
        private System.Windows.Forms.ToolStripMenuItem mniExit;
    }
}

