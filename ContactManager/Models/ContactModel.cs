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
        List<string> PhoneNumber { get; set; }


    }
}
