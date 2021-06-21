using Microsoft.EntityFrameworkCore.Migrations;

namespace eRent.Migrations
{
    public partial class editNekretninq : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "Nekretnina",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Nekretnina_UserId",
                table: "Nekretnina",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Nekretnina_AspNetUsers_UserId",
                table: "Nekretnina",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Nekretnina_AspNetUsers_UserId",
                table: "Nekretnina");

            migrationBuilder.DropIndex(
                name: "IX_Nekretnina_UserId",
                table: "Nekretnina");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Nekretnina");
        }
    }
}
