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

namespace Presentation.CommitteeViews
{
    public partial class ucCommittees : UserControl
    {
        private static ucCommittees _instance;
        public static ucCommittees Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ucCommittees();
                return _instance;
            }
        }
        public ucCommittees()
        {
            InitializeComponent();
        }

        private void ShowCommittees()
        {
            committeeBindingSource.DataSource = null;
            committeeBindingSource.DataSource = CommitteeLogic.Get();
        }

        private void ucCommittees_Load(object sender, EventArgs e)
        {
            ShowCommittees();
        }

        private void btnAddCommittee_Click(object sender, EventArgs e)
        {
            frmAddCommittee c = new frmAddCommittee();
            c.ShowDialog();
            ShowCommittees();
        }

        private void btnUpdateCommittee_Click(object sender, EventArgs e)
        {
            frmAddCommittee c = new frmAddCommittee(dgvCommittees.CurrentRow.DataBoundItem as Committee);
            c.ShowDialog();
            ShowCommittees();
        }
    }
}
