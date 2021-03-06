﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Presentation.TeamViews;
using Presentation.ProjectViews;
using Logic;
using Presentation.PositionViews;
using Presentation.ActivityViews;
using Data;
using Presentation.CommitteeViews;

namespace Presentation
{
    public partial class frmMyAiesecNet : Form
    {
        public frmMyAiesecNet()
        {
            InitializeComponent();
        }

        private void ClearLabels()
        {
            foreach (Control c in this.Controls)
            {
                if (c.GetType() == typeof(Label))
                    c.Font = new Font(lblTeams.Font.Name, lblTeams.Font.SizeInPoints, FontStyle.Regular);
            }
        }

        private void lblTeams_Click(object sender, EventArgs e)
        {
            ClearLabels();
            lblTeams.Font = new Font(lblTeams.Font.Name, lblTeams.Font.SizeInPoints, FontStyle.Underline);
            if (!pnlContainer.Controls.Contains(ucTeams.Instance))
            {
                pnlContainer.Controls.Add(ucTeams.Instance);
                ucTeams.Instance.Dock = DockStyle.Fill;
                ucTeams.Instance.BringToFront();
            }
            else
            {
                ucTeams.Instance.BringToFront();
            }
        }

        private void lblProjects_Click(object sender, EventArgs e)
        {
            ClearLabels();
            lblProjects.Font = new Font(lblProjects.Font.Name, lblProjects.Font.SizeInPoints, FontStyle.Underline);
            if (!pnlContainer.Controls.Contains(ucProjects.Instance))
            {
                pnlContainer.Controls.Add(ucProjects.Instance);
                ucProjects.Instance.Dock = DockStyle.Fill;
                ucProjects.Instance.BringToFront();
            }
            else
            {
                ucProjects.Instance.BringToFront();
            }
        }

        private void frmMyAiesecNet_Load(object sender, EventArgs e)
        {
            KeyPreview = true;
            if (Session.roleId == 2 || Session.roleId == 3)
            {
                lblCommitties.Visible = false;
            }

            else if (Session.roleId == 4)
            {
                lblCommitties.Visible = false;
                lblProjects.Visible = false;
                lblPositions.Visible = false;
                lblTeams.Visible = false;
            }

            LoadMainUc();
            ActivitiesTimer.SetActivitiesList();
            tmrActivities.Enabled = true;
            tmrActivities.Start();
        }

        private void lblPositions_Click(object sender, EventArgs e)
        {
            ClearLabels();
            lblPositions.Font = new Font(lblPositions.Font.Name, lblPositions.Font.SizeInPoints, FontStyle.Underline);
            if (!pnlContainer.Controls.Contains(ucPositions.Instance))
            {
                pnlContainer.Controls.Add(ucPositions.Instance);
                ucPositions.Instance.Dock = DockStyle.Fill;
                ucPositions.Instance.BringToFront();
            }
            else
            {
                ucPositions.Instance.BringToFront();
            }
        }

        private void lblActivities_Click(object sender, EventArgs e)
        {
            ClearLabels();
            lblActivities.Font = new Font(lblActivities.Font.Name, lblActivities.Font.SizeInPoints, FontStyle.Underline);
            if (!pnlContainer.Controls.Contains(ucActivities.Instance))
            {
                pnlContainer.Controls.Add(ucActivities.Instance);
                ucActivities.Instance.Dock = DockStyle.Fill;
                ucActivities.Instance.BringToFront();
            }
            else
            {
                ucActivities.Instance.BringToFront();
            }
        }

        private void tmrActivities_Tick(object sender, EventArgs e)
        {
            Activity a = ActivitiesTimer.CheckDeadline();
            if (a != null)
            {
                ntfDeadline.Visible = true;
                ntfDeadline.BalloonTipTitle = a.Name;
                ntfDeadline.BalloonTipText = a.Description;
                ntfDeadline.ShowBalloonTip(1000);
            }
        }

        private void lblCommitties_Click(object sender, EventArgs e)
        {
            ClearLabels();
            lblCommitties.Font = new Font(lblCommitties.Font.Name, lblCommitties.Font.SizeInPoints, FontStyle.Underline);
            if (!pnlContainer.Controls.Contains(ucCommittees.Instance))
            {
                pnlContainer.Controls.Add(ucCommittees.Instance);
                ucCommittees.Instance.Dock = DockStyle.Fill;
                ucCommittees.Instance.BringToFront();
            }
            else
            {
                ucCommittees.Instance.BringToFront();
            }
        }

        private void lblHome_Click(object sender, EventArgs e)
        {
            LoadMainUc();
        }

        private void LoadMainUc()
        {
            ClearLabels();
            lblHome.Font = new Font(lblHome.Font.Name, lblHome.Font.SizeInPoints, FontStyle.Underline);
            if (!pnlContainer.Controls.Contains(ucMain.Instance))
            {
                pnlContainer.Controls.Add(ucMain.Instance);
                ucMain.Instance.Dock = DockStyle.Fill;
                ucMain.Instance.BringToFront();
            }
            else
            {
                ucMain.Instance.BringToFront();
            }
        }

        private void lblLogOut_Click(object sender, EventArgs e)
        {
            LoginLogic.LogOut();
            this.Close();
        }

        private void frmMyAiesecNet_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.F1)
            {
                System.Diagnostics.Process.Start("https://github.com/foivz/r17006/wiki/Korisni%C4%8Dka-dokumentacija");
            }
            
           
        }

        private void frmMyAiesecNet_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                //MessageBox.Show("radi");
                System.Diagnostics.Process.Start("https://github.com/foivz/r17006/wiki/Korisni%C4%8Dka-dokumentacija");
            }
        }
    }
}
