using BSSApp.Data.Entity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BSSApp.Repository.Data
{
    public class BSSDbContext : IdentityDbContext<ApplicationUser>
    {
        public BSSDbContext(DbContextOptions<BSSDbContext> options) : base(options) { }
    }
}
