using DMS.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace DMS.Data;

public class ApplicationContext : DbContext
{
    public DbSet<RoomDb> Rooms { get; set; } = null!;
    public DbSet<ResidentDb> Residents { get; set; } = null!;

    public DbSet<RatingChangeCategoryDb>
        RatingChangeCategories { get; set; } = null!;

    public DbSet<TransactionDb> Transactions { get; set; } = null!;
    public DbSet<RatingOperationDb> RatingOperations { get; set; } = null!;
    public DbSet<EvictionOrderDb> EvictionOrders { get; set; } = null!;
    public DbSet<SettlementOrderDb> SettlementOrders { get; set; } = null!;

    public DbSet<PassportInformationDb> Passports { get; set; } =
        null!;

    public ApplicationContext(DbContextOptions<ApplicationContext> options)
        : base(options) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<PassportInformationDb>().HasKey(p =>
            new { p.ResidentId, p.PassportInformationId });
        
        modelBuilder.Entity<ResidentDb>().Property(r => r.ResidentId)
            .UseIdentityAlwaysColumn();
        modelBuilder.Entity<SettlementOrderDb>().Property(s => s.SettlementOrderId)
            .UseIdentityAlwaysColumn();
        modelBuilder.Entity<EvictionOrderDb>().Property(e => e.EvictionOrderId)
            .UseIdentityAlwaysColumn();
        modelBuilder.Entity<RatingChangeCategoryDb>().Property(rc => rc.RatingChangeCategoryId)
            .UseIdentityAlwaysColumn();
        modelBuilder.Entity<RoomDb>().Property(r => r.FloorNumber)
            .HasComputedColumnSql("room_number / 100", stored:true);
        
