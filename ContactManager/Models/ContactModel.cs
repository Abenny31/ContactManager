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
        public SexEnum Sex { get; set; }
        public string PhoneNumber { get; set; }
        public List<string> PhoneNumbers { get; set; } = new List<string>();

        public ContactModel()
        { PhoneNumbers = new List<string>(); }

    }

    public enum SexEnum
    { 
        M='M',
        W='W',
        NotSpecified=0
    
    }
}
