using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace NoteApp.Repository.DbConfigs
{
    public class DbCongigurations : IDbCongigurations
    {
        public string ConnectionString { get; set; }
        public DbContextOptions Options { get; set; }

        public DbCongigurations(IConfiguration config)
        {
            ConnectionString = config.GetConnectionString("ConString");
            Options = new DbContextOptionsBuilder().UseSqlServer(ConnectionString).Options;
        }
    }
}
