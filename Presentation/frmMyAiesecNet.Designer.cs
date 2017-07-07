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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMyAiesecNet));
            this.lblHome = new System.Windows.Forms.Label();
            this.lblTeams = new System.Windows.Forms.Label();
            this.pnlContainer = new System.Windows.Forms.Panel();
            this.lblProjects = new System.Windows.Forms.Label();
            this.lblActivities = new System.Windows.Forms.Label();
            this.lblCommitties = new System.Windows.Forms.Label();
            this.lblConferences = new System.Windows.Forms.Label();
            this.lblMeetings = new System.Windows.Forms.Label();
            this.lblPositions = new System.Windows.Forms.Label();
            this.tmrActivities = new System.Windows.Forms.Timer(this.components);
            this.ntfDeadline = new System.Windows.Forms.NotifyIcon(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblLogOut = new System.Windows.Forms.Label();
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
            this.lblHome.Click += new System.EventHandler(this.lblHome_Click);
            // 
            // lblTeams
            // 
            this.lblTeams.AutoSize = true;
            this.lblTeams.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblTeams.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTeams.Location = new System.Drawing.Point(459, 18);
            this.lblTeams.Name = "lblTeams";
            this.lblTeams.Size = new System.Drawing.Size(75, 25);
            this.lblTeams.TabIndex = 1;
            this.lblTeams.Text = "Timovi";
            this.lblTeams.Click += new System.EventHandler(this.lblTeams_Click);
            // 
            // pnlContainer
            // 
            this.pnlContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlContainer.Location = new System.Drawing.Point(17, 60);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Size = new System.Drawing.Size(986, 426);
            this.pnlContainer.TabIndex = 2;
            // 
            // lblProjects
            // 
            this.lblProjects.AutoSize = true;
            this.lblProjects.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblProjects.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProjects.Location = new System.Drawing.Point(633, 18);
            this.lblProjects.Name = "lblProjects";
            this.lblProjects.Size = new System.Drawing.Size(84, 25);
            this.lblProjects.TabIndex = 3;
            this.lblProjects.Text = "Projekti";
            this.lblProjects.Click += new System.EventHandler(this.lblProjects_Click);
            // 
            // lblActivities
            // 
            this.lblActivities.AutoSize = true;
            this.lblActivities.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblActivities.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActivities.Location = new System.Drawing.Point(109, 18);
            this.lblActivities.Name = "lblActivities";
            this.lblActivities.Size = new System.Drawing.Size(105, 25);
            this.lblActivities.TabIndex = 5;
            this.lblActivities.Text = "Aktivnosti";
            this.lblActivities.Click += new System.EventHandler(this.lblActivities_Click);
            // 
            // lblCommitties
            // 
            this.lblCommitties.AutoSize = true;
            this.lblCommitties.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblCommitties.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCommitties.Location = new System.Drawing.Point(723, 18);
            this.lblCommitties.Name = "lblCommitties";
            this.lblCommitties.Size = new System.Drawing.Size(76, 25);
            this.lblCommitties.TabIndex = 6;
            this.lblCommitties.Text = "Odbori";
            this.lblCommitties.Click += new System.EventHandler(this.lblCommitties_Click);
            // 
            // lblConferences
            // 
            this.lblConferences.AutoSize = true;
            this.lblConferences.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblConferences.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConferences.Location = new System.Drawing.Point(220, 18);
            this.lblConferences.Name = "lblConferences";
            this.lblConferences.Size = new System.Drawing.Size(132, 25);
            this.lblConferences.TabIndex = 7;
            this.lblConferences.Text = "Konferencije";
            // 
            // lblMeetings
            // 
            this.lblMeetings.AutoSize = true;
            this.lblMeetings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblMeetings.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMeetings.Location = new System.Drawing.Point(358, 18);
            this.lblMeetings.Name = "lblMeetings";
            this.lblMeetings.Size = new System.Drawing.Size(95, 25);
            this.lblMeetings.TabIndex = 8;
            this.lblMeetings.Text = "Sastanci";
            // 
            // lblPositions
            // 
            this.lblPositions.AutoSize = true;
            this.lblPositions.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblPositions.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPositions.Location = new System.Drawing.Point(540, 18);
            this.lblPositions.Name = "lblPositions";
            this.lblPositions.Size = new System.Drawing.Size(87, 25);
            this.lblPositions.TabIndex = 9;
            this.lblPositions.Text = "Pozicije";
            this.lblPositions.Click += new System.EventHandler(this.lblPositions_Click);
            // 
            // tmrActivities
            // 
            this.tmrActivities.Interval = 60000;
            this.tmrActivities.Tick += new System.EventHandler(this.tmrActivities_Tick);
            // 
            // ntfDeadline
            // 
            this.ntfDeadline.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.ntfDeadline.Icon = ((System.Drawing.Icon)(resources.GetObject("ntfDeadline.Icon")));
            this.ntfDeadline.Text = "ntfDeadline";
            this.ntfDeadline.Visible = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::Presentation.Properties.Resources.Aiesec_blue_1;
            this.pictureBox1.Location = new System.Drawing.Point(785, 507);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(218, 36);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // lblLogOut
            // 
            this.lblLogOut.AutoSize = true;
            this.lblLogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblLogOut.Location = new System.Drawing.Point(12, 518);
            this.lblLogOut.Name = "lblLogOut";
            this.lblLogOut.Size = new System.Drawing.Size(102, 25);
            this.lblLogOut.TabIndex = 10;
            this.lblLogOut.Text = "Odjavi se";
            this.lblLogOut.Click += new System.EventHandler(this.lblLogOut_Click);
            // 
            // frmMyAiesecNet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1015, 555);
            this.Controls.Add(this.lblLogOut);
            this.Controls.Add(this.lblPositions);
            this.Controls.Add(this.lblMeetings);
            this.Controls.Add(this.lblConferences);
            this.Controls.Add(this.lblCommitties);
            this.Controls.Add(this.lblActivities);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblProjects);
            this.Controls.Add(this.pnlContainer);
            this.Controls.Add(this.lblTeams);
            this.Controls.Add(this.lblHome);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMyAiesecNet";
            this.Text = "frmMyAiesecNet";
            this.Load += new System.EventHandler(this.frmMyAiesecNet_Load);
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
        private System.Windows.Forms.Label lblActivities;
        private System.Windows.Forms.Label lblCommitties;
        private System.Windows.Forms.Label lblConferences;
        private System.Windows.Forms.Label lblMeetings;
        private System.Windows.Forms.Label lblPositions;
        private System.Windows.Forms.Timer tmrActivities;
        private System.Windows.Forms.NotifyIcon ntfDeadline;
        private System.Windows.Forms.Label lblLogOut;
    }
}