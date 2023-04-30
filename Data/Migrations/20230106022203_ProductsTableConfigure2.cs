using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    public partial class ProductsTableConfigure2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_CATEGORIES_CategoryId",
                table: "Products");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Products",
                table: "Products");

            migrationBuilder.RenameTable(
                name: "Products",
                newName: "PRODUCTS");

            migrationBuilder.RenameIndex(
                name: "IX_Products_CategoryId",
                table: "PRODUCTS",
                newName: "IX_PRODUCTS_CategoryId");

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "PRODUCTS",
                type: "varchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<bool>(
                name: "Enabled",
                table: "PRODUCTS",
                type: "tinyint(1)",
                nullable: true,
                defaultValueSql: "1",
                oldClrType: typeof(bool),
                oldType: "tinyint(1)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "PRODUCTS",
                type: "varchar(250)",
                maxLength: 250,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PRODUCTS",
                table: "PRODUCTS",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_PRODUCTS_Title",
                table: "PRODUCTS",
                column: "Title",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_PRODUCTS_CATEGORIES_CategoryId",
                table: "PRODUCTS",
                column: "CategoryId",
                principalTable: "CATEGORIES",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PRODUCTS_CATEGORIES_CategoryId",
                table: "PRODUCTS");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PRODUCTS",
                table: "PRODUCTS");

            migrationBuilder.DropIndex(
                name: "IX_PRODUCTS_Title",
                table: "PRODUCTS");

            migrationBuilder.RenameTable(
                name: "PRODUCTS",
                newName: "Products");

            migrationBuilder.RenameIndex(
                name: "IX_PRODUCTS_CategoryId",
                table: "Products",
                newName: "IX_Products_CategoryId");

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Products",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(100)",
                oldMaxLength: 100)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<bool>(
                name: "Enabled",
                table: "Products",
                type: "tinyint(1)",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "tinyint(1)",
                oldNullable: true,
                oldDefaultValueSql: "1");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Products",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(250)",
                oldMaxLength: 250)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Products",
                table: "Products",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_CATEGORIES_CategoryId",
                table: "Products",
                column: "CategoryId",
                principalTable: "CATEGORIES",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
