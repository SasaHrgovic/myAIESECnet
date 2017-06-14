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

namespace Presentation
{
    public partial class frmRegistration : Form
    {

        List<int[]> listArray = null;

        public frmRegistration()
        {
            InitializeComponent();
        }

        private void lblPrijava_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        private void btnRegistriraj_Click(object sender, EventArgs e)
        {
            User u = new User();
            u.Name = txtName.Text;
            u.Surname = txtSurname.Text;
            u.Email = txtEmail.Text;
            u.Password = txtPassword.Text;
            u.PhoneNumber = txtPhoneNumber.Text;
            u.BirthDate = DateTime.Parse(cbxYear.Text + "/" + cbxMonth.Text + "/" + cbxDay.Text);
            u.CommitteeId = int.Parse(cbxCommittee.SelectedValue.ToString());
            LoginLogic l = new LoginLogic();
            
            if (l.Register(u))
            {
                MessageBox.Show("Registracija je uspješna!", "Registracija", MessageBoxButtons.OK);
                this.Close();
            }
            
        }

        private void frmRegistration_Load(object sender, EventArgs e)
        {
            LoginLogic l = new LoginLogic();
            listArray = l.GetDate();
            cbxMonth.DataSource = listArray[0];
            cbxYear.DataSource = listArray[4];
            cbxCommittee.DataSource = l.GetCommittees();
            cbxCommittee.ValueMember = "Id";
            cbxCommittee.DisplayMember = "Name";
            
        }

        private void cbxMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            int mjesec = cbxMonth.SelectedIndex+1;
            switch (mjesec)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    {
                        cbxDay.DataSource = null;
                        cbxDay.DataSource = listArray[3];
                        break;
                    }
                case 2:
                    cbxDay.DataSource = null;
                    cbxDay.DataSource = listArray[1];
                    break;
                case 4:
                case 6:
                case 9:
                case 11:
                    {
                        cbxDay.DataSource = null;
                        cbxDay.DataSource = listArray[2];
                        break;
                    }
            }



        }
    }
}
