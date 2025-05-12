using Microsoft.AspNetCore.Mvc;
using System.Linq;
using WebApplication1.Data;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserLekeres : Controller
    {
        private readonly ApplicationDbContext _context;

        public UserLekeres(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet("User")]
        public async Task<IActionResult> GetUserData()
        {
            var user = await _context.User.ToListAsync();

            var id = user.Id;

            

            return Ok(user);
            
        }
    }
}
