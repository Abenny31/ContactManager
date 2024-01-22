using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContactManager.Models
{
    internal partial class FrmModifyContact : Form
    {
        private ContactModel _contactLoaded;
        internal FrmModifyContact()
        {
            InitializeComponent();
        }

        internal FrmModifyContact(ContactModel contact)
        {
            InitializeComponent();
            _contactLoaded = contact;
        }

        private void FrmModifyContact_Load(object sender, EventArgs e)
        {
            if (_contactLoaded.Id != null)
            {
                FillForm();
            }
        }


        private void FillForm()
        {
            txtName.Text = _contactLoaded.Name;
            txtSurname.Text = _contactLoaded.Surname;
            txtDob.Text = _contactLoaded.DateOfBirth.ToString();
            txtSex.Text = _contactLoaded.Sex.ToString();
            txtPhoneNumber.Text = _contactLoaded.PhoneNumber;



        }
    }
}
