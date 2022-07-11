using Microsoft.IdentityModel.Tokens;
using NoteApp.Bussness.Interfaces;
using NoteApp.Repository.DataDB;
using NoteApp.Repository.Entities;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;

namespace NoteApp.Bussness.Services
{
    public class UserService : IUserService
    {
        private SqlDB _context { get; }

        public UserService(SqlDB context)
        {

            _context = context;
        }

        public string Login(string userName, string password)
        {
            var user = _context.Users.Where(x => x.LoginName == userName && x.LoginPassword == password).FirstOrDefault();

            //return null if user not found
            if (user == null)
            {
                return string.Empty;
            }

            // authentication successful so generate jwt token
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes("paprastasstringas");

            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[]
                {
                    new Claim(ClaimTypes.Name, user.LoginName),
                    new Claim(ClaimTypes.NameIdentifier, user.Id.ToString()),
                }),

                Expires = DateTime.UtcNow.AddMinutes(60),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };

            var token = tokenHandler.CreateToken(tokenDescriptor);
            user.Token = tokenHandler.WriteToken(token);

            return user.Token;
        }

        public string CreateUser(string name, string password)
        {
            var result = _context.Users.Add(new(name, password));
            _context.SaveChanges();
            return result.ToString();
        }

        public UserModel GetUsers(string name)
        {
            var result = _context.Users.Where(x => x.LoginName == name).FirstOrDefault();
            return result;
        }

        public bool ValidateCredentials(string name, string password)
        {
            if (_context.Users.Any(x => x.LoginName == name && _context.Users.Any(x => x.LoginPassword == password)))
            {
                var uname = _context.Users.Where(x=>x.LoginName == name).FirstOrDefault().ToString();
                var upass = _context.Users.Where(x => x.LoginPassword == password).FirstOrDefault().ToString();

                return name.Equals(uname) && password.Equals(upass);
            }
            else
            {
                return false;
            }
        }
    }
}
