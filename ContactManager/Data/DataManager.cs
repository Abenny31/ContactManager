using ContactManager.Data;
using ContactManager.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ContactManager
{
    internal class DataManager
    {
        private IDataManager dataManager;

        public DataManager(IDataManager manager)
        {
            this.dataManager = manager;
        }

        public async Task<List<ContactModel>> GetDataAsync()
        {
            return await dataManager.GetDataAsync();
        }
    }
}
