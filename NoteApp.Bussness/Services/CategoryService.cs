using NoteApp.Bussness.Interfaces;
using NoteApp.Repository.DataDB;
using NoteApp.Repository.Entities;
using System.Linq;

namespace NoteApp.Bussness.Services
{
    public class CategoryService : ICategoryService
    {
        private SqlDB Con { get; }

        public CategoryService(SqlDB con)
        {
            Con = con;
        }

        public void CreateCategory(string name)
        {
            Con.Categories.Add(new CategoryModel(name));
            Con.SaveChanges();
        }

        public void UpdateCategoryName(string oldnName, string newName)
        {
            var oldName = Con.Categories.Where(x => x.Name == oldnName).FirstOrDefault();
            oldName.Name = newName;
            Con.SaveChanges();
        }
        public void DeleteCategory(string name)
        {
            var result = Con.Categories.Where(x => x.Name == name).FirstOrDefault();
            Con.Remove(result);
            Con.SaveChanges();
        }
    }
}
