using Microsoft.AspNetCore.Mvc;
using NoteApp.Bussness.Interfaces;
using NoteApp.Bussness.Services;
using NoteApp.Repository.DataDB;
using NoteApp.Repository.Entities;

namespace NoteApp.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class UserController : Controller
    {
        private readonly IUserService _userService;
        private readonly ICategoryService _categoryService;

        public UserController(IUserService userService, ICategoryService categoryService)
        {
            _userService = userService;
            _categoryService = categoryService;
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

        [HttpPost("Create Category")]
        public IActionResult CreateCategory(string name)
        {
            var result = _categoryService.CreateCategory(name);
            return Ok(result);
        }
    }
}
