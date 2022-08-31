using System.ComponentModel.DataAnnotations;

namespace BSSApp.Data.Entity
{
    public class Registration
    {
        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public string UserName { get; set; }

        [Required, EmailAddress]
        public string Email { get; set; }

        [Required, Compare("ConfirmPassword")]
        public string Password { get; set; }
        
        [Required]
        public string ConfirmPassword { get; set; }
    }
}
