using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactManager.Models
{
    internal class LoginModel
    {
        internal int Id { get; set; }
        internal string UserName { get; set; }
        internal string Password { get; set; }
        internal DateTime CreateDate { get; set; }
        internal DateTime LastLogin { get; set; }

        public LoginModel(string userName, string password, DateTime lastLogin)
        {
            UserName = userName;
            Password = password;
            LastLogin = lastLogin;
        }
    }
}
