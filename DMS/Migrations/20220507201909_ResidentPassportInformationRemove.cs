using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DMS.Migrations
{
    public partial class ResidentPassportInformationRemove : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_resident_passport_information",
                table: "resident");

            migrationBuilder.DropColumn(
                name: "passport_information",
                table: "resident");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "passport_information",
                table: "resident",
                type: "varchar(10)",
                nullable: true);

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

            migrationBuilder.CreateIndex(
                name: "IX_resident_passport_information",
                table: "resident",
                column: "passport_information",
                unique: true);
        }
    }
}
