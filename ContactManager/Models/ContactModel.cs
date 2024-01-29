using System;
using System.Collections.Generic;

namespace ContactManager.Models
{
    public class ContactModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime DateOfBirth { get; set; }
        public char Sex { get; set; }
        public string PhoneNumber { get; set; }
        List<string> PhoneNumbers { get; set; }

        public ContactModel()
        { }
        public ContactModel(string name, string surname, DateTime dateOfBirth, char sex, string phoneNumber)
        {
            Name = name;
            Surname = surname;
            DateOfBirth = dateOfBirth;
            Sex = sex;
            PhoneNumber = phoneNumber;
        }
        public ContactModel(int id,string name, string surname, DateTime dateOfBirth, char sex, string phoneNumber)
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
