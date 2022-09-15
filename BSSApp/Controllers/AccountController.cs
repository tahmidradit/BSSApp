using BSSApp.Data.Entity;
using BSSApp.Data.Model;
using BSSApp.Repository.Account;
using BSSApp.Repository.Data;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace BSSApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly BSSDbContext context;
        private readonly UserManager<ApplicationUser> userManager;
        private readonly IAccountRepository accountRepository;

        public AccountController(BSSDbContext context, UserManager<ApplicationUser> userManager, IAccountRepository accountRepository)
        {
            this.context = context;
            this.userManager = userManager;
            this.accountRepository = accountRepository;
        }

        [HttpPost]
        [Route("registration")]
        public async Task<IActionResult> Registration([FromBody]Registration registration)
        {
            //var user = new ApplicationUser()
            //{
            //    FirstName = registration.FirstName,
            //    LastName = registration.LastName,
            //    Email = registration.Email,
            //    UserName = registration.UserName
            //};
            //await userManager.CreateAsync(user, registration.Password);


            //var result = await accountRepository.RegisterAsync(registration);

            //if (result.Succeeded)
            //{
            //    return Ok(result.Succeeded);
            //}
            //return Unauthorized();
            await accountRepository.RegisterAsync(registration);
            return Ok();
        }

        //[HttpPost("login")]
        //public async Task<IActionResult> Login([FromBody] Login login)
        //{
        //    var result = await accountRepository.LoginAsync(login);

        //    if(string.IsNullOrEmpty(result))
        //    {
        //        return Unauthorized();
        //    }

        //    return Ok(result);
        //}

        //[HttpPost("login")]
        //public async Task<IActionResult> Login([FromBody] Login login)
        //{
        //    var result = await accountRepository.LoginAsync(login);

        //    if (result.Succeeded)
        //    {
        //        return Ok(result.Succeeded);
        //    }

        //    //if (string.IsNullOrEmpty(result.Succeeded))
        //    //{
        //    //    return Unauthorized();
        //    //}

        //    return Ok(result);
        //}
    }
}
