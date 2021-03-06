﻿using System;
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
            teamBindingSource.DataSource = TeamLogic.Get();
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

        private void dgvTeams_SelectionChanged(object sender, EventArgs e)
        {
            userBindingSource.DataSource = null;
            if (dgvTeams.CurrentRow != null)
            {
                Team t = dgvTeams.CurrentRow.DataBoundItem as Team;
                TeamLogic tl = new TeamLogic();
                userBindingSource.DataSource = tl.GetTeamMembers(t);
            }
        }
    }
}
