using ContactManager.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ContactManager.Data
{
    public class DatabaseManager : IDataManager
    {
        public LoginModel CheckUser(string userName, string password)
        {
            throw new NotImplementedException();
        }

        public async Task<ResponseModel> DeleteDataAsync(ContactModel contact)
        {
            throw new System.NotImplementedException();
        }
        public async Task<List<ContactModel>> GetDataAsync()
        {
            return new List<ContactModel>
            {
                new ContactModel("Ante", "Benic", DateTime.Now, 'M',  "12string3243" ),
                new ContactModel("Ante1", "Benic1", DateTime.Now, 'M', "12343543"),
                new ContactModel("Ante2", "Benic2", DateTime.Now, 'M',"123243" )
            };
        }

        public async Task<ResponseModel> ModifyDataAsync(ContactModel contact)
        {
            throw new System.NotImplementedException();
        }

        public async Task<ResponseModel> SaveDataAsync(ContactModel contact)
        {
            throw new System.NotImplementedException();
        }
    }
}
