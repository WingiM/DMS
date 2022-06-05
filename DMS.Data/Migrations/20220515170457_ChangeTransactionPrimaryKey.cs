using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace DMS.Migrations
{
    public partial class ChangeTransactionPrimaryKey : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_transaction",
                table: "transaction");

            migrationBuilder.DeleteData(
                table: "transaction",
                keyColumns: new[] { "operation_date", "resident_id" },
                keyValues: new object[] { new DateTime(2021, 10, 8, 21, 0, 0, 0, DateTimeKind.Utc), 1 });

            migrationBuilder.DeleteData(
                table: "transaction",
                keyColumns: new[] { "operation_date", "resident_id" },
                keyValues: new object[] { new DateTime(2021, 10, 9, 7, 0, 0, 0, DateTimeKind.Utc), 2 });

            migrationBuilder.DeleteData(
                table: "transaction",
                keyColumns: new[] { "operation_date", "resident_id" },
                keyValues: new object[] { new DateTime(2021, 10, 9, 9, 0, 0, 0, DateTimeKind.Utc), 2 });

            migrationBuilder.DeleteData(
                table: "transaction",
                keyColumns: new[] { "operation_date", "resident_id" },
                keyValues: new object[] { new DateTime(2021, 10, 11, 21, 0, 0, 0, DateTimeKind.Utc), 3 });

            migrationBuilder.DeleteData(
                table: "transaction",
                keyColumns: new[] { "operation_date", "resident_id" },
                keyValues: new object[] { new DateTime(2021, 10, 9, 21, 0, 0, 0, DateTimeKind.Utc), 4 });

            migrationBuilder.DeleteData(
                table: "transaction",
                keyColumns: new[] { "operation_date", "resident_id" },
                keyValues: new object[] { new DateTime(2021, 10, 19, 21, 0, 0, 0, DateTimeKind.Utc), 5 });

            migrationBuilder.AddColumn<int>(
                name: "transaction_id",
                table: "transaction",
                type: "integer",
                nullable: false,
                defaultValue: 0)
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AddPrimaryKey(
                name: "PK_transaction",
                table: "transaction",
                column: "transaction_id");

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

            migrationBuilder.InsertData(
                table: "transaction",
                columns: new[] { "transaction_id", "operation_date", "resident_id", "sum" },
                values: new object[,]
                {
                    { 1, new DateTime(2021, 10, 8, 21, 0, 0, 0, DateTimeKind.Utc), 1, 3000.0 },
                    { 2, new DateTime(2021, 10, 9, 7, 0, 0, 0, DateTimeKind.Utc), 2, 1000.0 },
                    { 3, new DateTime(2021, 10, 9, 9, 0, 0, 0, DateTimeKind.Utc), 2, 3000.0 },
                    { 4, new DateTime(2021, 10, 11, 21, 0, 0, 0, DateTimeKind.Utc), 3, 4000.0 },
                    { 5, new DateTime(2021, 10, 9, 21, 0, 0, 0, DateTimeKind.Utc), 4, 2012.4200000000001 },
                    { 6, new DateTime(2021, 10, 19, 21, 0, 0, 0, DateTimeKind.Utc), 5, 18234.130000000001 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_transaction_resident_id",
                table: "transaction",
                column: "resident_id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_transaction",
                table: "transaction");

            migrationBuilder.DropIndex(
                name: "IX_transaction_resident_id",
                table: "transaction");

            migrationBuilder.DropColumn(
                name: "transaction_id",
                table: "transaction");

            migrationBuilder.AddPrimaryKey(
                name: "PK_transaction",
                table: "transaction",
                columns: new[] { "resident_id", "operation_date" });

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
    }
}
