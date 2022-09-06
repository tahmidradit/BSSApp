using BSSApp.Data.Entity;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BSSApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        [HttpGet]
        public async Task<List<Book>> GetBooks()
        {
            return new List<Book>
            {
                new Book
                {
                    Name = "My Life",
                    Author = "Bill Clinton"
                }
            };
        } 
    }
}
