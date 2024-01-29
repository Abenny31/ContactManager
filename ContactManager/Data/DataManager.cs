using ContactManager.Data;
using ContactManager.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ContactManager
{
    public class DataManager :IDataManager
    {
        private IDataManager dataManager;

        public DataManager(IDataManager manager)
        {
            this.dataManager = manager;
        }

        public LoginModel CheckUser(string userName, string password)
        {
            return dataManager.CheckUser(userName, password);
        }

        public async Task<ResponseModel> DeleteDataAsync(ContactModel contact)
        {
            return await dataManager.DeleteDataAsync(contact);
        }

        public async Task<List<ContactModel>> GetDataAsync()
        {
            return await dataManager.GetDataAsync();
        }

        public async Task<ResponseModel> ModifyDataAsync(ContactModel contact)
        {
            return await dataManager.ModifyDataAsync(contact);
        }

        public async Task<ResponseModel> SaveDataAsync(ContactModel contact)
        {
            return await dataManager.SaveDataAsync(contact);
        }
    }
}
