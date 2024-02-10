using ContactManager.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ContactManager.Data
{
    public interface IDataManager
    {
        Task<List<ContactModel>> GetDataAsync();
        Task<ResponseModel> SaveDataAsync(ContactModel contact);
        Task<ResponseModel> DeleteDataAsync(ContactModel contact);
        Task<ResponseModel> ModifyDataAsync(ContactModel contact);
    }
}
