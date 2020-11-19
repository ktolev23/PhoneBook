using System.ComponentModel.DataAnnotations;

namespace PhoneBook.ViewModels.Contacts
{
    public class ContactsCreateVM
    {
        [Required(ErrorMessage = "*This field is required!")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "*This field is required!")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "*This field is required!")]
        public string Email { get; set; }
    }
}