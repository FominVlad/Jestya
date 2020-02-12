using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AuthApp.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AuthApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RolesController : Controller
    {
        private readonly AppDbContext DbContext;

        public RolesController(AppDbContext dbContext)
        {
            this.DbContext = dbContext;
        }

        [HttpGet]
        public IActionResult GetRolesList()
        {
            return Ok(DbContext.Roles.ToList());
        }

        [HttpPost]
        public IActionResult CreateRole()
        {
            return Created("", DbContext.Roles.ToList());
        }
    }
}