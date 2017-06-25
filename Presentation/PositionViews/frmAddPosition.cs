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
        public frmAddPosition()
        {
            InitializeComponent();
        }

        private void DisplayTeams()
        {
            TeamLogic t = new TeamLogic();
            cboTeam.DataSource = t.Get();
            cboTeam.DisplayMember = "Name";
            cboTeam.ValueMember = "Id";
        }

        private void frmAddPosition_Load(object sender, EventArgs e)
        {
            DisplayTeams();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Position p = new Position();
            p.Name = txtName.Text;
            p.Description = txtDescription.Text;
            p.TeamId = int.Parse(cboTeam.SelectedValue.ToString());
        }
    }
}
