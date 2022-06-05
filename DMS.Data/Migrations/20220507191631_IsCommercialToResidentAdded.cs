using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DMS.Migrations
{
    public partial class IsCommercialToResidentAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "is_commercial",
                table: "resident",
                type: "bool",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "eviction_order",
                keyColumn: "order_id",
                keyValue: 1,
                column: "order_date",
                value: new DateTime(2022, 5, 7, 19, 16, 30, 748, DateTimeKind.Utc).AddTicks(8482));

            migrationBuilder.UpdateData(
                table: "eviction_order",
                keyColumn: "order_id",
                keyValue: 2,
                column: "order_date",
                value: new DateTime(2022, 5, 7, 19, 16, 30, 748, DateTimeKind.Utc).AddTicks(8483));

            migrationBuilder.UpdateData(
                table: "eviction_order",
                keyColumn: "order_id",
                keyValue: 3,
                column: "order_date",
                value: new DateTime(2022, 5, 7, 19, 16, 30, 748, DateTimeKind.Utc).AddTicks(8484));

            migrationBuilder.UpdateData(
                table: "eviction_order",
                keyColumn: "order_id",
                keyValue: 4,
                column: "order_date",
                value: new DateTime(2022, 5, 7, 19, 16, 30, 748, DateTimeKind.Utc).AddTicks(8484));

            migrationBuilder.UpdateData(
                table: "eviction_order",
                keyColumn: "order_id",
                keyValue: 5,
                column: "order_date",
                value: new DateTime(2022, 5, 7, 19, 16, 30, 748, DateTimeKind.Utc).AddTicks(8485));

            migrationBuilder.UpdateData(
                table: "rating_operation",
                keyColumn: "operation_id",
                keyValue: 1,
                column: "order_date",
                value: new DateTime(2022, 5, 7, 19, 16, 30, 748, DateTimeKind.Utc).AddTicks(8503));

            migrationBuilder.UpdateData(
                table: "rating_operation",
                keyColumn: "operation_id",
                keyValue: 2,
                column: "order_date",
                value: new DateTime(2022, 5, 7, 19, 16, 30, 748, DateTimeKind.Utc).AddTicks(8504));

            migrationBuilder.UpdateData(
                table: "rating_operation",
                keyColumn: "operation_id",
                keyValue: 3,
                column: "order_date",
                value: new DateTime(2022, 5, 7, 19, 16, 30, 748, DateTimeKind.Utc).AddTicks(8505));

            migrationBuilder.UpdateData(
                table: "rating_operation",
                keyColumn: "operation_id",
                keyValue: 4,
                column: "order_date",
                value: new DateTime(2022, 5, 7, 19, 16, 30, 748, DateTimeKind.Utc).AddTicks(8506));

            migrationBuilder.UpdateData(
                table: "rating_operation",
                keyColumn: "operation_id",
                keyValue: 5,
                column: "order_date",
                value: new DateTime(2022, 5, 7, 19, 16, 30, 748, DateTimeKind.Utc).AddTicks(8506));

            migrationBuilder.UpdateData(
                table: "rating_operation",
                keyColumn: "operation_id",
                keyValue: 6,
                column: "order_date",
                value: new DateTime(2022, 5, 7, 19, 16, 30, 748, DateTimeKind.Utc).AddTicks(8507));

            migrationBuilder.UpdateData(
                table: "resident",
                keyColumn: "resident_id",
                keyValue: 1,
                column: "birth_date",
                value: new DateTime(2022, 5, 7, 19, 16, 30, 748, DateTimeKind.Utc).AddTicks(8153));

            migrationBuilder.UpdateData(
                table: "resident",
                keyColumn: "resident_id",
                keyValue: 2,
                column: "birth_date",
                value: new DateTime(2022, 5, 7, 19, 16, 30, 748, DateTimeKind.Utc).AddTicks(8156));

            migrationBuilder.UpdateData(
                table: "resident",
                keyColumn: "resident_id",
                keyValue: 3,
                column: "birth_date",
                value: new DateTime(2022, 5, 7, 19, 16, 30, 748, DateTimeKind.Utc).AddTicks(8158));

            migrationBuilder.UpdateData(
                table: "resident",
                keyColumn: "resident_id",
                keyValue: 4,
                column: "birth_date",
                value: new DateTime(2022, 5, 7, 19, 16, 30, 748, DateTimeKind.Utc).AddTicks(8160));

            migrationBuilder.UpdateData(
                table: "resident",
                keyColumn: "resident_id",
                keyValue: 5,
                column: "birth_date",
                value: new DateTime(2022, 5, 7, 19, 16, 30, 748, DateTimeKind.Utc).AddTicks(8161));

            migrationBuilder.UpdateData(
                table: "resident",
                keyColumn: "resident_id",
                keyValue: 6,
                column: "birth_date",
                value: new DateTime(2022, 5, 7, 19, 16, 30, 748, DateTimeKind.Utc).AddTicks(8163));

            migrationBuilder.UpdateData(
                table: "resident",
                keyColumn: "resident_id",
                keyValue: 7,
                column: "birth_date",
                value: new DateTime(2022, 5, 7, 19, 16, 30, 748, DateTimeKind.Utc).AddTicks(8164));

            migrationBuilder.UpdateData(
                table: "resident",
                keyColumn: "resident_id",
                keyValue: 8,
                column: "birth_date",
                value: new DateTime(2022, 5, 7, 19, 16, 30, 748, DateTimeKind.Utc).AddTicks(8165));

            migrationBuilder.UpdateData(
                table: "resident",
                keyColumn: "resident_id",
                keyValue: 9,
                column: "birth_date",
                value: new DateTime(2022, 5, 7, 19, 16, 30, 748, DateTimeKind.Utc).AddTicks(8167));

            migrationBuilder.UpdateData(
                table: "resident",
                keyColumn: "resident_id",
                keyValue: 10,
                column: "birth_date",
                value: new DateTime(2022, 5, 7, 19, 16, 30, 748, DateTimeKind.Utc).AddTicks(8168));

            migrationBuilder.UpdateData(
                table: "resident",
                keyColumn: "resident_id",
                keyValue: 11,
                column: "birth_date",
                value: new DateTime(2022, 5, 7, 19, 16, 30, 748, DateTimeKind.Utc).AddTicks(8169));

            migrationBuilder.UpdateData(
                table: "settlement_order",
                keyColumn: "order_id",
                keyValue: 1,
                column: "order_date",
                value: new DateTime(2022, 5, 7, 19, 16, 30, 748, DateTimeKind.Utc).AddTicks(8463));

            migrationBuilder.UpdateData(
                table: "settlement_order",
                keyColumn: "order_id",
                keyValue: 2,
                column: "order_date",
                value: new DateTime(2022, 5, 7, 19, 16, 30, 748, DateTimeKind.Utc).AddTicks(8464));

            migrationBuilder.UpdateData(
                table: "settlement_order",
                keyColumn: "order_id",
                keyValue: 3,
                column: "order_date",
                value: new DateTime(2022, 5, 7, 19, 16, 30, 748, DateTimeKind.Utc).AddTicks(8465));

            migrationBuilder.UpdateData(
                table: "settlement_order",
                keyColumn: "order_id",
                keyValue: 4,
                column: "order_date",
                value: new DateTime(2022, 5, 7, 19, 16, 30, 748, DateTimeKind.Utc).AddTicks(8466));

            migrationBuilder.UpdateData(
                table: "settlement_order",
                keyColumn: "order_id",
                keyValue: 5,
                column: "order_date",
                value: new DateTime(2022, 5, 7, 19, 16, 30, 748, DateTimeKind.Utc).AddTicks(8466));

            migrationBuilder.UpdateData(
                table: "settlement_order",
                keyColumn: "order_id",
                keyValue: 6,
                column: "order_date",
                value: new DateTime(2022, 5, 7, 19, 16, 30, 748, DateTimeKind.Utc).AddTicks(8467));

            migrationBuilder.UpdateData(
                table: "settlement_order",
                keyColumn: "order_id",
                keyValue: 7,
                column: "order_date",
                value: new DateTime(2022, 5, 7, 19, 16, 30, 748, DateTimeKind.Utc).AddTicks(8467));

            migrationBuilder.UpdateData(
                table: "settlement_order",
                keyColumn: "order_id",
                keyValue: 8,
                column: "order_date",
                value: new DateTime(2022, 5, 7, 19, 16, 30, 748, DateTimeKind.Utc).AddTicks(8468));

            migrationBuilder.UpdateData(
                table: "settlement_order",
                keyColumn: "order_id",
                keyValue: 9,
                column: "order_date",
                value: new DateTime(2022, 5, 7, 19, 16, 30, 748, DateTimeKind.Utc).AddTicks(8468));

            migrationBuilder.UpdateData(
                table: "settlement_order",
                keyColumn: "order_id",
                keyValue: 10,
                column: "order_date",
                value: new DateTime(2022, 5, 7, 19, 16, 30, 748, DateTimeKind.Utc).AddTicks(8469));

            migrationBuilder.UpdateData(
                table: "settlement_order",
                keyColumn: "order_id",
                keyValue: 11,
                column: "order_date",
                value: new DateTime(2022, 5, 7, 19, 16, 30, 748, DateTimeKind.Utc).AddTicks(8470));

            migrationBuilder.UpdateData(
                table: "transaction",
                keyColumn: "operation_id",
                keyValue: 1,
                column: "operation_date",
                value: new DateTime(2022, 5, 7, 19, 16, 30, 748, DateTimeKind.Utc).AddTicks(8517));

            migrationBuilder.UpdateData(
                table: "transaction",
                keyColumn: "operation_id",
                keyValue: 2,
                column: "operation_date",
                value: new DateTime(2022, 5, 7, 19, 16, 30, 748, DateTimeKind.Utc).AddTicks(8518));

            migrationBuilder.UpdateData(
                table: "transaction",
                keyColumn: "operation_id",
                keyValue: 3,
                column: "operation_date",
                value: new DateTime(2022, 5, 7, 19, 16, 30, 748, DateTimeKind.Utc).AddTicks(8519));

            migrationBuilder.UpdateData(
                table: "transaction",
                keyColumn: "operation_id",
                keyValue: 4,
                column: "operation_date",
                value: new DateTime(2022, 5, 7, 19, 16, 30, 748, DateTimeKind.Utc).AddTicks(8519));

            migrationBuilder.UpdateData(
                table: "transaction",
                keyColumn: "operation_id",
                keyValue: 5,
                column: "operation_date",
                value: new DateTime(2022, 5, 7, 19, 16, 30, 748, DateTimeKind.Utc).AddTicks(8520));

            migrationBuilder.UpdateData(
                table: "transaction",
                keyColumn: "operation_id",
                keyValue: 6,
                column: "operation_date",
                value: new DateTime(2022, 5, 7, 19, 16, 30, 748, DateTimeKind.Utc).AddTicks(8520));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "is_commercial",
                table: "resident");

            migrationBuilder.UpdateData(
                table: "eviction_order",
                keyColumn: "order_id",
                keyValue: 1,
                column: "order_date",
                value: new DateTime(2022, 4, 28, 20, 26, 58, 461, DateTimeKind.Utc).AddTicks(5430));

            migrationBuilder.UpdateData(
                table: "eviction_order",
                keyColumn: "order_id",
                keyValue: 2,
                column: "order_date",
                value: new DateTime(2022, 4, 28, 20, 26, 58, 461, DateTimeKind.Utc).AddTicks(5431));

            migrationBuilder.UpdateData(
                table: "eviction_order",
                keyColumn: "order_id",
                keyValue: 3,
                column: "order_date",
                value: new DateTime(2022, 4, 28, 20, 26, 58, 461, DateTimeKind.Utc).AddTicks(5432));

            migrationBuilder.UpdateData(
                table: "eviction_order",
                keyColumn: "order_id",
                keyValue: 4,
                column: "order_date",
                value: new DateTime(2022, 4, 28, 20, 26, 58, 461, DateTimeKind.Utc).AddTicks(5432));

            migrationBuilder.UpdateData(
                table: "eviction_order",
                keyColumn: "order_id",
                keyValue: 5,
                column: "order_date",
                value: new DateTime(2022, 4, 28, 20, 26, 58, 461, DateTimeKind.Utc).AddTicks(5433));

            migrationBuilder.UpdateData(
                table: "rating_operation",
                keyColumn: "operation_id",
                keyValue: 1,
                column: "order_date",
                value: new DateTime(2022, 4, 28, 20, 26, 58, 461, DateTimeKind.Utc).AddTicks(5459));

            migrationBuilder.UpdateData(
                table: "rating_operation",
                keyColumn: "operation_id",
                keyValue: 2,
                column: "order_date",
                value: new DateTime(2022, 4, 28, 20, 26, 58, 461, DateTimeKind.Utc).AddTicks(5460));

            migrationBuilder.UpdateData(
                table: "rating_operation",
                keyColumn: "operation_id",
                keyValue: 3,
                column: "order_date",
                value: new DateTime(2022, 4, 28, 20, 26, 58, 461, DateTimeKind.Utc).AddTicks(5461));

            migrationBuilder.UpdateData(
                table: "rating_operation",
                keyColumn: "operation_id",
                keyValue: 4,
                column: "order_date",
                value: new DateTime(2022, 4, 28, 20, 26, 58, 461, DateTimeKind.Utc).AddTicks(5462));

            migrationBuilder.UpdateData(
                table: "rating_operation",
                keyColumn: "operation_id",
                keyValue: 5,
                column: "order_date",
                value: new DateTime(2022, 4, 28, 20, 26, 58, 461, DateTimeKind.Utc).AddTicks(5463));

            migrationBuilder.UpdateData(
                table: "rating_operation",
                keyColumn: "operation_id",
                keyValue: 6,
                column: "order_date",
                value: new DateTime(2022, 4, 28, 20, 26, 58, 461, DateTimeKind.Utc).AddTicks(5463));

            migrationBuilder.UpdateData(
                table: "resident",
                keyColumn: "resident_id",
                keyValue: 1,
                column: "birth_date",
                value: new DateTime(2022, 4, 28, 20, 26, 58, 461, DateTimeKind.Utc).AddTicks(5025));

            migrationBuilder.UpdateData(
                table: "resident",
                keyColumn: "resident_id",
                keyValue: 2,
                column: "birth_date",
                value: new DateTime(2022, 4, 28, 20, 26, 58, 461, DateTimeKind.Utc).AddTicks(5029));

            migrationBuilder.UpdateData(
                table: "resident",
                keyColumn: "resident_id",
                keyValue: 3,
                column: "birth_date",
                value: new DateTime(2022, 4, 28, 20, 26, 58, 461, DateTimeKind.Utc).AddTicks(5030));

            migrationBuilder.UpdateData(
                table: "resident",
                keyColumn: "resident_id",
                keyValue: 4,
                column: "birth_date",
                value: new DateTime(2022, 4, 28, 20, 26, 58, 461, DateTimeKind.Utc).AddTicks(5031));

            migrationBuilder.UpdateData(
                table: "resident",
                keyColumn: "resident_id",
                keyValue: 5,
                column: "birth_date",
                value: new DateTime(2022, 4, 28, 20, 26, 58, 461, DateTimeKind.Utc).AddTicks(5033));

            migrationBuilder.UpdateData(
                table: "resident",
                keyColumn: "resident_id",
                keyValue: 6,
                column: "birth_date",
                value: new DateTime(2022, 4, 28, 20, 26, 58, 461, DateTimeKind.Utc).AddTicks(5034));

            migrationBuilder.UpdateData(
                table: "resident",
                keyColumn: "resident_id",
                keyValue: 7,
                column: "birth_date",
                value: new DateTime(2022, 4, 28, 20, 26, 58, 461, DateTimeKind.Utc).AddTicks(5036));

            migrationBuilder.UpdateData(
                table: "resident",
                keyColumn: "resident_id",
                keyValue: 8,
                column: "birth_date",
                value: new DateTime(2022, 4, 28, 20, 26, 58, 461, DateTimeKind.Utc).AddTicks(5037));

            migrationBuilder.UpdateData(
                table: "resident",
                keyColumn: "resident_id",
                keyValue: 9,
                column: "birth_date",
                value: new DateTime(2022, 4, 28, 20, 26, 58, 461, DateTimeKind.Utc).AddTicks(5038));

            migrationBuilder.UpdateData(
                table: "resident",
                keyColumn: "resident_id",
                keyValue: 10,
                column: "birth_date",
                value: new DateTime(2022, 4, 28, 20, 26, 58, 461, DateTimeKind.Utc).AddTicks(5039));

            migrationBuilder.UpdateData(
                table: "resident",
                keyColumn: "resident_id",
                keyValue: 11,
                column: "birth_date",
                value: new DateTime(2022, 4, 28, 20, 26, 58, 461, DateTimeKind.Utc).AddTicks(5041));

            migrationBuilder.UpdateData(
                table: "settlement_order",
                keyColumn: "order_id",
                keyValue: 1,
                column: "order_date",
                value: new DateTime(2022, 4, 28, 20, 26, 58, 461, DateTimeKind.Utc).AddTicks(5406));

            migrationBuilder.UpdateData(
                table: "settlement_order",
                keyColumn: "order_id",
                keyValue: 2,
                column: "order_date",
                value: new DateTime(2022, 4, 28, 20, 26, 58, 461, DateTimeKind.Utc).AddTicks(5407));

            migrationBuilder.UpdateData(
                table: "settlement_order",
                keyColumn: "order_id",
                keyValue: 3,
                column: "order_date",
                value: new DateTime(2022, 4, 28, 20, 26, 58, 461, DateTimeKind.Utc).AddTicks(5408));

            migrationBuilder.UpdateData(
                table: "settlement_order",
                keyColumn: "order_id",
                keyValue: 4,
                column: "order_date",
                value: new DateTime(2022, 4, 28, 20, 26, 58, 461, DateTimeKind.Utc).AddTicks(5409));

            migrationBuilder.UpdateData(
                table: "settlement_order",
                keyColumn: "order_id",
                keyValue: 5,
                column: "order_date",
                value: new DateTime(2022, 4, 28, 20, 26, 58, 461, DateTimeKind.Utc).AddTicks(5409));

            migrationBuilder.UpdateData(
                table: "settlement_order",
                keyColumn: "order_id",
                keyValue: 6,
                column: "order_date",
                value: new DateTime(2022, 4, 28, 20, 26, 58, 461, DateTimeKind.Utc).AddTicks(5410));

            migrationBuilder.UpdateData(
                table: "settlement_order",
                keyColumn: "order_id",
                keyValue: 7,
                column: "order_date",
                value: new DateTime(2022, 4, 28, 20, 26, 58, 461, DateTimeKind.Utc).AddTicks(5411));

            migrationBuilder.UpdateData(
                table: "settlement_order",
                keyColumn: "order_id",
                keyValue: 8,
                column: "order_date",
                value: new DateTime(2022, 4, 28, 20, 26, 58, 461, DateTimeKind.Utc).AddTicks(5411));

            migrationBuilder.UpdateData(
                table: "settlement_order",
                keyColumn: "order_id",
                keyValue: 9,
                column: "order_date",
                value: new DateTime(2022, 4, 28, 20, 26, 58, 461, DateTimeKind.Utc).AddTicks(5412));

            migrationBuilder.UpdateData(
                table: "settlement_order",
                keyColumn: "order_id",
                keyValue: 10,
                column: "order_date",
                value: new DateTime(2022, 4, 28, 20, 26, 58, 461, DateTimeKind.Utc).AddTicks(5413));

            migrationBuilder.UpdateData(
                table: "settlement_order",
                keyColumn: "order_id",
                keyValue: 11,
                column: "order_date",
                value: new DateTime(2022, 4, 28, 20, 26, 58, 461, DateTimeKind.Utc).AddTicks(5413));

            migrationBuilder.UpdateData(
                table: "transaction",
                keyColumn: "operation_id",
                keyValue: 1,
                column: "operation_date",
                value: new DateTime(2022, 4, 28, 20, 26, 58, 461, DateTimeKind.Utc).AddTicks(5478));

            migrationBuilder.UpdateData(
                table: "transaction",
                keyColumn: "operation_id",
                keyValue: 2,
                column: "operation_date",
                value: new DateTime(2022, 4, 28, 20, 26, 58, 461, DateTimeKind.Utc).AddTicks(5479));

            migrationBuilder.UpdateData(
                table: "transaction",
                keyColumn: "operation_id",
                keyValue: 3,
                column: "operation_date",
                value: new DateTime(2022, 4, 28, 20, 26, 58, 461, DateTimeKind.Utc).AddTicks(5480));

            migrationBuilder.UpdateData(
                table: "transaction",
                keyColumn: "operation_id",
                keyValue: 4,
                column: "operation_date",
                value: new DateTime(2022, 4, 28, 20, 26, 58, 461, DateTimeKind.Utc).AddTicks(5481));

            migrationBuilder.UpdateData(
                table: "transaction",
                keyColumn: "operation_id",
                keyValue: 5,
                column: "operation_date",
                value: new DateTime(2022, 4, 28, 20, 26, 58, 461, DateTimeKind.Utc).AddTicks(5481));

            migrationBuilder.UpdateData(
                table: "transaction",
                keyColumn: "operation_id",
                keyValue: 6,
                column: "operation_date",
                value: new DateTime(2022, 4, 28, 20, 26, 58, 461, DateTimeKind.Utc).AddTicks(5482));
        }
    }
}
