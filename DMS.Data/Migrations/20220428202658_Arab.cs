using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace DMS.Migrations
{
    public partial class Arab : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "rating_change_category",
                columns: table => new
                {
                    category_id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityAlwaysColumn),
                    name = table.Column<string>(type: "varchar(20)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_rating_change_category", x => x.category_id);
                });

            migrationBuilder.CreateTable(
                name: "room",
                columns: table => new
                {
                    room_number = table.Column<int>(type: "int", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    capacity = table.Column<int>(type: "integer", nullable: false),
                    gender = table.Column<char>(type: "character(1)", nullable: false),
                    floor_number = table.Column<int>(type: "integer", nullable: false, computedColumnSql: "room_number / 100", stored: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_room", x => x.room_number);
                });

            migrationBuilder.CreateTable(
                name: "resident",
                columns: table => new
                {
                    resident_id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityAlwaysColumn),
                    last_name = table.Column<string>(type: "varchar(50)", nullable: false),
                    first_name = table.Column<string>(type: "varchar(30)", nullable: false),
                    patronymic = table.Column<string>(type: "varchar(30)", nullable: true),
                    gender = table.Column<char>(type: "character(1)", nullable: false),
                    birth_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    passport_information = table.Column<string>(type: "varchar(10)", nullable: true),
                    tin = table.Column<string>(type: "varchar(12)", nullable: true),
                    room_number = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_resident", x => x.resident_id);
                    table.ForeignKey(
                        name: "FK_resident_room_room_number",
                        column: x => x.room_number,
                        principalTable: "room",
                        principalColumn: "room_number");
                });

            migrationBuilder.CreateTable(
                name: "eviction_order",
                columns: table => new
                {
                    order_id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityAlwaysColumn),
                    resident_id = table.Column<int>(type: "integer", nullable: false),
                    order_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    description = table.Column<string>(type: "varchar(200)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_eviction_order", x => x.order_id);
                    table.ForeignKey(
                        name: "FK_eviction_order_resident_resident_id",
                        column: x => x.resident_id,
                        principalTable: "resident",
                        principalColumn: "resident_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "rating_operation",
                columns: table => new
                {
                    operation_id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityAlwaysColumn),
                    resident_id = table.Column<int>(type: "integer", nullable: false),
                    change_value = table.Column<int>(type: "integer", nullable: false),
                    order_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    description = table.Column<string>(type: "varchar(200)", nullable: true),
                    category_id = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_rating_operation", x => x.operation_id);
                    table.ForeignKey(
                        name: "FK_rating_operation_rating_change_category_category_id",
                        column: x => x.category_id,
                        principalTable: "rating_change_category",
                        principalColumn: "category_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_rating_operation_resident_resident_id",
                        column: x => x.resident_id,
                        principalTable: "resident",
                        principalColumn: "resident_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "settlement_order",
                columns: table => new
                {
                    order_id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityAlwaysColumn),
                    resident_id = table.Column<int>(type: "integer", nullable: false),
                    room_number = table.Column<int>(type: "int", nullable: false),
                    order_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    description = table.Column<string>(type: "varchar(200)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_settlement_order", x => x.order_id);
                    table.ForeignKey(
                        name: "FK_settlement_order_resident_resident_id",
                        column: x => x.resident_id,
                        principalTable: "resident",
                        principalColumn: "resident_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_settlement_order_room_room_number",
                        column: x => x.room_number,
                        principalTable: "room",
                        principalColumn: "room_number",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "transaction",
                columns: table => new
                {
                    operation_id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityAlwaysColumn),
                    resident_id = table.Column<int>(type: "integer", nullable: false),
                    operation_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    sum = table.Column<double>(type: "double precision", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_transaction", x => x.operation_id);
                    table.ForeignKey(
                        name: "FK_transaction_resident_resident_id",
                        column: x => x.resident_id,
                        principalTable: "resident",
                        principalColumn: "resident_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "rating_change_category",
                columns: new[] { "category_id", "name" },
                values: new object[,]
                {
                    { 1, "Докладная" },
                    { 2, "Поощрение" },
                    { 3, "Выговор" }
                });

            migrationBuilder.InsertData(
                table: "room",
                columns: new[] { "room_number", "capacity", "gender" },
                values: new object[,]
                {
                    { 301, 3, 'M' },
                    { 302, 3, 'M' },
                    { 303, 3, 'M' },
                    { 304, 3, 'M' },
                    { 305, 3, 'M' },
                    { 306, 3, 'M' },
                    { 307, 3, 'M' },
                    { 308, 3, 'M' },
                    { 309, 3, 'M' },
                    { 407, 3, 'M' },
                    { 423, 3, 'M' }
                });

            migrationBuilder.InsertData(
                table: "resident",
                columns: new[] { "resident_id", "birth_date", "first_name", "gender", "last_name", "passport_information", "patronymic", "room_number", "tin" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 4, 28, 20, 26, 58, 461, DateTimeKind.Utc).AddTicks(5025), "Даниил", 'M', "Морозов", null, "Артёмович", 301, null },
                    { 2, new DateTime(2022, 4, 28, 20, 26, 58, 461, DateTimeKind.Utc).AddTicks(5029), "Роман", 'M', "Васильев", null, "Алексеевич", 423, null },
                    { 3, new DateTime(2022, 4, 28, 20, 26, 58, 461, DateTimeKind.Utc).AddTicks(5030), "Doma", 'M', "Vasilev", null, "Артёмович", 301, null },
                    { 4, new DateTime(2022, 4, 28, 20, 26, 58, 461, DateTimeKind.Utc).AddTicks(5031), "Goma", 'M', "Vasilev", null, "Артёмович", 301, null },
                    { 5, new DateTime(2022, 4, 28, 20, 26, 58, 461, DateTimeKind.Utc).AddTicks(5033), "Doma", 'M', "Vasilev", null, "Артёмович", 302, null },
                    { 6, new DateTime(2022, 4, 28, 20, 26, 58, 461, DateTimeKind.Utc).AddTicks(5034), "Moma", 'M', "Vasilev", null, "Артёмович", 303, null },
                    { 7, new DateTime(2022, 4, 28, 20, 26, 58, 461, DateTimeKind.Utc).AddTicks(5036), "Noma", 'M', "Vasilev", null, "Артёмович", 304, null },
                    { 8, new DateTime(2022, 4, 28, 20, 26, 58, 461, DateTimeKind.Utc).AddTicks(5037), "Bulat", 'M', "Vasilev", null, "Артёмович", 305, null },
                    { 9, new DateTime(2022, 4, 28, 20, 26, 58, 461, DateTimeKind.Utc).AddTicks(5038), "Bulad", 'M', "Vasilev", null, "Артёмович", 306, null },
                    { 10, new DateTime(2022, 4, 28, 20, 26, 58, 461, DateTimeKind.Utc).AddTicks(5039), "Bular", 'M', "Vasilev", null, "Артёмович", 307, null },
                    { 11, new DateTime(2022, 4, 28, 20, 26, 58, 461, DateTimeKind.Utc).AddTicks(5041), "Bulas", 'M', "Vasilev", null, "Артёмович", 407, null }
                });

            migrationBuilder.InsertData(
                table: "eviction_order",
                columns: new[] { "order_id", "description", "order_date", "resident_id" },
                values: new object[,]
                {
                    { 1, null, new DateTime(2022, 4, 28, 20, 26, 58, 461, DateTimeKind.Utc).AddTicks(5430), 11 },
                    { 2, null, new DateTime(2022, 4, 28, 20, 26, 58, 461, DateTimeKind.Utc).AddTicks(5431), 10 },
                    { 3, null, new DateTime(2022, 4, 28, 20, 26, 58, 461, DateTimeKind.Utc).AddTicks(5432), 9 },
                    { 4, null, new DateTime(2022, 4, 28, 20, 26, 58, 461, DateTimeKind.Utc).AddTicks(5432), 8 },
                    { 5, null, new DateTime(2022, 4, 28, 20, 26, 58, 461, DateTimeKind.Utc).AddTicks(5433), 7 }
                });

            migrationBuilder.InsertData(
                table: "rating_operation",
                columns: new[] { "operation_id", "category_id", "change_value", "description", "order_date", "resident_id" },
                values: new object[,]
                {
                    { 1, 1, -3, null, new DateTime(2022, 4, 28, 20, 26, 58, 461, DateTimeKind.Utc).AddTicks(5459), 1 },
                    { 2, 2, 2, null, new DateTime(2022, 4, 28, 20, 26, 58, 461, DateTimeKind.Utc).AddTicks(5460), 2 },
                    { 3, 3, -1, null, new DateTime(2022, 4, 28, 20, 26, 58, 461, DateTimeKind.Utc).AddTicks(5461), 3 },
                    { 4, 1, -2, null, new DateTime(2022, 4, 28, 20, 26, 58, 461, DateTimeKind.Utc).AddTicks(5462), 4 },
                    { 5, 2, 2, null, new DateTime(2022, 4, 28, 20, 26, 58, 461, DateTimeKind.Utc).AddTicks(5463), 5 },
                    { 6, 2, 2, null, new DateTime(2022, 4, 28, 20, 26, 58, 461, DateTimeKind.Utc).AddTicks(5463), 6 }
                });

            migrationBuilder.InsertData(
                table: "settlement_order",
                columns: new[] { "order_id", "description", "order_date", "resident_id", "room_number" },
                values: new object[,]
                {
                    { 1, null, new DateTime(2022, 4, 28, 20, 26, 58, 461, DateTimeKind.Utc).AddTicks(5406), 1, 301 },
                    { 2, null, new DateTime(2022, 4, 28, 20, 26, 58, 461, DateTimeKind.Utc).AddTicks(5407), 2, 423 },
                    { 3, null, new DateTime(2022, 4, 28, 20, 26, 58, 461, DateTimeKind.Utc).AddTicks(5408), 3, 301 },
                    { 4, null, new DateTime(2022, 4, 28, 20, 26, 58, 461, DateTimeKind.Utc).AddTicks(5409), 4, 301 },
                    { 5, null, new DateTime(2022, 4, 28, 20, 26, 58, 461, DateTimeKind.Utc).AddTicks(5409), 5, 302 },
                    { 6, null, new DateTime(2022, 4, 28, 20, 26, 58, 461, DateTimeKind.Utc).AddTicks(5410), 6, 303 },
                    { 7, null, new DateTime(2022, 4, 28, 20, 26, 58, 461, DateTimeKind.Utc).AddTicks(5411), 7, 304 },
                    { 8, null, new DateTime(2022, 4, 28, 20, 26, 58, 461, DateTimeKind.Utc).AddTicks(5411), 8, 305 },
                    { 9, null, new DateTime(2022, 4, 28, 20, 26, 58, 461, DateTimeKind.Utc).AddTicks(5412), 9, 306 },
                    { 10, null, new DateTime(2022, 4, 28, 20, 26, 58, 461, DateTimeKind.Utc).AddTicks(5413), 10, 307 },
                    { 11, null, new DateTime(2022, 4, 28, 20, 26, 58, 461, DateTimeKind.Utc).AddTicks(5413), 11, 407 }
                });

            migrationBuilder.InsertData(
                table: "transaction",
                columns: new[] { "operation_id", "operation_date", "resident_id", "sum" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 4, 28, 20, 26, 58, 461, DateTimeKind.Utc).AddTicks(5478), 1, 3000.0 },
                    { 2, new DateTime(2022, 4, 28, 20, 26, 58, 461, DateTimeKind.Utc).AddTicks(5479), 2, 1000.0 },
                    { 3, new DateTime(2022, 4, 28, 20, 26, 58, 461, DateTimeKind.Utc).AddTicks(5480), 2, 3000.0 },
                    { 4, new DateTime(2022, 4, 28, 20, 26, 58, 461, DateTimeKind.Utc).AddTicks(5481), 3, 4000.0 },
                    { 5, new DateTime(2022, 4, 28, 20, 26, 58, 461, DateTimeKind.Utc).AddTicks(5481), 4, 2012.4200000000001 },
                    { 6, new DateTime(2022, 4, 28, 20, 26, 58, 461, DateTimeKind.Utc).AddTicks(5482), 5, 18234.130000000001 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_eviction_order_resident_id",
                table: "eviction_order",
                column: "resident_id");

            migrationBuilder.CreateIndex(
                name: "IX_rating_operation_category_id",
                table: "rating_operation",
                column: "category_id");

            migrationBuilder.CreateIndex(
                name: "IX_rating_operation_resident_id",
                table: "rating_operation",
                column: "resident_id");

            migrationBuilder.CreateIndex(
                name: "IX_resident_passport_information",
                table: "resident",
                column: "passport_information",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_resident_room_number",
                table: "resident",
                column: "room_number");

            migrationBuilder.CreateIndex(
                name: "IX_resident_tin",
                table: "resident",
                column: "tin",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_settlement_order_resident_id",
                table: "settlement_order",
                column: "resident_id");

            migrationBuilder.CreateIndex(
                name: "IX_settlement_order_room_number",
                table: "settlement_order",
                column: "room_number");

            migrationBuilder.CreateIndex(
                name: "IX_transaction_resident_id",
                table: "transaction",
                column: "resident_id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "eviction_order");

            migrationBuilder.DropTable(
                name: "rating_operation");

            migrationBuilder.DropTable(
                name: "settlement_order");

            migrationBuilder.DropTable(
                name: "transaction");

            migrationBuilder.DropTable(
                name: "rating_change_category");

            migrationBuilder.DropTable(
                name: "resident");

            migrationBuilder.DropTable(
                name: "room");
        }
    }
}
