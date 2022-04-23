using System;
using DataManipulation;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace DMS.Models
{
    public class ApplicationContext : DbContext
    {
        private readonly IConfiguration Configuration;

        public DbSet<Resident> Residents { get; set; } = null!;
        //public DbSet<Room> Rooms { get; set } = null!;

        public ApplicationContext(DbContextOptions<ApplicationContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
             base.OnConfiguring(optionsBuilder);
             optionsBuilder.UseNpgsql(Configuration.GetConnectionString("DefaultConnection"));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Resident>()
                .HasData(new Resident(401, "Дураков", "Карим", "Наллович", 'М', DateTime.Now, 305));
        }
    }
}