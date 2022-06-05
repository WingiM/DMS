using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DMS.Migrations
{
    public partial class AddDataToPassportInformation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "series_number",
                table: "PassportInformation",
                type: "varchar(10)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "issued_by",
                table: "PassportInformation",
                type: "varchar(50)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "address",
                table: "PassportInformation",
                type: "varchar(70)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "PassportInformation",
                columns: new[] { "passport_information_id", "address", "department_code", "issue_date", "issued_by", "resident_id", "series_number" },
                values: new object[,]
                {
                    { 1, "asdasdasdas", 23124, new DateTime(2022, 5, 7, 21, 37, 37, 784, DateTimeKind.Utc).AddTicks(4600), "МВД по чему-то", 1, "1234567890" },
                    { 2, "sadgsdfgfdg", 23124, new DateTime(2022, 5, 7, 21, 37, 37, 784, DateTimeKind.Utc).AddTicks(4602), "МВД по чему-то", 2, "1523123123" },
                    { 3, "sdghgfhgfhfgdh", 23423, new DateTime(2022, 5, 7, 21, 37, 37, 784, DateTimeKind.Utc).AddTicks(4603), "МВД по чему-то", 3, "7916239123" },
                    { 4, "asdfsdfdsaf", 54334, new DateTime(2022, 5, 7, 21, 37, 37, 784, DateTimeKind.Utc).AddTicks(4604), "МВД по чему-то", 4, "9817349817" },
                    { 5, "gdfsgfdsgdsf", 98172, new DateTime(2022, 5, 7, 21, 37, 37, 784, DateTimeKind.Utc).AddTicks(4605), "МВД по чему-то", 5, "1807231987" }
                });

            migrationBuilder.UpdateData(
                table: "eviction_order",
                keyColumn: "order_id",
                keyValue: 1,
                column: "order_date",
                value: new DateTime(2022, 5, 7, 21, 37, 37, 784, DateTimeKind.Utc).AddTicks(4516));

            migrationBuilder.UpdateData(
                table: "eviction_order",
                keyColumn: "order_id",
                keyValue: 2,
                column: "order_date",
                value: new DateTime(2022, 5, 7, 21, 37, 37, 784, DateTimeKind.Utc).AddTicks(4517));

            migrationBuilder.UpdateData(
                table: "eviction_order",
                keyColumn: "order_id",
                keyValue: 3,
                column: "order_date",
                value: new DateTime(2022, 5, 7, 21, 37, 37, 784, DateTimeKind.Utc).AddTicks(4518));

            migrationBuilder.UpdateData(
                table: "eviction_order",
                keyColumn: "order_id",
                keyValue: 4,
                column: "order_date",
                value: new DateTime(2022, 5, 7, 21, 37, 37, 784, DateTimeKind.Utc).AddTicks(4518));

            migrationBuilder.UpdateData(
                table: "eviction_order",
                keyColumn: "order_id",
                keyValue: 5,
                column: "order_date",
                value: new DateTime(2022, 5, 7, 21, 37, 37, 784, DateTimeKind.Utc).AddTicks(4519));

            migrationBuilder.UpdateData(
                table: "rating_operation",
                keyColumn: "operation_id",
                keyValue: 1,
                column: "order_date",
                value: new DateTime(2022, 5, 7, 21, 37, 37, 784, DateTimeKind.Utc).AddTicks(4538));

            migrationBuilder.UpdateData(
                table: "rating_operation",
                keyColumn: "operation_id",
                keyValue: 2,
                column: "order_date",
                value: new DateTime(2022, 5, 7, 21, 37, 37, 784, DateTimeKind.Utc).AddTicks(4539));

            migrationBuilder.UpdateData(
                table: "rating_operation",
                keyColumn: "operation_id",
                keyValue: 3,
                column: "order_date",
                value: new DateTime(2022, 5, 7, 21, 37, 37, 784, DateTimeKind.Utc).AddTicks(4540));

            migrationBuilder.UpdateData(
                table: "rating_operation",
                keyColumn: "operation_id",
                keyValue: 4,
                column: "order_date",
                value: new DateTime(2022, 5, 7, 21, 37, 37, 784, DateTimeKind.Utc).AddTicks(4540));

            migrationBuilder.UpdateData(
                table: "rating_operation",
                keyColumn: "operation_id",
                keyValue: 5,
                column: "order_date",
                value: new DateTime(2022, 5, 7, 21, 37, 37, 784, DateTimeKind.Utc).AddTicks(4541));

            migrationBuilder.UpdateData(
                table: "rating_operation",
                keyColumn: "operation_id",
                keyValue: 6,
                column: "order_date",
                value: new DateTime(2022, 5, 7, 21, 37, 37, 784, DateTimeKind.Utc).AddTicks(4542));

            migrationBuilder.UpdateData(
                table: "resident",
                keyColumn: "resident_id",
                keyValue: 1,
                column: "birth_date",
                value: new DateTime(2022, 5, 7, 21, 37, 37, 784, DateTimeKind.Utc).AddTicks(4151));

            migrationBuilder.UpdateData(
                table: "resident",
                keyColumn: "resident_id",
                keyValue: 2,
                column: "birth_date",
                value: new DateTime(2022, 5, 7, 21, 37, 37, 784, DateTimeKind.Utc).AddTicks(4154));

            migrationBuilder.UpdateData(
                table: "resident",
                keyColumn: "resident_id",
                keyValue: 3,
                column: "birth_date",
                value: new DateTime(2022, 5, 7, 21, 37, 37, 784, DateTimeKind.Utc).AddTicks(4155));

            migrationBuilder.UpdateData(
                table: "resident",
                keyColumn: "resident_id",
                keyValue: 4,
                column: "birth_date",
                value: new DateTime(2022, 5, 7, 21, 37, 37, 784, DateTimeKind.Utc).AddTicks(4156));

            migrationBuilder.UpdateData(
                table: "resident",
                keyColumn: "resident_id",
                keyValue: 5,
                column: "birth_date",
                value: new DateTime(2022, 5, 7, 21, 37, 37, 784, DateTimeKind.Utc).AddTicks(4158));

            migrationBuilder.UpdateData(
                table: "resident",
                keyColumn: "resident_id",
                keyValue: 6,
                column: "birth_date",
                value: new DateTime(2022, 5, 7, 21, 37, 37, 784, DateTimeKind.Utc).AddTicks(4159));

            migrationBuilder.UpdateData(
                table: "resident",
                keyColumn: "resident_id",
                keyValue: 7,
                column: "birth_date",
                value: new DateTime(2022, 5, 7, 21, 37, 37, 784, DateTimeKind.Utc).AddTicks(4194));

            migrationBuilder.UpdateData(
                table: "resident",
                keyColumn: "resident_id",
                keyValue: 8,
                column: "birth_date",
                value: new DateTime(2022, 5, 7, 21, 37, 37, 784, DateTimeKind.Utc).AddTicks(4196));

            migrationBuilder.UpdateData(
                table: "resident",
                keyColumn: "resident_id",
                keyValue: 9,
                column: "birth_date",
                value: new DateTime(2022, 5, 7, 21, 37, 37, 784, DateTimeKind.Utc).AddTicks(4197));

            migrationBuilder.UpdateData(
                table: "resident",
                keyColumn: "resident_id",
                keyValue: 10,
                column: "birth_date",
                value: new DateTime(2022, 5, 7, 21, 37, 37, 784, DateTimeKind.Utc).AddTicks(4198));

            migrationBuilder.UpdateData(
                table: "resident",
                keyColumn: "resident_id",
                keyValue: 11,
                column: "birth_date",
                value: new DateTime(2022, 5, 7, 21, 37, 37, 784, DateTimeKind.Utc).AddTicks(4199));

            migrationBuilder.UpdateData(
                table: "settlement_order",
                keyColumn: "order_id",
                keyValue: 1,
                column: "order_date",
                value: new DateTime(2022, 5, 7, 21, 37, 37, 784, DateTimeKind.Utc).AddTicks(4496));

            migrationBuilder.UpdateData(
                table: "settlement_order",
                keyColumn: "order_id",
                keyValue: 2,
                column: "order_date",
                value: new DateTime(2022, 5, 7, 21, 37, 37, 784, DateTimeKind.Utc).AddTicks(4497));

            migrationBuilder.UpdateData(
                table: "settlement_order",
                keyColumn: "order_id",
                keyValue: 3,
                column: "order_date",
                value: new DateTime(2022, 5, 7, 21, 37, 37, 784, DateTimeKind.Utc).AddTicks(4498));

            migrationBuilder.UpdateData(
                table: "settlement_order",
                keyColumn: "order_id",
                keyValue: 4,
                column: "order_date",
                value: new DateTime(2022, 5, 7, 21, 37, 37, 784, DateTimeKind.Utc).AddTicks(4498));

            migrationBuilder.UpdateData(
                table: "settlement_order",
                keyColumn: "order_id",
                keyValue: 5,
                column: "order_date",
                value: new DateTime(2022, 5, 7, 21, 37, 37, 784, DateTimeKind.Utc).AddTicks(4499));

            migrationBuilder.UpdateData(
                table: "settlement_order",
                keyColumn: "order_id",
                keyValue: 6,
                column: "order_date",
                value: new DateTime(2022, 5, 7, 21, 37, 37, 784, DateTimeKind.Utc).AddTicks(4500));

            migrationBuilder.UpdateData(
                table: "settlement_order",
                keyColumn: "order_id",
                keyValue: 7,
                column: "order_date",
                value: new DateTime(2022, 5, 7, 21, 37, 37, 784, DateTimeKind.Utc).AddTicks(4501));

            migrationBuilder.UpdateData(
                table: "settlement_order",
                keyColumn: "order_id",
                keyValue: 8,
                column: "order_date",
                value: new DateTime(2022, 5, 7, 21, 37, 37, 784, DateTimeKind.Utc).AddTicks(4501));

            migrationBuilder.UpdateData(
                table: "settlement_order",
                keyColumn: "order_id",
                keyValue: 9,
                column: "order_date",
                value: new DateTime(2022, 5, 7, 21, 37, 37, 784, DateTimeKind.Utc).AddTicks(4502));

            migrationBuilder.UpdateData(
                table: "settlement_order",
                keyColumn: "order_id",
                keyValue: 10,
                column: "order_date",
                value: new DateTime(2022, 5, 7, 21, 37, 37, 784, DateTimeKind.Utc).AddTicks(4502));

            migrationBuilder.UpdateData(
                table: "settlement_order",
                keyColumn: "order_id",
                keyValue: 11,
                column: "order_date",
                value: new DateTime(2022, 5, 7, 21, 37, 37, 784, DateTimeKind.Utc).AddTicks(4503));

            migrationBuilder.UpdateData(
                table: "transaction",
                keyColumn: "operation_id",
                keyValue: 1,
                column: "operation_date",
                value: new DateTime(2022, 5, 7, 21, 37, 37, 784, DateTimeKind.Utc).AddTicks(4551));

            migrationBuilder.UpdateData(
                table: "transaction",
                keyColumn: "operation_id",
                keyValue: 2,
                column: "operation_date",
                value: new DateTime(2022, 5, 7, 21, 37, 37, 784, DateTimeKind.Utc).AddTicks(4552));

            migrationBuilder.UpdateData(
                table: "transaction",
                keyColumn: "operation_id",
                keyValue: 3,
                column: "operation_date",
                value: new DateTime(2022, 5, 7, 21, 37, 37, 784, DateTimeKind.Utc).AddTicks(4553));

            migrationBuilder.UpdateData(
                table: "transaction",
                keyColumn: "operation_id",
                keyValue: 4,
                column: "operation_date",
                value: new DateTime(2022, 5, 7, 21, 37, 37, 784, DateTimeKind.Utc).AddTicks(4553));

            migrationBuilder.UpdateData(
                table: "transaction",
                keyColumn: "operation_id",
                keyValue: 5,
                column: "operation_date",
                value: new DateTime(2022, 5, 7, 21, 37, 37, 784, DateTimeKind.Utc).AddTicks(4554));

            migrationBuilder.UpdateData(
                table: "transaction",
                keyColumn: "operation_id",
                keyValue: 6,
                column: "operation_date",
                value: new DateTime(2022, 5, 7, 21, 37, 37, 784, DateTimeKind.Utc).AddTicks(4554));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "PassportInformation",
                keyColumn: "passport_information_id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "PassportInformation",
                keyColumn: "passport_information_id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "PassportInformation",
                keyColumn: "passport_information_id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "PassportInformation",
                keyColumn: "passport_information_id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "PassportInformation",
                keyColumn: "passport_information_id",
                keyValue: 5);

            migrationBuilder.AlterColumn<string>(
                name: "series_number",
                table: "PassportInformation",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(10)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "issued_by",
                table: "PassportInformation",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(50)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "address",
                table: "PassportInformation",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(70)",
                oldNullable: true);

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
        }
    }
}
