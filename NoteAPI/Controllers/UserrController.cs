using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using NoteApp.Bussness.Interfaces;
using NoteApp.Bussness.Services;
using NoteApp.Repository.DataDB;
using NoteApp.Repository.Entities;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace NoteAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class UserController : Controller
    {
        private readonly IUserService _userService;

        public UserController()
        {
            var context = new SqlDB();
            _userService = new UserService(context);
        }

        //POST api/user/login
       //[AllowAnonymous]
       //[HttpPost]
       // public IActionResult Login([FromBody] UserModel user)
       // {
       //     var token = _userService.Login(user.LoginName, user.LoginPassword);

       //     if (token == null || token == String.Empty)
       //         return BadRequest(new { message = "User name or password is incorrect" });

       //     return Ok(token);
       // }


        //[AllowAnonymous]
        //[HttpPost]
        //public ActionResult<IEnumerable<string>> CreatUser(string name, string password)
        //{
        //    _userService.CreateUser(name, password);
        //    return Ok($"User {name} created");
        //}
    }
}
