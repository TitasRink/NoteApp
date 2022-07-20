using Microsoft.EntityFrameworkCore;
using NoteApp.Bussness.Interfaces;
using NoteApp.Repository.DataDB;
using NoteApp.Repository.Entities;
using System;
using System.Collections.Generic;
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

        public Result CreateCategory(string name, string userNameId)
        {
            try
            {
                if (Con.Categories.Any(x => x.Name == name))
                {
                    return new Result(false, $"{name} Allready exists");
                }
                if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(userNameId))
                {
                    return new Result(false, "Fill up fields");
                }
                else
                {
                    var userid = Con.Users.Where(x => x.LoginName == userNameId).FirstOrDefault().Id;
                    var userNotes = Con.Notes.Include(x => x.Categories).Where(x=>x.UserModelId == userid).FirstOrDefault();
                    userNotes.Categories.Add(new CategoryModel(name));
                    Con.SaveChanges();
                    return new Result(true, "Created");
                }
            }
            catch (Exception e)
            {
                return new Result(false, $"Error {e.Message}");
            }
        }

        public  Result UpdateCategoryName(string oldnName, string newName)
        {
            try
            {
                if (string.IsNullOrEmpty(newName) && string.IsNullOrEmpty(oldnName))
                {
                    return new Result(false, "Fill up fields");
                }
                if (Con.Categories.Any(x => x.Name == newName))
                {
                    return new Result(false, $"Category : {newName} allready exists");
                }
                if (!Con.Categories.Any(x => x.Name == oldnName))
                {
                    return new Result(false, $"Category : {oldnName} not found ");
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
                    return new Result(false, "Fill up fields");
                }
                if (!Con.Categories.Any(x => x.Name == name))
                {
                    return new Result(false, $"Category : {name} not found");
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

        public List<CategoryModel> FilterCategory()
        {
            try
            {
                var result = Con.Categories.ToList();
                return result;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
