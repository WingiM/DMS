using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DMS.Migrations
{
    public partial class AddCourseColumnToResident : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "course",
                table: "resident",
                type: "integer",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "eviction_order",
                keyColumn: "order_id",
                keyValue: 1,
                column: "order_date",
                value: new DateTime(2022, 5, 10, 8, 14, 18, 400, DateTimeKind.Utc).AddTicks(1551));

            migrationBuilder.UpdateData(
                table: "eviction_order",
                keyColumn: "order_id",
                keyValue: 2,
                column: "order_date",
                value: new DateTime(2022, 5, 10, 8, 14, 18, 400, DateTimeKind.Utc).AddTicks(1553));

            migrationBuilder.UpdateData(
                table: "eviction_order",
                keyColumn: "order_id",
                keyValue: 3,
                column: "order_date",
                value: new DateTime(2022, 5, 10, 8, 14, 18, 400, DateTimeKind.Utc).AddTicks(1554));

            migrationBuilder.UpdateData(
                table: "eviction_order",
                keyColumn: "order_id",
                keyValue: 4,
                column: "order_date",
                value: new DateTime(2022, 5, 10, 8, 14, 18, 400, DateTimeKind.Utc).AddTicks(1555));

            migrationBuilder.UpdateData(
                table: "eviction_order",
                keyColumn: "order_id",
                keyValue: 5,
                column: "order_date",
                value: new DateTime(2022, 5, 10, 8, 14, 18, 400, DateTimeKind.Utc).AddTicks(1556));

            migrationBuilder.UpdateData(
                table: "passport_information",
                keyColumn: "passport_information_id",
                keyValue: 1,
                column: "issue_date",
                value: new DateTime(2022, 5, 10, 8, 14, 18, 400, DateTimeKind.Utc).AddTicks(1695));

            migrationBuilder.UpdateData(
                table: "passport_information",
                keyColumn: "passport_information_id",
                keyValue: 2,
                column: "issue_date",
                value: new DateTime(2022, 5, 10, 8, 14, 18, 400, DateTimeKind.Utc).AddTicks(1700));

            migrationBuilder.UpdateData(
                table: "passport_information",
                keyColumn: "passport_information_id",
                keyValue: 3,
                column: "issue_date",
                value: new DateTime(2022, 5, 10, 8, 14, 18, 400, DateTimeKind.Utc).AddTicks(1701));

            migrationBuilder.UpdateData(
                table: "passport_information",
                keyColumn: "passport_information_id",
                keyValue: 4,
                column: "issue_date",
                value: new DateTime(2022, 5, 10, 8, 14, 18, 400, DateTimeKind.Utc).AddTicks(1702));

            migrationBuilder.UpdateData(
                table: "passport_information",
                keyColumn: "passport_information_id",
                keyValue: 5,
                column: "issue_date",
                value: new DateTime(2022, 5, 10, 8, 14, 18, 400, DateTimeKind.Utc).AddTicks(1704));

            migrationBuilder.UpdateData(
                table: "resident",
                keyColumn: "resident_id",
                keyValue: 1,
                column: "birth_date",
                value: new DateTime(2022, 5, 10, 8, 14, 18, 400, DateTimeKind.Utc).AddTicks(1159));

            migrationBuilder.UpdateData(
                table: "resident",
                keyColumn: "resident_id",
                keyValue: 2,
                column: "birth_date",
                value: new DateTime(2022, 5, 10, 8, 14, 18, 400, DateTimeKind.Utc).AddTicks(1162));

            migrationBuilder.UpdateData(
                table: "resident",
                keyColumn: "resident_id",
                keyValue: 3,
                column: "birth_date",
                value: new DateTime(2022, 5, 10, 8, 14, 18, 400, DateTimeKind.Utc).AddTicks(1164));

            migrationBuilder.UpdateData(
                table: "resident",
                keyColumn: "resident_id",
                keyValue: 4,
                column: "birth_date",
                value: new DateTime(2022, 5, 10, 8, 14, 18, 400, DateTimeKind.Utc).AddTicks(1166));

            migrationBuilder.UpdateData(
                table: "resident",
                keyColumn: "resident_id",
                keyValue: 5,
                column: "birth_date",
                value: new DateTime(2022, 5, 10, 8, 14, 18, 400, DateTimeKind.Utc).AddTicks(1168));

            migrationBuilder.UpdateData(
                table: "resident",
                keyColumn: "resident_id",
                keyValue: 6,
                column: "birth_date",
                value: new DateTime(2022, 5, 10, 8, 14, 18, 400, DateTimeKind.Utc).AddTicks(1169));

            migrationBuilder.UpdateData(
                table: "resident",
                keyColumn: "resident_id",
                keyValue: 7,
                column: "birth_date",
                value: new DateTime(2022, 5, 10, 8, 14, 18, 400, DateTimeKind.Utc).AddTicks(1171));

            migrationBuilder.UpdateData(
                table: "resident",
                keyColumn: "resident_id",
                keyValue: 8,
                column: "birth_date",
                value: new DateTime(2022, 5, 10, 8, 14, 18, 400, DateTimeKind.Utc).AddTicks(1172));

            migrationBuilder.UpdateData(
                table: "resident",
                keyColumn: "resident_id",
                keyValue: 9,
                column: "birth_date",
                value: new DateTime(2022, 5, 10, 8, 14, 18, 400, DateTimeKind.Utc).AddTicks(1174));

            migrationBuilder.UpdateData(
                table: "resident",
                keyColumn: "resident_id",
                keyValue: 10,
                column: "birth_date",
                value: new DateTime(2022, 5, 10, 8, 14, 18, 400, DateTimeKind.Utc).AddTicks(1176));

            migrationBuilder.UpdateData(
                table: "resident",
                keyColumn: "resident_id",
                keyValue: 11,
                column: "birth_date",
                value: new DateTime(2022, 5, 10, 8, 14, 18, 400, DateTimeKind.Utc).AddTicks(1255));

            migrationBuilder.UpdateData(
                table: "settlement_order",
                keyColumn: "order_id",
                keyValue: 1,
                column: "order_date",
                value: new DateTime(2022, 5, 10, 8, 14, 18, 400, DateTimeKind.Utc).AddTicks(1524));

            migrationBuilder.UpdateData(
                table: "settlement_order",
                keyColumn: "order_id",
                keyValue: 2,
                column: "order_date",
                value: new DateTime(2022, 5, 10, 8, 14, 18, 400, DateTimeKind.Utc).AddTicks(1526));

            migrationBuilder.UpdateData(
                table: "settlement_order",
                keyColumn: "order_id",
                keyValue: 3,
                column: "order_date",
                value: new DateTime(2022, 5, 10, 8, 14, 18, 400, DateTimeKind.Utc).AddTicks(1527));

            migrationBuilder.UpdateData(
                table: "settlement_order",
                keyColumn: "order_id",
                keyValue: 4,
                column: "order_date",
                value: new DateTime(2022, 5, 10, 8, 14, 18, 400, DateTimeKind.Utc).AddTicks(1527));

            migrationBuilder.UpdateData(
                table: "settlement_order",
                keyColumn: "order_id",
                keyValue: 5,
                column: "order_date",
                value: new DateTime(2022, 5, 10, 8, 14, 18, 400, DateTimeKind.Utc).AddTicks(1528));

            migrationBuilder.UpdateData(
                table: "settlement_order",
                keyColumn: "order_id",
                keyValue: 6,
                column: "order_date",
                value: new DateTime(2022, 5, 10, 8, 14, 18, 400, DateTimeKind.Utc).AddTicks(1529));

            migrationBuilder.UpdateData(
                table: "settlement_order",
                keyColumn: "order_id",
                keyValue: 7,
                column: "order_date",
                value: new DateTime(2022, 5, 10, 8, 14, 18, 400, DateTimeKind.Utc).AddTicks(1530));

            migrationBuilder.UpdateData(
                table: "settlement_order",
                keyColumn: "order_id",
                keyValue: 8,
                column: "order_date",
                value: new DateTime(2022, 5, 10, 8, 14, 18, 400, DateTimeKind.Utc).AddTicks(1531));

            migrationBuilder.UpdateData(
                table: "settlement_order",
                keyColumn: "order_id",
                keyValue: 9,
                column: "order_date",
                value: new DateTime(2022, 5, 10, 8, 14, 18, 400, DateTimeKind.Utc).AddTicks(1532));

            migrationBuilder.UpdateData(
                table: "settlement_order",
                keyColumn: "order_id",
                keyValue: 10,
                column: "order_date",
                value: new DateTime(2022, 5, 10, 8, 14, 18, 400, DateTimeKind.Utc).AddTicks(1533));

            migrationBuilder.UpdateData(
                table: "settlement_order",
                keyColumn: "order_id",
                keyValue: 11,
                column: "order_date",
                value: new DateTime(2022, 5, 10, 8, 14, 18, 400, DateTimeKind.Utc).AddTicks(1534));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "course",
                table: "resident");

            migrationBuilder.UpdateData(
                table: "eviction_order",
                keyColumn: "order_id",
                keyValue: 1,
                column: "order_date",
                value: new DateTime(2022, 5, 10, 8, 3, 56, 351, DateTimeKind.Utc).AddTicks(8774));

            migrationBuilder.UpdateData(
                table: "eviction_order",
                keyColumn: "order_id",
                keyValue: 2,
                column: "order_date",
                value: new DateTime(2022, 5, 10, 8, 3, 56, 351, DateTimeKind.Utc).AddTicks(8775));

            migrationBuilder.UpdateData(
                table: "eviction_order",
                keyColumn: "order_id",
                keyValue: 3,
                column: "order_date",
                value: new DateTime(2022, 5, 10, 8, 3, 56, 351, DateTimeKind.Utc).AddTicks(8776));

            migrationBuilder.UpdateData(
                table: "eviction_order",
                keyColumn: "order_id",
                keyValue: 4,
                column: "order_date",
                value: new DateTime(2022, 5, 10, 8, 3, 56, 351, DateTimeKind.Utc).AddTicks(8777));

            migrationBuilder.UpdateData(
                table: "eviction_order",
                keyColumn: "order_id",
                keyValue: 5,
                column: "order_date",
                value: new DateTime(2022, 5, 10, 8, 3, 56, 351, DateTimeKind.Utc).AddTicks(8778));

            migrationBuilder.UpdateData(
                table: "passport_information",
                keyColumn: "passport_information_id",
                keyValue: 1,
                column: "issue_date",
                value: new DateTime(2022, 5, 10, 8, 3, 56, 351, DateTimeKind.Utc).AddTicks(9017));

            migrationBuilder.UpdateData(
                table: "passport_information",
                keyColumn: "passport_information_id",
                keyValue: 2,
                column: "issue_date",
                value: new DateTime(2022, 5, 10, 8, 3, 56, 351, DateTimeKind.Utc).AddTicks(9021));

            migrationBuilder.UpdateData(
                table: "passport_information",
                keyColumn: "passport_information_id",
                keyValue: 3,
                column: "issue_date",
                value: new DateTime(2022, 5, 10, 8, 3, 56, 351, DateTimeKind.Utc).AddTicks(9022));

            migrationBuilder.UpdateData(
                table: "passport_information",
                keyColumn: "passport_information_id",
                keyValue: 4,
                column: "issue_date",
                value: new DateTime(2022, 5, 10, 8, 3, 56, 351, DateTimeKind.Utc).AddTicks(9023));

            migrationBuilder.UpdateData(
                table: "passport_information",
                keyColumn: "passport_information_id",
                keyValue: 5,
                column: "issue_date",
                value: new DateTime(2022, 5, 10, 8, 3, 56, 351, DateTimeKind.Utc).AddTicks(9025));

            migrationBuilder.UpdateData(
                table: "resident",
                keyColumn: "resident_id",
                keyValue: 1,
                column: "birth_date",
                value: new DateTime(2022, 5, 10, 8, 3, 56, 351, DateTimeKind.Utc).AddTicks(8420));

            migrationBuilder.UpdateData(
                table: "resident",
                keyColumn: "resident_id",
                keyValue: 2,
                column: "birth_date",
                value: new DateTime(2022, 5, 10, 8, 3, 56, 351, DateTimeKind.Utc).AddTicks(8461));

            migrationBuilder.UpdateData(
                table: "resident",
                keyColumn: "resident_id",
                keyValue: 3,
                column: "birth_date",
                value: new DateTime(2022, 5, 10, 8, 3, 56, 351, DateTimeKind.Utc).AddTicks(8463));

            migrationBuilder.UpdateData(
                table: "resident",
                keyColumn: "resident_id",
                keyValue: 4,
                column: "birth_date",
                value: new DateTime(2022, 5, 10, 8, 3, 56, 351, DateTimeKind.Utc).AddTicks(8465));

            migrationBuilder.UpdateData(
                table: "resident",
                keyColumn: "resident_id",
                keyValue: 5,
                column: "birth_date",
                value: new DateTime(2022, 5, 10, 8, 3, 56, 351, DateTimeKind.Utc).AddTicks(8468));

            migrationBuilder.UpdateData(
                table: "resident",
                keyColumn: "resident_id",
                keyValue: 6,
                column: "birth_date",
                value: new DateTime(2022, 5, 10, 8, 3, 56, 351, DateTimeKind.Utc).AddTicks(8470));

            migrationBuilder.UpdateData(
                table: "resident",
                keyColumn: "resident_id",
                keyValue: 7,
                column: "birth_date",
                value: new DateTime(2022, 5, 10, 8, 3, 56, 351, DateTimeKind.Utc).AddTicks(8472));

            migrationBuilder.UpdateData(
                table: "resident",
                keyColumn: "resident_id",
                keyValue: 8,
                column: "birth_date",
                value: new DateTime(2022, 5, 10, 8, 3, 56, 351, DateTimeKind.Utc).AddTicks(8474));

            migrationBuilder.UpdateData(
                table: "resident",
                keyColumn: "resident_id",
                keyValue: 9,
                column: "birth_date",
                value: new DateTime(2022, 5, 10, 8, 3, 56, 351, DateTimeKind.Utc).AddTicks(8476));

            migrationBuilder.UpdateData(
                table: "resident",
                keyColumn: "resident_id",
                keyValue: 10,
                column: "birth_date",
                value: new DateTime(2022, 5, 10, 8, 3, 56, 351, DateTimeKind.Utc).AddTicks(8478));

            migrationBuilder.UpdateData(
                table: "resident",
                keyColumn: "resident_id",
                keyValue: 11,
                column: "birth_date",
                value: new DateTime(2022, 5, 10, 8, 3, 56, 351, DateTimeKind.Utc).AddTicks(8480));

            migrationBuilder.UpdateData(
                table: "settlement_order",
                keyColumn: "order_id",
                keyValue: 1,
                column: "order_date",
                value: new DateTime(2022, 5, 10, 8, 3, 56, 351, DateTimeKind.Utc).AddTicks(8741));

            migrationBuilder.UpdateData(
                table: "settlement_order",
                keyColumn: "order_id",
                keyValue: 2,
                column: "order_date",
                value: new DateTime(2022, 5, 10, 8, 3, 56, 351, DateTimeKind.Utc).AddTicks(8743));

            migrationBuilder.UpdateData(
                table: "settlement_order",
                keyColumn: "order_id",
                keyValue: 3,
                column: "order_date",
                value: new DateTime(2022, 5, 10, 8, 3, 56, 351, DateTimeKind.Utc).AddTicks(8744));

            migrationBuilder.UpdateData(
                table: "settlement_order",
                keyColumn: "order_id",
                keyValue: 4,
                column: "order_date",
                value: new DateTime(2022, 5, 10, 8, 3, 56, 351, DateTimeKind.Utc).AddTicks(8745));

            migrationBuilder.UpdateData(
                table: "settlement_order",
                keyColumn: "order_id",
                keyValue: 5,
                column: "order_date",
                value: new DateTime(2022, 5, 10, 8, 3, 56, 351, DateTimeKind.Utc).AddTicks(8746));

            migrationBuilder.UpdateData(
                table: "settlement_order",
                keyColumn: "order_id",
                keyValue: 6,
                column: "order_date",
                value: new DateTime(2022, 5, 10, 8, 3, 56, 351, DateTimeKind.Utc).AddTicks(8746));

            migrationBuilder.UpdateData(
                table: "settlement_order",
                keyColumn: "order_id",
                keyValue: 7,
                column: "order_date",
                value: new DateTime(2022, 5, 10, 8, 3, 56, 351, DateTimeKind.Utc).AddTicks(8747));

            migrationBuilder.UpdateData(
                table: "settlement_order",
                keyColumn: "order_id",
                keyValue: 8,
                column: "order_date",
                value: new DateTime(2022, 5, 10, 8, 3, 56, 351, DateTimeKind.Utc).AddTicks(8749));

            migrationBuilder.UpdateData(
                table: "settlement_order",
                keyColumn: "order_id",
                keyValue: 9,
                column: "order_date",
                value: new DateTime(2022, 5, 10, 8, 3, 56, 351, DateTimeKind.Utc).AddTicks(8750));

            migrationBuilder.UpdateData(
                table: "settlement_order",
                keyColumn: "order_id",
                keyValue: 10,
                column: "order_date",
                value: new DateTime(2022, 5, 10, 8, 3, 56, 351, DateTimeKind.Utc).AddTicks(8751));

            migrationBuilder.UpdateData(
                table: "settlement_order",
                keyColumn: "order_id",
                keyValue: 11,
                column: "order_date",
                value: new DateTime(2022, 5, 10, 8, 3, 56, 351, DateTimeKind.Utc).AddTicks(8752));
        }
    }
}
