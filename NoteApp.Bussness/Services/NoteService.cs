using NoteApp.Bussness.Interfaces;
using NoteApp.Repository.DataDB;
using NoteApp.Repository.Entities;
using System;
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
        public Result CreateNote(string name)
        {
            try
            {
                if (string.IsNullOrEmpty(name))
                {
                    Con.Notes.Add(new NoteModel(name));
                    Con.SaveChanges();

                    return new Result(true, "Note Created");
                }
                else
                {
                    return new Result(false, $"{name} Not created");
                }
            }
            catch (Exception e)
            {
                return new Result(false, $"Error {e.Message}");
            }
        }

        public Result CreateNoteAndMessage(string name, string message)
        {
            try
            {
                if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(message))
                {
                    Con.Notes.Add(new NoteModel(name, message));
                    Con.SaveChanges();

                    return new Result(true, "Note  and message Created");
                }
                else
                {
                    return new Result(false, $"{name} and {message} Not created");
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
                {
                    var not = Con.Notes.Where(x => x.Name == note).FirstOrDefault();
                    var cat = Con.Categories.Where(x => x.Name == categoty).FirstOrDefault();
                    not.Categories.Add(cat);
                    cat.Notes.Clear();
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
                var exist = Con.Notes.Find(oldnNote).Name;
                if (exist == null && string.IsNullOrEmpty(newNote))
                {
                    return new Result(false, $"{oldnNote} Doesnot exist or Empty");
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
                    return new Result(false, $"{name} Enter existing category");
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
    }
}
