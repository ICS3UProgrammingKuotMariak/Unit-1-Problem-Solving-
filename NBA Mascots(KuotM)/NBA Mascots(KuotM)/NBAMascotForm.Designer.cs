namespace NBA_Mascots_KuotM_
{
    partial class frmNBAMascot
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
            this.mnuNBAMascots = new System.Windows.Forms.MenuStrip();
            this.mniTeams = new System.Windows.Forms.ToolStripMenuItem();
            this.mniAtlantaHawks = new System.Windows.Forms.ToolStripMenuItem();
            this.mniTorontoRaptors = new System.Windows.Forms.ToolStripMenuItem();
            this.mniWashingtonWizards = new System.Windows.Forms.ToolStripMenuItem();
            this.mniChicagoBulls = new System.Windows.Forms.ToolStripMenuItem();
            this.grbTeams = new System.Windows.Forms.GroupBox();
            this.lblMascot = new System.Windows.Forms.Label();
            this.lblTeam = new System.Windows.Forms.Label();
            this.mnuNBAMascots.SuspendLayout();
            this.grbTeams.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuNBAMascots
            // 
            this.mnuNBAMascots.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniTeams});
            this.mnuNBAMascots.Location = new System.Drawing.Point(0, 0);
            this.mnuNBAMascots.Name = "mnuNBAMascots";
            this.mnuNBAMascots.Size = new System.Drawing.Size(518, 24);
            this.mnuNBAMascots.TabIndex = 0;
            this.mnuNBAMascots.Text = "menuStrip1";
            // 
            // mniTeams
            // 
            this.mniTeams.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniAtlantaHawks,
            this.mniTorontoRaptors,
            this.mniWashingtonWizards,
            this.mniChicagoBulls});
            this.mniTeams.Name = "mniTeams";
            this.mniTeams.Size = new System.Drawing.Size(53, 20);
            this.mniTeams.Text = "Teams";
            // 
            // mniAtlantaHawks
            // 
            this.mniAtlantaHawks.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.mniAtlantaHawks.Name = "mniAtlantaHawks";
            this.mniAtlantaHawks.Size = new System.Drawing.Size(182, 22);
            this.mniAtlantaHawks.Text = "Atlanta Hawks";
            this.mniAtlantaHawks.Click += new System.EventHandler(this.atlantaHawksToolStripMenuItem_Click);
            // 
            // mniTorontoRaptors
            // 
            this.mniTorontoRaptors.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.mniTorontoRaptors.Name = "mniTorontoRaptors";
            this.mniTorontoRaptors.Size = new System.Drawing.Size(182, 22);
            this.mniTorontoRaptors.Text = "Toronto Raptors";
            this.mniTorontoRaptors.Click += new System.EventHandler(this.torontoRaptorsToolStripMenuItem_Click);
            // 
            // mniWashingtonWizards
            // 
            this.mniWashingtonWizards.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.mniWashingtonWizards.Name = "mniWashingtonWizards";
            this.mniWashingtonWizards.Size = new System.Drawing.Size(182, 22);
            this.mniWashingtonWizards.Text = "Washington Wizards";
            this.mniWashingtonWizards.Click += new System.EventHandler(this.washingtonWizardsToolStripMenuItem_Click);
            // 
            // mniChicagoBulls
            // 
            this.mniChicagoBulls.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.mniChicagoBulls.Name = "mniChicagoBulls";
            this.mniChicagoBulls.Size = new System.Drawing.Size(182, 22);
            this.mniChicagoBulls.Text = "Chicago Bulls";
            this.mniChicagoBulls.Click += new System.EventHandler(this.chicagoBullsToolStripMenuItem_Click);
            // 
            // grbTeams
            // 
            this.grbTeams.BackColor = System.Drawing.Color.Transparent;
            this.grbTeams.Controls.Add(this.lblMascot);
            this.grbTeams.Controls.Add(this.lblTeam);
            this.grbTeams.Location = new System.Drawing.Point(41, 106);
            this.grbTeams.Name = "grbTeams";
            this.grbTeams.Size = new System.Drawing.Size(425, 272);
            this.grbTeams.TabIndex = 1;
            this.grbTeams.TabStop = false;
            // 
            // lblMascot
            // 
            this.lblMascot.BackColor = System.Drawing.Color.Transparent;
            this.lblMascot.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMascot.ForeColor = System.Drawing.Color.Yellow;
            this.lblMascot.Location = new System.Drawing.Point(6, 111);
            this.lblMascot.Name = "lblMascot";
            this.lblMascot.Size = new System.Drawing.Size(413, 111);
            this.lblMascot.TabIndex = 1;
            this.lblMascot.Text = "Mascot";
            this.lblMascot.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblMascot.Click += new System.EventHandler(this.lblMascot_Click);
            // 
            // lblTeam
            // 
            this.lblTeam.BackColor = System.Drawing.Color.Transparent;
            this.lblTeam.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTeam.ForeColor = System.Drawing.Color.Yellow;
            this.lblTeam.Location = new System.Drawing.Point(48, 32);
            this.lblTeam.Name = "lblTeam";
            this.lblTeam.Size = new System.Drawing.Size(322, 79);
            this.lblTeam.TabIndex = 0;
            this.lblTeam.Text = "Team";
            this.lblTeam.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmNBAMascot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(518, 390);
            this.Controls.Add(this.grbTeams);
            this.Controls.Add(this.mnuNBAMascots);
            this.MainMenuStrip = this.mnuNBAMascots;
            this.Name = "frmNBAMascot";
            this.Text = "NBA Mascots";
            this.Load += new System.EventHandler(this.frmNBAMascot_Load);
            this.mnuNBAMascots.ResumeLayout(false);
            this.mnuNBAMascots.PerformLayout();
            this.grbTeams.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuNBAMascots;
        private System.Windows.Forms.ToolStripMenuItem mniTeams;
        private System.Windows.Forms.ToolStripMenuItem mniAtlantaHawks;
        private System.Windows.Forms.ToolStripMenuItem mniTorontoRaptors;
        private System.Windows.Forms.ToolStripMenuItem mniWashingtonWizards;
        private System.Windows.Forms.ToolStripMenuItem mniChicagoBulls;
        private System.Windows.Forms.GroupBox grbTeams;
        private System.Windows.Forms.Label lblMascot;
        private System.Windows.Forms.Label lblTeam;
    }
}

