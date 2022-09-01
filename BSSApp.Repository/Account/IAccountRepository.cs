using BSSApp.Data.Model;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSSApp.Repository.Account
{
    public interface IAccountRepository
    {
        Task<IdentityResult> RegisterAsync(Registration registration);
        Task<SignInResult> LoginAsync(Login login);
    }
}
