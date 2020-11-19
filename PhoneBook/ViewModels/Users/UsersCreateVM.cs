using System.ComponentModel.DataAnnotations;

namespace PhoneBook.ViewModels.Users
{
    public class UsersCreateVM
    {
        [Required(ErrorMessage = "*This field is required!")]
        public string Username { get; set; }

        [Required(ErrorMessage = "*This field is required!")]
        public string Password { get; set; }

        [Required(ErrorMessage = "*This field is required!")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "*This field is required!")]
        public string LastName { get; set; }
    }
}