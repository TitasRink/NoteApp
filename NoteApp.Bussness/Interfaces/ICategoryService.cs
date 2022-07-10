using NoteApp.Repository.Entities;

namespace NoteApp.Bussness.Interfaces
{
    public interface ICategoryService
    {
        Result CreateCategory(string name);
        void DeleteCategory(string name);
        void UpdateCategoryName(string oldnName, string newName);
    }
}