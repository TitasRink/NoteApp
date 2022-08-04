using Microsoft.EntityFrameworkCore;
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
        public NoteService()
        {

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
                    var id = Con.Users.Include(x=>x.Notes).Where(x => x.LoginName == userNameId).FirstOrDefault().Id;
                    var user = Con.Users.Where(x => x.Id == id).FirstOrDefault();
                    NoteModel note = new(name, message, id);
                    user.Notes.Add(note);
                    Con.SaveChanges();
                    return new Result(true, "Note and message Created");
                }
            }
            catch (Exception e)
            {
                return new Result(false, $"Error {e.Message}");
            }
        }

        public Result MoveNoteToCategory(string note , string categoty)
        {
            try
            {
                if (string.IsNullOrEmpty(categoty) || string.IsNullOrEmpty(note))
                {
                    return new Result(false, $"{note} to {categoty} Not Moved");
                }
                else
                {
                    var noteResult = Con.Notes
                        .Include(i => i.Categories)
                        .Where(x => x.Name == note).FirstOrDefault();

                    var category = Con.Categories
                        .Include(x=>x.Notes)
                        .Where(x => x.Name == categoty).FirstOrDefault();

                    category.Notes.Add(noteResult);
                    noteResult.Categories.Add(category);

                    //var cat = Con.Notes.Include(x => x.Categories)
                    //        .Where(x => x.Categories.Any(x => x.Name == categoty))
                    //        //.Where(x => x.Name == note)
                    //        .FirstOrDefault();

                    Con.SaveChanges();

                    return new Result(true, "Note was moved to another category");
                }
            }
            catch (Exception e)
            {
                return new Result(false, $"Error {e.Message}");
            }
        }
        public Result UpdateNote(string noteName, string newMessage)
        {
            try
            {
                if (string.IsNullOrEmpty(noteName) && string.IsNullOrEmpty(newMessage))
                {
                    return new Result(false, "Fill up fields");
                }
                else
                {
                    var oldName = Con.Notes.Where(x => x.Name == noteName).FirstOrDefault();
                    oldName.Message = newMessage;
                    Con.SaveChanges();

                    return new Result(true, "Renamed");
                }
            }
            catch (Exception e)
            {
                return new Result(false, $"Error {e.Message}");
            }
        }
        public Result DeleteNote(string name, string userNameId)
        {
            try
            {
                if (string.IsNullOrEmpty(name))
                {
                    return new Result(false, "Fill up fields");
                }
                if (!Con.Notes.Any(x => x.Name == name))
                {
                    return new Result(false, $"Note {name} do not exists");
                }
                
                var res = Con.Users.Include(x => x.Notes).Where(x => x.LoginName == userNameId).FirstOrDefault();
                var remove = res.Notes.Where(x => x.Name == name).FirstOrDefault();
                Con.Remove(remove);
                Con.SaveChanges();

                return new Result(true, "Deleted");
            }
            catch (Exception e)
            {
                return new Result(false, $"Error {e.Message}");
            }
        }

        //public List<NoteModel> FilterByCategory(string userName)
        //{
        //    try
        //    {
        //        if (string.IsNullOrEmpty(userName))
        //        {
        //            throw new Exception();
        //        }

          
        //        var result = Con.Notes.Where(x => x.Categories.Any(x => x.Name == userName)).ToList();

        //        return result;
        //    }
        //    catch (Exception e)
        //    {
        //        throw new Exception(e.Message);
        //    }
        //}

        public List<NoteModel> FilterByNote(string userNameId)
        {
            try
            {
                var res = Con.Users.Include(x => x.Notes)
                 .Where(x => x.LoginName == userNameId)
                 .FirstOrDefault()
                 .Notes.ToList();

                return res;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public List<NoteModel> FilterNoteByCategory(string nameId, string userId)
        {
            try
            {
                if (string.IsNullOrEmpty(nameId))
                {
                    throw new Exception();
                }
                else
                {
                    var userID = Con.Users.Where(x => x.LoginName == userId).FirstOrDefault().Id;

                    var result = Con.Notes.Where(x => x.Categories.Any(x => x.Name == nameId)).ToList();

                    //var cateID = Con.Categories.Where(x => x.Name == nameId).FirstOrDefault().Id; 
                    //var notes = Con.Notes.Include(x => x.Categories).Where(x=>x.Id == cateID).ToList();

                    return result;
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        //public  Result ImgAdd(string name, byte[] ImgUrl)
        //{
            
         
        //}
    }
}
