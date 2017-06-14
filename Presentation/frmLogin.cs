using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logic;

namespace Presentation
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            LoginLogic login = new LoginLogic();
            if (login.Login(txtEmail.Text, txtPassword.Text))
            {
                frmMyAiesecNet a = new frmMyAiesecNet();
                a.Show();
                this.Visible = false;
            }
            
        }

        private void lblRegistracija_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmRegistration formar = new frmRegistration();
            this.Visible = false;
            formar.ShowDialog();
            this.Visible = true;
        }
    }
}
