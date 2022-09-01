using BSSApp.Data.Model;
using BSSApp.Repository.Account;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BSSApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly IAccountRepository accountRepository;

        public AccountController(IAccountRepository accountRepository)
        {
            this.accountRepository = accountRepository;
        }

        [HttpPost("registration")]
        public async Task<IActionResult> Registration([FromBody] Registration registration)
        {
            var result = await accountRepository.RegisterAsync(registration);
            
            if(result.Succeeded)
            {
                return Ok(result.Succeeded);
            }
            return Unauthorized();                                                                                                    
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

        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] Login login)
        {
            var result = await accountRepository.LoginAsync(login);

            if (result.Succeeded)
            {
                return Ok(result.Succeeded);
            }

            //if (string.IsNullOrEmpty(result.Succeeded))
            //{
            //    return Unauthorized();
            //}

            return Ok(result);
        }
    }
}
