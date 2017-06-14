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
        private Team _teamToUpdate;

        public frmAddTeam()
        {
            InitializeComponent();
        }

        public frmAddTeam(Team team)
        {
            InitializeComponent();
            _teamToUpdate = team;
        }

        private void frmAddTeam_Load(object sender, EventArgs e)
        {
            if (_teamToUpdate != null)
            {
                txtName.Text = _teamToUpdate.Name;
                txtDescription.Text = _teamToUpdate.Description;
                dtpStart.Value = _teamToUpdate.Start;
                dtpEnd.Value = _teamToUpdate.End;

                if (_teamToUpdate.Type == 0) radProjectTeam.Checked = true;
                else radFunctionalTeam.Checked = true;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int teamType = (radFunctionalTeam.Checked == true) ? 1 : 0;
            TeamLogic tl = new TeamLogic();

            Team newTeam = new Team();
            newTeam.Name = txtName.Text;
            newTeam.Description = txtDescription.Text;
            newTeam.Start = dtpStart.Value;
            newTeam.End = dtpEnd.Value;
            newTeam.Type = teamType;

            if (_teamToUpdate == null)
                tl.Add(newTeam);
            else
                tl.Update(_teamToUpdate, newTeam);

            Close();
        }

        private void btnDeleteTeam_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Jeste li sigurni?", "Upozorenje!", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                TeamLogic tl = new TeamLogic();
                tl.Delete(_teamToUpdate);
                Close();
            }
        }
    }
}
