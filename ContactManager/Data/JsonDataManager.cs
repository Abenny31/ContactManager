using ContactManager.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ContactManager.Data
{
    internal class JsonDataManager : IDataManager
    {
        public Task<ResponseModel> DeleteDataAsync(ContactModel contact)
        {
            throw new NotImplementedException();
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
        public Task<ResponseModel> ModifyDataAsync(ContactModel contact)
        {
            throw new NotImplementedException();
        }

        public Task<ResponseModel> SaveDataAsync(ContactModel contact)
        {
            throw new NotImplementedException();
        }
    }
}
