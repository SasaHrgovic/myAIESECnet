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
            frmAddActivity f = new frmAddActivity(activityBindingSource.Current as Activity);
            f.ShowDialog();
            ShowActivities();
            ActivitiesTimer.SetActivitiesList();
        }

        private void m_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            ToolStripItem item = e.ClickedItem;
            string itemName = item.ToString();
            if (itemName == "Izbriši")
            {
                ActivityLogic.Delete(activityBindingSource.Current as Activity);
                ShowActivities();
            }
        }

        private void dgvActivities_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var hti = dgvActivities.HitTest(e.X, e.Y);
                dgvActivities.ClearSelection();
                dgvActivities.Rows[hti.RowIndex].Selected = true;
                activityBindingSource.Position = hti.RowIndex;

                ContextMenuStrip m = new ContextMenuStrip();
                m.Items.Add("Započni");
                m.Items.Add("Završi");
                m.Items.Add("Izbriši");

                m.Show(dgvActivities, new Point(e.X, e.Y));

                m.ItemClicked += new ToolStripItemClickedEventHandler(m_ItemClicked);
            }
        }
    }
}
