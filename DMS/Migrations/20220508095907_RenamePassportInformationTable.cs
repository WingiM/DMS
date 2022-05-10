using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace DMS.Migrations
{
    public partial class RenamePassportInformationTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PassportInformation_resident_resident_id",
                table: "PassportInformation");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PassportInformation",
                table: "PassportInformation");

            migrationBuilder.RenameTable(
                name: "PassportInformation",
                newName: "passport_information");

            migrationBuilder.RenameIndex(
                name: "IX_PassportInformation_series_number",
                table: "passport_information",
                newName: "IX_passport_information_series_number");

            migrationBuilder.RenameIndex(
                name: "IX_PassportInformation_resident_id",
                table: "passport_information",
                newName: "IX_passport_information_resident_id");

            migrationBuilder.AlterColumn<int>(
                name: "resident_id",
                table: "transaction",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<int>(
                name: "operation_id",
                table: "transaction",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer")
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityAlwaysColumn)
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityAlwaysColumn);

            migrationBuilder.AlterColumn<int>(
                name: "resident_id",
                table: "settlement_order",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<int>(
                name: "order_id",
                table: "settlement_order",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer")
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityAlwaysColumn)
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityAlwaysColumn);

            migrationBuilder.AlterColumn<int>(
                name: "room_number",
                table: "room",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityAlwaysColumn)
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn);

            migrationBuilder.AlterColumn<int>(
                name: "resident_id",
                table: "resident",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer")
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityAlwaysColumn)
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityAlwaysColumn);

            migrationBuilder.AlterColumn<int>(
                name: "resident_id",
                table: "rating_operation",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<int>(
                name: "category_id",
                table: "rating_operation",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<int>(
                name: "operation_id",
                table: "rating_operation",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer")
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityAlwaysColumn)
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityAlwaysColumn);

            migrationBuilder.AlterColumn<int>(
                name: "category_id",
                table: "rating_change_category",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer")
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityAlwaysColumn)
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityAlwaysColumn);

            migrationBuilder.AlterColumn<int>(
                name: "resident_id",
                table: "eviction_order",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<int>(
                name: "order_id",
                table: "eviction_order",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer")
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityAlwaysColumn)
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityAlwaysColumn);

            migrationBuilder.AlterColumn<int>(
                name: "passport_information_id",
                table: "passport_information",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer")
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityAlwaysColumn);

            migrationBuilder.AddPrimaryKey(
                name: "PK_passport_information",
                table: "passport_information",
                column: "passport_information_id");

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

            migrationBuilder.AddForeignKey(
                name: "FK_passport_information_resident_resident_id",
                table: "passport_information",
                column: "resident_id",
                principalTable: "resident",
                principalColumn: "resident_id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_passport_information_resident_resident_id",
                table: "passport_information");

            migrationBuilder.DropPrimaryKey(
                name: "PK_passport_information",
                table: "passport_information");

            migrationBuilder.RenameTable(
                name: "passport_information",
                newName: "PassportInformation");

            migrationBuilder.RenameIndex(
                name: "IX_passport_information_series_number",
                table: "PassportInformation",
                newName: "IX_PassportInformation_series_number");

            migrationBuilder.RenameIndex(
                name: "IX_passport_information_resident_id",
                table: "PassportInformation",
                newName: "IX_PassportInformation_resident_id");

            migrationBuilder.AlterColumn<int>(
                name: "resident_id",
                table: "transaction",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "operation_id",
                table: "transaction",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityAlwaysColumn)
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityAlwaysColumn);

            migrationBuilder.AlterColumn<int>(
                name: "resident_id",
                table: "settlement_order",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "order_id",
                table: "settlement_order",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityAlwaysColumn)
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityAlwaysColumn);

            migrationBuilder.AlterColumn<int>(
                name: "room_number",
                table: "room",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn)
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityAlwaysColumn);

            migrationBuilder.AlterColumn<int>(
                name: "resident_id",
                table: "resident",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityAlwaysColumn)
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityAlwaysColumn);

            migrationBuilder.AlterColumn<int>(
                name: "resident_id",
                table: "rating_operation",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "category_id",
                table: "rating_operation",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "operation_id",
                table: "rating_operation",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityAlwaysColumn)
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityAlwaysColumn);

            migrationBuilder.AlterColumn<int>(
                name: "category_id",
                table: "rating_change_category",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityAlwaysColumn)
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityAlwaysColumn);

            migrationBuilder.AlterColumn<int>(
                name: "resident_id",
                table: "eviction_order",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "order_id",
                table: "eviction_order",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityAlwaysColumn)
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityAlwaysColumn);

            migrationBuilder.AlterColumn<int>(
                name: "passport_information_id",
                table: "PassportInformation",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer")
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityAlwaysColumn)
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AddPrimaryKey(
                name: "PK_PassportInformation",
                table: "PassportInformation",
                column: "passport_information_id");

            migrationBuilder.UpdateData(
                table: "PassportInformation",
                keyColumn: "passport_information_id",
                keyValue: 1,
                column: "issue_date",
                value: new DateTime(2022, 5, 7, 21, 37, 37, 784, DateTimeKind.Utc).AddTicks(4600));

            migrationBuilder.UpdateData(
                table: "PassportInformation",
                keyColumn: "passport_information_id",
                keyValue: 2,
                column: "issue_date",
                value: new DateTime(2022, 5, 7, 21, 37, 37, 784, DateTimeKind.Utc).AddTicks(4602));

            migrationBuilder.UpdateData(
                table: "PassportInformation",
                keyColumn: "passport_information_id",
                keyValue: 3,
                column: "issue_date",
                value: new DateTime(2022, 5, 7, 21, 37, 37, 784, DateTimeKind.Utc).AddTicks(4603));

            migrationBuilder.UpdateData(
                table: "PassportInformation",
                keyColumn: "passport_information_id",
                keyValue: 4,
                column: "issue_date",
                value: new DateTime(2022, 5, 7, 21, 37, 37, 784, DateTimeKind.Utc).AddTicks(4604));

            migrationBuilder.UpdateData(
                table: "PassportInformation",
                keyColumn: "passport_information_id",
                keyValue: 5,
                column: "issue_date",
                value: new DateTime(2022, 5, 7, 21, 37, 37, 784, DateTimeKind.Utc).AddTicks(4605));

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

            migrationBuilder.AddForeignKey(
                name: "FK_PassportInformation_resident_resident_id",
                table: "PassportInformation",
                column: "resident_id",
                principalTable: "resident",
                principalColumn: "resident_id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
