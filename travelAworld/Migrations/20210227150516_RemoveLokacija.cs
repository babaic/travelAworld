using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eRent.Migrations
{
    public partial class RemoveLokacija : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Nekretnina_Lokacija_LokacijaId",
                table: "Nekretnina");

            migrationBuilder.DropTable(
                name: "Lokacija");

            migrationBuilder.DropIndex(
                name: "IX_Nekretnina_LokacijaId",
                table: "Nekretnina");

            migrationBuilder.AddColumn<string>(
                name: "Adresa",
                table: "Nekretnina",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "GradId",
                table: "Nekretnina",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Nekretnina_GradId",
                table: "Nekretnina",
                column: "GradId");

            migrationBuilder.AddForeignKey(
                name: "FK_Nekretnina_Grad_GradId",
                table: "Nekretnina",
                column: "GradId",
                principalTable: "Grad",
                principalColumn: "GradId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Nekretnina_Grad_GradId",
                table: "Nekretnina");

            migrationBuilder.DropIndex(
                name: "IX_Nekretnina_GradId",
                table: "Nekretnina");

            migrationBuilder.DropColumn(
                name: "Adresa",
                table: "Nekretnina");

            migrationBuilder.DropColumn(
                name: "GradId",
                table: "Nekretnina");

            migrationBuilder.CreateTable(
                name: "Lokacija",
                columns: table => new
                {
                    LokacijaId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Adresa = table.Column<string>(nullable: true),
                    GradId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lokacija", x => x.LokacijaId);
                    table.ForeignKey(
                        name: "FK_Lokacija_Grad_GradId",
                        column: x => x.GradId,
                        principalTable: "Grad",
                        principalColumn: "GradId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Nekretnina_LokacijaId",
                table: "Nekretnina",
                column: "LokacijaId");

            migrationBuilder.CreateIndex(
                name: "IX_Lokacija_GradId",
                table: "Lokacija",
                column: "GradId");

            migrationBuilder.AddForeignKey(
                name: "FK_Nekretnina_Lokacija_LokacijaId",
                table: "Nekretnina",
                column: "LokacijaId",
                principalTable: "Lokacija",
                principalColumn: "LokacijaId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
