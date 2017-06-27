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

namespace Presentation.ActivityViews
{
    public partial class ucActivities : UserControl
    {
        private static ucActivities _instance;
        public static ucActivities Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ucActivities();
                return _instance;
            }
        }
        public ucActivities()
        {
            InitializeComponent();
        }

        private void ShowActivities()
        {
            activityBindingSource.DataSource = null;
            activityBindingSource.DataSource = ActivityLogic.Get();
        }
        private void ucActivities_Load(object sender, EventArgs e)
        {
            ShowActivities();
        }

        private void btnAddActivity_Click(object sender, EventArgs e)
        {
            frmAddActivity f = new frmAddActivity();
            f.ShowDialog();
            ShowActivities();
            ActivitiesTimer.SetActivitiesList();
        }

        private void btnUpdateActivity_Click(object sender, EventArgs e)
        {
            frmAddActivity f = new frmAddActivity();
            f.ShowDialog();
            ShowActivities();
            ActivitiesTimer.SetActivitiesList();
        }
    }
}
