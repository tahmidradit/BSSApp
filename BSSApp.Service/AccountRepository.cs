using BSSApp.Data.Entity;
using BSSApp.Data.Model;
using BSSApp.Repository;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSSApp.Service
{
    public class AccountRepository : IAccountRepository
    {
        private readonly UserManager<ApplicationUser> userManager;

        public AccountRepository(UserManager<ApplicationUser> userManager)
        {
            this.userManager = userManager;
        }

        public async Task<IdentityResult> RegisterAsync(Registration registration)
        {
            var user = new ApplicationUser()
            {
                FirstName = registration.FirstName,
                LastName = registration.LastName,
                Email = registration.Email,
                UserName = registration.UserName
            };
            return await userManager.CreateAsync(user, registration.Password);
        }


    }
}
