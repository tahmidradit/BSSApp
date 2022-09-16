using BSSApp.Data.Entity;
using BSSApp.Data.Model;
using BSSApp.Repository.Account;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.JsonWebTokens;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using JwtRegisteredClaimNames = System.IdentityModel.Tokens.Jwt.JwtRegisteredClaimNames;

namespace BSSApp.Service.Account
{
    public class AccountRepository : ControllerBase, IAccountRepository
    {
        private readonly UserManager<ApplicationUser> userManager;
        private readonly SignInManager<ApplicationUser> signInManager;
        private readonly IConfiguration configuration;

        public AccountRepository(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager, IConfiguration configuration)
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
            this.configuration = configuration;
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

        //public async Task<SignInResult> LoginAsync(Login login)
        //{
        //    //var result = await signInManager.PasswordSignInAsync(login.Email, login.Password, false, false);
        //     return await signInManager.PasswordSignInAsync(login.Email, login.Password, false, false);

        //    //if (!result.Succeeded)
        //    //{
        //    //    return null;
        //    //}

        //    //var claims = new List<Claim>
        //    //{
        //    //    new Claim(ClaimTypes.Name, login.Email),
        //    //    new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())
        //    //};

        //    //var loginKey = new SymmetricSecurityKey(Encoding.ASCII.GetBytes(configuration["JWT:Secret"]));

        //    //var jwtAuthenticationToken = new JwtSecurityToken(
        //    //    issuer: configuration["JWT:ValidIssuer"],
        //    //    audience: configuration["JWT:ValidAudience"],
        //    //    expires: DateTime.Now.AddDays(1),
        //    //    claims: claims,
        //    //    signingCredentials: new SigningCredentials(loginKey, SecurityAlgorithms.HmacSha256Signature)
        //    //    );

        //    //return new JwtSecurityTokenHandler().WriteToken(jwtAuthenticationToken);

        //    //return result;

            
        //}
    }
}
