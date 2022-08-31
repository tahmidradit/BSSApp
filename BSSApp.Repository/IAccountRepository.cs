using BSSApp.Data.Entity;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSSApp.Repository
{
    public interface IAccountRepository
    {
        Task<IdentityResult> RegisterAsync(Registration registration);
    }
}
