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
using Presentation.Project;

namespace Presentation
{
    public partial class frmMyAiesecNet : Form
    {
        public frmMyAiesecNet()
        {
            InitializeComponent();
        }

        private void lblTeams_Click(object sender, EventArgs e)
        {
            if(!pnlContainer.Controls.Contains(ucTeams.Instance))
            {
                lblTeams.Font = new Font(lblTeams.Font.Name, lblTeams.Font.SizeInPoints, FontStyle.Underline);
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
            if (!pnlContainer.Controls.Contains(ucProjects.Instance))
            {
                lblProjects.Font = new Font(lblProjects.Font.Name, lblProjects.Font.SizeInPoints, FontStyle.Underline);
                pnlContainer.Controls.Add(ucProjects.Instance);
                ucProjects.Instance.Dock = DockStyle.Fill;
                ucProjects.Instance.BringToFront();
            }
            else
            {
                ucProjects.Instance.BringToFront();
            }
        }
    }
}
