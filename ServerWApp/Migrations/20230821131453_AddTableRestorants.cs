using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ServerWApp.Migrations
{
    /// <inheritdoc />
    public partial class AddTableRestorants : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Restorants",
                columns: table => new
                {
                    RestorantId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RestorantName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RestorantAdres = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RestSahibiFullName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MyProperty = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RestSahibiEMail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RestSahibiPhone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KitchenId = table.Column<int>(type: "int", nullable: false),
                    KitchenName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Restorants", x => x.RestorantId);
                    table.ForeignKey(
                        name: "FK_Restorants_Kitchens_KitchenId",
                        column: x => x.KitchenId,
                        principalTable: "Kitchens",
                        principalColumn: "KitchenId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Restorants_KitchenId",
                table: "Restorants",
                column: "KitchenId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Restorants");
        }
    }
}
