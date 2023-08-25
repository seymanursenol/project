using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ServerWApp.Migrations
{
    /// <inheritdoc />
    public partial class AddColumnRestorantAciklama : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "RestAciklama",
                table: "Restorants",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RestAciklama",
                table: "Restorants");
        }
    }
}
