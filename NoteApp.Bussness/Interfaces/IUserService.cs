using NoteApp.Repository.Entities;
using System.Collections.Generic;

namespace NoteApp.Bussness.Interfaces
{
    public interface IUserService
    {
        string Login(string userName, string password);
        Result CreateUser(string name, string password);
        List<UserModel> GetUsers();
    }
}