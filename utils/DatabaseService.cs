using Microsoft.EntityFrameworkCore;

namespace api_dotnet.utils
{
    class DatabaseService : DbContext
    {
        public DbSet<User> User { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("SuaStringDeConexao");
        }
    }
}