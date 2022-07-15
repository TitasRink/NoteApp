
using NoteApp.Bussness.Interfaces;
using NoteApp.Repository.DataDB;
using NoteApp.Repository.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace NoteApp.Bussness.Services
{
    public class NoteService : INoteService
    {
        private SqlDB Con { get; }

        public NoteService(SqlDB con)
        {
            Con = con;
        }

        public Result CreateNoteAndMessage(string name, string message, string userNameId)
        {
            try
            {
                if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(message) || string.IsNullOrEmpty(userNameId))
                {
                    return new Result(false, "Fill up fields");
                }
                else
                {
                    var id = Con.Users.Where(x=>x.LoginName == userNameId).FirstOrDefault().Id;
                    var user = Con.Users.Where(x => x.Id == id).FirstOrDefault();
                    NoteModel note = new NoteModel(name, message, id);
                    user.Notes.Add(note);
                    Console.WriteLine("sada");
                    Con.SaveChanges();
                    return new Result(true, "Note and message Created");
                }
            }
            catch (Exception e)
            {
                return new Result(false, $"Error {e.Message}");
            }
        }

        public Result MoveNoteToCategory(string categoty, string note)
        {
            try
            {
                if (string.IsNullOrEmpty(categoty) || string.IsNullOrEmpty(note))
                {
                    return new Result(false, $"{note} to {categoty} Not Moved");
                }
                else

                if (!Con.Categories.Any(x => x.Name == categoty))
                {
                    Con.Categories.Add(new CategoryModel(categoty));
                    var not = Con.Notes.Where(x => x.Name == note).FirstOrDefault();
                    var cate = Con.Categories.Where(x => x.Name == categoty).FirstOrDefault();
                    cate.Notes.Add(not);
                    Con.SaveChanges();

                    return new Result(true, $"Category {categoty} was created and {note} moved to {categoty}");
                }

                else
                {
                    var not = Con.Notes.Where(x => x.Name == note).FirstOrDefault();
                    var cate = Con.Categories.Where(x => x.Name == categoty).FirstOrDefault();
                    cate.Notes.Add(not);
                    Con.SaveChanges();

                    return new Result(true, "Note was moved to another category");
                }
            }
            catch (Exception e)
            {
                return new Result(false, $"Error {e.Message}");
            }
        }
        public Result UpdateNote(string oldnNote, string newNote)
        {
            try
            {
                if (string.IsNullOrEmpty(oldnNote) && string.IsNullOrEmpty(newNote))
                {
                    return new Result(false, "Fill up fields");
                }
                if (Con.Notes.Any(x => x.Name == newNote))
                {
                    return new Result(false, $"Note : {newNote} allready exists");
                }
                if (Con.Categories.Any(x => x.Name == oldnNote))
                {
                    return new Result(false, $"Note : {oldnNote} not found ");
                }

                var oldName = Con.Notes.Where(x => x.Name == oldnNote).FirstOrDefault();
                oldName.Name = newNote;
                Con.SaveChanges();

                return new Result(true, "Renamed");
            }
            catch (Exception e)
            {
                return new Result(false, $"Error {e.Message}");
            }
        }
        public Result DeleteNote(string name)
        {
            try
            {
                if (string.IsNullOrEmpty(name))
                {
                    return new Result(false, "Fill up fields");
                }
                if (Con.Notes.Any(x => x.Name == name))
                {
                    return new Result(false, $"Note {name} do not exists");
                }
                var result = Con.Notes.Where(x => x.Name == name).FirstOrDefault();
                Con.Remove(result);
                Con.SaveChanges();

                return new Result(true, "Deleted");
            }
            catch (Exception e)
            {
                return new Result(false, $"Error {e.Message}");
            }
        }

        public List<NoteModel> FilterByCategory(string categoryName)
        {
            try
            {
                if (string.IsNullOrEmpty(categoryName))
                {
                    throw new Exception();
                }
                //var result = Con.Categories
                //    .Include(x => x.Notes)
                //    .Where(x => x.Name.Any() == categoryName).ToList();
                var result = Con.Notes.Where(x => x.Categories.Any(x => x.Name == categoryName)).ToList();

                return result;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public List<NoteModel> FilterByNote(string noteName)
        {
            try
            {
                if (string.IsNullOrEmpty(noteName))
                {
                    throw new Exception();
                }
                var result = Con.Notes.Where(x => x.Name == noteName).ToList();

                return result;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