        modelBuilder.Entity<ResidentDb>().HasData(new ResidentDb()
        {
            ResidentId = 1, LastName = "Морозов", FirstName = "Даниил",
            Patronymic = "Артёмович", Gender = 'M',
            BirthDate = new DateTime(2003,4,21).ToUniversalTime(),
            IsCommercial = true, Tin = "737277807092", Course = 4
        }, new ResidentDb()
        {
            ResidentId = 2, LastName = "Дубов", FirstName = "Платон",
            Patronymic = "Александрович",  Gender = 'M',
            BirthDate = new DateTime(2005,12,2).ToUniversalTime(),
            IsCommercial = true, Tin = "276204981825", Course = 2
        }, new ResidentDb()
        {
            ResidentId = 3, LastName = "Галкин", FirstName = "Артём",
            Patronymic = "Константинович", RoomId = 301, Gender = 'M',
            BirthDate = new DateTime(2004,4,3).ToUniversalTime(),
            IsCommercial = true, Tin = "545375584419", Course = 1
        }, new ResidentDb()
        {
            ResidentId = 4, LastName = "Скворцов", FirstName = "Владимир",
            Patronymic = "Максимович", RoomId = 302, Gender = 'M',
            BirthDate = new DateTime(2004,4,19).ToUniversalTime(),
            IsCommercial = false, Tin = "541729308186", Course = 3
        }, new ResidentDb()
        {
            ResidentId = 5, LastName = "Латышев", FirstName = "Мирон",
            Patronymic = "Глебович", RoomId = 302, Gender = 'M',
            BirthDate = new DateTime(2002,6,23).ToUniversalTime(),
            IsCommercial = false, Tin = "498392680283", Course = 4
        }, new ResidentDb()
        {
            ResidentId = 6, LastName = "Маркин", FirstName = "Александр",
            Patronymic = "Тимурович", RoomId = 302, Gender = 'M',
            BirthDate = new DateTime(2005,6,3).ToUniversalTime(),
            IsCommercial = false, Tin = "252251775675", Course = 1
        }, new ResidentDb()
        {
            ResidentId = 7, LastName = "Майоров", FirstName = "Андрей",
            Patronymic = "Александрович", RoomId = 303, Gender = 'M',
            BirthDate = new DateTime(2004,5,22).ToUniversalTime(),
            IsCommercial = false, Tin = "316152736997", Course = 4
        }, new ResidentDb()
        {
            ResidentId = 8, LastName = "Матвеев", FirstName = "Андрей",
            Patronymic = "Максимович", RoomId = 303, Gender = 'M',
            BirthDate = new DateTime(2004,4,22).ToUniversalTime(),
            IsCommercial = true, Tin = "728273836756", Course = 4
        }, new ResidentDb()
        {
            ResidentId = 9, LastName = "Авдеев", FirstName = "Денис",
            Patronymic = "Евгеньевич", RoomId = 303, Gender = 'M',
            BirthDate = new DateTime(2002,11,16).ToUniversalTime(),
            IsCommercial = false, Tin = "715730062207", Course = 1
        }, new ResidentDb()
        {
            ResidentId = 10, LastName = "Богданов", FirstName = "Кирилл",
            Patronymic = "Кириллович", RoomId = 304, Gender = 'M',
            BirthDate = new DateTime(2002,11,11).ToUniversalTime(),
            IsCommercial = true, Tin = "642845725453", Course = 1
        }, new ResidentDb()
        {
            ResidentId = 11, LastName = "Сахаров", FirstName = "Александр",
            Patronymic = "Егорович", RoomId = 304, Gender = 'M',
            BirthDate = new DateTime(2003,11,14).ToUniversalTime(),
            IsCommercial = true, Tin = "359284956944", Course = 2
        }, new ResidentDb()
        {
            ResidentId = 12, LastName = "Иванов", FirstName = "Роман",
            Patronymic = "Романович", RoomId = 304, Gender = 'M',
            BirthDate = new DateTime(2005,1,10).ToUniversalTime(),
            IsCommercial = false, Tin = "799582532172", Course = 2
        }, new ResidentDb()
        {
            ResidentId = 13, LastName = "Панов", FirstName = "Кирилл",
            Patronymic = "Романович", RoomId = 305, Gender = 'M',
            BirthDate = new DateTime(2006,12,30).ToUniversalTime(),
            IsCommercial = true, Tin = "108102025148", Course = 3
        }, new ResidentDb()
        {
            ResidentId = 14, LastName = "Ершов", FirstName = "Руслан",
            Patronymic = "Иванович", RoomId = 305, Gender = 'M',
            BirthDate = new DateTime(2002,10,6).ToUniversalTime(),
            IsCommercial = false, Tin = "288734150714", Course = 4
        }, new ResidentDb()
        {
            ResidentId = 15, LastName = "Афанасьев", FirstName = "Евгений",
            Patronymic = "Максимович", RoomId = 305, Gender = 'M',
            BirthDate = new DateTime(2005,4,19).ToUniversalTime(),
            IsCommercial = false, Tin = "613391118617", Course = 4
        });

