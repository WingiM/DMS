﻿// <auto-generated />
using System;
using DMS.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace DMS.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    partial class ApplicationContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("DMS.Models.EvictionOrder", b =>
                {
                    b.Property<int>("EvictionOrderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("order_id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityAlwaysColumn(b.Property<int>("EvictionOrderId"));

                    b.Property<string>("Description")
                        .HasColumnType("varchar(200)")
                        .HasColumnName("description");

                    b.Property<DateTime>("OrderDate")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("order_date");

                    b.Property<int>("ResidentId")
                        .HasColumnType("int")
                        .HasColumnName("resident_id");

                    b.HasKey("EvictionOrderId");

                    b.HasIndex("ResidentId");

                    b.ToTable("eviction_order");

                    b.HasData(
                        new
                        {
                            EvictionOrderId = 1,
                            OrderDate = new DateTime(2022, 5, 15, 17, 4, 56, 387, DateTimeKind.Utc).AddTicks(9193),
                            ResidentId = 11
                        },
                        new
                        {
                            EvictionOrderId = 2,
                            OrderDate = new DateTime(2022, 5, 15, 17, 4, 56, 387, DateTimeKind.Utc).AddTicks(9195),
                            ResidentId = 10
                        },
                        new
                        {
                            EvictionOrderId = 3,
                            OrderDate = new DateTime(2022, 5, 15, 17, 4, 56, 387, DateTimeKind.Utc).AddTicks(9196),
                            ResidentId = 9
                        },
                        new
                        {
                            EvictionOrderId = 4,
                            OrderDate = new DateTime(2022, 5, 15, 17, 4, 56, 387, DateTimeKind.Utc).AddTicks(9197),
                            ResidentId = 8
                        },
                        new
                        {
                            EvictionOrderId = 5,
                            OrderDate = new DateTime(2022, 5, 15, 17, 4, 56, 387, DateTimeKind.Utc).AddTicks(9198),
                            ResidentId = 7
                        });
                });

            modelBuilder.Entity("DMS.Models.PassportInformation", b =>
                {
                    b.Property<int>("PassportInformationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("passport_information_id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("PassportInformationId"));

                    b.Property<string>("Address")
                        .HasColumnType("varchar(70)")
                        .HasColumnName("address");

                    b.Property<int?>("DepartmentCode")
                        .HasColumnType("integer")
                        .HasColumnName("department_code");

                    b.Property<DateTime?>("IssueDate")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("issue_date");

                    b.Property<string>("IssuedBy")
                        .HasColumnType("varchar(50)")
                        .HasColumnName("issued_by");

                    b.Property<int>("ResidentId")
                        .HasColumnType("int")
                        .HasColumnName("resident_id");

                    b.Property<string>("SeriesAndNumber")
                        .HasColumnType("varchar(10)")
                        .HasColumnName("series_number");

                    b.HasKey("PassportInformationId");

                    b.HasIndex("ResidentId")
                        .IsUnique();

                    b.HasIndex("SeriesAndNumber")
                        .IsUnique();

                    b.ToTable("passport_information");

                    b.HasData(
                        new
                        {
                            PassportInformationId = 1,
                            Address = "asdasdasdas",
                            DepartmentCode = 23124,
                            IssueDate = new DateTime(2022, 5, 15, 17, 4, 56, 387, DateTimeKind.Utc).AddTicks(9372),
                            IssuedBy = "МВД по чему-то",
                            ResidentId = 1,
                            SeriesAndNumber = "1234567890"
                        },
                        new
                        {
                            PassportInformationId = 2,
                            Address = "sadgsdfgfdg",
                            DepartmentCode = 23124,
                            IssueDate = new DateTime(2022, 5, 15, 17, 4, 56, 387, DateTimeKind.Utc).AddTicks(9377),
                            IssuedBy = "МВД по чему-то",
                            ResidentId = 2,
                            SeriesAndNumber = "1523123123"
                        },
                        new
                        {
                            PassportInformationId = 3,
                            Address = "sdghgfhgfhfgdh",
                            DepartmentCode = 23423,
                            IssueDate = new DateTime(2022, 5, 15, 17, 4, 56, 387, DateTimeKind.Utc).AddTicks(9378),
                            IssuedBy = "МВД по чему-то",
                            ResidentId = 3,
                            SeriesAndNumber = "7916239123"
                        },
                        new
                        {
                            PassportInformationId = 4,
                            Address = "asdfsdfdsaf",
                            DepartmentCode = 54334,
                            IssueDate = new DateTime(2022, 5, 15, 17, 4, 56, 387, DateTimeKind.Utc).AddTicks(9380),
                            IssuedBy = "МВД по чему-то",
                            ResidentId = 4,
                            SeriesAndNumber = "9817349817"
                        },
                        new
                        {
                            PassportInformationId = 5,
                            Address = "gdfsgfdsgdsf",
                            DepartmentCode = 98172,
                            IssueDate = new DateTime(2022, 5, 15, 17, 4, 56, 387, DateTimeKind.Utc).AddTicks(9382),
                            IssuedBy = "МВД по чему-то",
                            ResidentId = 5,
                            SeriesAndNumber = "1807231987"
                        });
                });

            modelBuilder.Entity("DMS.Models.RatingChangeCategory", b =>
                {
                    b.Property<int>("RatingChangeCategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("category_id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityAlwaysColumn(b.Property<int>("RatingChangeCategoryId"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar(20)")
                        .HasColumnName("name");

                    b.HasKey("RatingChangeCategoryId");

                    b.ToTable("rating_change_category");

                    b.HasData(
                        new
                        {
                            RatingChangeCategoryId = 1,
                            Name = "Докладная"
                        },
                        new
                        {
                            RatingChangeCategoryId = 2,
                            Name = "Поощрение"
                        },
                        new
                        {
                            RatingChangeCategoryId = 3,
                            Name = "Выговор"
                        });
                });

            modelBuilder.Entity("DMS.Models.RatingOperation", b =>
                {
                    b.Property<int>("ResidentId")
                        .HasColumnType("int")
                        .HasColumnName("resident_id");

                    b.Property<DateTime>("OrderDate")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("order_date");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int")
                        .HasColumnName("category_id");

                    b.Property<int>("ChangeValue")
                        .HasColumnType("integer")
                        .HasColumnName("change_value");

                    b.Property<string>("Description")
                        .HasColumnType("varchar(200)")
                        .HasColumnName("description");

                    b.HasKey("ResidentId", "OrderDate");

                    b.HasIndex("CategoryId");

                    b.ToTable("rating_operation");

                    b.HasData(
                        new
                        {
                            ResidentId = 1,
                            OrderDate = new DateTime(2021, 10, 8, 21, 0, 0, 0, DateTimeKind.Utc),
                            CategoryId = 1,
                            ChangeValue = -3
                        },
                        new
                        {
                            ResidentId = 2,
                            OrderDate = new DateTime(2021, 10, 9, 21, 0, 0, 0, DateTimeKind.Utc),
                            CategoryId = 2,
                            ChangeValue = 2
                        },
                        new
                        {
                            ResidentId = 3,
                            OrderDate = new DateTime(2021, 10, 10, 21, 0, 0, 0, DateTimeKind.Utc),
                            CategoryId = 3,
                            ChangeValue = -1
                        },
                        new
                        {
                            ResidentId = 4,
                            OrderDate = new DateTime(2021, 10, 11, 21, 0, 0, 0, DateTimeKind.Utc),
                            CategoryId = 1,
                            ChangeValue = -2
                        },
                        new
                        {
                            ResidentId = 5,
                            OrderDate = new DateTime(2021, 10, 12, 21, 0, 0, 0, DateTimeKind.Utc),
                            CategoryId = 2,
                            ChangeValue = 2
                        },
                        new
                        {
                            ResidentId = 6,
                            OrderDate = new DateTime(2021, 10, 13, 21, 0, 0, 0, DateTimeKind.Utc),
                            CategoryId = 2,
                            ChangeValue = 2
                        });
                });

            modelBuilder.Entity("DMS.Models.Resident", b =>
                {
                    b.Property<int>("ResidentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("resident_id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityAlwaysColumn(b.Property<int>("ResidentId"));

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("birth_date");

                    b.Property<int?>("Course")
                        .HasColumnType("integer")
                        .HasColumnName("course");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("varchar(30)")
                        .HasColumnName("first_name");

                    b.Property<char>("Gender")
                        .HasColumnType("character(1)")
                        .HasColumnName("gender");

                    b.Property<bool>("IsCommercial")
                        .HasColumnType("bool")
                        .HasColumnName("is_commercial");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("varchar(50)")
                        .HasColumnName("last_name");

                    b.Property<string>("Patronymic")
                        .HasColumnType("varchar(30)")
                        .HasColumnName("patronymic");

                    b.Property<int?>("RoomId")
                        .HasColumnType("int")
                        .HasColumnName("room_number");

                    b.Property<string>("Tin")
                        .HasColumnType("varchar(12)")
                        .HasColumnName("tin");

                    b.HasKey("ResidentId");

                    b.HasIndex("RoomId");

                    b.HasIndex("Tin")
                        .IsUnique();

                    b.ToTable("resident");

                    b.HasData(
                        new
                        {
                            ResidentId = 1,
                            BirthDate = new DateTime(2022, 5, 15, 17, 4, 56, 387, DateTimeKind.Utc).AddTicks(8837),
                            FirstName = "Даниил",
                            Gender = 'M',
                            IsCommercial = false,
                            LastName = "Морозов",
                            Patronymic = "Артёмович",
                            RoomId = 301
                        },
                        new
                        {
                            ResidentId = 2,
                            BirthDate = new DateTime(2022, 5, 15, 17, 4, 56, 387, DateTimeKind.Utc).AddTicks(8840),
                            FirstName = "Роман",
                            Gender = 'M',
                            IsCommercial = false,
                            LastName = "Васильев",
                            Patronymic = "Алексеевич",
                            RoomId = 423
                        },
                        new
                        {
                            ResidentId = 3,
                            BirthDate = new DateTime(2022, 5, 15, 17, 4, 56, 387, DateTimeKind.Utc).AddTicks(8842),
                            FirstName = "Doma",
                            Gender = 'M',
                            IsCommercial = false,
                            LastName = "Vasilev",
                            Patronymic = "Артёмович",
                            RoomId = 301
                        },
                        new
                        {
                            ResidentId = 4,
                            BirthDate = new DateTime(2022, 5, 15, 17, 4, 56, 387, DateTimeKind.Utc).AddTicks(8846),
                            FirstName = "Goma",
                            Gender = 'M',
                            IsCommercial = false,
                            LastName = "Vasilev",
                            Patronymic = "Артёмович",
                            RoomId = 301
                        },
                        new
                        {
                            ResidentId = 5,
                            BirthDate = new DateTime(2022, 5, 15, 17, 4, 56, 387, DateTimeKind.Utc).AddTicks(8848),
                            FirstName = "Doma",
                            Gender = 'M',
                            IsCommercial = false,
                            LastName = "Vasilev",
                            Patronymic = "Артёмович",
                            RoomId = 302
                        },
                        new
                        {
                            ResidentId = 6,
                            BirthDate = new DateTime(2022, 5, 15, 17, 4, 56, 387, DateTimeKind.Utc).AddTicks(8850),
                            FirstName = "Moma",
                            Gender = 'M',
                            IsCommercial = false,
                            LastName = "Vasilev",
                            Patronymic = "Артёмович",
                            RoomId = 303
                        },
                        new
                        {
                            ResidentId = 7,
                            BirthDate = new DateTime(2022, 5, 15, 17, 4, 56, 387, DateTimeKind.Utc).AddTicks(8852),
                            FirstName = "Noma",
                            Gender = 'M',
                            IsCommercial = false,
                            LastName = "Vasilev",
                            Patronymic = "Артёмович",
                            RoomId = 304
                        },
                        new
                        {
                            ResidentId = 8,
                            BirthDate = new DateTime(2022, 5, 15, 17, 4, 56, 387, DateTimeKind.Utc).AddTicks(8855),
                            FirstName = "Bulat",
                            Gender = 'M',
                            IsCommercial = false,
                            LastName = "Vasilev",
                            Patronymic = "Артёмович",
                            RoomId = 305
                        },
                        new
                        {
                            ResidentId = 9,
                            BirthDate = new DateTime(2022, 5, 15, 17, 4, 56, 387, DateTimeKind.Utc).AddTicks(8857),
                            FirstName = "Bulad",
                            Gender = 'M',
                            IsCommercial = false,
                            LastName = "Vasilev",
                            Patronymic = "Артёмович",
                            RoomId = 306
                        },
                        new
                        {
                            ResidentId = 10,
                            BirthDate = new DateTime(2022, 5, 15, 17, 4, 56, 387, DateTimeKind.Utc).AddTicks(8859),
                            FirstName = "Bular",
                            Gender = 'M',
                            IsCommercial = false,
                            LastName = "Vasilev",
                            Patronymic = "Артёмович",
                            RoomId = 307
                        },
                        new
                        {
                            ResidentId = 11,
                            BirthDate = new DateTime(2022, 5, 15, 17, 4, 56, 387, DateTimeKind.Utc).AddTicks(8861),
                            FirstName = "Bulas",
                            Gender = 'M',
                            IsCommercial = false,
                            LastName = "Vasilev",
                            Patronymic = "Артёмович",
                            RoomId = 407
                        });
                });

            modelBuilder.Entity("DMS.Models.Room", b =>
                {
                    b.Property<int>("RoomId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("room_number");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("RoomId"));

                    b.Property<int>("Capacity")
                        .HasColumnType("integer")
                        .HasColumnName("capacity");

                    b.Property<int>("FloorNumber")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("integer")
                        .HasColumnName("floor_number")
                        .HasComputedColumnSql("room_number / 100", true);

                    b.Property<char>("Gender")
                        .HasColumnType("character(1)")
                        .HasColumnName("gender");

                    b.HasKey("RoomId");

                    b.ToTable("room");

                    b.HasData(
                        new
                        {
                            RoomId = 301,
                            Capacity = 3,
                            FloorNumber = 0,
                            Gender = 'M'
                        },
                        new
                        {
                            RoomId = 302,
                            Capacity = 3,
                            FloorNumber = 0,
                            Gender = 'M'
                        },
                        new
                        {
                            RoomId = 303,
                            Capacity = 3,
                            FloorNumber = 0,
                            Gender = 'M'
                        },
                        new
                        {
                            RoomId = 304,
                            Capacity = 3,
                            FloorNumber = 0,
                            Gender = 'M'
                        },
                        new
                        {
                            RoomId = 305,
                            Capacity = 3,
                            FloorNumber = 0,
                            Gender = 'M'
                        },
                        new
                        {
                            RoomId = 306,
                            Capacity = 3,
                            FloorNumber = 0,
                            Gender = 'M'
                        },
                        new
                        {
                            RoomId = 307,
                            Capacity = 3,
                            FloorNumber = 0,
                            Gender = 'M'
                        },
                        new
                        {
                            RoomId = 308,
                            Capacity = 3,
                            FloorNumber = 0,
                            Gender = 'M'
                        },
                        new
                        {
                            RoomId = 309,
                            Capacity = 3,
                            FloorNumber = 0,
                            Gender = 'M'
                        },
                        new
                        {
                            RoomId = 407,
                            Capacity = 3,
                            FloorNumber = 0,
                            Gender = 'M'
                        },
                        new
                        {
                            RoomId = 423,
                            Capacity = 3,
                            FloorNumber = 0,
                            Gender = 'M'
                        });
                });

            modelBuilder.Entity("DMS.Models.SettlementOrder", b =>
                {
                    b.Property<int>("SettlementOrderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("order_id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityAlwaysColumn(b.Property<int>("SettlementOrderId"));

                    b.Property<string>("Description")
                        .HasColumnType("varchar(200)")
                        .HasColumnName("description");

                    b.Property<DateTime>("OrderDate")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("order_date");

                    b.Property<string>("ParentsFullName")
                        .HasColumnType("varchar(110)")
                        .HasColumnName("parents_name");

                    b.Property<string>("ParentsPassportAddress")
                        .HasColumnType("varchar(70)")
                        .HasColumnName("parents_passport_address");

                    b.Property<int?>("ParentsPassportDepartmentCode")
                        .HasColumnType("integer")
                        .HasColumnName("parents_passport_department_code");

                    b.Property<DateTime?>("ParentsPassportIssueDate")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("parents_passport_issue_date");

                    b.Property<string>("ParentsPassportIssuedBy")
                        .HasColumnType("varchar(50)")
                        .HasColumnName("parents_passport_issued_by");

                    b.Property<string>("ParentsPassportSeriesNumber")
                        .HasColumnType("varchar(10)")
                        .HasColumnName("parents_passport_series_number");

                    b.Property<int>("ResidentId")
                        .HasColumnType("int")
                        .HasColumnName("resident_id");

                    b.Property<int>("RoomId")
                        .HasColumnType("int")
                        .HasColumnName("room_number");

                    b.HasKey("SettlementOrderId");

                    b.HasIndex("ResidentId");

                    b.HasIndex("RoomId");

                    b.ToTable("settlement_order");

                    b.HasData(
                        new
                        {
                            SettlementOrderId = 1,
                            OrderDate = new DateTime(2022, 5, 15, 17, 4, 56, 387, DateTimeKind.Utc).AddTicks(9151),
                            ResidentId = 1,
                            RoomId = 301
                        },
                        new
                        {
                            SettlementOrderId = 2,
                            OrderDate = new DateTime(2022, 5, 15, 17, 4, 56, 387, DateTimeKind.Utc).AddTicks(9153),
                            ResidentId = 2,
                            RoomId = 423
                        },
                        new
                        {
                            SettlementOrderId = 3,
                            OrderDate = new DateTime(2022, 5, 15, 17, 4, 56, 387, DateTimeKind.Utc).AddTicks(9154),
                            ResidentId = 3,
                            RoomId = 301
                        },
                        new
                        {
                            SettlementOrderId = 4,
                            OrderDate = new DateTime(2022, 5, 15, 17, 4, 56, 387, DateTimeKind.Utc).AddTicks(9155),
                            ResidentId = 4,
                            RoomId = 301
                        },
                        new
                        {
                            SettlementOrderId = 5,
                            OrderDate = new DateTime(2022, 5, 15, 17, 4, 56, 387, DateTimeKind.Utc).AddTicks(9156),
                            ResidentId = 5,
                            RoomId = 302
                        },
                        new
                        {
                            SettlementOrderId = 6,
                            OrderDate = new DateTime(2022, 5, 15, 17, 4, 56, 387, DateTimeKind.Utc).AddTicks(9157),
                            ResidentId = 6,
                            RoomId = 303
                        },
                        new
                        {
                            SettlementOrderId = 7,
                            OrderDate = new DateTime(2022, 5, 15, 17, 4, 56, 387, DateTimeKind.Utc).AddTicks(9158),
                            ResidentId = 7,
                            RoomId = 304
                        },
                        new
                        {
                            SettlementOrderId = 8,
                            OrderDate = new DateTime(2022, 5, 15, 17, 4, 56, 387, DateTimeKind.Utc).AddTicks(9159),
                            ResidentId = 8,
                            RoomId = 305
                        },
                        new
                        {
                            SettlementOrderId = 9,
                            OrderDate = new DateTime(2022, 5, 15, 17, 4, 56, 387, DateTimeKind.Utc).AddTicks(9161),
                            ResidentId = 9,
                            RoomId = 306
                        },
                        new
                        {
                            SettlementOrderId = 10,
                            OrderDate = new DateTime(2022, 5, 15, 17, 4, 56, 387, DateTimeKind.Utc).AddTicks(9163),
                            ResidentId = 10,
                            RoomId = 307
                        },
                        new
                        {
                            SettlementOrderId = 11,
                            OrderDate = new DateTime(2022, 5, 15, 17, 4, 56, 387, DateTimeKind.Utc).AddTicks(9164),
                            ResidentId = 11,
                            RoomId = 407
                        });
                });

            modelBuilder.Entity("DMS.Models.Transaction", b =>
                {
                    b.Property<int>("TransactionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("transaction_id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("TransactionId"));

                    b.Property<DateTime>("OperationDate")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("operation_date");

                    b.Property<int>("ResidentId")
                        .HasColumnType("int")
                        .HasColumnName("resident_id");

                    b.Property<double>("Sum")
                        .HasColumnType("double precision")
                        .HasColumnName("sum");

                    b.HasKey("TransactionId");

                    b.HasIndex("ResidentId");

                    b.ToTable("transaction");

                    b.HasData(
                        new
                        {
                            TransactionId = 1,
                            OperationDate = new DateTime(2021, 10, 8, 21, 0, 0, 0, DateTimeKind.Utc),
                            ResidentId = 1,
                            Sum = 3000.0
                        },
                        new
                        {
                            TransactionId = 2,
                            OperationDate = new DateTime(2021, 10, 9, 7, 0, 0, 0, DateTimeKind.Utc),
                            ResidentId = 2,
                            Sum = 1000.0
                        },
                        new
                        {
                            TransactionId = 3,
                            OperationDate = new DateTime(2021, 10, 9, 9, 0, 0, 0, DateTimeKind.Utc),
                            ResidentId = 2,
                            Sum = 3000.0
                        },
                        new
                        {
                            TransactionId = 4,
                            OperationDate = new DateTime(2021, 10, 11, 21, 0, 0, 0, DateTimeKind.Utc),
                            ResidentId = 3,
                            Sum = 4000.0
                        },
                        new
                        {
                            TransactionId = 5,
                            OperationDate = new DateTime(2021, 10, 9, 21, 0, 0, 0, DateTimeKind.Utc),
                            ResidentId = 4,
                            Sum = 2012.4200000000001
                        },
                        new
                        {
                            TransactionId = 6,
                            OperationDate = new DateTime(2021, 10, 19, 21, 0, 0, 0, DateTimeKind.Utc),
                            ResidentId = 5,
                            Sum = 18234.130000000001
                        });
                });

            modelBuilder.Entity("DMS.Models.EvictionOrder", b =>
                {
                    b.HasOne("DMS.Models.Resident", "Resident")
                        .WithMany("EvictionOrders")
                        .HasForeignKey("ResidentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Resident");
                });

            modelBuilder.Entity("DMS.Models.PassportInformation", b =>
                {
                    b.HasOne("DMS.Models.Resident", "Resident")
                        .WithOne("PassportInformation")
                        .HasForeignKey("DMS.Models.PassportInformation", "ResidentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Resident");
                });

            modelBuilder.Entity("DMS.Models.RatingOperation", b =>
                {
                    b.HasOne("DMS.Models.RatingChangeCategory", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DMS.Models.Resident", "Resident")
                        .WithMany("RatingOperations")
                        .HasForeignKey("ResidentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("Resident");
                });

            modelBuilder.Entity("DMS.Models.Resident", b =>
                {
                    b.HasOne("DMS.Models.Room", "Room")
                        .WithMany("Residents")
                        .HasForeignKey("RoomId");

                    b.Navigation("Room");
                });

            modelBuilder.Entity("DMS.Models.SettlementOrder", b =>
                {
                    b.HasOne("DMS.Models.Resident", "Resident")
                        .WithMany("SettlementOrders")
                        .HasForeignKey("ResidentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DMS.Models.Room", "Room")
                        .WithMany()
                        .HasForeignKey("RoomId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Resident");

                    b.Navigation("Room");
                });

            modelBuilder.Entity("DMS.Models.Transaction", b =>
                {
                    b.HasOne("DMS.Models.Resident", "Resident")
                        .WithMany("Transactions")
                        .HasForeignKey("ResidentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Resident");
                });

            modelBuilder.Entity("DMS.Models.Resident", b =>
                {
                    b.Navigation("EvictionOrders");

                    b.Navigation("PassportInformation");

                    b.Navigation("RatingOperations");

                    b.Navigation("SettlementOrders");

                    b.Navigation("Transactions");
                });

            modelBuilder.Entity("DMS.Models.Room", b =>
                {
                    b.Navigation("Residents");
                });
#pragma warning restore 612, 618
        }
    }
}
