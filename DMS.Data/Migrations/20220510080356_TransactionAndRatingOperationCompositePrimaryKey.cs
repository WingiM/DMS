using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace DMS.Migrations
{
    public partial class TransactionAndRatingOperationCompositePrimaryKey : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_transaction",
                table: "transaction");

            migrationBuilder.DropIndex(
                name: "IX_transaction_resident_id",
                table: "transaction");

            migrationBuilder.DropPrimaryKey(
                name: "PK_rating_operation",
                table: "rating_operation");

            migrationBuilder.DropIndex(
                name: "IX_rating_operation_resident_id",
                table: "rating_operation");

            migrationBuilder.DeleteData(
                table: "rating_operation",
                keyColumn: "operation_id",
                keyColumnType: "int",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "rating_operation",
                keyColumn: "operation_id",
                keyColumnType: "int",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "rating_operation",
                keyColumn: "operation_id",
                keyColumnType: "int",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "rating_operation",
                keyColumn: "operation_id",
                keyColumnType: "int",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "rating_operation",
                keyColumn: "operation_id",
                keyColumnType: "int",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "rating_operation",
                keyColumn: "operation_id",
                keyColumnType: "int",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "transaction",
                keyColumn: "operation_id",
                keyColumnType: "int",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "transaction",
                keyColumn: "operation_id",
                keyColumnType: "int",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "transaction",
                keyColumn: "operation_id",
                keyColumnType: "int",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "transaction",
                keyColumn: "operation_id",
                keyColumnType: "int",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "transaction",
                keyColumn: "operation_id",
                keyColumnType: "int",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "transaction",
                keyColumn: "operation_id",
                keyColumnType: "int",
                keyValue: 6);

            migrationBuilder.DropColumn(
                name: "operation_id",
                table: "transaction");

            migrationBuilder.DropColumn(
                name: "operation_id",
                table: "rating_operation");

            migrationBuilder.AddPrimaryKey(
                name: "PK_transaction",
                table: "transaction",
                columns: new[] { "resident_id", "operation_date" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_rating_operation",
                table: "rating_operation",
                columns: new[] { "resident_id", "order_date" });

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

            migrationBuilder.InsertData(
                table: "rating_operation",
                columns: new[] { "order_date", "resident_id", "category_id", "change_value", "description" },
                values: new object[,]
                {
                    { new DateTime(2021, 10, 8, 21, 0, 0, 0, DateTimeKind.Utc), 1, 1, -3, null },
                    { new DateTime(2021, 10, 9, 21, 0, 0, 0, DateTimeKind.Utc), 2, 2, 2, null },
                    { new DateTime(2021, 10, 10, 21, 0, 0, 0, DateTimeKind.Utc), 3, 3, -1, null },
                    { new DateTime(2021, 10, 11, 21, 0, 0, 0, DateTimeKind.Utc), 4, 1, -2, null },
                    { new DateTime(2021, 10, 12, 21, 0, 0, 0, DateTimeKind.Utc), 5, 2, 2, null },
                    { new DateTime(2021, 10, 13, 21, 0, 0, 0, DateTimeKind.Utc), 6, 2, 2, null }
                });

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

            migrationBuilder.InsertData(
                table: "transaction",
                columns: new[] { "operation_date", "resident_id", "sum" },
                values: new object[,]
                {
                    { new DateTime(2021, 10, 8, 21, 0, 0, 0, DateTimeKind.Utc), 1, 3000.0 },
                    { new DateTime(2021, 10, 9, 7, 0, 0, 0, DateTimeKind.Utc), 2, 1000.0 },
                    { new DateTime(2021, 10, 9, 9, 0, 0, 0, DateTimeKind.Utc), 2, 3000.0 },
                    { new DateTime(2021, 10, 11, 21, 0, 0, 0, DateTimeKind.Utc), 3, 4000.0 },
                    { new DateTime(2021, 10, 9, 21, 0, 0, 0, DateTimeKind.Utc), 4, 2012.4200000000001 },
                    { new DateTime(2021, 10, 19, 21, 0, 0, 0, DateTimeKind.Utc), 5, 18234.130000000001 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_transaction",
                table: "transaction");

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
                name: "operation_id",
                table: "transaction",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityAlwaysColumn);

            migrationBuilder.AddColumn<int>(
                name: "operation_id",
                table: "rating_operation",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityAlwaysColumn);

            migrationBuilder.AddPrimaryKey(
                name: "PK_transaction",
                table: "transaction",
                column: "operation_id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_rating_operation",
                table: "rating_operation",
                column: "operation_id");

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

            migrationBuilder.InsertData(
                table: "rating_operation",
                columns: new[] { "operation_id", "category_id", "change_value", "description", "order_date", "resident_id" },
                values: new object[,]
                {
                    { 1, 1, -3, null, new DateTime(2022, 5, 9, 20, 7, 23, 383, DateTimeKind.Utc).AddTicks(1723), 1 },
                    { 2, 2, 2, null, new DateTime(2022, 5, 9, 20, 7, 23, 383, DateTimeKind.Utc).AddTicks(1725), 2 },
                    { 3, 3, -1, null, new DateTime(2022, 5, 9, 20, 7, 23, 383, DateTimeKind.Utc).AddTicks(1726), 3 },
                    { 4, 1, -2, null, new DateTime(2022, 5, 9, 20, 7, 23, 383, DateTimeKind.Utc).AddTicks(1727), 4 },
                    { 5, 2, 2, null, new DateTime(2022, 5, 9, 20, 7, 23, 383, DateTimeKind.Utc).AddTicks(1728), 5 },
                    { 6, 2, 2, null, new DateTime(2022, 5, 9, 20, 7, 23, 383, DateTimeKind.Utc).AddTicks(1729), 6 }
                });

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

            migrationBuilder.InsertData(
                table: "transaction",
                columns: new[] { "operation_id", "operation_date", "resident_id", "sum" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 5, 9, 20, 7, 23, 383, DateTimeKind.Utc).AddTicks(1744), 1, 3000.0 },
                    { 2, new DateTime(2022, 5, 9, 20, 7, 23, 383, DateTimeKind.Utc).AddTicks(1745), 2, 1000.0 },
                    { 3, new DateTime(2022, 5, 9, 20, 7, 23, 383, DateTimeKind.Utc).AddTicks(1746), 2, 3000.0 },
                    { 4, new DateTime(2022, 5, 9, 20, 7, 23, 383, DateTimeKind.Utc).AddTicks(1747), 3, 4000.0 },
                    { 5, new DateTime(2022, 5, 9, 20, 7, 23, 383, DateTimeKind.Utc).AddTicks(1748), 4, 2012.4200000000001 },
                    { 6, new DateTime(2022, 5, 9, 20, 7, 23, 383, DateTimeKind.Utc).AddTicks(1749), 5, 18234.130000000001 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_transaction_resident_id",
                table: "transaction",
                column: "resident_id");

            migrationBuilder.CreateIndex(
                name: "IX_rating_operation_resident_id",
                table: "rating_operation",
                column: "resident_id");
        }
    }
}
