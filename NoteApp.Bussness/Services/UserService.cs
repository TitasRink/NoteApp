using NoteApp.Bussness.Interfaces;
using NoteApp.Repository.DataDB;
using NoteApp.Repository.Entities;

namespace NoteApp.Bussness.Services
{
    public class UserService : IUserService
    {
        private SqlDB Con { get; }

        public UserService(SqlDB con)
        {
            Con = con;
        }

        public void CreateUser(string name, string password)
        {
            Con.Users.Add(new UserModel(name, password));
            Con.SaveChanges();
        }
    }
}
