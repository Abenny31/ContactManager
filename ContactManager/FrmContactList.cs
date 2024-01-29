using ContactManager.Data;
using ContactManager.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContactManager
{
    public partial class FrmContactList : Form
    {
        private List<ContactModel> _contactListLoad = new List<ContactModel>();
        private ContactModel _selectedContactModel;

        public FrmContactList()
        {
            InitializeComponent();
        }
        public FrmContactList(DataManager dataManager)
        {
            InitializeComponent();
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

        public async Task GetContacts()
        {
            _contactListLoad = await Task.Run(() => DM._dataManager.GetDataAsync());
            FillGrid();
        }

        private async void btnAddNew_Click(object sender, EventArgs e)
        {
            FrmModifyContact frm = new FrmModifyContact();
            frm.ShowDialog();
            if (!frm.isSaved)
                return;

             await GetContacts();

        }

        private async void btnEditContact_Click(object sender, EventArgs e)
        {

            ContactModel contact = GetContactFromRow();
            FrmModifyContact frm = new FrmModifyContact(contact);
            frm.ShowDialog();
            if (!frm.isSaved)
                return;

            await GetContacts();

        }

        private ContactModel GetContactFromRow()
        {
            ContactModel contact = new ContactModel();
            DataGridViewRow selectedRow = grdContactList.CurrentRow;

            contact = selectedRow?.DataBoundItem as ContactModel;

            return contact;

        }

        private async void btnDeleteContact_Click(object sender, EventArgs e)
        {
            ContactModel contact = GetContactFromRow();
            ResponseModel result = await DM._dataManager.DeleteDataAsync(contact);
            new FrmMessageBox(result.Message).ShowDialog();

            await GetContacts();

        }

    }
}
