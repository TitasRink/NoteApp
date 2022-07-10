using Microsoft.EntityFrameworkCore;
using NoteApp.Repository.Entities;
using System.Linq;

namespace NoteApp.Repository.DataDB
{
    public class SqlDB : DbContext
    {
        public DbSet<CategoryModel> Categories { get; set; }
        public DbSet<NoteModel> Notes { get; set; }
        public DbSet<UserModel> Users { get; set; }
     
        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            builder.UseSqlServer("Server=localhost;Database=NoteApp;Trusted_Connection=True;");
        }
    }
}
