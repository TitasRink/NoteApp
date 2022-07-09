using NoteApp.Repository.DataDB;
using NoteApp.Repository.Entities;

namespace NoteApp.Bussness.Services
{
    public class NoteService
    {
        private SqlDB Con { get; }

        public NoteService(SqlDB con)
        {
            Con = con;
        }
        private void CreateNote(string name)
        {
            using (Con)
            {
                Con.Notes.Add(new NoteModel(name));
                Con.SaveChanges();
            }
        }
        private void CreateNoteAndMessasge(string name, string message)
        {
            using (Con)
            {
                Con.Notes.Add(new NoteModel(name));
                Con.SaveChanges();
            }
           
        }
    }
}
