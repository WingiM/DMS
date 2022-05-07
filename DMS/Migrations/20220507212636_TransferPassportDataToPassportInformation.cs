using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace DMS.Migrations
{
    public partial class TransferPassportDataToPassportInformation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PassportInformation",
                columns: table => new
                {
                    passport_information_id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityAlwaysColumn),
                    series_number = table.Column<string>(type: "text", nullable: true),
                    issued_by = table.Column<string>(type: "text", nullable: true),
                    department_code = table.Column<int>(type: "integer", nullable: true),
                    issue_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    address = table.Column<string>(type: "text", nullable: true),
                    resident_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PassportInformation", x => x.passport_information_id);
                    table.ForeignKey(
                        name: "FK_PassportInformation_resident_resident_id",
                        column: x => x.resident_id,
                        principalTable: "resident",
                        principalColumn: "resident_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "eviction_order",
                keyColumn: "order_id",
                keyValue: 1,
                column: "order_date",
                value: new DateTime(2022, 5, 7, 21, 26, 36, 551, DateTimeKind.Utc).AddTicks(8967));

            migrationBuilder.UpdateData(
                table: "eviction_order",
                keyColumn: "order_id",
                keyValue: 2,
                column: "order_date",
                value: new DateTime(2022, 5, 7, 21, 26, 36, 551, DateTimeKind.Utc).AddTicks(8968));

            migrationBuilder.UpdateData(
                table: "eviction_order",
                keyColumn: "order_id",
                keyValue: 3,
                column: "order_date",
                value: new DateTime(2022, 5, 7, 21, 26, 36, 551, DateTimeKind.Utc).AddTicks(8968));

            migrationBuilder.UpdateData(
                table: "eviction_order",
                keyColumn: "order_id",
                keyValue: 4,
                column: "order_date",
                value: new DateTime(2022, 5, 7, 21, 26, 36, 551, DateTimeKind.Utc).AddTicks(8969));

            migrationBuilder.UpdateData(
                table: "eviction_order",
                keyColumn: "order_id",
                keyValue: 5,
                column: "order_date",
                value: new DateTime(2022, 5, 7, 21, 26, 36, 551, DateTimeKind.Utc).AddTicks(8969));

            migrationBuilder.UpdateData(
                table: "rating_operation",
                keyColumn: "operation_id",
                keyValue: 1,
                column: "order_date",
                value: new DateTime(2022, 5, 7, 21, 26, 36, 551, DateTimeKind.Utc).AddTicks(8992));

            migrationBuilder.UpdateData(
                table: "rating_operation",
                keyColumn: "operation_id",
                keyValue: 2,
                column: "order_date",
                value: new DateTime(2022, 5, 7, 21, 26, 36, 551, DateTimeKind.Utc).AddTicks(8994));

            migrationBuilder.UpdateData(
                table: "rating_operation",
                keyColumn: "operation_id",
                keyValue: 3,
                column: "order_date",
                value: new DateTime(2022, 5, 7, 21, 26, 36, 551, DateTimeKind.Utc).AddTicks(8994));

            migrationBuilder.UpdateData(
                table: "rating_operation",
                keyColumn: "operation_id",
                keyValue: 4,
                column: "order_date",
                value: new DateTime(2022, 5, 7, 21, 26, 36, 551, DateTimeKind.Utc).AddTicks(8995));

            migrationBuilder.UpdateData(
                table: "rating_operation",
                keyColumn: "operation_id",
                keyValue: 5,
                column: "order_date",
                value: new DateTime(2022, 5, 7, 21, 26, 36, 551, DateTimeKind.Utc).AddTicks(8995));

            migrationBuilder.UpdateData(
                table: "rating_operation",
                keyColumn: "operation_id",
                keyValue: 6,
                column: "order_date",
                value: new DateTime(2022, 5, 7, 21, 26, 36, 551, DateTimeKind.Utc).AddTicks(8996));

            migrationBuilder.UpdateData(
                table: "resident",
                keyColumn: "resident_id",
                keyValue: 1,
                column: "birth_date",
                value: new DateTime(2022, 5, 7, 21, 26, 36, 551, DateTimeKind.Utc).AddTicks(8607));

            migrationBuilder.UpdateData(
                table: "resident",
                keyColumn: "resident_id",
                keyValue: 2,
                column: "birth_date",
                value: new DateTime(2022, 5, 7, 21, 26, 36, 551, DateTimeKind.Utc).AddTicks(8609));

            migrationBuilder.UpdateData(
                table: "resident",
                keyColumn: "resident_id",
                keyValue: 3,
                column: "birth_date",
                value: new DateTime(2022, 5, 7, 21, 26, 36, 551, DateTimeKind.Utc).AddTicks(8610));

            migrationBuilder.UpdateData(
                table: "resident",
                keyColumn: "resident_id",
                keyValue: 4,
                column: "birth_date",
                value: new DateTime(2022, 5, 7, 21, 26, 36, 551, DateTimeKind.Utc).AddTicks(8611));

            migrationBuilder.UpdateData(
                table: "resident",
                keyColumn: "resident_id",
                keyValue: 5,
                column: "birth_date",
                value: new DateTime(2022, 5, 7, 21, 26, 36, 551, DateTimeKind.Utc).AddTicks(8613));

            migrationBuilder.UpdateData(
                table: "resident",
                keyColumn: "resident_id",
                keyValue: 6,
                column: "birth_date",
                value: new DateTime(2022, 5, 7, 21, 26, 36, 551, DateTimeKind.Utc).AddTicks(8614));

            migrationBuilder.UpdateData(
                table: "resident",
                keyColumn: "resident_id",
                keyValue: 7,
                column: "birth_date",
                value: new DateTime(2022, 5, 7, 21, 26, 36, 551, DateTimeKind.Utc).AddTicks(8615));

            migrationBuilder.UpdateData(
                table: "resident",
                keyColumn: "resident_id",
                keyValue: 8,
                column: "birth_date",
                value: new DateTime(2022, 5, 7, 21, 26, 36, 551, DateTimeKind.Utc).AddTicks(8616));

            migrationBuilder.UpdateData(
                table: "resident",
                keyColumn: "resident_id",
                keyValue: 9,
                column: "birth_date",
                value: new DateTime(2022, 5, 7, 21, 26, 36, 551, DateTimeKind.Utc).AddTicks(8617));

            migrationBuilder.UpdateData(
                table: "resident",
                keyColumn: "resident_id",
                keyValue: 10,
                column: "birth_date",
                value: new DateTime(2022, 5, 7, 21, 26, 36, 551, DateTimeKind.Utc).AddTicks(8657));

            migrationBuilder.UpdateData(
                table: "resident",
                keyColumn: "resident_id",
                keyValue: 11,
                column: "birth_date",
                value: new DateTime(2022, 5, 7, 21, 26, 36, 551, DateTimeKind.Utc).AddTicks(8658));

            migrationBuilder.UpdateData(
                table: "settlement_order",
                keyColumn: "order_id",
                keyValue: 1,
                column: "order_date",
                value: new DateTime(2022, 5, 7, 21, 26, 36, 551, DateTimeKind.Utc).AddTicks(8946));

            migrationBuilder.UpdateData(
                table: "settlement_order",
                keyColumn: "order_id",
                keyValue: 2,
                column: "order_date",
                value: new DateTime(2022, 5, 7, 21, 26, 36, 551, DateTimeKind.Utc).AddTicks(8947));

            migrationBuilder.UpdateData(
                table: "settlement_order",
                keyColumn: "order_id",
                keyValue: 3,
                column: "order_date",
                value: new DateTime(2022, 5, 7, 21, 26, 36, 551, DateTimeKind.Utc).AddTicks(8948));

            migrationBuilder.UpdateData(
                table: "settlement_order",
                keyColumn: "order_id",
                keyValue: 4,
                column: "order_date",
                value: new DateTime(2022, 5, 7, 21, 26, 36, 551, DateTimeKind.Utc).AddTicks(8948));

            migrationBuilder.UpdateData(
                table: "settlement_order",
                keyColumn: "order_id",
                keyValue: 5,
                column: "order_date",
                value: new DateTime(2022, 5, 7, 21, 26, 36, 551, DateTimeKind.Utc).AddTicks(8950));

            migrationBuilder.UpdateData(
                table: "settlement_order",
                keyColumn: "order_id",
                keyValue: 6,
                column: "order_date",
                value: new DateTime(2022, 5, 7, 21, 26, 36, 551, DateTimeKind.Utc).AddTicks(8950));

            migrationBuilder.UpdateData(
                table: "settlement_order",
                keyColumn: "order_id",
                keyValue: 7,
                column: "order_date",
                value: new DateTime(2022, 5, 7, 21, 26, 36, 551, DateTimeKind.Utc).AddTicks(8951));

            migrationBuilder.UpdateData(
                table: "settlement_order",
                keyColumn: "order_id",
                keyValue: 8,
                column: "order_date",
                value: new DateTime(2022, 5, 7, 21, 26, 36, 551, DateTimeKind.Utc).AddTicks(8952));

            migrationBuilder.UpdateData(
                table: "settlement_order",
                keyColumn: "order_id",
                keyValue: 9,
                column: "order_date",
                value: new DateTime(2022, 5, 7, 21, 26, 36, 551, DateTimeKind.Utc).AddTicks(8952));

            migrationBuilder.UpdateData(
                table: "settlement_order",
                keyColumn: "order_id",
                keyValue: 10,
                column: "order_date",
                value: new DateTime(2022, 5, 7, 21, 26, 36, 551, DateTimeKind.Utc).AddTicks(8953));

            migrationBuilder.UpdateData(
                table: "settlement_order",
                keyColumn: "order_id",
                keyValue: 11,
                column: "order_date",
                value: new DateTime(2022, 5, 7, 21, 26, 36, 551, DateTimeKind.Utc).AddTicks(8953));

            migrationBuilder.UpdateData(
                table: "transaction",
                keyColumn: "operation_id",
                keyValue: 1,
                column: "operation_date",
                value: new DateTime(2022, 5, 7, 21, 26, 36, 551, DateTimeKind.Utc).AddTicks(9006));

            migrationBuilder.UpdateData(
                table: "transaction",
                keyColumn: "operation_id",
                keyValue: 2,
                column: "operation_date",
                value: new DateTime(2022, 5, 7, 21, 26, 36, 551, DateTimeKind.Utc).AddTicks(9007));

            migrationBuilder.UpdateData(
                table: "transaction",
                keyColumn: "operation_id",
                keyValue: 3,
                column: "operation_date",
                value: new DateTime(2022, 5, 7, 21, 26, 36, 551, DateTimeKind.Utc).AddTicks(9008));

            migrationBuilder.UpdateData(
                table: "transaction",
                keyColumn: "operation_id",
                keyValue: 4,
                column: "operation_date",
                value: new DateTime(2022, 5, 7, 21, 26, 36, 551, DateTimeKind.Utc).AddTicks(9008));

            migrationBuilder.UpdateData(
                table: "transaction",
                keyColumn: "operation_id",
                keyValue: 5,
                column: "operation_date",
                value: new DateTime(2022, 5, 7, 21, 26, 36, 551, DateTimeKind.Utc).AddTicks(9009));

            migrationBuilder.UpdateData(
                table: "transaction",
                keyColumn: "operation_id",
                keyValue: 6,
                column: "operation_date",
                value: new DateTime(2022, 5, 7, 21, 26, 36, 551, DateTimeKind.Utc).AddTicks(9009));

            migrationBuilder.CreateIndex(
                name: "IX_PassportInformation_resident_id",
                table: "PassportInformation",
                column: "resident_id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_PassportInformation_series_number",
                table: "PassportInformation",
                column: "series_number",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PassportInformation");

            migrationBuilder.UpdateData(
                table: "eviction_order",
                keyColumn: "order_id",
                keyValue: 1,
                column: "order_date",
                value: new DateTime(2022, 5, 7, 20, 19, 9, 51, DateTimeKind.Utc).AddTicks(7325));

            migrationBuilder.UpdateData(
                table: "eviction_order",
                keyColumn: "order_id",
                keyValue: 2,
                column: "order_date",
                value: new DateTime(2022, 5, 7, 20, 19, 9, 51, DateTimeKind.Utc).AddTicks(7326));

            migrationBuilder.UpdateData(
                table: "eviction_order",
                keyColumn: "order_id",
                keyValue: 3,
                column: "order_date",
                value: new DateTime(2022, 5, 7, 20, 19, 9, 51, DateTimeKind.Utc).AddTicks(7327));

            migrationBuilder.UpdateData(
                table: "eviction_order",
                keyColumn: "order_id",
                keyValue: 4,
                column: "order_date",
                value: new DateTime(2022, 5, 7, 20, 19, 9, 51, DateTimeKind.Utc).AddTicks(7327));

            migrationBuilder.UpdateData(
                table: "eviction_order",
                keyColumn: "order_id",
                keyValue: 5,
                column: "order_date",
                value: new DateTime(2022, 5, 7, 20, 19, 9, 51, DateTimeKind.Utc).AddTicks(7328));

            migrationBuilder.UpdateData(
                table: "rating_operation",
                keyColumn: "operation_id",
                keyValue: 1,
                column: "order_date",
                value: new DateTime(2022, 5, 7, 20, 19, 9, 51, DateTimeKind.Utc).AddTicks(7347));

            migrationBuilder.UpdateData(
                table: "rating_operation",
                keyColumn: "operation_id",
                keyValue: 2,
                column: "order_date",
                value: new DateTime(2022, 5, 7, 20, 19, 9, 51, DateTimeKind.Utc).AddTicks(7348));

            migrationBuilder.UpdateData(
                table: "rating_operation",
                keyColumn: "operation_id",
                keyValue: 3,
                column: "order_date",
                value: new DateTime(2022, 5, 7, 20, 19, 9, 51, DateTimeKind.Utc).AddTicks(7349));

            migrationBuilder.UpdateData(
                table: "rating_operation",
                keyColumn: "operation_id",
                keyValue: 4,
                column: "order_date",
                value: new DateTime(2022, 5, 7, 20, 19, 9, 51, DateTimeKind.Utc).AddTicks(7350));

            migrationBuilder.UpdateData(
                table: "rating_operation",
                keyColumn: "operation_id",
                keyValue: 5,
                column: "order_date",
                value: new DateTime(2022, 5, 7, 20, 19, 9, 51, DateTimeKind.Utc).AddTicks(7350));

            migrationBuilder.UpdateData(
                table: "rating_operation",
                keyColumn: "operation_id",
                keyValue: 6,
                column: "order_date",
                value: new DateTime(2022, 5, 7, 20, 19, 9, 51, DateTimeKind.Utc).AddTicks(7351));

            migrationBuilder.UpdateData(
                table: "resident",
                keyColumn: "resident_id",
                keyValue: 1,
                column: "birth_date",
                value: new DateTime(2022, 5, 7, 20, 19, 9, 51, DateTimeKind.Utc).AddTicks(6999));

            migrationBuilder.UpdateData(
                table: "resident",
                keyColumn: "resident_id",
                keyValue: 2,
                column: "birth_date",
                value: new DateTime(2022, 5, 7, 20, 19, 9, 51, DateTimeKind.Utc).AddTicks(7002));

            migrationBuilder.UpdateData(
                table: "resident",
                keyColumn: "resident_id",
                keyValue: 3,
                column: "birth_date",
                value: new DateTime(2022, 5, 7, 20, 19, 9, 51, DateTimeKind.Utc).AddTicks(7003));

            migrationBuilder.UpdateData(
                table: "resident",
                keyColumn: "resident_id",
                keyValue: 4,
                column: "birth_date",
                value: new DateTime(2022, 5, 7, 20, 19, 9, 51, DateTimeKind.Utc).AddTicks(7004));

            migrationBuilder.UpdateData(
                table: "resident",
                keyColumn: "resident_id",
                keyValue: 5,
                column: "birth_date",
                value: new DateTime(2022, 5, 7, 20, 19, 9, 51, DateTimeKind.Utc).AddTicks(7005));

            migrationBuilder.UpdateData(
                table: "resident",
                keyColumn: "resident_id",
                keyValue: 6,
                column: "birth_date",
                value: new DateTime(2022, 5, 7, 20, 19, 9, 51, DateTimeKind.Utc).AddTicks(7007));

            migrationBuilder.UpdateData(
                table: "resident",
                keyColumn: "resident_id",
                keyValue: 7,
                column: "birth_date",
                value: new DateTime(2022, 5, 7, 20, 19, 9, 51, DateTimeKind.Utc).AddTicks(7008));

            migrationBuilder.UpdateData(
                table: "resident",
                keyColumn: "resident_id",
                keyValue: 8,
                column: "birth_date",
                value: new DateTime(2022, 5, 7, 20, 19, 9, 51, DateTimeKind.Utc).AddTicks(7009));

            migrationBuilder.UpdateData(
                table: "resident",
                keyColumn: "resident_id",
                keyValue: 9,
                column: "birth_date",
                value: new DateTime(2022, 5, 7, 20, 19, 9, 51, DateTimeKind.Utc).AddTicks(7010));

            migrationBuilder.UpdateData(
                table: "resident",
                keyColumn: "resident_id",
                keyValue: 10,
                column: "birth_date",
                value: new DateTime(2022, 5, 7, 20, 19, 9, 51, DateTimeKind.Utc).AddTicks(7011));

            migrationBuilder.UpdateData(
                table: "resident",
                keyColumn: "resident_id",
                keyValue: 11,
                column: "birth_date",
                value: new DateTime(2022, 5, 7, 20, 19, 9, 51, DateTimeKind.Utc).AddTicks(7012));

            migrationBuilder.UpdateData(
                table: "settlement_order",
                keyColumn: "order_id",
                keyValue: 1,
                column: "order_date",
                value: new DateTime(2022, 5, 7, 20, 19, 9, 51, DateTimeKind.Utc).AddTicks(7300));

            migrationBuilder.UpdateData(
                table: "settlement_order",
                keyColumn: "order_id",
                keyValue: 2,
                column: "order_date",
                value: new DateTime(2022, 5, 7, 20, 19, 9, 51, DateTimeKind.Utc).AddTicks(7301));

            migrationBuilder.UpdateData(
                table: "settlement_order",
                keyColumn: "order_id",
                keyValue: 3,
                column: "order_date",
                value: new DateTime(2022, 5, 7, 20, 19, 9, 51, DateTimeKind.Utc).AddTicks(7303));

            migrationBuilder.UpdateData(
                table: "settlement_order",
                keyColumn: "order_id",
                keyValue: 4,
                column: "order_date",
                value: new DateTime(2022, 5, 7, 20, 19, 9, 51, DateTimeKind.Utc).AddTicks(7305));

            migrationBuilder.UpdateData(
                table: "settlement_order",
                keyColumn: "order_id",
                keyValue: 5,
                column: "order_date",
                value: new DateTime(2022, 5, 7, 20, 19, 9, 51, DateTimeKind.Utc).AddTicks(7305));

            migrationBuilder.UpdateData(
                table: "settlement_order",
                keyColumn: "order_id",
                keyValue: 6,
                column: "order_date",
                value: new DateTime(2022, 5, 7, 20, 19, 9, 51, DateTimeKind.Utc).AddTicks(7306));

            migrationBuilder.UpdateData(
                table: "settlement_order",
                keyColumn: "order_id",
                keyValue: 7,
                column: "order_date",
                value: new DateTime(2022, 5, 7, 20, 19, 9, 51, DateTimeKind.Utc).AddTicks(7307));

            migrationBuilder.UpdateData(
                table: "settlement_order",
                keyColumn: "order_id",
                keyValue: 8,
                column: "order_date",
                value: new DateTime(2022, 5, 7, 20, 19, 9, 51, DateTimeKind.Utc).AddTicks(7309));

            migrationBuilder.UpdateData(
                table: "settlement_order",
                keyColumn: "order_id",
                keyValue: 9,
                column: "order_date",
                value: new DateTime(2022, 5, 7, 20, 19, 9, 51, DateTimeKind.Utc).AddTicks(7310));

            migrationBuilder.UpdateData(
                table: "settlement_order",
                keyColumn: "order_id",
                keyValue: 10,
                column: "order_date",
                value: new DateTime(2022, 5, 7, 20, 19, 9, 51, DateTimeKind.Utc).AddTicks(7311));

            migrationBuilder.UpdateData(
                table: "settlement_order",
                keyColumn: "order_id",
                keyValue: 11,
                column: "order_date",
                value: new DateTime(2022, 5, 7, 20, 19, 9, 51, DateTimeKind.Utc).AddTicks(7312));

            migrationBuilder.UpdateData(
                table: "transaction",
                keyColumn: "operation_id",
                keyValue: 1,
                column: "operation_date",
                value: new DateTime(2022, 5, 7, 20, 19, 9, 51, DateTimeKind.Utc).AddTicks(7361));

            migrationBuilder.UpdateData(
                table: "transaction",
                keyColumn: "operation_id",
                keyValue: 2,
                column: "operation_date",
                value: new DateTime(2022, 5, 7, 20, 19, 9, 51, DateTimeKind.Utc).AddTicks(7362));

            migrationBuilder.UpdateData(
                table: "transaction",
                keyColumn: "operation_id",
                keyValue: 3,
                column: "operation_date",
                value: new DateTime(2022, 5, 7, 20, 19, 9, 51, DateTimeKind.Utc).AddTicks(7363));

            migrationBuilder.UpdateData(
                table: "transaction",
                keyColumn: "operation_id",
                keyValue: 4,
                column: "operation_date",
                value: new DateTime(2022, 5, 7, 20, 19, 9, 51, DateTimeKind.Utc).AddTicks(7363));

            migrationBuilder.UpdateData(
                table: "transaction",
                keyColumn: "operation_id",
                keyValue: 5,
                column: "operation_date",
                value: new DateTime(2022, 5, 7, 20, 19, 9, 51, DateTimeKind.Utc).AddTicks(7364));

            migrationBuilder.UpdateData(
                table: "transaction",
                keyColumn: "operation_id",
                keyValue: 6,
                column: "operation_date",
                value: new DateTime(2022, 5, 7, 20, 19, 9, 51, DateTimeKind.Utc).AddTicks(7364));
        }
    }
}
