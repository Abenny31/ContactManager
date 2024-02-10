using ContactManager.Data;
using ContactManager.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContactManager
{
    public partial class FrmLogin : Form
    {
        public bool userAuthenticated = false;
        public LoginModel _loginModel;

        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Login();
        }
        private void Login()
        {
            this.Cursor.Equals(Cursors.WaitCursor);
            if (!string.IsNullOrWhiteSpace(txtUserName.Text) && !string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                _loginModel = new LoginModel(txtUserName.Text, txtPassword.Text, DateTime.Now);
                AuthenticateLogin();
            }
            if (userAuthenticated)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            this.Cursor.Equals(Cursors.Default);

        }
        private void AuthenticateLogin()
        {
            SetLblMessage(CheckUser());
        }

        private void SetLblMessage(bool isSuccess)
        {
            lblMessage.Text = isSuccess ? "Success!" : "Login failed!";
            lblMessage.Visible = true;
            txtPassword.Text = string.Empty;
        }

        private bool CheckUser()
        {
            userAuthenticated = CheckUserData(txtUserName.Text, txtPassword.Text);
            return userAuthenticated;
        }

        private bool CheckUserData(string txtUserName, string txtPassword)
        {
            if (txtUserName == Global.user && txtPassword == Global.pass)
                return true;
            else
                return false;
        }
        private void FrmLogin_Load(object sender, EventArgs e)
        {
            txtUserName.Focus();
        }

    }
}
