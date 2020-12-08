using System.ComponentModel.DataAnnotations;

namespace LoginRegPartials.Models
{
    public class LogUser
    {
        [Required]
        [Display(Name = "Email:")]
        [EmailAddress]
        public string LogEmail { get; set; }

        [Required]
        [Display(Name = "Password:")]
        [DataType(DataType.Password)]
        [MinLength(8,ErrorMessage = "Password/Email Must Be Valid!")]
        public string LogPassword { get; set; }
    }
}