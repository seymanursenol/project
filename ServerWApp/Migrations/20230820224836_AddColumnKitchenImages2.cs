using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ServerWApp.Migrations
{
    /// <inheritdoc />
    public partial class AddColumnKitchenImages2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Images2",
                table: "Kitchens",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Images2",
                table: "Kitchens");
        }
    }
}
