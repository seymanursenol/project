using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ServerWApp.Migrations
{
    /// <inheritdoc />
    public partial class AddColumnKitchenImageData2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageData",
                table: "Kitchens");

            migrationBuilder.AddColumn<string>(
                name: "Images",
                table: "Kitchens",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Images",
                table: "Kitchens");

            migrationBuilder.AddColumn<byte[]>(
                name: "ImageData",
                table: "Kitchens",
                type: "varbinary(max)",
                nullable: false,
                defaultValue: new byte[0]);
        }
    }
}
