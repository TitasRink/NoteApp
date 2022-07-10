using Microsoft.EntityFrameworkCore;

namespace NoteApp.Repository.DbConfigs
{
    public interface IDbCongigurations
    {
        string ConnectionString { get; set; }
        DbContextOptions Options { get; set; }
    }
}