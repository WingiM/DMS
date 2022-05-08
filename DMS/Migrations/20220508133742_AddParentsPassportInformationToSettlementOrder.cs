using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DMS.Migrations
{
    public partial class AddParentsPassportInformationToSettlementOrder : Migration
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
                value: new DateTime(2022, 5, 8, 13, 37, 42, 184, DateTimeKind.Utc).AddTicks(551));

            migrationBuilder.UpdateData(
                table: "eviction_order",
                keyColumn: "order_id",
                keyValue: 2,
                column: "order_date",
                value: new DateTime(2022, 5, 8, 13, 37, 42, 184, DateTimeKind.Utc).AddTicks(552));

            migrationBuilder.UpdateData(
                table: "eviction_order",
                keyColumn: "order_id",
                keyValue: 3,
                column: "order_date",
                value: new DateTime(2022, 5, 8, 13, 37, 42, 184, DateTimeKind.Utc).AddTicks(553));

            migrationBuilder.UpdateData(
                table: "eviction_order",
                keyColumn: "order_id",
                keyValue: 4,
                column: "order_date",
                value: new DateTime(2022, 5, 8, 13, 37, 42, 184, DateTimeKind.Utc).AddTicks(553));

            migrationBuilder.UpdateData(
                table: "eviction_order",
                keyColumn: "order_id",
                keyValue: 5,
                column: "order_date",
                value: new DateTime(2022, 5, 8, 13, 37, 42, 184, DateTimeKind.Utc).AddTicks(554));

            migrationBuilder.UpdateData(
                table: "passport_information",
                keyColumn: "passport_information_id",
                keyValue: 1,
                column: "issue_date",
                value: new DateTime(2022, 5, 8, 13, 37, 42, 184, DateTimeKind.Utc).AddTicks(606));

            migrationBuilder.UpdateData(
                table: "passport_information",
                keyColumn: "passport_information_id",
                keyValue: 2,
                column: "issue_date",
                value: new DateTime(2022, 5, 8, 13, 37, 42, 184, DateTimeKind.Utc).AddTicks(609));

            migrationBuilder.UpdateData(
                table: "passport_information",
                keyColumn: "passport_information_id",
                keyValue: 3,
                column: "issue_date",
                value: new DateTime(2022, 5, 8, 13, 37, 42, 184, DateTimeKind.Utc).AddTicks(610));

            migrationBuilder.UpdateData(
                table: "passport_information",
                keyColumn: "passport_information_id",
                keyValue: 4,
                column: "issue_date",
                value: new DateTime(2022, 5, 8, 13, 37, 42, 184, DateTimeKind.Utc).AddTicks(611));

            migrationBuilder.UpdateData(
                table: "passport_information",
                keyColumn: "passport_information_id",
                keyValue: 5,
                column: "issue_date",
                value: new DateTime(2022, 5, 8, 13, 37, 42, 184, DateTimeKind.Utc).AddTicks(612));

            migrationBuilder.UpdateData(
                table: "rating_operation",
                keyColumn: "operation_id",
                keyValue: 1,
                column: "order_date",
                value: new DateTime(2022, 5, 8, 13, 37, 42, 184, DateTimeKind.Utc).AddTicks(577));

            migrationBuilder.UpdateData(
                table: "rating_operation",
                keyColumn: "operation_id",
                keyValue: 2,
                column: "order_date",
                value: new DateTime(2022, 5, 8, 13, 37, 42, 184, DateTimeKind.Utc).AddTicks(578));

            migrationBuilder.UpdateData(
                table: "rating_operation",
                keyColumn: "operation_id",
                keyValue: 3,
                column: "order_date",
                value: new DateTime(2022, 5, 8, 13, 37, 42, 184, DateTimeKind.Utc).AddTicks(579));

            migrationBuilder.UpdateData(
                table: "rating_operation",
                keyColumn: "operation_id",
                keyValue: 4,
                column: "order_date",
                value: new DateTime(2022, 5, 8, 13, 37, 42, 184, DateTimeKind.Utc).AddTicks(579));

            migrationBuilder.UpdateData(
                table: "rating_operation",
                keyColumn: "operation_id",
                keyValue: 5,
                column: "order_date",
                value: new DateTime(2022, 5, 8, 13, 37, 42, 184, DateTimeKind.Utc).AddTicks(580));

            migrationBuilder.UpdateData(
                table: "rating_operation",
                keyColumn: "operation_id",
                keyValue: 6,
                column: "order_date",
                value: new DateTime(2022, 5, 8, 13, 37, 42, 184, DateTimeKind.Utc).AddTicks(581));

            migrationBuilder.UpdateData(
                table: "resident",
                keyColumn: "resident_id",
                keyValue: 1,
                column: "birth_date",
                value: new DateTime(2022, 5, 8, 13, 37, 42, 184, DateTimeKind.Utc).AddTicks(177));

            migrationBuilder.UpdateData(
                table: "resident",
                keyColumn: "resident_id",
                keyValue: 2,
                column: "birth_date",
                value: new DateTime(2022, 5, 8, 13, 37, 42, 184, DateTimeKind.Utc).AddTicks(180));

            migrationBuilder.UpdateData(
                table: "resident",
                keyColumn: "resident_id",
                keyValue: 3,
                column: "birth_date",
                value: new DateTime(2022, 5, 8, 13, 37, 42, 184, DateTimeKind.Utc).AddTicks(182));

            migrationBuilder.UpdateData(
                table: "resident",
                keyColumn: "resident_id",
                keyValue: 4,
                column: "birth_date",
                value: new DateTime(2022, 5, 8, 13, 37, 42, 184, DateTimeKind.Utc).AddTicks(183));

            migrationBuilder.UpdateData(
                table: "resident",
                keyColumn: "resident_id",
                keyValue: 5,
                column: "birth_date",
                value: new DateTime(2022, 5, 8, 13, 37, 42, 184, DateTimeKind.Utc).AddTicks(185));

            migrationBuilder.UpdateData(
                table: "resident",
                keyColumn: "resident_id",
                keyValue: 6,
                column: "birth_date",
                value: new DateTime(2022, 5, 8, 13, 37, 42, 184, DateTimeKind.Utc).AddTicks(186));

            migrationBuilder.UpdateData(
                table: "resident",
                keyColumn: "resident_id",
                keyValue: 7,
                column: "birth_date",
                value: new DateTime(2022, 5, 8, 13, 37, 42, 184, DateTimeKind.Utc).AddTicks(187));

            migrationBuilder.UpdateData(
                table: "resident",
                keyColumn: "resident_id",
                keyValue: 8,
                column: "birth_date",
                value: new DateTime(2022, 5, 8, 13, 37, 42, 184, DateTimeKind.Utc).AddTicks(188));

            migrationBuilder.UpdateData(
                table: "resident",
                keyColumn: "resident_id",
                keyValue: 9,
                column: "birth_date",
                value: new DateTime(2022, 5, 8, 13, 37, 42, 184, DateTimeKind.Utc).AddTicks(190));

            migrationBuilder.UpdateData(
                table: "resident",
                keyColumn: "resident_id",
                keyValue: 10,
                column: "birth_date",
                value: new DateTime(2022, 5, 8, 13, 37, 42, 184, DateTimeKind.Utc).AddTicks(191));

            migrationBuilder.UpdateData(
                table: "resident",
                keyColumn: "resident_id",
                keyValue: 11,
                column: "birth_date",
                value: new DateTime(2022, 5, 8, 13, 37, 42, 184, DateTimeKind.Utc).AddTicks(192));

            migrationBuilder.UpdateData(
                table: "settlement_order",
                keyColumn: "order_id",
                keyValue: 1,
                column: "order_date",
                value: new DateTime(2022, 5, 8, 13, 37, 42, 184, DateTimeKind.Utc).AddTicks(494));

            migrationBuilder.UpdateData(
                table: "settlement_order",
                keyColumn: "order_id",
                keyValue: 2,
                column: "order_date",
                value: new DateTime(2022, 5, 8, 13, 37, 42, 184, DateTimeKind.Utc).AddTicks(496));

            migrationBuilder.UpdateData(
                table: "settlement_order",
                keyColumn: "order_id",
                keyValue: 3,
                column: "order_date",
                value: new DateTime(2022, 5, 8, 13, 37, 42, 184, DateTimeKind.Utc).AddTicks(497));

            migrationBuilder.UpdateData(
                table: "settlement_order",
                keyColumn: "order_id",
                keyValue: 4,
                column: "order_date",
                value: new DateTime(2022, 5, 8, 13, 37, 42, 184, DateTimeKind.Utc).AddTicks(498));

            migrationBuilder.UpdateData(
                table: "settlement_order",
                keyColumn: "order_id",
                keyValue: 5,
                column: "order_date",
                value: new DateTime(2022, 5, 8, 13, 37, 42, 184, DateTimeKind.Utc).AddTicks(498));

            migrationBuilder.UpdateData(
                table: "settlement_order",
                keyColumn: "order_id",
                keyValue: 6,
                column: "order_date",
                value: new DateTime(2022, 5, 8, 13, 37, 42, 184, DateTimeKind.Utc).AddTicks(499));

            migrationBuilder.UpdateData(
                table: "settlement_order",
                keyColumn: "order_id",
                keyValue: 7,
                column: "order_date",
                value: new DateTime(2022, 5, 8, 13, 37, 42, 184, DateTimeKind.Utc).AddTicks(499));

            migrationBuilder.UpdateData(
                table: "settlement_order",
                keyColumn: "order_id",
                keyValue: 8,
                column: "order_date",
                value: new DateTime(2022, 5, 8, 13, 37, 42, 184, DateTimeKind.Utc).AddTicks(500));

            migrationBuilder.UpdateData(
                table: "settlement_order",
                keyColumn: "order_id",
                keyValue: 9,
                column: "order_date",
                value: new DateTime(2022, 5, 8, 13, 37, 42, 184, DateTimeKind.Utc).AddTicks(501));

            migrationBuilder.UpdateData(
                table: "settlement_order",
                keyColumn: "order_id",
                keyValue: 10,
                column: "order_date",
                value: new DateTime(2022, 5, 8, 13, 37, 42, 184, DateTimeKind.Utc).AddTicks(501));

            migrationBuilder.UpdateData(
                table: "settlement_order",
                keyColumn: "order_id",
                keyValue: 11,
                column: "order_date",
                value: new DateTime(2022, 5, 8, 13, 37, 42, 184, DateTimeKind.Utc).AddTicks(502));

            migrationBuilder.UpdateData(
                table: "transaction",
                keyColumn: "operation_id",
                keyValue: 1,
                column: "operation_date",
                value: new DateTime(2022, 5, 8, 13, 37, 42, 184, DateTimeKind.Utc).AddTicks(591));

            migrationBuilder.UpdateData(
                table: "transaction",
                keyColumn: "operation_id",
                keyValue: 2,
                column: "operation_date",
                value: new DateTime(2022, 5, 8, 13, 37, 42, 184, DateTimeKind.Utc).AddTicks(592));

            migrationBuilder.UpdateData(
                table: "transaction",
                keyColumn: "operation_id",
                keyValue: 3,
                column: "operation_date",
                value: new DateTime(2022, 5, 8, 13, 37, 42, 184, DateTimeKind.Utc).AddTicks(593));

            migrationBuilder.UpdateData(
                table: "transaction",
                keyColumn: "operation_id",
                keyValue: 4,
                column: "operation_date",
                value: new DateTime(2022, 5, 8, 13, 37, 42, 184, DateTimeKind.Utc).AddTicks(594));

            migrationBuilder.UpdateData(
                table: "transaction",
                keyColumn: "operation_id",
                keyValue: 5,
                column: "operation_date",
                value: new DateTime(2022, 5, 8, 13, 37, 42, 184, DateTimeKind.Utc).AddTicks(594));

            migrationBuilder.UpdateData(
                table: "transaction",
                keyColumn: "operation_id",
                keyValue: 6,
                column: "operation_date",
                value: new DateTime(2022, 5, 8, 13, 37, 42, 184, DateTimeKind.Utc).AddTicks(595));
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
