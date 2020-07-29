using Microsoft.EntityFrameworkCore;
using System;
using System.Runtime.CompilerServices;

namespace CygSoft.GuitarSessions.Data
{
    public class DataContext : DbContext
    {
        public DbSet<Exercise> Exercises { get; set; }

        public DataContext(DbContextOptions<DataContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Exercise>().ToTable("Exercise");
            base.OnModelCreating(modelBuilder);
        }
    }
}
