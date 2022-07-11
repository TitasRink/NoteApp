using NoteApp.Repository.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace NoteApp.Bussness.Interfaces
{
    public interface IUserService
    {
        string Login(string userName, string password);
        string CreateUser(string name, string password);
        bool LogIn(string name, string password);
        UserModel GetUsers(string name);
        bool ValidateCredentials(string name, string password);

    }
}