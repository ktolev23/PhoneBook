using PhoneBook.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PhoneBook.ViewModels.Contacts
{
    public class ContactsShareVM
    {
        public int UserId { get; set; }
        public int ContactId { get; set; }
        public Contact Contact { get; set; }
        public List<User> SharedWith { get; set; }
        public List<User> Users { get; set; }
    }
}
