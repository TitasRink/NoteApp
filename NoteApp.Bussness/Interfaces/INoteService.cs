using NoteApp.Repository.Entities;
using System.Collections.Generic;

namespace NoteApp.Bussness.Interfaces
{
    public interface INoteService
    {
        Result CreateNoteAndMessage(string name, string message, int userId);
        Result MoveNoteToCategory(string categoty, string note);
        Result UpdateNote(string oldnNote, string newNote);
        Result DeleteNote(string name);
        List<NoteModel> FilterByCategory(string categoryName);
        List<NoteModel> FilterByNote(string noteName);
    }
}