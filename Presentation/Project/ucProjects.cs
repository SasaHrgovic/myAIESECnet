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

namespace Presentation.Project
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

        private void ucProjects_Load(object sender, EventArgs e)
        {
            ProjectLogic pl = new ProjectLogic();
            projectBindingSource.DataSource =  pl.getProjects();
        }
    }
}
