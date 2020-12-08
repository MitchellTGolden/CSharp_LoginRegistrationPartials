using System.ComponentModel.DataAnnotations;

namespace LoginRegPartials.Models
{
    public class RegUser
    {
        [Display(Name = "First Name:")]
        [Required]
        [MinLength(4)]
        public string FirstName { get; set; }
        [Display(Name = "Last Name:")]
        [Required]
        [MinLength(4)]
        public string LastName { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [MinLength(8)]
        public string Password { get; set; }
        [Required]
        [Compare("Password", ErrorMessage = "Passwords must match!")]
        [DataType(DataType.Password)]
        public string ConfirmPW { get; set; }
    }
}