using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using NoteApp.Bussness.Interfaces;
using NoteApp.Repository.DataDB;
using NoteApp.Repository.Entities;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;

namespace NoteApp.Bussness.Services
{
    public class UserService : IUserService
    {
        private SqlDB _context { get; }
        private readonly IConfiguration _configuration;

        public UserService(SqlDB context, IConfiguration configuration)
        {
            _context = context;
            _configuration = configuration;
        }

        public string Login(string userName, string password)
        {
            var getuser = _context.Users.Where(x => x.LoginName == userName).FirstOrDefault();

            if (!VerifyPasswordHash(password, getuser.PasswordHash, getuser.PasswordSalt))
            {
                return "Wrong username or/and password";
            }

            if (getuser == null)
            {
                return string.Empty;
            }

            List<Claim> claims = new()
            {
                new Claim(ClaimTypes.Name, getuser.LoginName),
            };

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["Jwt:Key"]));
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
            var token = new JwtSecurityToken(
                issuer: _configuration["Jwt:Issuer"],
                audience: _configuration["Jwt:Audience"],
                claims: claims,
                expires: DateTime.Now.AddDays(1),
                signingCredentials: creds
                );
            var jwt = new JwtSecurityTokenHandler().WriteToken(token);

            return jwt;
        }

        public Result CreateUser(string name, string password)
        {
            try
            {
                var usercheck = _context.Users.Any(x=>x.LoginName == name);
                if (string.IsNullOrEmpty(name) && string.IsNullOrEmpty(password))
                {
                    return new Result(false, "Fill up fields");
                }
                if (usercheck)
                {
                    return new Result(false, "User allready exists");
                }
                else
                {
                    CreatePasswordHash(password, out byte[] passwordHash, out byte[] passwordSalt);
                    var user = new UserModel(name, passwordHash, passwordSalt);
                    _context.Users.Add(user);
                    _context.SaveChanges();

                    return new Result(true, "Created");
                }
            }
            catch (Exception e)
            {
                return new Result(false, $"Error {e.Message}");
            }
        }

        public Result GetUsers(string name)
        {
            try
            {
                if (string.IsNullOrEmpty(name))
                {
                    return new Result(false, "Fill up fields");
                }
                var result = _context.Users.Where(x => x.LoginName == name).FirstOrDefault();

                return new Result(true, "Show user");
            }
            catch (Exception e)
            {
                return new Result(false, $"Error {e.Message}");
            }
        }

        private void CreatePasswordHash(string password, out byte[] passwordHash, out byte[] passwordSalt)
        {
            using var hmac = new HMACSHA512();
            passwordSalt = hmac.Key;
            passwordHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));
        }
        private bool VerifyPasswordHash(string password, byte[] passwordHash, byte[] passwordSalt)
        {
            using (var hmac = new HMACSHA512(passwordSalt))
            {
                var computedHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));
                return computedHash.SequenceEqual(passwordHash);
            }
        }
    }
}