        modelBuilder.Entity<PassportInformationDb>().HasData(new PassportInformationDb()
        {
            PassportInformationId = 1, SeriesAndNumber = "4943101489", 
            IssuedBy = "Отделом внутренних дел России по г. Йошкар-Ола", DepartmentCode = 930822 , 
            IssueDate = new DateTime(2019,8,19).ToUniversalTime(), 
            Address = "Россия, г. Йошкар-Ола, Радужная ул., д. 4 кв.58",
            ResidentId = 1
        },new PassportInformationDb()
        {
            PassportInformationId = 2, SeriesAndNumber = "4702117803", 
            IssuedBy = "Отделением УФМС России по г. Екатеринбург", DepartmentCode = 830605, 
            IssueDate = new DateTime(2019,11,25).ToUniversalTime(), 
            Address = "Россия, г. Екатеринбург, Центральный пер., д. 18 кв.101", 
            ResidentId = 2
        },new PassportInformationDb()
        {
            PassportInformationId = 3, SeriesAndNumber = "4006644387", 
            IssuedBy = "Отделением УФМС России в г. Новошахтинск", DepartmentCode = 670210, 
            IssueDate = new DateTime(2016,10,6).ToUniversalTime(), 
            Address = "Россия, г. Новошахтинск, Пролетарская ул., д. 18 кв.32", 
            ResidentId = 3
        },new PassportInformationDb()
        {
            PassportInformationId = 4, SeriesAndNumber = "4906472737", 
            IssuedBy = "Отделением УФМС России по г. Домодедово", DepartmentCode = 660389, 
            IssueDate = new DateTime(2018,12,2).ToUniversalTime(), 
            Address = "Россия, г. Домодедово, Солнечный пер., д. 8 кв.4", 
            ResidentId = 4
        },new PassportInformationDb()
        {
            PassportInformationId = 5, SeriesAndNumber = "4102385088", 
            IssuedBy = "Отделением УФМС России в г. Балаково", DepartmentCode = 920691, 
            IssueDate = new DateTime(2016,3,17).ToUniversalTime(), 
            Address = "Россия, г. Балаково, Совхозная ул., д. 8 кв.144", 
            ResidentId = 5
        },new PassportInformationDb()
        {
            PassportInformationId = 6, SeriesAndNumber = "4605443539", 
            IssuedBy = "Отделом внутренних дел России по г. Томск", DepartmentCode = 590726, 
            IssueDate = new DateTime(2018,7,27).ToUniversalTime(), 
            Address = "Россия, г. Томск, Колхозный пер., д. 23 кв.218", 
            ResidentId = 6
        },new PassportInformationDb()
        {
            PassportInformationId = 7, SeriesAndNumber = "4404497341", 
            IssuedBy = "ОУФМС России по г. Энгельс", DepartmentCode = 670697, 
            IssueDate = new DateTime(2019,1,1).ToUniversalTime(), 
            Address = "Россия, г. Энгельс, ул. Ленина, д. 13 кв.269", 
            ResidentId = 7
        },new PassportInformationDb()
        {
            PassportInformationId = 8, SeriesAndNumber = "4205516390", 
            IssuedBy = "Управление внутренних дел по г. Благовещенск", DepartmentCode = 640958, 
            IssueDate = new DateTime(2018,11,16).ToUniversalTime(), 
            Address = "Россия, г. Благовещенск, Цветочный пер., д. 54 кв.12", 
            ResidentId = 8
        },new PassportInformationDb()
        {
            PassportInformationId = 9, SeriesAndNumber = "4703955170", 
            IssuedBy = "Отделением УФМС России в г. Балаково", DepartmentCode = 230962, 
            IssueDate = new DateTime(2017,8,6).ToUniversalTime(), 
            Address = "Россия, г. Балаково, ул. Женитьбы, д. 21 кв.14", 
            ResidentId = 9
        },new PassportInformationDb()
        {
            PassportInformationId = 10, SeriesAndNumber = "4906779333", 
            IssuedBy = "Отделением УФМС России по г. Владивосток", DepartmentCode = 920142, 
            IssueDate = new DateTime(2018,1,13).ToUniversalTime(), 
            Address = "Россия, г. Владивосток, ул. Красная, д. 21 кв.15", 
            ResidentId = 10
        });

