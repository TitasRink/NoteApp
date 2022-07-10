using Microsoft.AspNetCore.Mvc;
using NoteApp.Bussness.Interfaces;
using NoteApp.Bussness.Services;
using NoteApp.Repository.DataDB;
using NoteApp.Repository.Entities;

namespace NoteApp.API.Controllers
{
    public class UserController : Controller
    {
        private IUserService userService { get; }
        public UserController()
        {
            var Con = new SqlDB();
           userService = new UserService(Con);
        }
        
        [HttpPost("Create User")]
        public IActionResult CreateUser(string name, string password)
        {
            var result = userService.CreateUser(name, password);
            return Ok(result);
        }
        [HttpPost("Log in User")]
        public IActionResult LogInUse(string name, string password)
        {
            var result = userService.LogIn(name, password);
            return Ok(result);
        }

        [HttpGet("Get User Info")]
        public UserModel getusers(string name)
        {
            var result = userService.GetUsers(name);
            return result;
        }

    }
}
