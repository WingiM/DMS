using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace DMS.Migrations
{
    public partial class NewMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_eviction_order_resident_resident_id",
                table: "eviction_order");

            migrationBuilder.DropForeignKey(
                name: "FK_passport_information_resident_resident_id",
                table: "passport_information");

            migrationBuilder.DropForeignKey(
                name: "FK_rating_operation_rating_change_category_category_id",
                table: "rating_operation");

            migrationBuilder.DropForeignKey(
                name: "FK_rating_operation_resident_resident_id",
                table: "rating_operation");

            migrationBuilder.DropForeignKey(
                name: "FK_resident_room_room_number",
                table: "resident");

            migrationBuilder.DropForeignKey(
                name: "FK_settlement_order_resident_resident_id",
                table: "settlement_order");

            migrationBuilder.DropForeignKey(
                name: "FK_settlement_order_room_room_number",
                table: "settlement_order");

            migrationBuilder.DropForeignKey(
                name: "FK_transaction_resident_resident_id",
                table: "transaction");

            migrationBuilder.DropPrimaryKey(
                name: "PK_transaction",
                table: "transaction");

            migrationBuilder.DropPrimaryKey(
                name: "PK_settlement_order",
                table: "settlement_order");

            migrationBuilder.DropPrimaryKey(
                name: "PK_room",
                table: "room");

            migrationBuilder.DropPrimaryKey(
                name: "PK_resident",
                table: "resident");

            migrationBuilder.DropPrimaryKey(
                name: "PK_rating_operation",
                table: "rating_operation");

            migrationBuilder.DropPrimaryKey(
                name: "PK_rating_change_category",
                table: "rating_change_category");

            migrationBuilder.DropPrimaryKey(
                name: "PK_passport_information",
                table: "passport_information");

            migrationBuilder.DropPrimaryKey(
                name: "PK_eviction_order",
                table: "eviction_order");

            migrationBuilder.RenameIndex(
                name: "IX_transaction_resident_id",
                table: "transaction",
                newName: "ix_transaction_resident_id");

            migrationBuilder.RenameIndex(
                name: "IX_settlement_order_room_number",
                table: "settlement_order",
                newName: "ix_settlement_order_room_number");

            migrationBuilder.RenameIndex(
                name: "IX_settlement_order_resident_id",
                table: "settlement_order",
                newName: "ix_settlement_order_resident_id");

            migrationBuilder.RenameIndex(
                name: "IX_resident_tin",
                table: "resident",
                newName: "ix_resident_tin");

            migrationBuilder.RenameIndex(
                name: "IX_resident_room_number",
                table: "resident",
                newName: "ix_resident_room_number");

            migrationBuilder.RenameIndex(
                name: "IX_rating_operation_resident_id",
                table: "rating_operation",
                newName: "ix_rating_operation_resident_id");

            migrationBuilder.RenameIndex(
                name: "IX_rating_operation_category_id",
                table: "rating_operation",
                newName: "ix_rating_operation_category_id");

            migrationBuilder.RenameColumn(
                name: "series_number",
                table: "passport_information",
                newName: "series_and_number");

            migrationBuilder.RenameIndex(
                name: "IX_passport_information_resident_id",
                table: "passport_information",
                newName: "ix_passport_information_resident_id");

            migrationBuilder.RenameIndex(
                name: "IX_passport_information_series_number",
                table: "passport_information",
                newName: "ix_passport_information_series_and_number");

            migrationBuilder.RenameColumn(
                name: "order_id",
                table: "eviction_order",
                newName: "eviction_order_id");

            migrationBuilder.RenameIndex(
                name: "IX_eviction_order_resident_id",
                table: "eviction_order",
                newName: "ix_eviction_order_resident_id");

            migrationBuilder.AlterColumn<int>(
                name: "passport_information_id",
                table: "passport_information",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer")
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AlterColumn<int>(
                name: "eviction_order_id",
                table: "eviction_order",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityAlwaysColumn)
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityAlwaysColumn);

            migrationBuilder.AddPrimaryKey(
                name: "pk_transaction",
                table: "transaction",
                column: "transaction_id");

            migrationBuilder.AddPrimaryKey(
                name: "pk_settlement_order",
                table: "settlement_order",
                column: "order_id");

            migrationBuilder.AddPrimaryKey(
                name: "pk_room",
                table: "room",
                column: "room_number");

            migrationBuilder.AddPrimaryKey(
                name: "pk_resident",
                table: "resident",
                column: "resident_id");

            migrationBuilder.AddPrimaryKey(
                name: "pk_rating_operation",
                table: "rating_operation",
                column: "rating_operation_id");

            migrationBuilder.AddPrimaryKey(
                name: "pk_rating_change_category",
                table: "rating_change_category",
                column: "category_id");

            migrationBuilder.AddPrimaryKey(
                name: "pk_passport_information",
                table: "passport_information",
                columns: new[] { "resident_id", "passport_information_id" });

            migrationBuilder.AddPrimaryKey(
                name: "pk_eviction_order",
                table: "eviction_order",
                column: "eviction_order_id");

            migrationBuilder.AddForeignKey(
                name: "fk_eviction_order_resident_resident_id",
                table: "eviction_order",
                column: "resident_id",
                principalTable: "resident",
                principalColumn: "resident_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "fk_passport_information_resident_resident_id",
                table: "passport_information",
                column: "resident_id",
                principalTable: "resident",
                principalColumn: "resident_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "fk_rating_operation_rating_change_category_category_id",
                table: "rating_operation",
                column: "category_id",
                principalTable: "rating_change_category",
                principalColumn: "category_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "fk_rating_operation_resident_resident_id",
                table: "rating_operation",
                column: "resident_id",
                principalTable: "resident",
                principalColumn: "resident_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "fk_resident_room_room_number",
                table: "resident",
                column: "room_number",
                principalTable: "room",
                principalColumn: "room_number");

            migrationBuilder.AddForeignKey(
                name: "fk_settlement_order_resident_resident_id",
                table: "settlement_order",
                column: "resident_id",
                principalTable: "resident",
                principalColumn: "resident_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "fk_settlement_order_room_room_number",
                table: "settlement_order",
                column: "room_number",
                principalTable: "room",
                principalColumn: "room_number",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "fk_transaction_resident_resident_id",
                table: "transaction",
                column: "resident_id",
                principalTable: "resident",
                principalColumn: "resident_id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "fk_eviction_order_resident_resident_id",
                table: "eviction_order");

            migrationBuilder.DropForeignKey(
                name: "fk_passport_information_resident_resident_id",
                table: "passport_information");

            migrationBuilder.DropForeignKey(
                name: "fk_rating_operation_rating_change_category_category_id",
                table: "rating_operation");

            migrationBuilder.DropForeignKey(
                name: "fk_rating_operation_resident_resident_id",
                table: "rating_operation");

            migrationBuilder.DropForeignKey(
                name: "fk_resident_room_room_number",
                table: "resident");

            migrationBuilder.DropForeignKey(
                name: "fk_settlement_order_resident_resident_id",
                table: "settlement_order");

            migrationBuilder.DropForeignKey(
                name: "fk_settlement_order_room_room_number",
                table: "settlement_order");

            migrationBuilder.DropForeignKey(
                name: "fk_transaction_resident_resident_id",
                table: "transaction");

            migrationBuilder.DropPrimaryKey(
                name: "pk_transaction",
                table: "transaction");

            migrationBuilder.DropPrimaryKey(
                name: "pk_settlement_order",
                table: "settlement_order");

            migrationBuilder.DropPrimaryKey(
                name: "pk_room",
                table: "room");

            migrationBuilder.DropPrimaryKey(
                name: "pk_resident",
                table: "resident");

            migrationBuilder.DropPrimaryKey(
                name: "pk_rating_operation",
                table: "rating_operation");

            migrationBuilder.DropPrimaryKey(
                name: "pk_rating_change_category",
                table: "rating_change_category");

            migrationBuilder.DropPrimaryKey(
                name: "pk_passport_information",
                table: "passport_information");

            migrationBuilder.DropPrimaryKey(
                name: "pk_eviction_order",
                table: "eviction_order");

            migrationBuilder.RenameIndex(
                name: "ix_transaction_resident_id",
                table: "transaction",
                newName: "IX_transaction_resident_id");

            migrationBuilder.RenameIndex(
                name: "ix_settlement_order_room_number",
                table: "settlement_order",
                newName: "IX_settlement_order_room_number");

            migrationBuilder.RenameIndex(
                name: "ix_settlement_order_resident_id",
                table: "settlement_order",
                newName: "IX_settlement_order_resident_id");

            migrationBuilder.RenameIndex(
                name: "ix_resident_tin",
                table: "resident",
                newName: "IX_resident_tin");

            migrationBuilder.RenameIndex(
                name: "ix_resident_room_number",
                table: "resident",
                newName: "IX_resident_room_number");

            migrationBuilder.RenameIndex(
                name: "ix_rating_operation_resident_id",
                table: "rating_operation",
                newName: "IX_rating_operation_resident_id");

            migrationBuilder.RenameIndex(
                name: "ix_rating_operation_category_id",
                table: "rating_operation",
                newName: "IX_rating_operation_category_id");

            migrationBuilder.RenameColumn(
                name: "series_and_number",
                table: "passport_information",
                newName: "series_number");

            migrationBuilder.RenameIndex(
                name: "ix_passport_information_resident_id",
                table: "passport_information",
                newName: "IX_passport_information_resident_id");

            migrationBuilder.RenameIndex(
                name: "ix_passport_information_series_and_number",
                table: "passport_information",
                newName: "IX_passport_information_series_number");

            migrationBuilder.RenameColumn(
                name: "eviction_order_id",
                table: "eviction_order",
                newName: "order_id");

            migrationBuilder.RenameIndex(
                name: "ix_eviction_order_resident_id",
                table: "eviction_order",
                newName: "IX_eviction_order_resident_id");

            migrationBuilder.AlterColumn<int>(
                name: "passport_information_id",
                table: "passport_information",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer")
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AlterColumn<int>(
                name: "order_id",
                table: "eviction_order",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer")
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityAlwaysColumn)
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityAlwaysColumn);

            migrationBuilder.AddPrimaryKey(
                name: "PK_transaction",
                table: "transaction",
                column: "transaction_id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_settlement_order",
                table: "settlement_order",
                column: "order_id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_room",
                table: "room",
                column: "room_number");

            migrationBuilder.AddPrimaryKey(
                name: "PK_resident",
                table: "resident",
                column: "resident_id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_rating_operation",
                table: "rating_operation",
                column: "rating_operation_id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_rating_change_category",
                table: "rating_change_category",
                column: "category_id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_passport_information",
                table: "passport_information",
                column: "passport_information_id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_eviction_order",
                table: "eviction_order",
                column: "order_id");

            migrationBuilder.AddForeignKey(
                name: "FK_eviction_order_resident_resident_id",
                table: "eviction_order",
                column: "resident_id",
                principalTable: "resident",
                principalColumn: "resident_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_passport_information_resident_resident_id",
                table: "passport_information",
                column: "resident_id",
                principalTable: "resident",
                principalColumn: "resident_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_rating_operation_rating_change_category_category_id",
                table: "rating_operation",
                column: "category_id",
                principalTable: "rating_change_category",
                principalColumn: "category_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_rating_operation_resident_resident_id",
                table: "rating_operation",
                column: "resident_id",
                principalTable: "resident",
                principalColumn: "resident_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_resident_room_room_number",
                table: "resident",
                column: "room_number",
                principalTable: "room",
                principalColumn: "room_number");

            migrationBuilder.AddForeignKey(
                name: "FK_settlement_order_resident_resident_id",
                table: "settlement_order",
                column: "resident_id",
                principalTable: "resident",
                principalColumn: "resident_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_settlement_order_room_room_number",
                table: "settlement_order",
                column: "room_number",
                principalTable: "room",
                principalColumn: "room_number",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_transaction_resident_resident_id",
                table: "transaction",
                column: "resident_id",
                principalTable: "resident",
                principalColumn: "resident_id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
