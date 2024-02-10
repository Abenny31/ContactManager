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
    public partial class FrmMessageBox : Form
    {

        public bool IsConfirmed = false;
        public bool IsNo = false;

        public FrmMessageBox()
        {
            InitializeComponent();
        }

        public FrmMessageBox(string message)
        {
            InitializeComponent();
            SetVisibleFalse();
            lblMessage.Text = message;
            btnOk.Visible = true;
        }
        public FrmMessageBox(string message, string caption)
        {
            InitializeComponent();
            SetVisibleFalse();
            lblMessage.Text = message;
            lblCaption.Text = caption;
            lblCaption.Visible = true;
            btnOk.Visible = true;
        }
        public FrmMessageBox(MessageBoxButtons buttons, string message)
        {

            InitializeComponent();
            SetVisibleFalse();
            lblMessage.Text = message;

            if (buttons == MessageBoxButtons.OK)
            {
                btnOk.Visible = true;

            }
            else if (buttons == MessageBoxButtons.YesNo)
            {
                btnYes.Visible = true;
                btnNo.Visible = true;
            }


        }
        public FrmMessageBox(MessageBoxButtons buttons, string message, string naslov)
        {
            InitializeComponent();
            SetVisibleFalse();

            lblMessage.Text = message;
            lblCaption.Text = naslov;
            lblCaption.Visible = true;

            if (buttons == MessageBoxButtons.OK)
            {
                btnOk.Visible = true;
            }
            else if (buttons == MessageBoxButtons.YesNo)
            {
                btnYes.Visible = true;
                btnNo.Visible = true;
            }
            this.StartPosition = FormStartPosition.CenterParent;
        }

        public void SetMessage(string message)
        {
            this.lblMessage.Text = message;
        }
        private void SetVisibleFalse()
        {
            btnNo.Visible = false;
            btnYes.Visible = false;
            btnOk.Visible = false;
        }

        private void FrmMsgConfirm_Load(object sender, EventArgs e)
        {

        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            IsConfirmed = true; this.Close();
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            IsConfirmed = false; this.Close();

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            IsConfirmed = true;
            this.Close();
        }
    }
}