        modelBuilder.Entity<SettlementOrderDb>().HasData(new SettlementOrderDb()
        {
            SettlementOrderId = 1, ResidentId = 1, RoomId = 301, 
            OrderDate = new DateTime(21,08,29).ToUniversalTime(),
            ParentsFullName = "Беляков Даниил Андреевич", ParentsPassportDepartmentCode = 930822,
            ParentsPassportIssueDate = new DateTime(1987,10,4).ToUniversalTime(),
            ParentsPassportIssuedBy = "Отделением УФМС России в г. Балаково",
            ParentsPassportSeriesNumber = "4605443539",
            ParentsPassportAddress = "Россия, г. Йошкар-Ола, Радужная ул., д. 4 кв.58"
        }, new SettlementOrderDb()
        {
            SettlementOrderId = 2, ResidentId = 2, RoomId = 301,
            OrderDate = new DateTime(21,08,30).ToUniversalTime(),
            ParentsFullName = "Игнатова Анастасия Семёновна", ParentsPassportDepartmentCode = 830605,
            ParentsPassportIssueDate = new DateTime(1987,10,4).ToUniversalTime(),
            ParentsPassportIssuedBy = "Отделением УФМС России по г. Владивосток",
            ParentsPassportSeriesNumber = "4404497341",
            ParentsPassportAddress = "Россия, г. Екатеринбург, Центральный пер., д. 18 кв.101"
        }, new SettlementOrderDb()
        {
            SettlementOrderId = 3, ResidentId = 3, RoomId = 301,
            OrderDate = new DateTime(21,9,1).ToUniversalTime(),
            ParentsFullName = "Васильев Александр Захарович", ParentsPassportDepartmentCode = 670210,
            ParentsPassportIssueDate = new DateTime(1987,10,4).ToUniversalTime(),
            ParentsPassportIssuedBy = "Отделом внутренних дел России по г. Йошкар-Ола",
            ParentsPassportSeriesNumber = "4205516390",
            ParentsPassportAddress = "Россия, г. Новошахтинск, Пролетарская ул., д. 18 кв.32"
        }, new SettlementOrderDb()
        {
            SettlementOrderId = 4, ResidentId = 4, RoomId = 302,
            OrderDate = new DateTime(21,8,28).ToUniversalTime(),
            ParentsFullName = "Иванов Георгий Никитич", ParentsPassportDepartmentCode = 660389,
            ParentsPassportIssueDate = new DateTime(1987,10,4).ToUniversalTime(),
            ParentsPassportIssuedBy = "Отделением УФМС России по г. Екатеринбург",
            ParentsPassportSeriesNumber = "4703955170",
            ParentsPassportAddress = "Россия, г. Домодедово, Солнечный пер., д. 8 кв.4"
        }, new SettlementOrderDb()
        {
            SettlementOrderId = 5, ResidentId = 5, RoomId = 302, 
            OrderDate = new DateTime(21,8,29).ToUniversalTime(),
            ParentsFullName = "Исаков Тимур Романович", ParentsPassportDepartmentCode = 920691,
            ParentsPassportIssueDate = new DateTime(1987,10,4).ToUniversalTime(), 
            ParentsPassportIssuedBy = "Отделением УФМС России в г. Новошахтинск",
            ParentsPassportSeriesNumber = "4906779333",
            ParentsPassportAddress = "Россия, г. Балаково, Совхозная ул., д. 8 кв.144"
        }, new SettlementOrderDb()
        {
            SettlementOrderId = 6, ResidentId = 6, RoomId = 302, 
            OrderDate = new DateTime(21,8,30).ToUniversalTime(),
            ParentsFullName = "Пахомова Виктория Ярославовна", ParentsPassportDepartmentCode = 590726,
            ParentsPassportIssueDate = new DateTime(1987,10,4).ToUniversalTime(),
            ParentsPassportIssuedBy = "Отделением УФМС России по г. Домодедово",
            ParentsPassportSeriesNumber = "4504272308",
            ParentsPassportAddress = "Россия, г. Томск, Колхозный пер., д. 23 кв.218"
        }, new SettlementOrderDb()
        {
            SettlementOrderId = 7, ResidentId = 7, RoomId = 303, 
            OrderDate = new DateTime(21,8,30).ToUniversalTime(),
            ParentsFullName = "Исаева Анна Васильевна", ParentsPassportDepartmentCode = 670697,
            ParentsPassportIssueDate = new DateTime(1987,10,4).ToUniversalTime(), 
            ParentsPassportIssuedBy = "Отделением УФМС России в г. Балаково",
            ParentsPassportSeriesNumber = "4602684723",
            ParentsPassportAddress = "Россия, г. Энгельс, ул. Ленина, д. 13 кв.269"
        }, new SettlementOrderDb()
        {
            SettlementOrderId = 8, ResidentId = 8, RoomId = 303, 
            OrderDate = new DateTime(21,9,1).ToUniversalTime(),
            ParentsFullName = "Царева Эмилия Леонидовна", ParentsPassportDepartmentCode = 640958,
            ParentsPassportIssueDate = new DateTime(1987,10,4).ToUniversalTime(),
            ParentsPassportIssuedBy = "Отделом внутренних дел России по г. Томск",
            ParentsPassportSeriesNumber = "4604696743",
            ParentsPassportAddress = "Россия, г. Благовещенск, Цветочный пер., д. 54 кв.12"
        }, new SettlementOrderDb()
        {
            SettlementOrderId = 9, ResidentId = 9, RoomId = 303,
            OrderDate = new DateTime(21,9,2).ToUniversalTime(),
            ParentsFullName = "Золотарева Дарья Матвеевна", ParentsPassportDepartmentCode = 230962,
            ParentsPassportIssueDate = new DateTime(1987,10,4).ToUniversalTime(),
            ParentsPassportIssuedBy = "ОУФМС России по г. Энгельс",
            ParentsPassportSeriesNumber = "4704095718",
            ParentsPassportAddress = "Россия, г. Балаково, ул. Женитьбы, д. 21 кв.14"
        }, new SettlementOrderDb()
        {
            SettlementOrderId = 10, ResidentId = 10, RoomId = 304,
            OrderDate = new DateTime(21,8,29).ToUniversalTime(),
            ParentsFullName = "Власова София Леонидовна", ParentsPassportDepartmentCode = 920142,
            ParentsPassportIssueDate = new DateTime(1987,10,4).ToUniversalTime(),
            ParentsPassportIssuedBy = "Управление внутренних дел по г. Благовещенск",
            ParentsPassportSeriesNumber = "4302520273",
            ParentsPassportAddress = "Россия, г. Владивосток, ул. Красная, д. 21 кв.15"
        });

