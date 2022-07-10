using NoteApp.Repository.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace NoteApp.Bussness.Interfaces
{
    public interface IUserService
    {
        string CreateUser(string name, string password);
        bool LogIn(string name, string password);
        UserModel GetUsers(string name);
    }
}