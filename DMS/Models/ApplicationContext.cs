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
            ResidentId = 1, CategoryId = 1, RatingOperationId = 1,
            ChangeValue = -3, OrderDate = new DateTime(2021, 10, 9).ToUniversalTime(),
            Description = null
        }, new RatingOperation()
        {
            ResidentId = 2, CategoryId = 2, RatingOperationId = 6,
            ChangeValue = 2, OrderDate = new DateTime(2021, 10, 10).ToUniversalTime(),
            Description = null
        }, new RatingOperation()
        {
            ResidentId = 3, CategoryId = 3, RatingOperationId = 5,
            ChangeValue = -1, OrderDate = new DateTime(2021, 10, 11).ToUniversalTime(),
            Description = null
        }, new RatingOperation()
        {
            ResidentId = 4, CategoryId = 1, RatingOperationId = 4,
            ChangeValue = -2, OrderDate = new DateTime(2021, 10, 12).ToUniversalTime(),
            Description = null
        }, new RatingOperation()
        {
            ResidentId = 5, CategoryId = 2, RatingOperationId = 3,
            ChangeValue = 2, OrderDate = new DateTime(2021, 10, 13).ToUniversalTime(),
            Description = null
        }, new RatingOperation()
        {
            ResidentId = 6, CategoryId = 2, RatingOperationId = 2,
            ChangeValue = 2, OrderDate = new DateTime(2021, 10, 14).ToUniversalTime(),
            Description = null
        });
        
        modelBuilder.Entity<Transaction>().HasData(new Transaction()
        {
            ResidentId = 1, TransactionId = 1,
            OperationDate = new DateTime(2021, 10, 9).ToUniversalTime(), Sum = 3000
        }, new Transaction()
        {
           ResidentId = 2,TransactionId = 2,
           OperationDate = new DateTime(2021, 10, 9, 10, 0, 0).ToUniversalTime(), Sum = 1000
        }, new Transaction()
        {
            ResidentId = 2, TransactionId = 3,
            OperationDate = new DateTime(2021, 10, 9, 12, 0, 0).ToUniversalTime(), Sum = 3000
        }, new Transaction()
        {
            ResidentId = 3, TransactionId = 4,
            OperationDate = new DateTime(2021, 10, 12).ToUniversalTime(), Sum = 4000
        }, new Transaction()
        {
            ResidentId = 4, TransactionId = 5,
            OperationDate = new DateTime(2021, 10, 10).ToUniversalTime(), Sum = 2012.42
        }, new Transaction()
        {
            ResidentId = 5, TransactionId = 6,
            OperationDate = new DateTime(2021, 10, 20).ToUniversalTime(), Sum = 18234.13
        });
        
        modelBuilder.Entity<PassportInformation>().HasData(
            new PassportInformation()
            {
                PassportInformationId = 1, SeriesAndNumber = "1234567890",
                IssuedBy = "МВД по чему-то", DepartmentCode = 23124,
                IssueDate = DateTime.UtcNow, Address = "asdasdasdas",
                ResidentId = 1
            }, new PassportInformation()
            {
                PassportInformationId = 2, SeriesAndNumber = "1523123123",
                IssuedBy = "МВД по чему-то", DepartmentCode = 23124,
                IssueDate = DateTime.UtcNow, Address = "sadgsdfgfdg",
                ResidentId = 2
            }, new PassportInformation()
            {
                PassportInformationId = 3, SeriesAndNumber = "7916239123",
                IssuedBy = "МВД по чему-то", DepartmentCode = 23423,
                IssueDate = DateTime.UtcNow, Address = "sdghgfhgfhfgdh",
                ResidentId = 3
            }, new PassportInformation()
            {
                PassportInformationId = 4, SeriesAndNumber = "9817349817",
                IssuedBy = "МВД по чему-то", DepartmentCode = 54334,
                IssueDate = DateTime.UtcNow, Address = "asdfsdfdsaf",
                ResidentId = 4
            }, new PassportInformation()
            {
                PassportInformationId = 5, SeriesAndNumber = "1807231987",
                IssuedBy = "МВД по чему-то", DepartmentCode = 98172,
                IssueDate = DateTime.UtcNow, Address = "gdfsgfdsgdsf",
                ResidentId = 5
            });
    }
}