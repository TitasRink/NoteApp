using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using NoteApp.Bussness.Interfaces;
using NoteApp.Repository.Entities;
using System;


namespace NoteApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : Controller
    {
       
        private readonly IUserService _userService;
        private readonly ICategoryService _categoryService;
        private readonly INoteService _noteService;

        public UserController( IUserService userService, ICategoryService categoryService, INoteService noteService)
        {
            _userService = userService;
            _categoryService = categoryService;
            _noteService = noteService;
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

        [HttpPost("Log in User")]
        public IActionResult LogInUse(string name, string password)
        {
            var result = _userService.LogIn(name, password);
            return Ok(result);
        }

        [HttpGet("Get User Info")]
        
        public UserModel getusers(string name)
        {
            var result = _userService.GetUsers(name);
            return result;
        }

        [HttpPost("Create Category"), Authorize]
        
        public IActionResult CreateCategory(string name)
        {
            var result = _categoryService.CreateCategory(name);
            return Ok(result);
        }
    }
}
