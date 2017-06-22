using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Data;
using Logic;

namespace Presentation.TeamViews
{
    public partial class frmAddTeam : Form
    {
        private Team _teamToUpdate;
        private User _draggedUser;
        private List<User> _committeeMembers = new List<User>();
        private List<User> _teamMembers = new List<User>();
        private int _draggedOver;

        public frmAddTeam()
        {
            InitializeComponent();
        }

        public frmAddTeam(Team team)
        {
            InitializeComponent();
            _teamToUpdate = team;
        }

        private void ShowCommitteeMembers()
        {
            lbxCommitteeMembers.DataSource = null;
            lbxCommitteeMembers.DataSource = _committeeMembers;
            lbxCommitteeMembers.DisplayMember = "FullName";
            lbxCommitteeMembers.ValueMember = "Id";
        }

        private void ShowTeamMembers()
        {
            lbxTeamMembers.DataSource = null;
            lbxTeamMembers.DataSource = _teamMembers;
            lbxTeamMembers.DisplayMember = "FullName";
            lbxTeamMembers.ValueMember = "Id";
        }

        private void frmAddTeam_Load(object sender, EventArgs e)
        {
            List<User> _committeeMembersCopy = UserLogic.GetCommitteMembers();

            ProjectLogic pl = new ProjectLogic();
            cbxProjects.DataSource = pl.Get();
            cbxProjects.DisplayMember = "Name";
            cbxProjects.ValueMember = "Id";

            if (_teamToUpdate != null)
            {
                TeamLogic tl = new TeamLogic();
                _teamMembers = tl.GetTeamMembers(_teamToUpdate);
                _committeeMembers = _committeeMembersCopy.Except(_teamMembers, new UserListEqualityComparer()).ToList();
                ShowTeamMembers();

                txtName.Text = _teamToUpdate.Name;
                txtDescription.Text = _teamToUpdate.Description;
                dtpStart.Value = _teamToUpdate.Start;
                dtpEnd.Value = _teamToUpdate.End;             

                if (_teamToUpdate.Type == 0)
                {
                    radProjectTeam.Checked = true;
                    cbxProjects.SelectedValue = (_teamToUpdate.TeamsProjects.First()).ProjectId;
                }
                else radFunctionalTeam.Checked = true;
            }
            else _committeeMembers = _committeeMembersCopy;

            ShowCommitteeMembers();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int teamType = (radFunctionalTeam.Checked == true) ? 1 : 0;
            TeamLogic tl = new TeamLogic();

            Team newTeam = new Team();
            newTeam.Name = txtName.Text;
            newTeam.Description = txtDescription.Text;
            newTeam.Start = dtpStart.Value;
            newTeam.End = dtpEnd.Value;
            newTeam.Type = teamType;

            if (teamType == 0) newTeam.TeamsProjects.Add(new TeamProject() { TeamId = newTeam.Id, ProjectId = int.Parse(cbxProjects.SelectedValue.ToString())});

            if (_teamToUpdate == null)
                tl.Add(newTeam, _teamMembers);
            else
                tl.Update(_teamToUpdate, newTeam, _teamMembers);

            Close();
        }

        private void btnDeleteTeam_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Jeste li sigurni?", "Upozorenje!", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                TeamLogic tl = new TeamLogic();
                tl.Delete(_teamToUpdate);
                Close();
            }
        }

        private void lbxCommitteeMembers_MouseDown(object sender, MouseEventArgs e)
        {
            if (lbxCommitteeMembers.Items.Count == 0) return;

            int index = lbxCommitteeMembers.IndexFromPoint(e.X, e.Y);

            if (index != -1)
            {
                _draggedOver = 0;
                _draggedUser = lbxCommitteeMembers.Items[index] as User;
                DragDropEffects dde = DoDragDrop(_draggedUser, DragDropEffects.All);
            }
        }

        private void lbxTeamMembers_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
        }

        private void lbxTeamMembers_DragDrop(object sender, DragEventArgs e)
        {
            if (_draggedUser != null && _draggedOver == 0)
            {
                User userToRemove = _committeeMembers.Single(x => x == _draggedUser);
                _committeeMembers.Remove(userToRemove);
                ShowCommitteeMembers();

                _teamMembers.Add(_draggedUser);
                ShowTeamMembers();
            }
        }

        private void lbxTeamMembers_MouseDown(object sender, MouseEventArgs e)
        {
            if (lbxTeamMembers.Items.Count == 0) return;

            int index = lbxTeamMembers.IndexFromPoint(e.X, e.Y);

            if (index != -1)
            {
                _draggedOver = 1;
                _draggedUser = lbxTeamMembers.Items[index] as User;
                DragDropEffects dde = DoDragDrop(_draggedUser, DragDropEffects.All);
            }
        }

        private void lbxCommitteeMembers_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
        }

        private void lbxCommitteeMembers_DragDrop(object sender, DragEventArgs e)
        {
            if (_draggedUser!= null && _draggedOver == 1)
            {
                User userToRemove = _teamMembers.Single(x => x == _draggedUser);
                if (userToRemove != null) _teamMembers.Remove(userToRemove);
                else _teamMembers.Remove(_draggedUser);

                _committeeMembers.Add(_draggedUser);

                ShowTeamMembers();
                ShowCommitteeMembers();
            }
        }

        private void radProjectTeam_CheckedChanged(object sender, EventArgs e)
        {
            if (radProjectTeam.Checked == true) cbxProjects.Visible = true;
            else cbxProjects.Visible = false;
        }
    }
}
