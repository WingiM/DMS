using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace DMS.Migrations
{
    public partial class RemoveRoomNumberIdentityAlways : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "room_number",
                table: "room",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityAlwaysColumn);

            migrationBuilder.UpdateData(
                table: "eviction_order",
                keyColumn: "order_id",
                keyValue: 1,
                column: "order_date",
                value: new DateTime(2022, 5, 9, 20, 7, 23, 383, DateTimeKind.Utc).AddTicks(1689));

            migrationBuilder.UpdateData(
                table: "eviction_order",
                keyColumn: "order_id",
                keyValue: 2,
                column: "order_date",
                value: new DateTime(2022, 5, 9, 20, 7, 23, 383, DateTimeKind.Utc).AddTicks(1690));

            migrationBuilder.UpdateData(
                table: "eviction_order",
                keyColumn: "order_id",
                keyValue: 3,
                column: "order_date",
                value: new DateTime(2022, 5, 9, 20, 7, 23, 383, DateTimeKind.Utc).AddTicks(1691));

            migrationBuilder.UpdateData(
                table: "eviction_order",
                keyColumn: "order_id",
                keyValue: 4,
                column: "order_date",
                value: new DateTime(2022, 5, 9, 20, 7, 23, 383, DateTimeKind.Utc).AddTicks(1692));

            migrationBuilder.UpdateData(
                table: "eviction_order",
                keyColumn: "order_id",
                keyValue: 5,
                column: "order_date",
                value: new DateTime(2022, 5, 9, 20, 7, 23, 383, DateTimeKind.Utc).AddTicks(1693));

            migrationBuilder.UpdateData(
                table: "passport_information",
                keyColumn: "passport_information_id",
                keyValue: 1,
                column: "issue_date",
                value: new DateTime(2022, 5, 9, 20, 7, 23, 383, DateTimeKind.Utc).AddTicks(1764));

            migrationBuilder.UpdateData(
                table: "passport_information",
                keyColumn: "passport_information_id",
                keyValue: 2,
                column: "issue_date",
                value: new DateTime(2022, 5, 9, 20, 7, 23, 383, DateTimeKind.Utc).AddTicks(1769));

            migrationBuilder.UpdateData(
                table: "passport_information",
                keyColumn: "passport_information_id",
                keyValue: 3,
                column: "issue_date",
                value: new DateTime(2022, 5, 9, 20, 7, 23, 383, DateTimeKind.Utc).AddTicks(1770));

            migrationBuilder.UpdateData(
                table: "passport_information",
                keyColumn: "passport_information_id",
                keyValue: 4,
                column: "issue_date",
                value: new DateTime(2022, 5, 9, 20, 7, 23, 383, DateTimeKind.Utc).AddTicks(1771));

            migrationBuilder.UpdateData(
                table: "passport_information",
                keyColumn: "passport_information_id",
                keyValue: 5,
                column: "issue_date",
                value: new DateTime(2022, 5, 9, 20, 7, 23, 383, DateTimeKind.Utc).AddTicks(1772));

            migrationBuilder.UpdateData(
                table: "rating_operation",
                keyColumn: "operation_id",
                keyValue: 1,
                column: "order_date",
                value: new DateTime(2022, 5, 9, 20, 7, 23, 383, DateTimeKind.Utc).AddTicks(1723));

            migrationBuilder.UpdateData(
                table: "rating_operation",
                keyColumn: "operation_id",
                keyValue: 2,
                column: "order_date",
                value: new DateTime(2022, 5, 9, 20, 7, 23, 383, DateTimeKind.Utc).AddTicks(1725));

            migrationBuilder.UpdateData(
                table: "rating_operation",
                keyColumn: "operation_id",
                keyValue: 3,
                column: "order_date",
                value: new DateTime(2022, 5, 9, 20, 7, 23, 383, DateTimeKind.Utc).AddTicks(1726));

            migrationBuilder.UpdateData(
                table: "rating_operation",
                keyColumn: "operation_id",
                keyValue: 4,
                column: "order_date",
                value: new DateTime(2022, 5, 9, 20, 7, 23, 383, DateTimeKind.Utc).AddTicks(1727));

            migrationBuilder.UpdateData(
                table: "rating_operation",
                keyColumn: "operation_id",
                keyValue: 5,
                column: "order_date",
                value: new DateTime(2022, 5, 9, 20, 7, 23, 383, DateTimeKind.Utc).AddTicks(1728));

            migrationBuilder.UpdateData(
                table: "rating_operation",
                keyColumn: "operation_id",
                keyValue: 6,
                column: "order_date",
                value: new DateTime(2022, 5, 9, 20, 7, 23, 383, DateTimeKind.Utc).AddTicks(1729));

            migrationBuilder.UpdateData(
                table: "resident",
                keyColumn: "resident_id",
                keyValue: 1,
                column: "birth_date",
                value: new DateTime(2022, 5, 9, 20, 7, 23, 383, DateTimeKind.Utc).AddTicks(1259));

            migrationBuilder.UpdateData(
                table: "resident",
                keyColumn: "resident_id",
                keyValue: 2,
                column: "birth_date",
                value: new DateTime(2022, 5, 9, 20, 7, 23, 383, DateTimeKind.Utc).AddTicks(1262));

            migrationBuilder.UpdateData(
                table: "resident",
                keyColumn: "resident_id",
                keyValue: 3,
                column: "birth_date",
                value: new DateTime(2022, 5, 9, 20, 7, 23, 383, DateTimeKind.Utc).AddTicks(1264));

            migrationBuilder.UpdateData(
                table: "resident",
                keyColumn: "resident_id",
                keyValue: 4,
                column: "birth_date",
                value: new DateTime(2022, 5, 9, 20, 7, 23, 383, DateTimeKind.Utc).AddTicks(1266));

            migrationBuilder.UpdateData(
                table: "resident",
                keyColumn: "resident_id",
                keyValue: 5,
                column: "birth_date",
                value: new DateTime(2022, 5, 9, 20, 7, 23, 383, DateTimeKind.Utc).AddTicks(1267));

            migrationBuilder.UpdateData(
                table: "resident",
                keyColumn: "resident_id",
                keyValue: 6,
                column: "birth_date",
                value: new DateTime(2022, 5, 9, 20, 7, 23, 383, DateTimeKind.Utc).AddTicks(1269));

            migrationBuilder.UpdateData(
                table: "resident",
                keyColumn: "resident_id",
                keyValue: 7,
                column: "birth_date",
                value: new DateTime(2022, 5, 9, 20, 7, 23, 383, DateTimeKind.Utc).AddTicks(1271));

            migrationBuilder.UpdateData(
                table: "resident",
                keyColumn: "resident_id",
                keyValue: 8,
                column: "birth_date",
                value: new DateTime(2022, 5, 9, 20, 7, 23, 383, DateTimeKind.Utc).AddTicks(1272));

            migrationBuilder.UpdateData(
                table: "resident",
                keyColumn: "resident_id",
                keyValue: 9,
                column: "birth_date",
                value: new DateTime(2022, 5, 9, 20, 7, 23, 383, DateTimeKind.Utc).AddTicks(1274));

            migrationBuilder.UpdateData(
                table: "resident",
                keyColumn: "resident_id",
                keyValue: 10,
                column: "birth_date",
                value: new DateTime(2022, 5, 9, 20, 7, 23, 383, DateTimeKind.Utc).AddTicks(1276));

            migrationBuilder.UpdateData(
                table: "resident",
                keyColumn: "resident_id",
                keyValue: 11,
                column: "birth_date",
                value: new DateTime(2022, 5, 9, 20, 7, 23, 383, DateTimeKind.Utc).AddTicks(1278));

            migrationBuilder.UpdateData(
                table: "settlement_order",
                keyColumn: "order_id",
                keyValue: 1,
                column: "order_date",
                value: new DateTime(2022, 5, 9, 20, 7, 23, 383, DateTimeKind.Utc).AddTicks(1658));

            migrationBuilder.UpdateData(
                table: "settlement_order",
                keyColumn: "order_id",
                keyValue: 2,
                column: "order_date",
                value: new DateTime(2022, 5, 9, 20, 7, 23, 383, DateTimeKind.Utc).AddTicks(1660));

            migrationBuilder.UpdateData(
                table: "settlement_order",
                keyColumn: "order_id",
                keyValue: 3,
                column: "order_date",
                value: new DateTime(2022, 5, 9, 20, 7, 23, 383, DateTimeKind.Utc).AddTicks(1660));

            migrationBuilder.UpdateData(
                table: "settlement_order",
                keyColumn: "order_id",
                keyValue: 4,
                column: "order_date",
                value: new DateTime(2022, 5, 9, 20, 7, 23, 383, DateTimeKind.Utc).AddTicks(1661));

            migrationBuilder.UpdateData(
                table: "settlement_order",
                keyColumn: "order_id",
                keyValue: 5,
                column: "order_date",
                value: new DateTime(2022, 5, 9, 20, 7, 23, 383, DateTimeKind.Utc).AddTicks(1662));

            migrationBuilder.UpdateData(
                table: "settlement_order",
                keyColumn: "order_id",
                keyValue: 6,
                column: "order_date",
                value: new DateTime(2022, 5, 9, 20, 7, 23, 383, DateTimeKind.Utc).AddTicks(1663));

            migrationBuilder.UpdateData(
                table: "settlement_order",
                keyColumn: "order_id",
                keyValue: 7,
                column: "order_date",
                value: new DateTime(2022, 5, 9, 20, 7, 23, 383, DateTimeKind.Utc).AddTicks(1664));

            migrationBuilder.UpdateData(
                table: "settlement_order",
                keyColumn: "order_id",
                keyValue: 8,
                column: "order_date",
                value: new DateTime(2022, 5, 9, 20, 7, 23, 383, DateTimeKind.Utc).AddTicks(1665));

            migrationBuilder.UpdateData(
                table: "settlement_order",
                keyColumn: "order_id",
                keyValue: 9,
                column: "order_date",
                value: new DateTime(2022, 5, 9, 20, 7, 23, 383, DateTimeKind.Utc).AddTicks(1666));

            migrationBuilder.UpdateData(
                table: "settlement_order",
                keyColumn: "order_id",
                keyValue: 10,
                column: "order_date",
                value: new DateTime(2022, 5, 9, 20, 7, 23, 383, DateTimeKind.Utc).AddTicks(1667));

            migrationBuilder.UpdateData(
                table: "settlement_order",
                keyColumn: "order_id",
                keyValue: 11,
                column: "order_date",
                value: new DateTime(2022, 5, 9, 20, 7, 23, 383, DateTimeKind.Utc).AddTicks(1668));

            migrationBuilder.UpdateData(
                table: "transaction",
                keyColumn: "operation_id",
                keyValue: 1,
                column: "operation_date",
                value: new DateTime(2022, 5, 9, 20, 7, 23, 383, DateTimeKind.Utc).AddTicks(1744));

            migrationBuilder.UpdateData(
                table: "transaction",
                keyColumn: "operation_id",
                keyValue: 2,
                column: "operation_date",
                value: new DateTime(2022, 5, 9, 20, 7, 23, 383, DateTimeKind.Utc).AddTicks(1745));

            migrationBuilder.UpdateData(
                table: "transaction",
                keyColumn: "operation_id",
                keyValue: 3,
                column: "operation_date",
                value: new DateTime(2022, 5, 9, 20, 7, 23, 383, DateTimeKind.Utc).AddTicks(1746));

            migrationBuilder.UpdateData(
                table: "transaction",
                keyColumn: "operation_id",
                keyValue: 4,
                column: "operation_date",
                value: new DateTime(2022, 5, 9, 20, 7, 23, 383, DateTimeKind.Utc).AddTicks(1747));

            migrationBuilder.UpdateData(
                table: "transaction",
                keyColumn: "operation_id",
                keyValue: 5,
                column: "operation_date",
                value: new DateTime(2022, 5, 9, 20, 7, 23, 383, DateTimeKind.Utc).AddTicks(1748));

            migrationBuilder.UpdateData(
                table: "transaction",
                keyColumn: "operation_id",
                keyValue: 6,
                column: "operation_date",
                value: new DateTime(2022, 5, 9, 20, 7, 23, 383, DateTimeKind.Utc).AddTicks(1749));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "room_number",
                table: "room",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityAlwaysColumn)
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.UpdateData(
                table: "eviction_order",
                keyColumn: "order_id",
                keyValue: 1,
                column: "order_date",
                value: new DateTime(2022, 5, 8, 9, 59, 7, 257, DateTimeKind.Utc).AddTicks(456));

            migrationBuilder.UpdateData(
                table: "eviction_order",
                keyColumn: "order_id",
                keyValue: 2,
                column: "order_date",
                value: new DateTime(2022, 5, 8, 9, 59, 7, 257, DateTimeKind.Utc).AddTicks(457));

            migrationBuilder.UpdateData(
                table: "eviction_order",
                keyColumn: "order_id",
                keyValue: 3,
                column: "order_date",
                value: new DateTime(2022, 5, 8, 9, 59, 7, 257, DateTimeKind.Utc).AddTicks(458));

            migrationBuilder.UpdateData(
                table: "eviction_order",
                keyColumn: "order_id",
                keyValue: 4,
                column: "order_date",
                value: new DateTime(2022, 5, 8, 9, 59, 7, 257, DateTimeKind.Utc).AddTicks(459));

            migrationBuilder.UpdateData(
                table: "eviction_order",
                keyColumn: "order_id",
                keyValue: 5,
                column: "order_date",
                value: new DateTime(2022, 5, 8, 9, 59, 7, 257, DateTimeKind.Utc).AddTicks(460));

            migrationBuilder.UpdateData(
                table: "passport_information",
                keyColumn: "passport_information_id",
                keyValue: 1,
                column: "issue_date",
                value: new DateTime(2022, 5, 8, 9, 59, 7, 257, DateTimeKind.Utc).AddTicks(532));

            migrationBuilder.UpdateData(
                table: "passport_information",
                keyColumn: "passport_information_id",
                keyValue: 2,
                column: "issue_date",
                value: new DateTime(2022, 5, 8, 9, 59, 7, 257, DateTimeKind.Utc).AddTicks(535));

            migrationBuilder.UpdateData(
                table: "passport_information",
                keyColumn: "passport_information_id",
                keyValue: 3,
                column: "issue_date",
                value: new DateTime(2022, 5, 8, 9, 59, 7, 257, DateTimeKind.Utc).AddTicks(536));

            migrationBuilder.UpdateData(
                table: "passport_information",
                keyColumn: "passport_information_id",
                keyValue: 4,
                column: "issue_date",
                value: new DateTime(2022, 5, 8, 9, 59, 7, 257, DateTimeKind.Utc).AddTicks(537));

            migrationBuilder.UpdateData(
                table: "passport_information",
                keyColumn: "passport_information_id",
                keyValue: 5,
                column: "issue_date",
                value: new DateTime(2022, 5, 8, 9, 59, 7, 257, DateTimeKind.Utc).AddTicks(539));

            migrationBuilder.UpdateData(
                table: "rating_operation",
                keyColumn: "operation_id",
                keyValue: 1,
                column: "order_date",
                value: new DateTime(2022, 5, 8, 9, 59, 7, 257, DateTimeKind.Utc).AddTicks(490));

            migrationBuilder.UpdateData(
                table: "rating_operation",
                keyColumn: "operation_id",
                keyValue: 2,
                column: "order_date",
                value: new DateTime(2022, 5, 8, 9, 59, 7, 257, DateTimeKind.Utc).AddTicks(492));

            migrationBuilder.UpdateData(
                table: "rating_operation",
                keyColumn: "operation_id",
                keyValue: 3,
                column: "order_date",
                value: new DateTime(2022, 5, 8, 9, 59, 7, 257, DateTimeKind.Utc).AddTicks(493));

            migrationBuilder.UpdateData(
                table: "rating_operation",
                keyColumn: "operation_id",
                keyValue: 4,
                column: "order_date",
                value: new DateTime(2022, 5, 8, 9, 59, 7, 257, DateTimeKind.Utc).AddTicks(494));

            migrationBuilder.UpdateData(
                table: "rating_operation",
                keyColumn: "operation_id",
                keyValue: 5,
                column: "order_date",
                value: new DateTime(2022, 5, 8, 9, 59, 7, 257, DateTimeKind.Utc).AddTicks(495));

            migrationBuilder.UpdateData(
                table: "rating_operation",
                keyColumn: "operation_id",
                keyValue: 6,
                column: "order_date",
                value: new DateTime(2022, 5, 8, 9, 59, 7, 257, DateTimeKind.Utc).AddTicks(496));

            migrationBuilder.UpdateData(
                table: "resident",
                keyColumn: "resident_id",
                keyValue: 1,
                column: "birth_date",
                value: new DateTime(2022, 5, 8, 9, 59, 7, 257, DateTimeKind.Utc).AddTicks(59));

            migrationBuilder.UpdateData(
                table: "resident",
                keyColumn: "resident_id",
                keyValue: 2,
                column: "birth_date",
                value: new DateTime(2022, 5, 8, 9, 59, 7, 257, DateTimeKind.Utc).AddTicks(62));

            migrationBuilder.UpdateData(
                table: "resident",
                keyColumn: "resident_id",
                keyValue: 3,
                column: "birth_date",
                value: new DateTime(2022, 5, 8, 9, 59, 7, 257, DateTimeKind.Utc).AddTicks(63));

            migrationBuilder.UpdateData(
                table: "resident",
                keyColumn: "resident_id",
                keyValue: 4,
                column: "birth_date",
                value: new DateTime(2022, 5, 8, 9, 59, 7, 257, DateTimeKind.Utc).AddTicks(65));

            migrationBuilder.UpdateData(
                table: "resident",
                keyColumn: "resident_id",
                keyValue: 5,
                column: "birth_date",
                value: new DateTime(2022, 5, 8, 9, 59, 7, 257, DateTimeKind.Utc).AddTicks(67));

            migrationBuilder.UpdateData(
                table: "resident",
                keyColumn: "resident_id",
                keyValue: 6,
                column: "birth_date",
                value: new DateTime(2022, 5, 8, 9, 59, 7, 257, DateTimeKind.Utc).AddTicks(69));

            migrationBuilder.UpdateData(
                table: "resident",
                keyColumn: "resident_id",
                keyValue: 7,
                column: "birth_date",
                value: new DateTime(2022, 5, 8, 9, 59, 7, 257, DateTimeKind.Utc).AddTicks(71));

            migrationBuilder.UpdateData(
                table: "resident",
                keyColumn: "resident_id",
                keyValue: 8,
                column: "birth_date",
                value: new DateTime(2022, 5, 8, 9, 59, 7, 257, DateTimeKind.Utc).AddTicks(72));

            migrationBuilder.UpdateData(
                table: "resident",
                keyColumn: "resident_id",
                keyValue: 9,
                column: "birth_date",
                value: new DateTime(2022, 5, 8, 9, 59, 7, 257, DateTimeKind.Utc).AddTicks(74));

            migrationBuilder.UpdateData(
                table: "resident",
                keyColumn: "resident_id",
                keyValue: 10,
                column: "birth_date",
                value: new DateTime(2022, 5, 8, 9, 59, 7, 257, DateTimeKind.Utc).AddTicks(76));

            migrationBuilder.UpdateData(
                table: "resident",
                keyColumn: "resident_id",
                keyValue: 11,
                column: "birth_date",
                value: new DateTime(2022, 5, 8, 9, 59, 7, 257, DateTimeKind.Utc).AddTicks(77));

            migrationBuilder.UpdateData(
                table: "settlement_order",
                keyColumn: "order_id",
                keyValue: 1,
                column: "order_date",
                value: new DateTime(2022, 5, 8, 9, 59, 7, 257, DateTimeKind.Utc).AddTicks(391));

            migrationBuilder.UpdateData(
                table: "settlement_order",
                keyColumn: "order_id",
                keyValue: 2,
                column: "order_date",
                value: new DateTime(2022, 5, 8, 9, 59, 7, 257, DateTimeKind.Utc).AddTicks(393));

            migrationBuilder.UpdateData(
                table: "settlement_order",
                keyColumn: "order_id",
                keyValue: 3,
                column: "order_date",
                value: new DateTime(2022, 5, 8, 9, 59, 7, 257, DateTimeKind.Utc).AddTicks(394));

            migrationBuilder.UpdateData(
                table: "settlement_order",
                keyColumn: "order_id",
                keyValue: 4,
                column: "order_date",
                value: new DateTime(2022, 5, 8, 9, 59, 7, 257, DateTimeKind.Utc).AddTicks(395));

            migrationBuilder.UpdateData(
                table: "settlement_order",
                keyColumn: "order_id",
                keyValue: 5,
                column: "order_date",
                value: new DateTime(2022, 5, 8, 9, 59, 7, 257, DateTimeKind.Utc).AddTicks(396));

            migrationBuilder.UpdateData(
                table: "settlement_order",
                keyColumn: "order_id",
                keyValue: 6,
                column: "order_date",
                value: new DateTime(2022, 5, 8, 9, 59, 7, 257, DateTimeKind.Utc).AddTicks(397));

            migrationBuilder.UpdateData(
                table: "settlement_order",
                keyColumn: "order_id",
                keyValue: 7,
                column: "order_date",
                value: new DateTime(2022, 5, 8, 9, 59, 7, 257, DateTimeKind.Utc).AddTicks(398));

            migrationBuilder.UpdateData(
                table: "settlement_order",
                keyColumn: "order_id",
                keyValue: 8,
                column: "order_date",
                value: new DateTime(2022, 5, 8, 9, 59, 7, 257, DateTimeKind.Utc).AddTicks(398));

            migrationBuilder.UpdateData(
                table: "settlement_order",
                keyColumn: "order_id",
                keyValue: 9,
                column: "order_date",
                value: new DateTime(2022, 5, 8, 9, 59, 7, 257, DateTimeKind.Utc).AddTicks(399));

            migrationBuilder.UpdateData(
                table: "settlement_order",
                keyColumn: "order_id",
                keyValue: 10,
                column: "order_date",
                value: new DateTime(2022, 5, 8, 9, 59, 7, 257, DateTimeKind.Utc).AddTicks(400));

            migrationBuilder.UpdateData(
                table: "settlement_order",
                keyColumn: "order_id",
                keyValue: 11,
                column: "order_date",
                value: new DateTime(2022, 5, 8, 9, 59, 7, 257, DateTimeKind.Utc).AddTicks(401));

            migrationBuilder.UpdateData(
                table: "transaction",
                keyColumn: "operation_id",
                keyValue: 1,
                column: "operation_date",
                value: new DateTime(2022, 5, 8, 9, 59, 7, 257, DateTimeKind.Utc).AddTicks(511));

            migrationBuilder.UpdateData(
                table: "transaction",
                keyColumn: "operation_id",
                keyValue: 2,
                column: "operation_date",
                value: new DateTime(2022, 5, 8, 9, 59, 7, 257, DateTimeKind.Utc).AddTicks(512));

            migrationBuilder.UpdateData(
                table: "transaction",
                keyColumn: "operation_id",
                keyValue: 3,
                column: "operation_date",
                value: new DateTime(2022, 5, 8, 9, 59, 7, 257, DateTimeKind.Utc).AddTicks(513));

            migrationBuilder.UpdateData(
                table: "transaction",
                keyColumn: "operation_id",
                keyValue: 4,
                column: "operation_date",
                value: new DateTime(2022, 5, 8, 9, 59, 7, 257, DateTimeKind.Utc).AddTicks(514));

            migrationBuilder.UpdateData(
                table: "transaction",
                keyColumn: "operation_id",
                keyValue: 5,
                column: "operation_date",
                value: new DateTime(2022, 5, 8, 9, 59, 7, 257, DateTimeKind.Utc).AddTicks(515));

            migrationBuilder.UpdateData(
                table: "transaction",
                keyColumn: "operation_id",
                keyValue: 6,
                column: "operation_date",
                value: new DateTime(2022, 5, 8, 9, 59, 7, 257, DateTimeKind.Utc).AddTicks(516));
        }
    }
}
