using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ServerWApp.Migrations
{
    /// <inheritdoc />
    public partial class TableUpdateProducts : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Aciklama",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "RestorantId",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Products_RestorantId",
                table: "Products",
                column: "RestorantId");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Restorants_RestorantId",
                table: "Products",
                column: "RestorantId",
                principalTable: "Restorants",
                principalColumn: "RestorantId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Restorants_RestorantId",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_RestorantId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Aciklama",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "RestorantId",
                table: "Products");
        }
    }
}
