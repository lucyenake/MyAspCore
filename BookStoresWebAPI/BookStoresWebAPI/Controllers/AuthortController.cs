using BookStoresWebAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace BookStoresWebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AuthorController : ControllerBase
    {       
        [HttpGet]
        public IEnumerable<Author> Get()
        {
            using (var context = new BookStoresDbContext())
            {
                return context.Authors.ToList();
            }
        }
    }
}