using Microsoft.EntityFrameworkCore;

namespace DMS.Models;

public class ApplicationContext : DbContext
{
    public DbSet<Room> Rooms { get; set; } = null!;
    public DbSet<Resident> Residents { get; set; } = null!;

    public DbSet<RatingChangeCategory>
        RatingChangeCategories { get; set; } = null!;

    public DbSet<Transaction> Transactions { get; set; } = null!;
    public DbSet<RatingOperation> RatingOperations { get; set; } = null!;
    public DbSet<EvictionOrder> EvictionOrders { get; set; } = null!;
    public DbSet<SettlementOrder> SettlementOrders { get; set; } = null!;

    public DbSet<PassportInformation> Passports { get; set; } =
        null!;

    public ApplicationContext(DbContextOptions<ApplicationContext> options)
        : base(options) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Resident>().Property(r => r.ResidentId)
            .UseIdentityAlwaysColumn();
        modelBuilder.Entity<SettlementOrder>().Property(s => s.SettlementOrderId)
            .UseIdentityAlwaysColumn();
        modelBuilder.Entity<EvictionOrder>().Property(e => e.EvictionOrderId)
            .UseIdentityAlwaysColumn();
        modelBuilder.Entity<RatingChangeCategory>().Property(rc => rc.RatingChangeCategoryId)
            .UseIdentityAlwaysColumn();
        modelBuilder.Entity<Room>().Property(r => r.FloorNumber)
            .HasComputedColumnSql("room_number / 100", stored:true);
    }
}