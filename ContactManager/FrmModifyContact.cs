using Newtonsoft.Json.Linq;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContactManager.Models
{
    public partial class FrmModifyContact : Form
    {
        private ContactModel _contactLoaded;
        public ContactModel _contactSaved = new ContactModel();
        public bool isSaved = false;
        public List<string> _PhoneNumbers = new List<string>();
        public FrmModifyContact()
        {
            InitializeComponent();
        }

        public FrmModifyContact(ContactModel contact)
        {
            InitializeComponent();
            _contactLoaded = contact;
            if (contact.PhoneNumbers != null)
                _PhoneNumbers = contact.PhoneNumbers.Count > 0 ? contact.PhoneNumbers : _PhoneNumbers;

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
            ShowList();
        }

        private void ShowList()
        {
            List<string> numbers=new List<string>();
            panelNumbers.Controls.Clear();
            if (_contactSaved.PhoneNumbers != null && _contactSaved.PhoneNumbers.Count > 0)
                numbers = new List<string>(_contactSaved.PhoneNumbers);
            else if (_PhoneNumbers != null && _PhoneNumbers.Count > 0)
                numbers = new List<string>(_PhoneNumbers);

            if (numbers != null && numbers.Count > 0)
            {
                _PhoneNumbers = numbers;
                panelNumbers.Controls.Clear();
                for (int i = 0; i < numbers.Count; i++)
                    CreateLabel(numbers[i], i);
            }
        }

        private void CreateLabel(string phoneNumber,int i)
        {
            Label label = new Label();
            label.Text = phoneNumber;
            label.AutoSize = true;
            label.Location = new Point(3, 3 + i * 30);
            panelNumbers.Controls.Add(label);
            
        }
        private void SetSexCB(SexEnum sex)
        {
            cbM.Checked = (sex == SexEnum.M);
            cbW.Checked = (sex != SexEnum.M);
        }
        private SexEnum SetSexChar()
        {
            SexEnum sex;
            sex = cbM.Checked ? SexEnum.M : SexEnum.W;
            return sex;
        }


        private void btnPhoneNumber_Click(object sender, EventArgs e)
        {
            FrmPhoneNumbers frm = new FrmPhoneNumbers(new List<string>(_PhoneNumbers));
            frm.ShowDialog();

            if (frm.isSaved)
            {
                _contactSaved.PhoneNumbers = frm.contactLoaded.PhoneNumbers;
                ShowList();
            }

        }

        private void btnDiscard_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {

            if (!ValidateData())
                return;
            _contactSaved = GetModelContact();
            if (_contactLoaded != null)
            {
                _contactSaved.Id = _contactLoaded.Id;

                if (!CheckContactLoaded())
                {
                    FrmMessageBox frm = new FrmMessageBox(MessageBoxButtons.YesNo, "Do you want to save changes?");
                    frm.ShowDialog();
                    if (!frm.IsConfirmed)
                        return;
                    await DM._dataManager.ModifyDataAsync(_contactSaved);
                }
                else
                {
                    new FrmMessageBox(MessageBoxButtons.OK, "No changes were made").ShowDialog();
                    return;
                }

            }
            else
                await DM._dataManager.SaveDataAsync(_contactSaved);

            new FrmMessageBox("Contact Saved").ShowDialog();
            isSaved = true;
            this.Close();
        }

        private bool CheckContactLoaded()
        {
            bool isEqual = true;
            Type type = typeof(ContactModel);
            PropertyInfo[] properties = type.GetProperties();

            foreach (PropertyInfo property in properties)
            {
                object load = property.GetValue(_contactLoaded, null);
                object save = property.GetValue(_contactSaved, null);

                if (load == null && save == null)
                {
                    continue;
                }
                else if (load is IList list1 && save is IList list2)
                {
                    if (!AreListsEqual(list1, list2))
                    {
                        isEqual= false;
                    }
                }
                else if ((load == null && save != null) || !load.Equals(save))
                {
                    isEqual = false;
                }
            }
            return isEqual;
        }

        public  bool AreListsEqual(IList list1, IList list2)
        {
            if (list1.Count != list2.Count)
            {
                return false;
            }

            for (int i = 0; i < list1.Count; i++)
            {
                object item1 = list1[i];
                object item2 = list2[i];

                if (item1 == null && item2 == null)
                {
                    continue;
                }

                if (item1 == null || !item1.Equals(item2))
                {
                    return false;
                }
            }

            return true;
        }
        private bool ValidateData()
        {
            ClearValidation();
            if (txtName.Text == "")
                lblReqName.Visible = true;

            if (!ValidatePhone())
                lblReqPhone.Visible = true;

            if (lblReqName.Visible || lblReqPhone.Visible)
                return false;
            else
                return true;
            

        } 
        private void ClearValidation()
        {
            lblReqName.Visible = false;
            lblReqPhone.Visible = false;
        }

        private bool ValidatePhone()
        {
            string phone = txtPhoneNumber.Text;

            //string reg = @"^([\+]?33[-]?|[0])?[1-9][0-9]{0,12}$";
            string reg = @"^\+?[0-9]{1,15}$";

            if (phone != "") return Regex.IsMatch(phone, reg);
            else return false;

        }

        private ContactModel GetModelContact()
        {
            ContactModel contactModel = new ContactModel();
            contactModel.Name = txtName.Text;
            contactModel.Surname = txtSurname.Text;
            contactModel.DateOfBirth = dtDob.Value;
            contactModel.Sex = SetSexChar();
            contactModel.PhoneNumber = txtPhoneNumber.Text;
            contactModel.PhoneNumbers = _PhoneNumbers.Count>0 ? _PhoneNumbers : new List<string>();

            return contactModel;
        }
    }
}
