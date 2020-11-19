using System.ComponentModel.DataAnnotations;

namespace PhoneBook.ViewModels.Contacts
{
    public class ContactsEditVM
    {
        public int Id { get; set; }

        public int UserId { get; set; }

        [Required(ErrorMessage = "*This field is required!")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "*This field is required!")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "*This field is required!")]
        public string Email { get; set; }
    }
}