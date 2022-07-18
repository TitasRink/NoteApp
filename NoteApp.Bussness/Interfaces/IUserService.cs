using NoteApp.Repository.Entities;

namespace NoteApp.Bussness.Interfaces
{
    public interface IUserService
    {
        string Login(string userName, string password);
        Result CreateUser(string name, string password);
        Result GetUsers(string name);
    }
}