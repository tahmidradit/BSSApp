using BSSApp.Data.Model;
using BSSApp.Repository;
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
    }
}
