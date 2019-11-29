
using Microsoft.EntityFrameworkCore;
using tut01.Models;

namespace tut01.Data
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) 
        : base(options) {}

        public DbSet<Employee> Employees { get; set;}
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) => optionsBuilder.UseSqlite("Data Source=sqlitedemo.db");
    }
}