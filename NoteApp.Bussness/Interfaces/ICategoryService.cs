using NoteApp.Repository.Entities;

namespace NoteApp.Bussness.Interfaces
{
    public interface ICategoryService
    {
        Result CreateCategory(string name, string userNameId);
        Result UpdateCategoryName(string oldnName, string newName);
        Result DeleteCategory(string name);
    }
}