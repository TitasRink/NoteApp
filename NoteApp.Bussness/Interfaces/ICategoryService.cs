namespace NoteApp.Bussness.Interfaces
{
    public interface ICategoryService
    {
        void CreateCategory(string name);
        void DeleteCategory(string name);
        void UpdateCategoryName(string oldnName, string newName);
    }
}