        modelBuilder.Entity<EvictionOrderDb>().HasData(new EvictionOrderDb()
        {
            EvictionOrderId = 1, ResidentId = 7,
            OrderDate = new DateTime(2022,1,17).ToUniversalTime()
        }, new EvictionOrderDb()
        {
            EvictionOrderId = 2, ResidentId = 4,
            OrderDate = new DateTime(2022,8,3).ToUniversalTime()
        }, new EvictionOrderDb()
        {
            EvictionOrderId = 3, ResidentId = 10,
            OrderDate = new DateTime(2022,1,21).ToUniversalTime()
        });

        modelBuilder.Entity<TransactionDb>().HasData(new TransactionDb()
        {
            TransactionId = 1, ResidentId = 1,
            OperationDate = new DateTime(2022,9,18).ToUniversalTime(),
            Sum = 7931.14
        }, new TransactionDb()
        {
            TransactionId = 2, ResidentId = 2,
            OperationDate = new DateTime(2022,9,26).ToUniversalTime(),
            Sum = 6255.49
        }, new TransactionDb()
        {
            TransactionId = 3, ResidentId = 3,
            OperationDate = new DateTime(2022,8,28).ToUniversalTime(),
            Sum = 9617.53
        }, new TransactionDb()
        {
            TransactionId = 4, ResidentId = 4,
            OperationDate = new DateTime(2022,8,30).ToUniversalTime(),
            Sum = 5058.38
        }, new TransactionDb()
        {
            TransactionId = 5, ResidentId = 5,
            OperationDate = new DateTime(2022,9,1).ToUniversalTime(),
            Sum = 9588.48
        }, new TransactionDb()
        {
            TransactionId = 6, ResidentId = 6,
            OperationDate = new DateTime(2022,8,29).ToUniversalTime(),
            Sum = 7287.07
        }, new TransactionDb()
        {
            TransactionId = 7, ResidentId = 7,
            OperationDate = new DateTime(2022,5,24).ToUniversalTime(),
            Sum = 8917.21
        }, new TransactionDb()
        {
            TransactionId = 8, ResidentId = 8,
            OperationDate = new DateTime(2022,4,29).ToUniversalTime(),
            Sum = 5403.78
        }, new TransactionDb()
        {
            TransactionId = 9, ResidentId = 9,
            OperationDate = new DateTime(2022,3,29).ToUniversalTime(),
            Sum = 6124.77
        }, new TransactionDb()
        {
            TransactionId = 10, ResidentId = 10,
            OperationDate = new DateTime(2022,2,23).ToUniversalTime(),
            Sum = 5108.79
        });

