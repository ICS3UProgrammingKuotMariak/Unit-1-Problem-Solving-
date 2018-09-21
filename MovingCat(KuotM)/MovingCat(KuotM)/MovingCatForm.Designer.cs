namespace MovingCat_KuotM_
{
    partial class frmMovingCat
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
            this.mnuMovingCat = new System.Windows.Forms.MenuStrip();
            this.mniFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mniExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mniCat = new System.Windows.Forms.ToolStripMenuItem();
            this.mniCat1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mniCat2 = new System.Windows.Forms.ToolStripMenuItem();
            this.picCat = new System.Windows.Forms.PictureBox();
            this.mnuMovingCat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCat)).BeginInit();
            this.SuspendLayout();
            // 
            // mnuMovingCat
            // 
            this.mnuMovingCat.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniFile,
            this.mniCat});
            this.mnuMovingCat.Location = new System.Drawing.Point(0, 0);
            this.mnuMovingCat.Name = "mnuMovingCat";
            this.mnuMovingCat.Size = new System.Drawing.Size(284, 24);
            this.mnuMovingCat.TabIndex = 0;
            this.mnuMovingCat.Text = "menuStrip1";
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
            this.mniExit.Click += new System.EventHandler(this.mniExit_Click);
            // 
            // mniCat
            // 
            this.mniCat.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniCat1,
            this.mniCat2});
            this.mniCat.Name = "mniCat";
            this.mniCat.Size = new System.Drawing.Size(37, 20);
            this.mniCat.Text = "Cat";
            // 
            // mniCat1
            // 
            this.mniCat1.Name = "mniCat1";
            this.mniCat1.Size = new System.Drawing.Size(98, 22);
            this.mniCat1.Text = "Cat1";
            this.mniCat1.Click += new System.EventHandler(this.mniCat1_Click);
            // 
            // mniCat2
            // 
            this.mniCat2.Name = "mniCat2";
            this.mniCat2.Size = new System.Drawing.Size(98, 22);
            this.mniCat2.Text = "Cat2";
            this.mniCat2.Click += new System.EventHandler(this.mniCat2_Click);
            // 
            // picCat
            // 
            this.picCat.Location = new System.Drawing.Point(12, 38);
            this.picCat.Name = "picCat";
            this.picCat.Size = new System.Drawing.Size(260, 211);
            this.picCat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picCat.TabIndex = 1;
            this.picCat.TabStop = false;
            // 
            // frmMovingCat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.picCat);
            this.Controls.Add(this.mnuMovingCat);
            this.MainMenuStrip = this.mnuMovingCat;
            this.Name = "frmMovingCat";
            this.Text = "Moving Cat";
            this.Load += new System.EventHandler(this.frmMovingCat_Load);
            this.mnuMovingCat.ResumeLayout(false);
            this.mnuMovingCat.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuMovingCat;
        private System.Windows.Forms.ToolStripMenuItem mniFile;
        private System.Windows.Forms.ToolStripMenuItem mniExit;
        private System.Windows.Forms.ToolStripMenuItem mniCat;
        private System.Windows.Forms.ToolStripMenuItem mniCat1;
        private System.Windows.Forms.ToolStripMenuItem mniCat2;
        private System.Windows.Forms.PictureBox picCat;
    }
}

