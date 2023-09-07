using EasyBank.Models;
using Microsoft.EntityFrameworkCore;

namespace EasyBank.DB
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Employee> Employees { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            new AppDbConfig(modelBuilder).Configure();
        }
    }
}
