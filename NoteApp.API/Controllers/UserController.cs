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

        [HttpPost("Log in")]
        public IActionResult Login([FromBody] UserDto user)
        {
            var getuser = _context.Users.Where(x => x.LoginName == user.Username).FirstOrDefault();

            if (!VerifyPasswordHash(user.Password, getuser.PasswordHash, getuser.PasswordSalt))
            {
                return BadRequest("Wrong username or/and password");
            }

            var token = _userService.Login(user.Username, user.Password);

            if (token == null || token == String.Empty)
                return BadRequest(new { message = "User name or password is incorrect" });

            return Ok(token);
        }
        
        [HttpPost("Create User")]
        public IActionResult CreateUser([FromBody] UserDto user)
        {
            var result = _userService.CreateUser(user.Username, user.Password);
            return Ok(result);
        }

        [HttpGet("Get User Info"), Authorize]
        
        public Result Getusers(string name)
        {
            var result = _userService.GetUsers(name);
            return result;
        }


        private void CreatePasswordHash(string password, out byte[] passwordHash, out byte[] passwordSalt)
        {
            using var hmac = new HMACSHA512();
            passwordSalt = hmac.Key;
            passwordHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
        }

        private bool VerifyPasswordHash(string password, byte[] passwordHash, byte[] passwordSalt)
        {
            using (var hmac = new HMACSHA512(passwordSalt))
            {
                var computedHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
                return computedHash.SequenceEqual(passwordHash);
            };
        }

        private bool PasswordValidation(string password)
        {
            //char[] specialChArray = @"%!@#$%^&*()?/>.<,:;'\|}]{[_~`+=-".ToCharArray();

            if (password.Length < 4)
            {
                return false;
            }
            //if (!password.Any(char.IsUpper))
            //{
            //    return false;
            //}
            //if (!password.Any(char.IsLower))
            //{
            //    return false;
            //}
            if (password.Contains(" "))
            {
                return false;
            }

            //foreach (char ch in specialChArray)
            //{
            //    if (password.Contains(ch))
            //        return true;
            //}
            return true;
        }
    }
}
