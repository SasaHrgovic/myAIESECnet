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

namespace Presentation.ProjectViews
{
    public partial class ucProjects : UserControl
    {
        private static ucProjects _instance;
        public static ucProjects Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ucProjects();
                return _instance;
            }
        }
        public ucProjects()
        {
            InitializeComponent();
        }

        private void ShowProjects()
        {
            projectBindingSource.DataSource = null;
            ProjectLogic pl = new ProjectLogic();
            projectBindingSource.DataSource = pl.Get();
        }

        private void ucProjects_Load(object sender, EventArgs e)
        {
            ShowProjects();
        }

        private void btnAddProject_Click(object sender, EventArgs e)
        {
            frmAddProject f = new frmAddProject();
            f.ShowDialog();
            ShowProjects();
        }
    }
}
