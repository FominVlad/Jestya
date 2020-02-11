using Microsoft.AspNetCore.Mvc;

namespace AuthApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : Controller
    {
        public AppDbContext DbContext { get; private set; }

        public AuthController(AppDbContext dbContext)
        {
            this.DbContext = dbContext;
        }

    }
}