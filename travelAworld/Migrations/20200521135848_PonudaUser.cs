using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace travelAworld.Migrations
{
    public partial class PonudaUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PonudaUser",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    PonudaId = table.Column<int>(nullable: false),
                    UserId = table.Column<int>(nullable: false),
                    Cijena = table.Column<double>(nullable: false),
                    TransakcijaId = table.Column<string>(nullable: true),
                    VrijemePlacanja = table.Column<DateTime>(nullable: false),
                    TipSobe = table.Column<string>(nullable: true),
                    BrojOsoba = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PonudaUser", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PonudaUser_Ponuda_PonudaId",
                        column: x => x.PonudaId,
                        principalTable: "Ponuda",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PonudaUser_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PonudaUser_PonudaId",
                table: "PonudaUser",
                column: "PonudaId");

            migrationBuilder.CreateIndex(
                name: "IX_PonudaUser_UserId",
                table: "PonudaUser",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PonudaUser");
        }
    }
}
