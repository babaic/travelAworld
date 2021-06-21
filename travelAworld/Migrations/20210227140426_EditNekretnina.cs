using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eRent.Migrations
{
    public partial class EditNekretnina : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Slika",
                table: "Nekretnina");

            migrationBuilder.DropColumn(
                name: "SlikaThumb",
                table: "Nekretnina");

            migrationBuilder.CreateTable(
                name: "NekretninaSlike",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    NekretninaId = table.Column<int>(nullable: false),
                    SlikaUrl = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NekretninaSlike", x => x.Id);
                    table.ForeignKey(
                        name: "FK_NekretninaSlike_Nekretnina_NekretninaId",
                        column: x => x.NekretninaId,
                        principalTable: "Nekretnina",
                        principalColumn: "NekretninaId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_NekretninaSlike_NekretninaId",
                table: "NekretninaSlike",
                column: "NekretninaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "NekretninaSlike");

            migrationBuilder.AddColumn<byte[]>(
                name: "Slika",
                table: "Nekretnina",
                nullable: true);

            migrationBuilder.AddColumn<byte[]>(
                name: "SlikaThumb",
                table: "Nekretnina",
                nullable: true);
        }
    }
}
