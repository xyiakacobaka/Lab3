using Microsoft.EntityFrameworkCore;

namespace Lab3
{
    internal class UserContext:DbContext
    {
        public DbSet<User> Users { get; set; }
        public UserContext()
        {
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=userstore;Trusted_Connection=True;");
        }
    }
}
