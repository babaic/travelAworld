using Microsoft.EntityFrameworkCore.Migrations;

namespace travelAworld.Migrations
{
    public partial class AddKoordinate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Koordinata1",
                table: "Ponuda",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Koordinata2",
                table: "Ponuda",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Koordinata1",
                table: "Ponuda");

            migrationBuilder.DropColumn(
                name: "Koordinata2",
                table: "Ponuda");
        }
    }
}
