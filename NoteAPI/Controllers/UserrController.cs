using Microsoft.AspNetCore.Mvc;
using NoteApp.Bussness.Interfaces;
using NoteApp.Bussness.Services;
using NoteApp.Repository.DataDB;
using System;

namespace NoteAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : Controller
    {
        
        private readonly IUserService _userService;

        public UserController()
        {
            //var context = new SqlDB();
           // _userService = new UserService(context);
        }

        //POST api/user/login
        //[AllowAnonymous]
        [HttpPost]
        public IActionResult Login([FromBody] NoteApp.Repository.Entities.UserModel user)
        {
            var token = _userService.Login(user.LoginName, user.LoginPassword);

            if (token == null || token == String.Empty)
                return BadRequest(new { message = "User name or password is incorrect" });

            return Ok(token);
        }


        //[AllowAnonymous]
        //[HttpPost]
        //public ActionResult<IEnumerable<string>> CreatUser(string name, string password)
        //{
        //    _userService.CreateUser(name, password);
        //    return Ok($"User {name} created");
        //}
    }
}
