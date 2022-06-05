using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace DMS.Migrations
{
    public partial class ChangeRatingOperationPrimaryKey : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_rating_operation",
                table: "rating_operation");

            migrationBuilder.DeleteData(
                table: "rating_operation",
                keyColumns: new[] { "order_date", "resident_id" },
                keyValues: new object[] { new DateTime(2021, 10, 8, 21, 0, 0, 0, DateTimeKind.Utc), 1 });

            migrationBuilder.DeleteData(
                table: "rating_operation",
                keyColumns: new[] { "order_date", "resident_id" },
                keyValues: new object[] { new DateTime(2021, 10, 9, 21, 0, 0, 0, DateTimeKind.Utc), 2 });

            migrationBuilder.DeleteData(
                table: "rating_operation",
                keyColumns: new[] { "order_date", "resident_id" },
                keyValues: new object[] { new DateTime(2021, 10, 10, 21, 0, 0, 0, DateTimeKind.Utc), 3 });

            migrationBuilder.DeleteData(
                table: "rating_operation",
                keyColumns: new[] { "order_date", "resident_id" },
                keyValues: new object[] { new DateTime(2021, 10, 11, 21, 0, 0, 0, DateTimeKind.Utc), 4 });

            migrationBuilder.DeleteData(
                table: "rating_operation",
                keyColumns: new[] { "order_date", "resident_id" },
                keyValues: new object[] { new DateTime(2021, 10, 12, 21, 0, 0, 0, DateTimeKind.Utc), 5 });

            migrationBuilder.DeleteData(
                table: "rating_operation",
                keyColumns: new[] { "order_date", "resident_id" },
                keyValues: new object[] { new DateTime(2021, 10, 13, 21, 0, 0, 0, DateTimeKind.Utc), 6 });

            migrationBuilder.AddColumn<int>(
                name: "rating_operation_id",
                table: "rating_operation",
                type: "integer",
                nullable: false,
                defaultValue: 0)
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AddPrimaryKey(
                name: "PK_rating_operation",
                table: "rating_operation",
                column: "rating_operation_id");

            migrationBuilder.UpdateData(
                table: "eviction_order",
                keyColumn: "order_id",
                keyValue: 1,
                column: "order_date",
                value: new DateTime(2022, 5, 15, 19, 5, 23, 256, DateTimeKind.Utc).AddTicks(4944));

            migrationBuilder.UpdateData(
                table: "eviction_order",
                keyColumn: "order_id",
                keyValue: 2,
                column: "order_date",
                value: new DateTime(2022, 5, 15, 19, 5, 23, 256, DateTimeKind.Utc).AddTicks(4945));

            migrationBuilder.UpdateData(
                table: "eviction_order",
                keyColumn: "order_id",
                keyValue: 3,
                column: "order_date",
                value: new DateTime(2022, 5, 15, 19, 5, 23, 256, DateTimeKind.Utc).AddTicks(4946));

            migrationBuilder.UpdateData(
                table: "eviction_order",
                keyColumn: "order_id",
                keyValue: 4,
                column: "order_date",
                value: new DateTime(2022, 5, 15, 19, 5, 23, 256, DateTimeKind.Utc).AddTicks(4947));

            migrationBuilder.UpdateData(
                table: "eviction_order",
                keyColumn: "order_id",
                keyValue: 5,
                column: "order_date",
                value: new DateTime(2022, 5, 15, 19, 5, 23, 256, DateTimeKind.Utc).AddTicks(4948));

            migrationBuilder.UpdateData(
                table: "passport_information",
                keyColumn: "passport_information_id",
                keyValue: 1,
                column: "issue_date",
                value: new DateTime(2022, 5, 15, 19, 5, 23, 256, DateTimeKind.Utc).AddTicks(5105));

            migrationBuilder.UpdateData(
                table: "passport_information",
                keyColumn: "passport_information_id",
                keyValue: 2,
                column: "issue_date",
                value: new DateTime(2022, 5, 15, 19, 5, 23, 256, DateTimeKind.Utc).AddTicks(5109));

            migrationBuilder.UpdateData(
                table: "passport_information",
                keyColumn: "passport_information_id",
                keyValue: 3,
                column: "issue_date",
                value: new DateTime(2022, 5, 15, 19, 5, 23, 256, DateTimeKind.Utc).AddTicks(5110));

            migrationBuilder.UpdateData(
                table: "passport_information",
                keyColumn: "passport_information_id",
                keyValue: 4,
                column: "issue_date",
                value: new DateTime(2022, 5, 15, 19, 5, 23, 256, DateTimeKind.Utc).AddTicks(5111));

            migrationBuilder.UpdateData(
                table: "passport_information",
                keyColumn: "passport_information_id",
                keyValue: 5,
                column: "issue_date",
                value: new DateTime(2022, 5, 15, 19, 5, 23, 256, DateTimeKind.Utc).AddTicks(5113));

            migrationBuilder.InsertData(
                table: "rating_operation",
                columns: new[] { "rating_operation_id", "category_id", "change_value", "description", "order_date", "resident_id" },
                values: new object[,]
                {
                    { 1, 1, -3, null, new DateTime(2021, 10, 8, 21, 0, 0, 0, DateTimeKind.Utc), 1 },
                    { 2, 2, 2, null, new DateTime(2021, 10, 13, 21, 0, 0, 0, DateTimeKind.Utc), 6 },
                    { 3, 2, 2, null, new DateTime(2021, 10, 12, 21, 0, 0, 0, DateTimeKind.Utc), 5 },
                    { 4, 1, -2, null, new DateTime(2021, 10, 11, 21, 0, 0, 0, DateTimeKind.Utc), 4 },
                    { 5, 3, -1, null, new DateTime(2021, 10, 10, 21, 0, 0, 0, DateTimeKind.Utc), 3 },
                    { 6, 2, 2, null, new DateTime(2021, 10, 9, 21, 0, 0, 0, DateTimeKind.Utc), 2 }
                });

            migrationBuilder.UpdateData(
                table: "resident",
                keyColumn: "resident_id",
                keyValue: 1,
                column: "birth_date",
                value: new DateTime(2022, 5, 15, 19, 5, 23, 256, DateTimeKind.Utc).AddTicks(4543));

            migrationBuilder.UpdateData(
                table: "resident",
                keyColumn: "resident_id",
                keyValue: 2,
                column: "birth_date",
                value: new DateTime(2022, 5, 15, 19, 5, 23, 256, DateTimeKind.Utc).AddTicks(4546));

            migrationBuilder.UpdateData(
                table: "resident",
                keyColumn: "resident_id",
                keyValue: 3,
                column: "birth_date",
                value: new DateTime(2022, 5, 15, 19, 5, 23, 256, DateTimeKind.Utc).AddTicks(4547));

            migrationBuilder.UpdateData(
                table: "resident",
                keyColumn: "resident_id",
                keyValue: 4,
                column: "birth_date",
                value: new DateTime(2022, 5, 15, 19, 5, 23, 256, DateTimeKind.Utc).AddTicks(4549));

            migrationBuilder.UpdateData(
                table: "resident",
                keyColumn: "resident_id",
                keyValue: 5,
                column: "birth_date",
                value: new DateTime(2022, 5, 15, 19, 5, 23, 256, DateTimeKind.Utc).AddTicks(4551));

            migrationBuilder.UpdateData(
                table: "resident",
                keyColumn: "resident_id",
                keyValue: 6,
                column: "birth_date",
                value: new DateTime(2022, 5, 15, 19, 5, 23, 256, DateTimeKind.Utc).AddTicks(4553));

            migrationBuilder.UpdateData(
                table: "resident",
                keyColumn: "resident_id",
                keyValue: 7,
                column: "birth_date",
                value: new DateTime(2022, 5, 15, 19, 5, 23, 256, DateTimeKind.Utc).AddTicks(4555));

            migrationBuilder.UpdateData(
                table: "resident",
                keyColumn: "resident_id",
                keyValue: 8,
                column: "birth_date",
                value: new DateTime(2022, 5, 15, 19, 5, 23, 256, DateTimeKind.Utc).AddTicks(4557));

            migrationBuilder.UpdateData(
                table: "resident",
                keyColumn: "resident_id",
                keyValue: 9,
                column: "birth_date",
                value: new DateTime(2022, 5, 15, 19, 5, 23, 256, DateTimeKind.Utc).AddTicks(4559));

            migrationBuilder.UpdateData(
                table: "resident",
                keyColumn: "resident_id",
                keyValue: 10,
                column: "birth_date",
                value: new DateTime(2022, 5, 15, 19, 5, 23, 256, DateTimeKind.Utc).AddTicks(4561));

            migrationBuilder.UpdateData(
                table: "resident",
                keyColumn: "resident_id",
                keyValue: 11,
                column: "birth_date",
                value: new DateTime(2022, 5, 15, 19, 5, 23, 256, DateTimeKind.Utc).AddTicks(4563));

            migrationBuilder.UpdateData(
                table: "settlement_order",
                keyColumn: "order_id",
                keyValue: 1,
                column: "order_date",
                value: new DateTime(2022, 5, 15, 19, 5, 23, 256, DateTimeKind.Utc).AddTicks(4912));

            migrationBuilder.UpdateData(
                table: "settlement_order",
                keyColumn: "order_id",
                keyValue: 2,
                column: "order_date",
                value: new DateTime(2022, 5, 15, 19, 5, 23, 256, DateTimeKind.Utc).AddTicks(4914));

            migrationBuilder.UpdateData(
                table: "settlement_order",
                keyColumn: "order_id",
                keyValue: 3,
                column: "order_date",
                value: new DateTime(2022, 5, 15, 19, 5, 23, 256, DateTimeKind.Utc).AddTicks(4915));

            migrationBuilder.UpdateData(
                table: "settlement_order",
                keyColumn: "order_id",
                keyValue: 4,
                column: "order_date",
                value: new DateTime(2022, 5, 15, 19, 5, 23, 256, DateTimeKind.Utc).AddTicks(4916));

            migrationBuilder.UpdateData(
                table: "settlement_order",
                keyColumn: "order_id",
                keyValue: 5,
                column: "order_date",
                value: new DateTime(2022, 5, 15, 19, 5, 23, 256, DateTimeKind.Utc).AddTicks(4917));

            migrationBuilder.UpdateData(
                table: "settlement_order",
                keyColumn: "order_id",
                keyValue: 6,
                column: "order_date",
                value: new DateTime(2022, 5, 15, 19, 5, 23, 256, DateTimeKind.Utc).AddTicks(4918));

            migrationBuilder.UpdateData(
                table: "settlement_order",
                keyColumn: "order_id",
                keyValue: 7,
                column: "order_date",
                value: new DateTime(2022, 5, 15, 19, 5, 23, 256, DateTimeKind.Utc).AddTicks(4920));

            migrationBuilder.UpdateData(
                table: "settlement_order",
                keyColumn: "order_id",
                keyValue: 8,
                column: "order_date",
                value: new DateTime(2022, 5, 15, 19, 5, 23, 256, DateTimeKind.Utc).AddTicks(4921));

            migrationBuilder.UpdateData(
                table: "settlement_order",
                keyColumn: "order_id",
                keyValue: 9,
                column: "order_date",
                value: new DateTime(2022, 5, 15, 19, 5, 23, 256, DateTimeKind.Utc).AddTicks(4922));

            migrationBuilder.UpdateData(
                table: "settlement_order",
                keyColumn: "order_id",
                keyValue: 10,
                column: "order_date",
                value: new DateTime(2022, 5, 15, 19, 5, 23, 256, DateTimeKind.Utc).AddTicks(4922));

            migrationBuilder.UpdateData(
                table: "settlement_order",
                keyColumn: "order_id",
                keyValue: 11,
                column: "order_date",
                value: new DateTime(2022, 5, 15, 19, 5, 23, 256, DateTimeKind.Utc).AddTicks(4923));

            migrationBuilder.CreateIndex(
                name: "IX_rating_operation_resident_id",
                table: "rating_operation",
                column: "resident_id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_rating_operation",
                table: "rating_operation");

            migrationBuilder.DropIndex(
                name: "IX_rating_operation_resident_id",
                table: "rating_operation");

            migrationBuilder.DropColumn(
                name: "rating_operation_id",
                table: "rating_operation");

            migrationBuilder.AddPrimaryKey(
                name: "PK_rating_operation",
                table: "rating_operation",
                columns: new[] { "resident_id", "order_date" });

            migrationBuilder.UpdateData(
                table: "eviction_order",
                keyColumn: "order_id",
                keyValue: 1,
                column: "order_date",
                value: new DateTime(2022, 5, 15, 17, 4, 56, 387, DateTimeKind.Utc).AddTicks(9193));

            migrationBuilder.UpdateData(
                table: "eviction_order",
                keyColumn: "order_id",
                keyValue: 2,
                column: "order_date",
                value: new DateTime(2022, 5, 15, 17, 4, 56, 387, DateTimeKind.Utc).AddTicks(9195));

            migrationBuilder.UpdateData(
                table: "eviction_order",
                keyColumn: "order_id",
                keyValue: 3,
                column: "order_date",
                value: new DateTime(2022, 5, 15, 17, 4, 56, 387, DateTimeKind.Utc).AddTicks(9196));

            migrationBuilder.UpdateData(
                table: "eviction_order",
                keyColumn: "order_id",
                keyValue: 4,
                column: "order_date",
                value: new DateTime(2022, 5, 15, 17, 4, 56, 387, DateTimeKind.Utc).AddTicks(9197));

            migrationBuilder.UpdateData(
                table: "eviction_order",
                keyColumn: "order_id",
                keyValue: 5,
                column: "order_date",
                value: new DateTime(2022, 5, 15, 17, 4, 56, 387, DateTimeKind.Utc).AddTicks(9198));

            migrationBuilder.UpdateData(
                table: "passport_information",
                keyColumn: "passport_information_id",
                keyValue: 1,
                column: "issue_date",
                value: new DateTime(2022, 5, 15, 17, 4, 56, 387, DateTimeKind.Utc).AddTicks(9372));

            migrationBuilder.UpdateData(
                table: "passport_information",
                keyColumn: "passport_information_id",
                keyValue: 2,
                column: "issue_date",
                value: new DateTime(2022, 5, 15, 17, 4, 56, 387, DateTimeKind.Utc).AddTicks(9377));

            migrationBuilder.UpdateData(
                table: "passport_information",
                keyColumn: "passport_information_id",
                keyValue: 3,
                column: "issue_date",
                value: new DateTime(2022, 5, 15, 17, 4, 56, 387, DateTimeKind.Utc).AddTicks(9378));

            migrationBuilder.UpdateData(
                table: "passport_information",
                keyColumn: "passport_information_id",
                keyValue: 4,
                column: "issue_date",
                value: new DateTime(2022, 5, 15, 17, 4, 56, 387, DateTimeKind.Utc).AddTicks(9380));

            migrationBuilder.UpdateData(
                table: "passport_information",
                keyColumn: "passport_information_id",
                keyValue: 5,
                column: "issue_date",
                value: new DateTime(2022, 5, 15, 17, 4, 56, 387, DateTimeKind.Utc).AddTicks(9382));

            migrationBuilder.UpdateData(
                table: "resident",
                keyColumn: "resident_id",
                keyValue: 1,
                column: "birth_date",
                value: new DateTime(2022, 5, 15, 17, 4, 56, 387, DateTimeKind.Utc).AddTicks(8837));

            migrationBuilder.UpdateData(
                table: "resident",
                keyColumn: "resident_id",
                keyValue: 2,
                column: "birth_date",
                value: new DateTime(2022, 5, 15, 17, 4, 56, 387, DateTimeKind.Utc).AddTicks(8840));

            migrationBuilder.UpdateData(
                table: "resident",
                keyColumn: "resident_id",
                keyValue: 3,
                column: "birth_date",
                value: new DateTime(2022, 5, 15, 17, 4, 56, 387, DateTimeKind.Utc).AddTicks(8842));

            migrationBuilder.UpdateData(
                table: "resident",
                keyColumn: "resident_id",
                keyValue: 4,
                column: "birth_date",
                value: new DateTime(2022, 5, 15, 17, 4, 56, 387, DateTimeKind.Utc).AddTicks(8846));

            migrationBuilder.UpdateData(
                table: "resident",
                keyColumn: "resident_id",
                keyValue: 5,
                column: "birth_date",
                value: new DateTime(2022, 5, 15, 17, 4, 56, 387, DateTimeKind.Utc).AddTicks(8848));

            migrationBuilder.UpdateData(
                table: "resident",
                keyColumn: "resident_id",
                keyValue: 6,
                column: "birth_date",
                value: new DateTime(2022, 5, 15, 17, 4, 56, 387, DateTimeKind.Utc).AddTicks(8850));

            migrationBuilder.UpdateData(
                table: "resident",
                keyColumn: "resident_id",
                keyValue: 7,
                column: "birth_date",
                value: new DateTime(2022, 5, 15, 17, 4, 56, 387, DateTimeKind.Utc).AddTicks(8852));

            migrationBuilder.UpdateData(
                table: "resident",
                keyColumn: "resident_id",
                keyValue: 8,
                column: "birth_date",
                value: new DateTime(2022, 5, 15, 17, 4, 56, 387, DateTimeKind.Utc).AddTicks(8855));

            migrationBuilder.UpdateData(
                table: "resident",
                keyColumn: "resident_id",
                keyValue: 9,
                column: "birth_date",
                value: new DateTime(2022, 5, 15, 17, 4, 56, 387, DateTimeKind.Utc).AddTicks(8857));

            migrationBuilder.UpdateData(
                table: "resident",
                keyColumn: "resident_id",
                keyValue: 10,
                column: "birth_date",
                value: new DateTime(2022, 5, 15, 17, 4, 56, 387, DateTimeKind.Utc).AddTicks(8859));

            migrationBuilder.UpdateData(
                table: "resident",
                keyColumn: "resident_id",
                keyValue: 11,
                column: "birth_date",
                value: new DateTime(2022, 5, 15, 17, 4, 56, 387, DateTimeKind.Utc).AddTicks(8861));

            migrationBuilder.UpdateData(
                table: "settlement_order",
                keyColumn: "order_id",
                keyValue: 1,
                column: "order_date",
                value: new DateTime(2022, 5, 15, 17, 4, 56, 387, DateTimeKind.Utc).AddTicks(9151));

            migrationBuilder.UpdateData(
                table: "settlement_order",
                keyColumn: "order_id",
                keyValue: 2,
                column: "order_date",
                value: new DateTime(2022, 5, 15, 17, 4, 56, 387, DateTimeKind.Utc).AddTicks(9153));

            migrationBuilder.UpdateData(
                table: "settlement_order",
                keyColumn: "order_id",
                keyValue: 3,
                column: "order_date",
                value: new DateTime(2022, 5, 15, 17, 4, 56, 387, DateTimeKind.Utc).AddTicks(9154));

            migrationBuilder.UpdateData(
                table: "settlement_order",
                keyColumn: "order_id",
                keyValue: 4,
                column: "order_date",
                value: new DateTime(2022, 5, 15, 17, 4, 56, 387, DateTimeKind.Utc).AddTicks(9155));

            migrationBuilder.UpdateData(
                table: "settlement_order",
                keyColumn: "order_id",
                keyValue: 5,
                column: "order_date",
                value: new DateTime(2022, 5, 15, 17, 4, 56, 387, DateTimeKind.Utc).AddTicks(9156));

            migrationBuilder.UpdateData(
                table: "settlement_order",
                keyColumn: "order_id",
                keyValue: 6,
                column: "order_date",
                value: new DateTime(2022, 5, 15, 17, 4, 56, 387, DateTimeKind.Utc).AddTicks(9157));

            migrationBuilder.UpdateData(
                table: "settlement_order",
                keyColumn: "order_id",
                keyValue: 7,
                column: "order_date",
                value: new DateTime(2022, 5, 15, 17, 4, 56, 387, DateTimeKind.Utc).AddTicks(9158));

            migrationBuilder.UpdateData(
                table: "settlement_order",
                keyColumn: "order_id",
                keyValue: 8,
                column: "order_date",
                value: new DateTime(2022, 5, 15, 17, 4, 56, 387, DateTimeKind.Utc).AddTicks(9159));

            migrationBuilder.UpdateData(
                table: "settlement_order",
                keyColumn: "order_id",
                keyValue: 9,
                column: "order_date",
                value: new DateTime(2022, 5, 15, 17, 4, 56, 387, DateTimeKind.Utc).AddTicks(9161));

            migrationBuilder.UpdateData(
                table: "settlement_order",
                keyColumn: "order_id",
                keyValue: 10,
                column: "order_date",
                value: new DateTime(2022, 5, 15, 17, 4, 56, 387, DateTimeKind.Utc).AddTicks(9163));

            migrationBuilder.UpdateData(
                table: "settlement_order",
                keyColumn: "order_id",
                keyValue: 11,
                column: "order_date",
                value: new DateTime(2022, 5, 15, 17, 4, 56, 387, DateTimeKind.Utc).AddTicks(9164));
        }
    }
}
