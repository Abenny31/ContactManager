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
        private DataManager _dataManager;
        private ContactModel _selectedContactModel;
        public FrmContactList()
        {
            InitializeComponent();
        }

        private void FrmContactList_Load(object sender, EventArgs e)
        {
            //TODO: Load config set default database manager.
            _dataManager = new DataManager(new JsonDataManager());

            GetContacts();
            
           
        }

        private void FillGrid()
        {
            grdContactList.DataSource = new BindingList<ContactModel>(_contactListLoad);
            grdContactList.Refresh();
        }

        private async Task GetContacts()
        {
            _contactListLoad = await Task.Run(() => _dataManager.GetDataAsync());
            FillGrid();
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {

        }

        private void btnEditContact_Click(object sender, EventArgs e)
        {

        }

        private void btnDeleteContact_Click(object sender, EventArgs e)
        {
            


        }

    }
}
