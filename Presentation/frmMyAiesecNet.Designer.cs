namespace Presentation
{
    partial class frmMyAiesecNet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMyAiesecNet));
            this.lblHome = new System.Windows.Forms.Label();
            this.lblTeams = new System.Windows.Forms.Label();
            this.pnlContainer = new System.Windows.Forms.Panel();
            this.lblProjects = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHome
            // 
            this.lblHome.AutoSize = true;
            this.lblHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHome.Location = new System.Drawing.Point(12, 18);
            this.lblHome.Name = "lblHome";
            this.lblHome.Size = new System.Drawing.Size(91, 25);
            this.lblHome.TabIndex = 0;
            this.lblHome.Text = "Početna";
            // 
            // lblTeams
            // 
            this.lblTeams.AutoSize = true;
            this.lblTeams.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblTeams.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTeams.Location = new System.Drawing.Point(109, 18);
            this.lblTeams.Name = "lblTeams";
            this.lblTeams.Size = new System.Drawing.Size(75, 25);
            this.lblTeams.TabIndex = 1;
            this.lblTeams.Text = "Timovi";
            this.lblTeams.Click += new System.EventHandler(this.lblTeams_Click);
            // 
            // pnlContainer
            // 
            this.pnlContainer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlContainer.Location = new System.Drawing.Point(17, 60);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Size = new System.Drawing.Size(811, 350);
            this.pnlContainer.TabIndex = 2;
            // 
            // lblProjects
            // 
            this.lblProjects.AutoSize = true;
            this.lblProjects.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblProjects.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProjects.Location = new System.Drawing.Point(190, 18);
            this.lblProjects.Name = "lblProjects";
            this.lblProjects.Size = new System.Drawing.Size(84, 25);
            this.lblProjects.TabIndex = 3;
            this.lblProjects.Text = "Projekti";
            this.lblProjects.Click += new System.EventHandler(this.lblProjects_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::Presentation.Properties.Resources.Aiesec_blue_1;
            this.pictureBox1.Location = new System.Drawing.Point(610, 423);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(218, 36);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // frmMyAiesecNet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(840, 471);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblProjects);
            this.Controls.Add(this.pnlContainer);
            this.Controls.Add(this.lblTeams);
            this.Controls.Add(this.lblHome);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMyAiesecNet";
            this.Text = "frmMyAiesecNet";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHome;
        private System.Windows.Forms.Label lblTeams;
        private System.Windows.Forms.Panel pnlContainer;
        private System.Windows.Forms.Label lblProjects;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}