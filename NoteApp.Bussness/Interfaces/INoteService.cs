using NoteApp.Repository.Entities;
using System.Collections.Generic;

namespace NoteApp.Bussness.Interfaces
{
    public interface INoteService
    {
        Result CreateNoteAndMessage(string name, string message, string userId);
        Result MoveNoteToCategory(string categoty, string note);
        Result UpdateNote(string oldnNote, string newNote);
        Result DeleteNote(string name, string userNameId);
        //List<NoteModel> FilterByCategory(string categoryName);
        List<NoteModel> FilterByNote(string userNameId);
        List<NoteModel> FilterNoteByCategory(string userName, string userId);
    }
}