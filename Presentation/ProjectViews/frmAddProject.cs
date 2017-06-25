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

namespace Presentation.ProjectViews
{
    public partial class frmAddProject : Form
    {
        private Project _projectToUpdate;
        public frmAddProject()
        {
            InitializeComponent();
        }

        public frmAddProject(Project project)
        {
            InitializeComponent();
            _projectToUpdate = project;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Project p = new Project();
            p.Name = txtName.Text;
            p.Description = txtDescription.Text;
            p.CreatedAt = DateTime.Now;

            if (_projectToUpdate == null)
                ProjectLogic.Add(p);
            else
                ProjectLogic.Update(_projectToUpdate, p);

            Close();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Jeste li sigurni?", "Upozorenje!", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                ProjectLogic.Delete(_projectToUpdate);
                Close();
            }
        }

        private void frmAddProject_Load(object sender, EventArgs e)
        {
            if (_projectToUpdate != null)
            {
                txtName.Text = _projectToUpdate.Name;
                txtDescription.Text = _projectToUpdate.Description;
            }
        }
    }
}
