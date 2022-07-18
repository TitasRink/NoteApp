using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using NoteApp.Bussness.Interfaces;
using NoteApp.Repository.DataDB;
using NoteApp.Repository.DTO;
using NoteApp.Repository.Entities;
using System;
using System.Linq;
using System.Security.Cryptography;

namespace NoteApp.API.Controllers
{
    [Route("api/user")]
    [ApiController]
    public class UserController : Controller
    {
        private readonly IUserService _userService;
        private readonly SqlDB _context;

        public UserController( IUserService userService, SqlDB context)
        {
            _context = context;
            _userService = userService;
        }

        [HttpPost("Log_in")]
        public IActionResult Login([FromBody] UserDto user)
        {
            try
            {
                var getuser = _context.Users.Where(x => x.LoginName == user.Username).FirstOrDefault();
                if (getuser == null)
                {
                    return BadRequest("Wrong username or/and password");
                }
                if (!VerifyPasswordHash(user.Password, getuser.PasswordHash, getuser.PasswordSalt))
                {
                    return BadRequest("Wrong username or/and password");
                }
                else
                {
                    var token = _userService.Login(user.Username, user.Password);

                    if (token == null || token == String.Empty)
                    return BadRequest("User name or password is incorrect");

                    return Ok(token);
                }
            }
            catch (Exception t)
            {
                return Ok(t);
            }
        }
        
        [HttpPost("Create_User")]
        public IActionResult CreateUser([FromBody] UserDto user)
        {
            var result = _userService.CreateUser(user.Username, user.Password);
            if (!result.IsSuccess)
            {
                return BadRequest(result.Message);
            }
            else
            {
                return Ok(result);
            }
        }

        [HttpGet("Get User Info"), Authorize]
        public Result Getusers(string name)
        {
            var result = _userService.GetUsers(name);
            return result;
        }

        private bool VerifyPasswordHash(string password, byte[] passwordHash, byte[] passwordSalt)
        {
            using (var hmac = new HMACSHA512(passwordSalt))
            {
                var computedHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
                return computedHash.SequenceEqual(passwordHash);
            }
        }
    }
}
