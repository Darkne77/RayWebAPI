using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using RayWebAPI.EF;
using RayWebAPI.Models;

namespace RayWebAPI.Controllers
{
    [ApiController]
    [Route("api/User")]
    public class UserController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<User> GetUsers()
        {
            var users = new List<User>();
            using (var dbContext = new RayDbContext())
            {
                users.AddRange(dbContext.Users.ToList());
            }
            return users;
        }
    }
}