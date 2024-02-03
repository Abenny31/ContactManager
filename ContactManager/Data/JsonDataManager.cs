using ContactManager.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContactManager.Data
{
    public class JsonDataManager : IDataManager
    {
        public ResponseModel Response { get; set; }

        public async Task<ResponseModel> DeleteDataAsync(ContactModel contact)
        {
            try
            {
                List<ContactModel> list = await GetDataAsync();
                list.RemoveAll(c => c.Id == contact.Id);
                string updatedJsonData = JsonConvert.SerializeObject(list);
                SaveJsonToFile(Global.JsonLocation, updatedJsonData);

                return new ResponseModel(true, "Contact deleted successfully");
            }
            catch (Exception e)
            {
                return new ResponseModel(false, "Delete failed!");
            }
        }

        public async Task<List<ContactModel>> GetDataAsync()
        {
            List<ContactModel> list = new List<ContactModel>();
            string jsonData = LoadJsonFromFile(Global.JsonLocation);
            list = JsonConvert.DeserializeObject<List<ContactModel>>(jsonData);

            return list;
        }
        public async Task<ResponseModel> ModifyDataAsync(ContactModel contact)
        {
            List<ContactModel> list = await GetDataAsync();

            ContactModel existingContact = list.FirstOrDefault(c => c.Id == contact.Id);

            if (existingContact != null)
            {
                existingContact.Name = contact.Name;
                existingContact.Surname = contact.Surname;
                existingContact.Sex = contact.Sex;
                existingContact.DateOfBirth = contact.DateOfBirth;
                existingContact.PhoneNumber = contact.PhoneNumber;

                string updatedJsonData = JsonConvert.SerializeObject(list);
                SaveJsonToFile(Global.JsonLocation, updatedJsonData);

                return new ResponseModel(true, "Contact modified successfully");
            }
            else
            {
                return new ResponseModel(false, "Edit failed!");
            }
        }

        private void SaveJsonToFile(string jsonLocation, string updatedJsonData)
        {
            File.WriteAllText(jsonLocation, updatedJsonData);
        }

        public async Task<ResponseModel> SaveDataAsync(ContactModel contact)
        {
            try
            {
                List<ContactModel> list = await GetDataAsync();
                int lastId = list.Any() ? list.Max(c => c.Id) : 0;
                contact.Id = lastId + 1;
                list.Add(contact);
                string updatedJsonData = JsonConvert.SerializeObject(list);
                SaveJsonToFile(Global.JsonLocation, updatedJsonData);

                return new ResponseModel(true, "Contact saved successfully");
            }
            catch (Exception e)
            {
                return new ResponseModel(false, "Save failed!");
            }
        }

        private string LoadJsonFromFile(string filePath)
        {

            string jsonData = string.Empty;
            if (File.Exists(filePath))
            {
                try
                {
                    jsonData = File.ReadAllText(filePath);
                }
                catch (Exception ex)
                {
                    jsonData = $"Error loading users from file: {ex.Message}";
                }
            }
            else
            {
                jsonData = "User data file not found.";
            }
            return jsonData;
        }

        public LoginModel CheckUser(string userName, string password)
        {
            throw new NotImplementedException();
        }
    }
}

