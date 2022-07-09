namespace NoteApp.Bussness.Interfaces
{
    public interface INoteService
    {
        void CreateNote(string name);
        void CreateNoteAndMessasge(string name, string message);
    }
}