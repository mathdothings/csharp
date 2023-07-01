using System;
using Microsoft.AspNetCore.Mvc;
using UserCRUD.Model;

namespace UserCRUD.Controllers

{
    [ApiController]
    [Route("api/controller")]
    public class UserController : ControllerBase
    {
        private static List<User> Users()
        {
            return new List<User> {
                new User { Id = 1, Name = "Mathdothings", Birthdate = new DateTime(1990, 1, 1) }
            };
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(Users());
        }

        [HttpPost]
        public IActionResult Post(User user)
        {
            var users = Users();
            users.Add(user);
            return Ok(users);
        }
    }
}