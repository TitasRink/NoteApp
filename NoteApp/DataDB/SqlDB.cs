using Microsoft.EntityFrameworkCore;
using NoteApp.Repository.DbConfigs;
using NoteApp.Repository.Entities;

namespace NoteApp.Repository.DataDB
{
    public class SqlDB : DbContext
    {
        public DbSet<CategoryModel> Categories { get; set; }
        public DbSet<NoteModel> Notes { get; set; }
        public DbSet<UserModel> Users { get; set; }

        //protected override void OnConfiguring(DbContextOptionsBuilder builder)
        //{
        //    builder.UseSqlServer("Server=localhost;Database=NoteApp;Trusted_Connection=True;");
        //}
        public SqlDB(IDbCongigurations options) : base(options.Options)
        {

        }
        public SqlDB()
        {

        }
    }
}
