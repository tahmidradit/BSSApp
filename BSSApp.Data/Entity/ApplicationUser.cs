using Microsoft.AspNetCore.Identity;

namespace BSSApp.Data.Entity
{
    public class ApplicationUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public int PostCode { get; set; }
    }
}
