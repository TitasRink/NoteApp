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

        public Result UpdateCategoryName(string oldnName, string newName)
        {
            try
            {
                var exist = Con.Categories.Find(oldnName).Name;
                if (exist == null && string.IsNullOrEmpty(newName))
                {
                    return new Result(false, $"{oldnName} Doesnot exist or Empty");
                }
                var oldName = Con.Categories.Where(x => x.Name == oldnName).FirstOrDefault();
                oldName.Name = newName;
                Con.SaveChanges();
                return new Result(true, "Renamed");
            }
            catch (Exception e)
            {
                return new Result(false, $"Error {e.Message}");
            }
        }

        public Result DeleteCategory(string name)
        {
            try
            {
                if (string.IsNullOrEmpty(name))
                {
                    return new Result(false, $"{name} Enter existing category");
                }
                var result = Con.Categories.Where(x => x.Name == name).FirstOrDefault();
                Con.Remove(result);
                Con.SaveChanges();
                return new Result(true, "Deleted");
            }
            catch (Exception e)
            {
                return new Result(false, $"Error {e.Message}");
            }
        }
    }
}
