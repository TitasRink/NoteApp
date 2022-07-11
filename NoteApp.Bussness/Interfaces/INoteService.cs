using NoteApp.Repository.Entities;

namespace NoteApp.Bussness.Interfaces
{
    public interface INoteService
    {
        Result CreateNote(string name);
        Result CreateNoteAndMessage(string name, string message);
        Result MoveNoteToCategory(string categoty, string note);
        Result UpdateNote(string oldnNote, string newNote);
        Result DeleteNote(string name);
       
    }
}