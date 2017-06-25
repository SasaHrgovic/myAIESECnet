using System;
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
            if (Session.roleId == 2)
            {
                lblCommitties.Visible = false;
            }
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
    }
}
