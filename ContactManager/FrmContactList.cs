using ContactManager.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ContactManager
{
    public partial class FrmContactList : Form
    {
        private List<ContactModel> _contactListLoad = new List<ContactModel>();

        public FrmContactList()
        {
            InitializeComponent();
            CheckJsonPath();
        }

        private void CheckJsonPath()
        {
            if (!File.Exists(Global.JsonLocation))
            {
                CreateJsonFile();
            }
        }

        private void CreateJsonFile()
        {
            try
            {
                string directoryPath = Path.GetDirectoryName(Global.JsonLocation);
                if (!Directory.Exists(directoryPath))
                {
                    Directory.CreateDirectory(directoryPath);
                }
                using (File.Create(Global.JsonLocation)) { }

            }
            catch 
            {
                new FrmMessageBox().Show();
            }
        }

        private void FrmContactList_Load(object sender, EventArgs e)
        {
            GetContacts();
        }

        public void FillGrid()
        {
            grdContactList.DataSource = new BindingList<ContactModel>(_contactListLoad);
            grdContactList.Refresh();
        }

        public async void GetContacts()
        {
            ClearGrid();
            pBar1.Visible = true;
            pBar1.Value = 60;
            _contactListLoad = await Task.Run(() => DM._dataManager.GetDataAsync());
            pBar1.Value = 100;
            await Task.Delay(500);
            pBar1.Visible = false;

            FillGrid();
           
        }

        private void ClearGrid()
        {
            grdContactList.Rows.Clear();
        }

        private  void btnAddNew_Click(object sender, EventArgs e)
        {
            FrmModifyContact frm = new FrmModifyContact();
            frm.ShowDialog();
            if (!frm.isSaved)
                return;

            GetContacts();
        }

        private  void btnEditContact_Click(object sender, EventArgs e)
        {
            (ContactModel contact, bool success) = GetContactFromRow();

            if (!success)
            {
                return;
            }
            FrmModifyContact frm = new FrmModifyContact(contact);
            frm.ShowDialog();
            if (!frm.isSaved)
                return;

            GetContacts();
        }

        private (ContactModel contact, bool success) GetContactFromRow()
        {
            ContactModel contact = new ContactModel();
            DataGridViewRow selectedRow = grdContactList.CurrentRow;

            if (selectedRow == null)
            {
                new FrmMessageBox("No contact is selected!").ShowDialog();
                return (contact, false);
            }

            int selectedId = (int)selectedRow.Cells["Id"].Value;
            contact = _contactListLoad.FirstOrDefault(c => c.Id == selectedId);

            return (contact,true);
        }

        private async void btnDeleteContact_Click(object sender, EventArgs e)
        {
            FrmMessageBox frm = new FrmMessageBox(MessageBoxButtons.YesNo, "Do you want to delete contact?");
            frm.ShowDialog();

            if (!frm.IsConfirmed)
                return;

            (ContactModel contact, bool success) = GetContactFromRow();
            if (!success)
                return;
            ResponseModel result = await DM._dataManager.DeleteDataAsync(contact);
            new FrmMessageBox(result.Message).ShowDialog();

            GetContacts();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            GetContacts();
        }
    }
}
