using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace DMS.Models;

public class ApplicationContext : DbContext
{
    private readonly IConfiguration Configuration;

    public DbSet<Room> Rooms { get; set; } = null!;
    public DbSet<Resident> Residents { get; set; } = null!;

    public DbSet<RatingChangeCategory>
        RatingChangeCategories { get; set; } = null!;

    public DbSet<Transaction> Transactions { get; set; } = null!;
    public DbSet<RatingOperation> RatingOperations { get; set; } = null!;
    public DbSet<EvictionOrder> EvictionOrders { get; set; } = null!;
    public DbSet<SettlementOrder> SettlementOrders { get; set; } = null!;

    public ApplicationContext(DbContextOptions<ApplicationContext> options)
        : base(options)
    {
        Database.EnsureDeleted();
        Database.EnsureCreated();
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.UseSerialColumns();

        modelBuilder.Entity<Resident>().Property(r => r.ResidentId)
            .UseIdentityAlwaysColumn();
        modelBuilder.Entity<Resident>().HasData(new Resident()
        {
            ResidentId = 71, LastName = "Vasilev", FirstName = "Roma",
            Gender = 'M', BirthDate = DateTime.UtcNow
        }, new Resident()
        {
            ResidentId = 62, LastName = "Vasilev", FirstName = "Boma",
            Gender = 'M', BirthDate = DateTime.UtcNow
        }, new Resident()
        {
            ResidentId = 35, LastName = "Vasilev", FirstName = "Doma",
            Gender = 'M', BirthDate = DateTime.UtcNow
        }, new Resident()
        {
            ResidentId = 44, LastName = "Vasilev", FirstName = "Goma",
            Gender = 'M', BirthDate = DateTime.UtcNow
        });

        modelBuilder.Entity<Room>()
            .Property(r => r.FloorNumber)
            .HasComputedColumnSql("left(room_number, 1)", stored: true);
    }
}