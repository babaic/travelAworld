using Microsoft.EntityFrameworkCore.Migrations;

namespace eRent.Migrations
{
    public partial class rezervacijeedit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Status",
                table: "Rezervacija",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ZaposlenikId",
                table: "Rezervacija",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Rezervacija_ZaposlenikId",
                table: "Rezervacija",
                column: "ZaposlenikId");

            migrationBuilder.AddForeignKey(
                name: "FK_Rezervacija_AspNetUsers_ZaposlenikId",
                table: "Rezervacija",
                column: "ZaposlenikId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Rezervacija_AspNetUsers_ZaposlenikId",
                table: "Rezervacija");

            migrationBuilder.DropIndex(
                name: "IX_Rezervacija_ZaposlenikId",
                table: "Rezervacija");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "Rezervacija");

            migrationBuilder.DropColumn(
                name: "ZaposlenikId",
                table: "Rezervacija");
        }
    }
}
