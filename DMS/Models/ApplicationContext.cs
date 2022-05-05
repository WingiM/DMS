using Microsoft.EntityFrameworkCore;

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
        // Database.EnsureDeleted();
        // Database.EnsureCreated();
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.UseSerialColumns();

        modelBuilder.Entity<Resident>().Property(r => r.ResidentId)
            .UseIdentityAlwaysColumn();
        modelBuilder.Entity<SettlementOrder>()
            .Property(s => s.SettlementOrderId)
            .UseIdentityAlwaysColumn();
        modelBuilder.Entity<EvictionOrder>().Property(e => e.EvictionOrderId)
            .UseIdentityAlwaysColumn();
        modelBuilder.Entity<RatingOperation>()
            .Property(ro => ro.RatingOperationId)
            .UseIdentityAlwaysColumn();
        modelBuilder.Entity<RatingChangeCategory>()
            .Property(rc => rc.RatingChangeCategoryId)
            .UseIdentityAlwaysColumn();
        modelBuilder.Entity<Transaction>().Property(t => t.TransactionId)
            .UseIdentityAlwaysColumn();

        modelBuilder.Entity<Resident>().HasData(new Resident()
        {
            ResidentId = 1, LastName = "Морозов", FirstName = "Даниил",
            Patronymic = "Артёмович", RoomId = 301, Gender = 'M',
            BirthDate = DateTime.UtcNow
        }, new Resident()
        {
            ResidentId = 2, LastName = "Васильев", FirstName = "Роман",
            Patronymic = "Алексеевич", RoomId = 423, Gender = 'M',
            BirthDate = DateTime.UtcNow
        }, new Resident()
        {
            ResidentId = 3, LastName = "Vasilev", FirstName = "Doma",
            Patronymic = "Артёмович", RoomId = 301, Gender = 'M',
            BirthDate = DateTime.UtcNow
        }, new Resident()
        {
            ResidentId = 4, LastName = "Vasilev", FirstName = "Goma",
            Patronymic = "Артёмович", RoomId = 301, Gender = 'M',
            BirthDate = DateTime.UtcNow
        }, new Resident()
        {
            ResidentId = 5, LastName = "Vasilev", FirstName = "Doma",
            Patronymic = "Артёмович", RoomId = 302, Gender = 'M',
            BirthDate = DateTime.UtcNow
        }, new Resident()
        {
            ResidentId = 6, LastName = "Vasilev", FirstName = "Moma",
            Patronymic = "Артёмович", RoomId = 303, Gender = 'M',
            BirthDate = DateTime.UtcNow
        }, new Resident()
        {
            ResidentId = 7, LastName = "Vasilev", FirstName = "Noma",
            Patronymic = "Артёмович", RoomId = 304, Gender = 'M',
            BirthDate = DateTime.UtcNow
        }, new Resident()
        {
            ResidentId = 8, LastName = "Vasilev", FirstName = "Bulat",
            Patronymic = "Артёмович", RoomId = 305, Gender = 'M',
            BirthDate = DateTime.UtcNow
        }, new Resident()
        {
            ResidentId = 9, LastName = "Vasilev", FirstName = "Bulad",
            Patronymic = "Артёмович", RoomId = 306, Gender = 'M',
            BirthDate = DateTime.UtcNow
        }, new Resident()
        {
            ResidentId = 10, LastName = "Vasilev", FirstName = "Bular",
            Patronymic = "Артёмович", RoomId = 307, Gender = 'M',
            BirthDate = DateTime.UtcNow
        }, new Resident()
        {
            ResidentId = 11, LastName = "Vasilev", FirstName = "Bulas",
            Patronymic = "Артёмович", RoomId = 407, Gender = 'M',
            BirthDate = DateTime.UtcNow
        });

        modelBuilder.Entity<Room>()
            .Property(r => r.FloorNumber)
            .HasComputedColumnSql("room_number / 100", stored: true);
        modelBuilder.Entity<Room>().HasData(new Room()
            {
                Capacity = 3, Gender = 'M', RoomId = 301
            }, new Room()
            {
                Capacity = 3, Gender = 'M', RoomId = 302
            }, new Room()
            {
                Capacity = 3, Gender = 'M', RoomId = 303
            }, new Room()
            {
                Capacity = 3, Gender = 'M', RoomId = 304
            }, new Room()
            {
                Capacity = 3, Gender = 'M', RoomId = 305
            }, new Room()
            {
                Capacity = 3, Gender = 'M', RoomId = 306
            }, new Room()
            {
                Capacity = 3, Gender = 'M', RoomId = 307
            }, new Room()
            {
                Capacity = 3, Gender = 'M', RoomId = 308
            }, new Room()
            {
                Capacity = 3, Gender = 'M', RoomId = 309
            }, new Room()
            {
                Capacity = 3, Gender = 'M', RoomId = 407
            }, new Room()
            {
                Capacity = 3, Gender = 'M', RoomId = 423
            }
        );

        modelBuilder.Entity<SettlementOrder>().HasData(new SettlementOrder()
        {
            SettlementOrderId = 1, ResidentId = 1, RoomId = 301,
            Description = null, OrderDate = DateTime.UtcNow,
        }, new SettlementOrder()
        {
            SettlementOrderId = 2, ResidentId = 2, RoomId = 423,
            Description = null, OrderDate = DateTime.UtcNow,
        }, new SettlementOrder()
        {
            SettlementOrderId = 3, ResidentId = 3, RoomId = 301,
            Description = null, OrderDate = DateTime.UtcNow,
        }, new SettlementOrder()
        {
            SettlementOrderId = 4, ResidentId = 4, RoomId = 301,
            Description = null, OrderDate = DateTime.UtcNow,
        }, new SettlementOrder()
        {
            SettlementOrderId = 5, ResidentId = 5, RoomId = 302,
            Description = null, OrderDate = DateTime.UtcNow,
        }, new SettlementOrder()
        {
            SettlementOrderId = 6, ResidentId = 6, RoomId = 303,
            Description = null, OrderDate = DateTime.UtcNow,
        }, new SettlementOrder()
        {
            SettlementOrderId = 7, ResidentId = 7, RoomId = 304,
            Description = null, OrderDate = DateTime.UtcNow,
        }, new SettlementOrder()
        {
            SettlementOrderId = 8, ResidentId = 8, RoomId = 305,
            Description = null, OrderDate = DateTime.UtcNow,
        }, new SettlementOrder()
        {
            SettlementOrderId = 9, ResidentId = 9, RoomId = 306,
            Description = null, OrderDate = DateTime.UtcNow,
        }, new SettlementOrder()
        {
            SettlementOrderId = 10, ResidentId = 10, RoomId = 307,
            Description = null, OrderDate = DateTime.UtcNow,
        }, new SettlementOrder()
        {
            SettlementOrderId = 11, ResidentId = 11, RoomId = 407,
            Description = null, OrderDate = DateTime.UtcNow,
        });

        modelBuilder.Entity<EvictionOrder>().HasData(new EvictionOrder()
        {
            EvictionOrderId = 1, ResidentId = 11,
            OrderDate = DateTime.UtcNow, Description = null
        }, new EvictionOrder()
        {
            EvictionOrderId = 2, ResidentId = 10,
            OrderDate = DateTime.UtcNow, Description = null
        }, new EvictionOrder()
        {
            EvictionOrderId = 3, ResidentId = 9,
            OrderDate = DateTime.UtcNow, Description = null
        }, new EvictionOrder()
        {
            EvictionOrderId = 4, ResidentId = 8,
            OrderDate = DateTime.UtcNow, Description = null
        }, new EvictionOrder()
        {
            EvictionOrderId = 5, ResidentId = 7,
            OrderDate = DateTime.UtcNow, Description = null
        });

        modelBuilder.Entity<RatingChangeCategory>().HasData(
            new RatingChangeCategory()
            {
                RatingChangeCategoryId = 1, Name = "Докладная"
            }, new RatingChangeCategory()
            {
                RatingChangeCategoryId = 2, Name = "Поощрение"
            }, new RatingChangeCategory()
            {
                RatingChangeCategoryId = 3, Name = "Выговор"
            });

        modelBuilder.Entity<RatingOperation>().HasData(new RatingOperation()
        {
            RatingOperationId = 1, ResidentId = 1, CategoryId = 1,
            ChangeValue = -3, OrderDate = DateTime.UtcNow,
            Description = null
        }, new RatingOperation()
        {
            RatingOperationId = 2, ResidentId = 2, CategoryId = 2,
            ChangeValue = 2, OrderDate = DateTime.UtcNow,
            Description = null
        }, new RatingOperation()
        {
            RatingOperationId = 3, ResidentId = 3, CategoryId = 3,
            ChangeValue = -1, OrderDate = DateTime.UtcNow,
            Description = null
        }, new RatingOperation()
        {
            RatingOperationId = 4, ResidentId = 4, CategoryId = 1,
            ChangeValue = -2, OrderDate = DateTime.UtcNow,
            Description = null
        }, new RatingOperation()
        {
            RatingOperationId = 5, ResidentId = 5, CategoryId = 2,
            ChangeValue = 2, OrderDate = DateTime.UtcNow,
            Description = null
        }, new RatingOperation()
        {
            RatingOperationId = 6, ResidentId = 6, CategoryId = 2,
            ChangeValue = 2, OrderDate = DateTime.UtcNow,
            Description = null
        });

        modelBuilder.Entity<Transaction>().HasData(new Transaction()
        {
            TransactionId = 1, ResidentId = 1,
            OperationDate = DateTime.UtcNow, Sum = 3000
        }, new Transaction()
        {
            TransactionId = 2, ResidentId = 2,
            OperationDate = DateTime.UtcNow, Sum = 1000
        }, new Transaction()
        {
            TransactionId = 3, ResidentId = 2,
            OperationDate = DateTime.UtcNow, Sum = 3000
        }, new Transaction()
        {
            TransactionId = 4, ResidentId = 3,
            OperationDate = DateTime.UtcNow, Sum = 4000
        }, new Transaction()
        {
            TransactionId = 5, ResidentId = 4,
            OperationDate = DateTime.UtcNow, Sum = 2012.42
        }, new Transaction()
        {
            TransactionId = 6, ResidentId = 5,
            OperationDate = DateTime.UtcNow, Sum = 18234.13
        });
    }
}