        modelBuilder.Entity<RatingChangeCategoryDb>().HasData(new RatingChangeCategoryDb()
        {
            RatingChangeCategoryId = 1, Name = "Докладная"
        }, new RatingChangeCategoryDb()
        {
            RatingChangeCategoryId = 2, Name = "Поощрение"
        }, new RatingChangeCategoryDb()
        {
            RatingChangeCategoryId = 3, Name = "Выговор"
        });

        modelBuilder.Entity<RatingOperationDb>().HasData(new RatingOperationDb()
        {
            RatingOperationId = 1, ResidentId = 1,
            CategoryId = 1, ChangeValue = -3,
            OrderDate = new DateTime(2022,5,12).ToUniversalTime()
        }, new RatingOperationDb()
        {
            RatingOperationId = 2, ResidentId = 2,
            CategoryId = 2, ChangeValue = 1,
            OrderDate = new DateTime(2022,4,11).ToUniversalTime()
        }, new RatingOperationDb()
        {
            RatingOperationId = 3, ResidentId = 3,
            CategoryId = 2, ChangeValue = 2,
            OrderDate = new DateTime(2022,5,1).ToUniversalTime()
        }, new RatingOperationDb()
        {
            RatingOperationId = 4, ResidentId = 4,
            CategoryId = 2, ChangeValue = 1,
            OrderDate = new DateTime(2022,6,2).ToUniversalTime()
        }, new RatingOperationDb()
        {
            RatingOperationId = 5, ResidentId = 5,
            CategoryId = 3, ChangeValue = -1,
            OrderDate = new DateTime(2022,5,21).ToUniversalTime()
        }, new RatingOperationDb()
        {
            RatingOperationId = 6, ResidentId = 6,
            CategoryId = 2, ChangeValue = 3,
            OrderDate = new DateTime(2022,3,5).ToUniversalTime()
        });

        modelBuilder.Entity<RoomDb>().HasData(new RoomDb()
        {
            RoomId = 301, Capacity = 3, Gender = 'M',
            FloorNumber = 3
        }, new RoomDb()
        {
            RoomId = 302, Capacity = 3, Gender = 'M',
            FloorNumber = 3
        }, new RoomDb()
        {
            RoomId = 303, Capacity = 3, Gender = 'M',
            FloorNumber = 3
        }, new RoomDb()
        {
            RoomId = 304, Capacity = 3, Gender = 'M',
            FloorNumber = 3
        }, new RoomDb()
        {
            RoomId = 305, Capacity = 3, Gender = 'M',
            FloorNumber = 3
        }, new RoomDb()
        {
            RoomId = 306, Capacity = 3, Gender = 'M',
            FloorNumber = 3
        }, new RoomDb()
        {
            RoomId = 307, Capacity = 3, Gender = 'M',
            FloorNumber = 3
        });
    }
}

public class Factory : IDesignTimeDbContextFactory<ApplicationContext>
{
    public ApplicationContext CreateDbContext(string[] args)
    {
        var options = new DbContextOptionsBuilder<ApplicationContext>()
            .UseNpgsql("Host=localhost;Port=5432;Database=dms;Username=postgres;Password=postgres;")
            .UseSnakeCaseNamingConvention()
            .Options;
        return new ApplicationContext(options);
    }
}