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
        private Activity _activityToUpdate;
        private List<User> _users;
        private List<User> _usersToActivity;
        private AutoCompleteStringCollection _usersAutoComplete;
        private static List<Team> _teams;
        public frmAddActivity()
        {
            InitializeComponent();
        }

        public frmAddActivity(Activity a)
        {
            InitializeComponent();
            _activityToUpdate = a;
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
            a.TeamId = int.Parse(cboTeam.SelectedValue.ToString());

            if (cboProject.DataSource != null)
            {
                a.ProjectId = int.Parse(cboProject.SelectedValue.ToString());
            }
            else a.ProjectId = null;

            if (_activityToUpdate == null)
                ActivityLogic.Add(a, _usersToActivity);
            else
                ActivityLogic.Update(_activityToUpdate, a, _usersToActivity);
            
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

        private void LoadTeams()
        {
            _teams = TeamLogic.Get();
            cboTeam.DataSource = _teams;
            cboTeam.DisplayMember = "Name";
            cboTeam.ValueMember = "Id";
        }

        private void frmAddActivity_Load(object sender, EventArgs e)
        {
            _users = UserLogic.GetCommitteMembers();
            _usersAutoComplete = new AutoCompleteStringCollection();
            InitializeAutoComplete();
            LoadTeams();
            this.cboTeam.SelectedValueChanged += new System.EventHandler(this.cboTeam_SelectedValueChanged);

            if (_activityToUpdate != null)
            {
                _usersToActivity = ActivityLogic.GetActivityMembers(_activityToUpdate);
                ShowActivityUsers();

                txtName.Text = _activityToUpdate.Name;
                txtDescription.Text = _activityToUpdate.Description;
                dtpDeadlineDate.Value = _activityToUpdate.Deadline.Value;
                dtpDeadlineTime.Value = _activityToUpdate.Deadline.Value;

                cboTeam.SelectedValue = _activityToUpdate.TeamId;
                cboProject.SelectedValue = _activityToUpdate.ProjectId;
            }
            else
            {
                _usersToActivity = new List<User>();
            }
        }

        private void LoadProjects(int selectedTeamId)
        {
            List<Project> projects = ProjectLogic.GetByTeamId(selectedTeamId);
            cboProject.DataSource = null;
            cboProject.DataSource = projects;
            cboProject.DisplayMember = "Name";
            cboProject.ValueMember = "Id";
        }

        private void cboTeam_SelectedValueChanged(object sender, EventArgs e)
        {
            int selectedTeamId = int.Parse(cboTeam.SelectedValue.ToString());
            if (selectedTeamId != -1)
            {
                if ((_teams.Where(y => y.Id == selectedTeamId).SelectMany(x => x.TeamsProjects)).Count() != 0)
                {
                    LoadProjects(selectedTeamId);
                    cboProject.Visible = true;
                    lblProject.Visible = true;
                }
                else
                {
                    cboProject.DataSource = null;
                    cboProject.Visible = false;
                    lblProject.Visible = false;
                }
            }
        }
    }
}
