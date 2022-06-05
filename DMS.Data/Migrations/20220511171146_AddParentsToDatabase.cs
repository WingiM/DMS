using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DMS.Migrations
{
    public partial class AddParentsToDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "parents_name",
                table: "settlement_order",
                type: "varchar(110)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "parents_passport_address",
                table: "settlement_order",
                type: "varchar(70)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "parents_passport_department_code",
                table: "settlement_order",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "parents_passport_issue_date",
                table: "settlement_order",
                type: "timestamp with time zone",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "parents_passport_issued_by",
                table: "settlement_order",
                type: "varchar(50)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "parents_passport_series_number",
                table: "settlement_order",
                type: "varchar(10)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "eviction_order",
                keyColumn: "order_id",
                keyValue: 1,
                column: "order_date",
                value: new DateTime(2022, 5, 11, 17, 11, 46, 224, DateTimeKind.Utc).AddTicks(36));

            migrationBuilder.UpdateData(
                table: "eviction_order",
                keyColumn: "order_id",
                keyValue: 2,
                column: "order_date",
                value: new DateTime(2022, 5, 11, 17, 11, 46, 224, DateTimeKind.Utc).AddTicks(38));

            migrationBuilder.UpdateData(
                table: "eviction_order",
                keyColumn: "order_id",
                keyValue: 3,
                column: "order_date",
                value: new DateTime(2022, 5, 11, 17, 11, 46, 224, DateTimeKind.Utc).AddTicks(38));

            migrationBuilder.UpdateData(
                table: "eviction_order",
                keyColumn: "order_id",
                keyValue: 4,
                column: "order_date",
                value: new DateTime(2022, 5, 11, 17, 11, 46, 224, DateTimeKind.Utc).AddTicks(39));

            migrationBuilder.UpdateData(
                table: "eviction_order",
                keyColumn: "order_id",
                keyValue: 5,
                column: "order_date",
                value: new DateTime(2022, 5, 11, 17, 11, 46, 224, DateTimeKind.Utc).AddTicks(40));

            migrationBuilder.UpdateData(
                table: "passport_information",
                keyColumn: "passport_information_id",
                keyValue: 1,
                column: "issue_date",
                value: new DateTime(2022, 5, 11, 17, 11, 46, 224, DateTimeKind.Utc).AddTicks(208));

            migrationBuilder.UpdateData(
                table: "passport_information",
                keyColumn: "passport_information_id",
                keyValue: 2,
                column: "issue_date",
                value: new DateTime(2022, 5, 11, 17, 11, 46, 224, DateTimeKind.Utc).AddTicks(212));

            migrationBuilder.UpdateData(
                table: "passport_information",
                keyColumn: "passport_information_id",
                keyValue: 3,
                column: "issue_date",
                value: new DateTime(2022, 5, 11, 17, 11, 46, 224, DateTimeKind.Utc).AddTicks(213));

            migrationBuilder.UpdateData(
                table: "passport_information",
                keyColumn: "passport_information_id",
                keyValue: 4,
                column: "issue_date",
                value: new DateTime(2022, 5, 11, 17, 11, 46, 224, DateTimeKind.Utc).AddTicks(214));

            migrationBuilder.UpdateData(
                table: "passport_information",
                keyColumn: "passport_information_id",
                keyValue: 5,
                column: "issue_date",
                value: new DateTime(2022, 5, 11, 17, 11, 46, 224, DateTimeKind.Utc).AddTicks(215));

            migrationBuilder.UpdateData(
                table: "resident",
                keyColumn: "resident_id",
                keyValue: 1,
                column: "birth_date",
                value: new DateTime(2022, 5, 11, 17, 11, 46, 223, DateTimeKind.Utc).AddTicks(9722));

            migrationBuilder.UpdateData(
                table: "resident",
                keyColumn: "resident_id",
                keyValue: 2,
                column: "birth_date",
                value: new DateTime(2022, 5, 11, 17, 11, 46, 223, DateTimeKind.Utc).AddTicks(9725));

            migrationBuilder.UpdateData(
                table: "resident",
                keyColumn: "resident_id",
                keyValue: 3,
                column: "birth_date",
                value: new DateTime(2022, 5, 11, 17, 11, 46, 223, DateTimeKind.Utc).AddTicks(9726));

            migrationBuilder.UpdateData(
                table: "resident",
                keyColumn: "resident_id",
                keyValue: 4,
                column: "birth_date",
                value: new DateTime(2022, 5, 11, 17, 11, 46, 223, DateTimeKind.Utc).AddTicks(9728));

            migrationBuilder.UpdateData(
                table: "resident",
                keyColumn: "resident_id",
                keyValue: 5,
                column: "birth_date",
                value: new DateTime(2022, 5, 11, 17, 11, 46, 223, DateTimeKind.Utc).AddTicks(9730));

            migrationBuilder.UpdateData(
                table: "resident",
                keyColumn: "resident_id",
                keyValue: 6,
                column: "birth_date",
                value: new DateTime(2022, 5, 11, 17, 11, 46, 223, DateTimeKind.Utc).AddTicks(9731));

            migrationBuilder.UpdateData(
                table: "resident",
                keyColumn: "resident_id",
                keyValue: 7,
                column: "birth_date",
                value: new DateTime(2022, 5, 11, 17, 11, 46, 223, DateTimeKind.Utc).AddTicks(9733));

            migrationBuilder.UpdateData(
                table: "resident",
                keyColumn: "resident_id",
                keyValue: 8,
                column: "birth_date",
                value: new DateTime(2022, 5, 11, 17, 11, 46, 223, DateTimeKind.Utc).AddTicks(9735));

            migrationBuilder.UpdateData(
                table: "resident",
                keyColumn: "resident_id",
                keyValue: 9,
                column: "birth_date",
                value: new DateTime(2022, 5, 11, 17, 11, 46, 223, DateTimeKind.Utc).AddTicks(9737));

            migrationBuilder.UpdateData(
                table: "resident",
                keyColumn: "resident_id",
                keyValue: 10,
                column: "birth_date",
                value: new DateTime(2022, 5, 11, 17, 11, 46, 223, DateTimeKind.Utc).AddTicks(9738));

            migrationBuilder.UpdateData(
                table: "resident",
                keyColumn: "resident_id",
                keyValue: 11,
                column: "birth_date",
                value: new DateTime(2022, 5, 11, 17, 11, 46, 223, DateTimeKind.Utc).AddTicks(9740));

            migrationBuilder.UpdateData(
                table: "settlement_order",
                keyColumn: "order_id",
                keyValue: 1,
                column: "order_date",
                value: new DateTime(2022, 5, 11, 17, 11, 46, 224, DateTimeKind.Utc).AddTicks(10));

            migrationBuilder.UpdateData(
                table: "settlement_order",
                keyColumn: "order_id",
                keyValue: 2,
                column: "order_date",
                value: new DateTime(2022, 5, 11, 17, 11, 46, 224, DateTimeKind.Utc).AddTicks(11));

            migrationBuilder.UpdateData(
                table: "settlement_order",
                keyColumn: "order_id",
                keyValue: 3,
                column: "order_date",
                value: new DateTime(2022, 5, 11, 17, 11, 46, 224, DateTimeKind.Utc).AddTicks(12));

            migrationBuilder.UpdateData(
                table: "settlement_order",
                keyColumn: "order_id",
                keyValue: 4,
                column: "order_date",
                value: new DateTime(2022, 5, 11, 17, 11, 46, 224, DateTimeKind.Utc).AddTicks(13));

            migrationBuilder.UpdateData(
                table: "settlement_order",
                keyColumn: "order_id",
                keyValue: 5,
                column: "order_date",
                value: new DateTime(2022, 5, 11, 17, 11, 46, 224, DateTimeKind.Utc).AddTicks(14));

            migrationBuilder.UpdateData(
                table: "settlement_order",
                keyColumn: "order_id",
                keyValue: 6,
                column: "order_date",
                value: new DateTime(2022, 5, 11, 17, 11, 46, 224, DateTimeKind.Utc).AddTicks(15));

            migrationBuilder.UpdateData(
                table: "settlement_order",
                keyColumn: "order_id",
                keyValue: 7,
                column: "order_date",
                value: new DateTime(2022, 5, 11, 17, 11, 46, 224, DateTimeKind.Utc).AddTicks(16));

            migrationBuilder.UpdateData(
                table: "settlement_order",
                keyColumn: "order_id",
                keyValue: 8,
                column: "order_date",
                value: new DateTime(2022, 5, 11, 17, 11, 46, 224, DateTimeKind.Utc).AddTicks(17));

            migrationBuilder.UpdateData(
                table: "settlement_order",
                keyColumn: "order_id",
                keyValue: 9,
                column: "order_date",
                value: new DateTime(2022, 5, 11, 17, 11, 46, 224, DateTimeKind.Utc).AddTicks(17));

            migrationBuilder.UpdateData(
                table: "settlement_order",
                keyColumn: "order_id",
                keyValue: 10,
                column: "order_date",
                value: new DateTime(2022, 5, 11, 17, 11, 46, 224, DateTimeKind.Utc).AddTicks(18));

            migrationBuilder.UpdateData(
                table: "settlement_order",
                keyColumn: "order_id",
                keyValue: 11,
                column: "order_date",
                value: new DateTime(2022, 5, 11, 17, 11, 46, 224, DateTimeKind.Utc).AddTicks(19));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "parents_name",
                table: "settlement_order");

            migrationBuilder.DropColumn(
                name: "parents_passport_address",
                table: "settlement_order");

            migrationBuilder.DropColumn(
                name: "parents_passport_department_code",
                table: "settlement_order");

            migrationBuilder.DropColumn(
                name: "parents_passport_issue_date",
                table: "settlement_order");

            migrationBuilder.DropColumn(
                name: "parents_passport_issued_by",
                table: "settlement_order");

            migrationBuilder.DropColumn(
                name: "parents_passport_series_number",
                table: "settlement_order");

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
    }
}
