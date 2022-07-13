﻿using Microsoft.Extensions.Configuration;
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
            //var user = _context.Users.Where(x => x.LoginName == userName && x.LoginPassword == password).FirstOrDefault();
            var getuser = _context.Users.Where(x => x.LoginName == userName).FirstOrDefault();

            if (!VerifyPasswordHash(password, getuser.PasswordHash, getuser.PasswordSalt))
            {
                return "Wrong username or/and password";
            }

            if (getuser == null)
            {
                return string.Empty;
            }

            List<Claim> claims = new List<Claim>
            {
                new Claim(ClaimTypes.Name, getuser.LoginName),
                //new Claim(ClaimTypes.NameIdentifier, getuser.Id.ToString())
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
                if (string.IsNullOrEmpty(name) && string.IsNullOrEmpty(password))
                {
                    return new Result(false, "Fill up fields");
                }

                CreatePasswordHash(password, out byte[] passwordHash, out byte[] passwordSalt);
                var user = new UserModel(name, passwordHash, passwordSalt);
                _context.Users.Add(user);
                _context.SaveChanges();
                
                return new Result(true, "Created");
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

        //public bool ValidateCredentials(string name, string password)
        //{
        //    if (string.IsNullOrEmpty(name) && string.IsNullOrEmpty(password))
        //    {
        //        return false;
        //    }
        //    if (_context.Users.Any(x => x.LoginName == name && _context.Users.Any(x => x.LoginPassword == password)))
        //    {
        //        var uname = _context.Users.Where(x=>x.LoginName == name).FirstOrDefault().ToString();
        //        var upass = _context.Users.Where(x => x.LoginPassword == password).FirstOrDefault().ToString();

        //        return name.Equals(uname) && password.Equals(upass);
        //    }
        //    else
        //    {
        //        return false;
        //    }
        //}

        private void CreatePasswordHash(string password, out byte[] passwordHash, out byte[] passwordSalt)
        {
            using (var hmac = new HMACSHA512())
            {
                passwordSalt = hmac.Key;
                passwordHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));
            }
        }
        private bool VerifyPasswordHash(string password, byte[] passwordHash, byte[] passwordSalt)
        {
            using (var hmac = new HMACSHA512(passwordSalt))
            {
                var computedHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
                return computedHash.SequenceEqual(passwordHash);
            };
        }
    }
}
