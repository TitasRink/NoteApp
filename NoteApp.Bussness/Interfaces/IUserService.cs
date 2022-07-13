using NoteApp.Repository.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace NoteApp.Bussness.Interfaces
{
    public interface IUserService
    {
        string Login(string userName, string password);
        Result CreateUser(string name, string password);
        Result GetUsers(string name);
       // bool ValidateCredentials(string name, string password);

    }
}