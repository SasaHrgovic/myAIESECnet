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

namespace Presentation.CommitteeViews
{
    public partial class frmAddCommittee : Form
    {
        private Committee _committeeToUpdate;
        public frmAddCommittee()
        {
            InitializeComponent();
        }

        public frmAddCommittee(Committee committee)
        {
            InitializeComponent();
            _committeeToUpdate = committee;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Committee c = new Committee();
            c.Name = txtName.Text;

            if (_committeeToUpdate == null) CommitteeLogic.Add(c);
            else CommitteeLogic.Update(_committeeToUpdate, c);

            Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Jeste li sigurni?", "Upozorenje", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                CommitteeLogic.Delete(_committeeToUpdate);
                Close();
            }           
        }

        private void frmAddCommittee_Load(object sender, EventArgs e)
        {
            if (_committeeToUpdate != null)
            {
                txtName.Text = _committeeToUpdate.Name;
            }
        }
    }
}
