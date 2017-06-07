using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Data;
using Logic;

namespace Presentation.TeamViews
{
    public partial class frmAddTeam : Form
    {
        public frmAddTeam()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Team newTeam = new Team();
            newTeam.Name = txtName.Text;
            newTeam.Description = txtDescription.Text;
            newTeam.Start = dtpStart.Value;
            newTeam.End = dtpEnd.Value;
            TeamLogic tl = new TeamLogic();
            tl.AddTeam(newTeam);
            Close();
        }
    }
}
