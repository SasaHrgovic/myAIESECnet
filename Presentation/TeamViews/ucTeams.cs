using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logic;
using Data;

namespace Presentation.TeamViews
{
    public partial class ucTeams : UserControl
    {
        private static ucTeams _instance;
        public static ucTeams Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ucTeams();
                return _instance;
            }
        }
        public ucTeams()
        {
            InitializeComponent();
        }

        private void ShowTeams()
        {
            teamBindingSource.DataSource = null;
            TeamLogic tl = new TeamLogic();
            teamBindingSource.DataSource = tl.Get();
        }

        private void ucTeams_Load(object sender, EventArgs e)
        {
            ShowTeams();
        }

        private void btnAddTeam_Click(object sender, EventArgs e)
        {
            frmAddTeam f = new frmAddTeam();
            f.ShowDialog();
            ShowTeams();
        }

        private void btnUpdateTeam_Click(object sender, EventArgs e)
        {
            frmAddTeam f = new frmAddTeam(teamBindingSource.Current as Team);
            f.ShowDialog();
            ShowTeams();
        }
    }
}
