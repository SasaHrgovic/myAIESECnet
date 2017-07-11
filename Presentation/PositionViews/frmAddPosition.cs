using Data;
using Logic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation.PositionViews
{
    public partial class frmAddPosition : Form
    {
        private Position _positionToUpdate;

        public frmAddPosition()
        {
            InitializeComponent();
        }

        public frmAddPosition(Position positionToUpdate)
        {
            InitializeComponent();
            _positionToUpdate = positionToUpdate;
        }

        private void DisplayTeams()
        {
            cboTeam.DataSource = TeamLogic.Get();
            cboTeam.DisplayMember = "Name";
            cboTeam.ValueMember = "Id";
        }

        private void DisplayRoles()
        {
            cboRole.DataSource = RoleLogic.Get();
            cboRole.DisplayMember = "Name";
            cboRole.ValueMember = "Id";
        }

        private void frmAddPosition_Load(object sender, EventArgs e)
        {
            DisplayTeams();
            DisplayRoles();
            if (_positionToUpdate != null)
            {
                txtName.Text = _positionToUpdate.Name;
                txtDescription.Text = _positionToUpdate.Description;
                cboRole.SelectedValue = _positionToUpdate.RoleId;
                cboTeam.SelectedValue = _positionToUpdate.TeamId;

            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Position p = new Position();
            p.Name = txtName.Text;
            p.Description = txtDescription.Text;
            p.TeamId = int.Parse(cboTeam.SelectedValue.ToString());
            p.RoleId = int.Parse(cboRole.SelectedValue.ToString());
            if (_positionToUpdate == null)
            {
                PositionLogic.Add(p);
            }
            else
            {
                PositionLogic.Update(_positionToUpdate, p);
            }
            Close();
        }
    }
}
