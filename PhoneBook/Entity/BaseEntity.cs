using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PhoneBook.Entity
{
    public abstract class BaseEntity
    {
        [Key]
        public int Id { get; set; }
    }
}
