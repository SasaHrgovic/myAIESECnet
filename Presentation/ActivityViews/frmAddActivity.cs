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
        private List<User> _users;
        private List<User> _usersToActivity;
        private AutoCompleteStringCollection _usersAutoComplete;
        public frmAddActivity()
        {
            InitializeComponent();
            _users = UserLogic.GetCommitteMembers();
            _usersToActivity = new List<User>();
            _usersAutoComplete = new AutoCompleteStringCollection();
            InitializeAutoComplete();
        }

        private void InitializeAutoComplete()
        {
            foreach(User u in _users)
            {
                _usersAutoComplete.Add(u.FullName);
            }
            txtUsers.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtUsers.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtUsers.AutoCompleteCustomSource = _usersAutoComplete;
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

            ActivityLogic.Add(a, _usersToActivity);
            Close();
        }

        private void ShowActivityUsers()
        {
            lbxUsers.DataSource = null;
            lbxUsers.DataSource = _usersToActivity;
            lbxUsers.DisplayMember = "FullName";
            lbxUsers.ValueMember = "Id";
        }

        private void txtUsers_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                User u = _users.Where(x => x.FullName == txtUsers.Text).First();
                if (u != null)
                {
                    _usersToActivity.Add(u);
                    ShowActivityUsers();
                }
            }
        }
    }
}
