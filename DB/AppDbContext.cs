﻿using EasyBank.Models;
using Microsoft.EntityFrameworkCore;

namespace EasyBank.DB
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Card> Cards { get; set; }
        public DbSet<History> History { get; set; }
        public DbSet<RefreshToken> RefreshTokens { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<History>()
                .HasOne(h => h.Employee)
                .WithMany(e => e.History)
                .HasForeignKey(h => h.EmployeeId)
                .OnDelete(DeleteBehavior.NoAction);

            new AppDbConfig(modelBuilder).Configure();
        }
    }
}
