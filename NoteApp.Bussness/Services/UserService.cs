using NoteApp.Bussness.Interfaces;
using NoteApp.Repository.DataDB;
using NoteApp.Repository.Entities;
using System.Linq;

namespace NoteApp.Bussness.Services
{
    public class UserService : IUserService
    {
        private SqlDB Con { get; }
        private string Token { get; set; }

        public UserService(SqlDB con)
        {
            Con = con;
        }

        public string CreateUser(string name, string password)
        {
            using (Con)
            {
                var aaa = Con.Users.Add(new(name, password));
                Con.SaveChanges();
                return aaa.ToString();
            }
        }

        public UserModel GetUsers(string name)
        {
            using (Con)
            {
                var aaa = Con.Users.Where(x => x.LoginName == name).FirstOrDefault();
                return aaa;
            }
        }

        public bool LogIn(string name, string password)
        {
            using (Con)
            {
                if (Con.Users.Any(x => x.LoginName == name && Con.Users.Any(x => x.LoginPassword == password)))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }




        //private List<UserModel> _users = new List<UserModel>
        //{
        //    new UserModel { LoginName = "user", LoginPassword = "pass"},
        //    new UserModel {  LoginName = "user2", LoginPassword = "password2"}
        //};
        //public string Login(string userName, string password)
        //{
        //var user = _users.SingleOrDefault(x => x.LoginName == userName && x.LoginPassword == password);
        //var user = Con.Users.Where(x => x.LoginName == userName && x.LoginPassword == password).FirstOrDefault();
        //var user = Con.Users.FirstOrDefault(x => x.LoginName == userName && x.LoginPassword == password);

        // return null if user not found
        //    if (_users == null)
        //    {
        //        return string.Empty;
        //    }

        //    // authentication successful so generate jwt token
        //    var tokenHandler = new JwtSecurityTokenHandler();
        //    var key = Encoding.ASCII.GetBytes("paprastasstringas");

        //    var tokenDescriptor = new SecurityTokenDescriptor
        //    {
        //        Subject = new ClaimsIdentity(new Claim[]
        //        {
        //            new Claim(ClaimTypes.Name, user.LoginName),
        //        }),

        //        Expires = DateTime.UtcNow.AddMinutes(60),
        //        SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
        //    };

        //    var token = tokenHandler.CreateToken(tokenDescriptor);
        //    user.Token = tokenHandler.WriteToken(token);

        //    this.Token = user.Token;
        //    return user.Token;
        //}
    }
}
