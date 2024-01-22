using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Menu;

namespace ContactManager.Models
{
    internal class ContactModel
    {
        internal int Id { get; set; }
        internal string Name { get; set; }
        internal string Surname { get; set; }
        internal DateTime DateOfBirth { get; set; }
        internal char Sex { get; set; }
        internal string PhoneNumber { get; set; }
        List<string> PhoneNumbers { get; set; }

        internal ContactModel()
        { }
        internal ContactModel(string name, string surname, DateTime dateOfBirth, char sex, string phoneNumber)
        {
            Name = name;
            Surname = surname;
            DateOfBirth = dateOfBirth;
            Sex = sex;
            PhoneNumber = phoneNumber;
        }
        internal ContactModel(int id,string name, string surname, DateTime dateOfBirth, char sex, string phoneNumber)
        {
            Id = id;
            Name = name;
            Surname = surname;
            DateOfBirth = dateOfBirth;
            Sex = sex;
            PhoneNumber = phoneNumber;
        }
    }
}
