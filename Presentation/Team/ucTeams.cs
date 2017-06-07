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

namespace Presentation.Team
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

        private void ucTeams_Load(object sender, EventArgs e)
        {
            TeamLogic tl = new TeamLogic();
            teamBindingSource.DataSource = tl.getTeams();
        }

        private void btnAddTeam_Click(object sender, EventArgs e)
        {
            frmAddTeam f = new frmAddTeam();
            f.Show();
        }
    }
}
