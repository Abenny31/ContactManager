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
    public partial class FrmModifyContact : Form
    {
        private ContactModel _contactLoaded;
        public ContactModel _contactSaved;
        public bool isSaved = false;
        public FrmModifyContact()
        {
            InitializeComponent();
        }

        public FrmModifyContact(ContactModel contact)
        {
            InitializeComponent();
            _contactLoaded = contact;
        }

        private void FrmModifyContact_Load(object sender, EventArgs e)
        {
            if (_contactLoaded != null)
            {
                FillForm();
            }
        }


        private void FillForm()
        {
            txtName.Text = _contactLoaded.Name;
            txtSurname.Text = _contactLoaded.Surname;
            dtDob.Value = _contactLoaded.DateOfBirth;        
            txtPhoneNumber.Text = _contactLoaded.PhoneNumber;

            SetSexCB(_contactLoaded.Sex);

        }

        private void SetSexCB(char sex)
        {
            cbM.Checked = (sex == 'M');
            cbW.Checked = (sex != 'M');
        }
        private char SetSexChar()
        {
            char sex = '0';
            sex = cbM.Checked ? 'M' : 'W';
            return sex;
        }


        private void btnPhoneNumber_Click(object sender, EventArgs e)
        {
            FrmPhoneNumbers frm = new FrmPhoneNumbers();
            frm.ShowDialog();
        }

        private void btnDiscard_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {

            _contactSaved = GetModelContact();
            if (_contactLoaded != null)
            {
                _contactSaved.Id = _contactLoaded.Id;
                await DM._dataManager.ModifyDataAsync(_contactSaved);
            }
            else
                await DM._dataManager.SaveDataAsync(_contactSaved);

             new FrmMessageBox("Contact Saved").ShowDialog();
            isSaved = true;
            this.Close();
        }

        private ContactModel GetModelContact()
        {
            ContactModel contactModel = new ContactModel();
            contactModel.Name=txtName.Text ;
            contactModel.Surname= txtSurname.Text;
            contactModel.DateOfBirth= dtDob.Value;
            contactModel.Sex= SetSexChar();
            contactModel.PhoneNumber= txtPhoneNumber.Text;


            return contactModel;
        }
    }
}
