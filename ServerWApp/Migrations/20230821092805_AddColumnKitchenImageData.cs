using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ServerWApp.Migrations
{
    /// <inheritdoc />
    public partial class AddColumnKitchenImageData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Images2",
                table: "Kitchens");

            migrationBuilder.DropColumn(
                name: "İmages",
                table: "Kitchens");

            migrationBuilder.AddColumn<byte[]>(
                name: "ImageData",
                table: "Kitchens",
                type: "varbinary(max)",
                nullable: false,
                defaultValue: new byte[0]);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageData",
                table: "Kitchens");

            migrationBuilder.AddColumn<string>(
                name: "Images2",
                table: "Kitchens",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "İmages",
                table: "Kitchens",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
