using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using NoteApp.Bussness.Interfaces;
using NoteApp.Repository.Entities;
using System;


namespace NoteApp.API.Controllers
{
    [Route("api/user")]
    [ApiController]

    public class UserController : Controller
    {
       
        private readonly IUserService _userService;

        public UserController( IUserService userService)
        {
            _userService = userService;
        }

        [HttpPost("Log in")]
        public IActionResult Login([FromBody] UserDto user)
        {
            
            var token = _userService.Login(user.Username, user.Password);

            if (token == null || token == String.Empty)
                return BadRequest(new { message = "User name or password is incorrect" });

            return Ok(token);
        }
        
        [HttpPost("Create User")]
        public IActionResult CreateUser(string name, string password)
        {
            var result = _userService.CreateUser(name, password);
            return Ok(result);
        }

        [HttpGet("Get User Info"), Authorize]
        
        public Result getusers(string name)
        {
            var result = _userService.GetUsers(name);
            return result;
        }
    }
}
