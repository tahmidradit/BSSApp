using System.ComponentModel.DataAnnotations;

namespace BSSApp.Data.Entity
{
    public class Registration
    {
        [Required]
        public string Name { get; set; }

        [Required, EmailAddress]
        public string Email { get; set; }

        [Required, Compare("ConfirmPassword")]
        public string Password { get; set; }
        
        [Required]
        public string ConfirmPassword { get; set; }
    }
}
