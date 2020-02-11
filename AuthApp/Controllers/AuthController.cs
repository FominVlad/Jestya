using AuthApp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace AuthApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : Controller
    {
        private readonly AppDbContext DbContext;

        public AuthController(AppDbContext dbContext)
        {
            this.DbContext = dbContext;
        }

        [HttpPost]
        public IActionResult Register(RegisterUserDTO userDTO)
        {
            if (DbContext.Users.Count() > 0)
            {
                return Forbid();
            }

            DbContext.Users.Add(userDTO);
            DbContext.SaveChanges();

            return Created("", new { JWT = "" });
        }
    }
}