using ContactManager.Models;
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
    internal partial class FrmLogin : Form
    {
        internal bool userAuthenticated = false;
        internal LoginModel _loginModel;

        internal FrmLogin()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
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
            lblPassword.Text = string.Empty;
        }

        private bool CheckUser()
        {
            if (_loginModel == null)
                return false;
            //TODO: connect to db or json and check user.
            userAuthenticated = true; 
            return true;
        }
    }
}
