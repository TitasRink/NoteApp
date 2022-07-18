using NoteApp.Repository.Entities;
using System.Collections.Generic;

namespace NoteApp.Bussness.Interfaces
{
    public interface ICategoryService
    {
        List<CategoryModel> FilterCategory();
        Result CreateCategory(string name, string userNameId);
        Result UpdateCategoryName(string oldnName, string newName);
        Result DeleteCategory(string name);
    }
}