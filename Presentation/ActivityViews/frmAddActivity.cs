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

namespace Presentation.ActivityViews
{
    public partial class frmAddActivity : Form
    {
        public frmAddActivity()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DateTime d = DateTime.Parse(dtpDeadlineDate.Value.ToString());
            DateTime t = DateTime.Parse(dtpDeadlineTime.Value.ToString());
            DateTime ddl = d.Date.Add(t.TimeOfDay);

            Activity a = new Activity();
            a.Name = txtName.Text;
            a.Description = txtDescription.Text;
            a.Created = DateTime.Now;
            a.Deadline = ddl;
            a.TeamId = 2;

            ActivityLogic.Add(a);
            Close();
        }
    }
}
