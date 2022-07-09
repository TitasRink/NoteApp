using NoteApp.Bussness.Interfaces;
using NoteApp.Repository.DataDB;
using NoteApp.Repository.Entities;

namespace NoteApp.Bussness.Services
{
    public class NoteService : INoteService
    {
        private SqlDB Con { get; }

        public NoteService(SqlDB con)
        {
            Con = con;
        }
        public void CreateNote(string name)
        {
            using (Con)
            {
                Con.Notes.Add(new NoteModel(name));
                Con.SaveChanges();
            }
        }
        public void CreateNoteAndMessasge(string name, string message)
        {
            using (Con)
            {
                Con.Notes.Add(new NoteModel(name));
                Con.SaveChanges();
            }

        }
    }
}
