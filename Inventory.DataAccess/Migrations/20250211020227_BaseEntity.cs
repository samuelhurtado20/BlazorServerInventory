using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Inventory.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class BaseEntity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_InOuts_Storages_StorageId",
                table: "InOuts");

            migrationBuilder.DropForeignKey(
                name: "FK_Warehouses_Storages_StorageId",
                table: "Warehouses");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Warehouses",
                table: "Warehouses");

            migrationBuilder.DropIndex(
                name: "IX_Warehouses_StorageId",
                table: "Warehouses");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Storages",
                table: "Storages");

            migrationBuilder.DropPrimaryKey(
                name: "PK_InOuts",
                table: "InOuts");

            migrationBuilder.DropIndex(
                name: "IX_InOuts_StorageId",
                table: "InOuts");

            migrationBuilder.DropColumn(
                name: "WarehouseId",
                table: "Warehouses");

            migrationBuilder.DropColumn(
                name: "StorageId",
                table: "Storages");

            migrationBuilder.DropColumn(
                name: "InOutId",
                table: "InOuts");

            migrationBuilder.RenameColumn(
                name: "ProductId",
                table: "Products",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "CategoryId",
                table: "Categories",
                newName: "Id");

            migrationBuilder.AlterColumn<string>(
                name: "StorageId",
                table: "Warehouses",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Warehouses",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "StorageId1",
                table: "Warehouses",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Storages",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<string>(
                name: "StorageId",
                table: "InOuts",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "InOuts",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "StorageId1",
                table: "InOuts",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Warehouses",
                table: "Warehouses",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Storages",
                table: "Storages",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_InOuts",
                table: "InOuts",
                column: "Id");

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
                name: "FK_Warehouses_Storages_StorageId1",
                table: "Warehouses",
                column: "StorageId1",
                principalTable: "Storages",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_InOuts_Storages_StorageId1",
                table: "InOuts");

            migrationBuilder.DropForeignKey(
                name: "FK_Warehouses_Storages_StorageId1",
                table: "Warehouses");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Warehouses",
                table: "Warehouses");

            migrationBuilder.DropIndex(
                name: "IX_Warehouses_StorageId1",
                table: "Warehouses");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Storages",
                table: "Storages");

            migrationBuilder.DropPrimaryKey(
                name: "PK_InOuts",
                table: "InOuts");

            migrationBuilder.DropIndex(
                name: "IX_InOuts_StorageId1",
                table: "InOuts");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Warehouses");

            migrationBuilder.DropColumn(
                name: "StorageId1",
                table: "Warehouses");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Storages");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "InOuts");

            migrationBuilder.DropColumn(
                name: "StorageId1",
                table: "InOuts");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Products",
                newName: "ProductId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Categories",
                newName: "CategoryId");

            migrationBuilder.AlterColumn<string>(
                name: "StorageId",
                table: "Warehouses",
                type: "nvarchar(50)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<string>(
                name: "WarehouseId",
                table: "Warehouses",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "StorageId",
                table: "Storages",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "StorageId",
                table: "InOuts",
                type: "nvarchar(50)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<string>(
                name: "InOutId",
                table: "InOuts",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Warehouses",
                table: "Warehouses",
                column: "WarehouseId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Storages",
                table: "Storages",
                column: "StorageId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_InOuts",
                table: "InOuts",
                column: "InOutId");

            migrationBuilder.CreateIndex(
                name: "IX_Warehouses_StorageId",
                table: "Warehouses",
                column: "StorageId");

            migrationBuilder.CreateIndex(
                name: "IX_InOuts_StorageId",
                table: "InOuts",
                column: "StorageId");

            migrationBuilder.AddForeignKey(
                name: "FK_InOuts_Storages_StorageId",
                table: "InOuts",
                column: "StorageId",
                principalTable: "Storages",
                principalColumn: "StorageId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Warehouses_Storages_StorageId",
                table: "Warehouses",
                column: "StorageId",
                principalTable: "Storages",
                principalColumn: "StorageId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
