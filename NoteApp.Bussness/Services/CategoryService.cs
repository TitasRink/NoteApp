using NoteApp.Bussness.Interfaces;
using NoteApp.Repository.DataDB;
using NoteApp.Repository.Entities;
using System;
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

        public Result CreateCategory(string name)
        {
            using (Con)
            {
                try
                {
                    var exist = Con.Categories.Find(name).Name;
                    if (exist == name)
                    {
                        return new Result(false, $"{name} Allready exists");
                    }
                    Con.Categories.Add(new CategoryModel(name));
                    Con.SaveChanges();
                    return new Result(true, "Created");
                }
                catch (Exception e)
                {
                    return new Result(false, $"Error {e.Message}");
                }
            }
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
