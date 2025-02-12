using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Inventory.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class PK_as_int : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_InOuts_Storages_StorageId1",
                table: "InOuts");

            migrationBuilder.DropForeignKey(
                name: "FK_Storages_Products_ProductId1",
                table: "Storages");

            migrationBuilder.DropForeignKey(
                name: "FK_Warehouses_Storages_StorageId1",
                table: "Warehouses");

            migrationBuilder.DropIndex(
                name: "IX_Warehouses_StorageId1",
                table: "Warehouses");

            migrationBuilder.DropIndex(
                name: "IX_InOuts_StorageId1",
                table: "InOuts");

            migrationBuilder.DropColumn(
                name: "StorageId",
                table: "Warehouses");

            migrationBuilder.DropColumn(
                name: "StorageId1",
                table: "Warehouses");

            migrationBuilder.DropColumn(
                name: "StorageId1",
                table: "InOuts");

            migrationBuilder.RenameColumn(
                name: "ProductId1",
                table: "Storages",
                newName: "WarehouseId");

            migrationBuilder.RenameIndex(
                name: "IX_Storages_ProductId1",
                table: "Storages",
                newName: "IX_Storages_WarehouseId");

            migrationBuilder.AlterColumn<int>(
                name: "ProductId",
                table: "Storages",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "StorageId",
                table: "InOuts",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateIndex(
                name: "IX_Storages_ProductId",
                table: "Storages",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_InOuts_StorageId",
                table: "InOuts",
                column: "StorageId");

            migrationBuilder.AddForeignKey(
                name: "FK_InOuts_Storages_StorageId",
                table: "InOuts",
                column: "StorageId",
                principalTable: "Storages",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Storages_Products_ProductId",
                table: "Storages",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Storages_Warehouses_WarehouseId",
                table: "Storages",
                column: "WarehouseId",
                principalTable: "Warehouses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_InOuts_Storages_StorageId",
                table: "InOuts");

            migrationBuilder.DropForeignKey(
                name: "FK_Storages_Products_ProductId",
                table: "Storages");

            migrationBuilder.DropForeignKey(
                name: "FK_Storages_Warehouses_WarehouseId",
                table: "Storages");

            migrationBuilder.DropIndex(
                name: "IX_Storages_ProductId",
                table: "Storages");

            migrationBuilder.DropIndex(
                name: "IX_InOuts_StorageId",
                table: "InOuts");

            migrationBuilder.RenameColumn(
                name: "WarehouseId",
                table: "Storages",
                newName: "ProductId1");

            migrationBuilder.RenameIndex(
                name: "IX_Storages_WarehouseId",
                table: "Storages",
                newName: "IX_Storages_ProductId1");

            migrationBuilder.AddColumn<string>(
                name: "StorageId",
                table: "Warehouses",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "StorageId1",
                table: "Warehouses",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "ProductId",
                table: "Storages",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "StorageId",
                table: "InOuts",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "StorageId1",
                table: "InOuts",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Warehouses_StorageId1",
                table: "Warehouses",
                column: "StorageId1");

            migrationBuilder.CreateIndex(
                name: "IX_InOuts_StorageId1",
                table: "InOuts",
                column: "StorageId1");

            migrationBuilder.AddForeignKey(
                name: "FK_InOuts_Storages_StorageId1",
                table: "InOuts",
                column: "StorageId1",
                principalTable: "Storages",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Storages_Products_ProductId1",
                table: "Storages",
                column: "ProductId1",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Warehouses_Storages_StorageId1",
                table: "Warehouses",
                column: "StorageId1",
                principalTable: "Storages",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
