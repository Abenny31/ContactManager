using ContactManager.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace ContactManager
{
    public partial class FrmPhoneNumbers : Form
    {
        public ContactModel contactLoaded = new ContactModel();
        public bool isSaved = false;
        public FrmPhoneNumbers()
        {
            InitializeComponent();
        }

        public FrmPhoneNumbers(List<string> phoneNumbers)
        {
            InitializeComponent();
            contactLoaded.PhoneNumbers = phoneNumbers;

            ShowLabels();
        }

        private void ShowLabels()
        {
           
            if (contactLoaded.PhoneNumbers.Count > 0)
                GenerateLabels();
        }

        private void GenerateLabels()
        {
            panelNumbers.Controls.Clear();

            for (int i = 0; i < contactLoaded.PhoneNumbers.Count; i++)
            {
                string phoneNumber = contactLoaded.PhoneNumbers[i];

                Label label = new Label();
                label.Text = phoneNumber;
                label.AutoSize = true;
                label.Location = new Point(3, 3 + i * 30);
                label.Name = "list" + i.ToString();

                Button removeButton = new Button();
                removeButton.Text = "Remove";
                removeButton.Tag = i;
                removeButton.Location = new Point(180, 3 + i * 30);
                removeButton.Click += RemoveButton_Click;
                removeButton.Name = "btnlist" + i.ToString();

                panelNumbers.Controls.Add(label);
                panelNumbers.Controls.Add(removeButton);
            }
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            int index = (int)button.Tag;

            contactLoaded.PhoneNumbers.RemoveAt(index);

            ShowLabels();
        }

        private void btnPhoneNumber_Click(object sender, EventArgs e)
        {
            if (txtAddPhone.Text == string.Empty)
                return;

            if (!ValidatePhone())
                return;

            contactLoaded.PhoneNumbers.Add(txtAddPhone.Text);
            txtAddPhone.Text = "";
            ShowLabels();
        }

        private bool ValidatePhone()
        {
            
            string phone = txtAddPhone.Text;
            string reg = @"^\+?[0-9]{1,15}$";
           // string reg = @"^([\+]?33[-]?|[0])?[1-9][0-9]{0,12}$";
            bool isValidated = false;
            if (phone != "") 
                isValidated= Regex.IsMatch(phone, reg);

            lblReqPhone.Visible = !isValidated;
            return isValidated;

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            isSaved = true;
            this.Close();
        }

        private void btnDiscard_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lblReqPhone.Visible = false;
            txtAddPhone.Text = String.Empty;
        }
    }

}
