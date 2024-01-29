using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactManager.Models
{
    public class LoginModel
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public DateTime? CreateDate { get; set; }
        public DateTime? LastLogin { get; set; }

        public LoginModel(string userName, string password, DateTime lastLogin)
        {
            UserName = userName;
            Password = password;
            LastLogin = lastLogin;
        }
    }
}
