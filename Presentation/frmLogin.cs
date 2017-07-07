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
using Logic.Properties;

namespace Presentation
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        private void RunMainForm ()
        {
            Visible = false;
            frmMyAiesecNet a = new frmMyAiesecNet();
            a.ShowDialog();
            if (LoginLogic.GetSettings())
            {
                Visible = true;
            }
            else Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            LoginLogic login = new LoginLogic();
            if (login.Login(txtEmail.Text, txtPassword.Text)) RunMainForm();
            else
            {
                MessageBox.Show("Email ili lozinka nisu ispravni!", "Netočni podaci", MessageBoxButtons.OK);
                txtEmail.Clear();
                txtPassword.Clear();
            }
            
        }

        private void lblRegistracija_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmRegistration formar = new frmRegistration();
            this.Visible = false;
            formar.ShowDialog();
            this.Visible = true;
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            if (LoginLogic.LoginFromSession())
            {
                RunMainForm();
            }
        }

        private void frmMyAiesecNet_Load(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
