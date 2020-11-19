using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PhoneBook.Entity
{
    public class UserToContact : BaseEntity
    {
        public int UserId { get; set; }
        public int ContactId { get; set; }

        [ForeignKey("UserId")]
        public User ParentUser { get; set; }
        [ForeignKey("ContactId")]
        public Contact ParentContact { get; set; }
    }
}
