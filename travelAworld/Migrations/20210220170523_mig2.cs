using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eRent.Migrations
{
    public partial class mig2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Drzava",
                columns: table => new
                {
                    DrzavaId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Naziv = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Drzava", x => x.DrzavaId);
                });

            migrationBuilder.CreateTable(
                name: "KategorijaNekretnina",
                columns: table => new
                {
                    KategorijaNekretninaId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Naziv = table.Column<string>(nullable: true),
                    Opis = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KategorijaNekretnina", x => x.KategorijaNekretninaId);
                });

            migrationBuilder.CreateTable(
                name: "Novost",
                columns: table => new
                {
                    NovostId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Datum = table.Column<DateTime>(nullable: false),
                    Naziv = table.Column<string>(nullable: true),
                    Opis = table.Column<string>(nullable: true),
                    Slika = table.Column<byte[]>(nullable: true),
                    UserId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Novost", x => x.NovostId);
                    table.ForeignKey(
                        name: "FK_Novost_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Ocjena",
                columns: table => new
                {
                    OcjenaId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    NekretninaId = table.Column<int>(nullable: false),
                    UserId = table.Column<int>(nullable: false),
                    Datum = table.Column<DateTime>(nullable: false),
                    Vrijednost = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ocjena", x => x.OcjenaId);
                    table.ForeignKey(
                        name: "FK_Ocjena_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Grad",
                columns: table => new
                {
                    GradId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Naziv = table.Column<string>(nullable: true),
                    DrzavaId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Grad", x => x.GradId);
                    table.ForeignKey(
                        name: "FK_Grad_Drzava_DrzavaId",
                        column: x => x.DrzavaId,
                        principalTable: "Drzava",
                        principalColumn: "DrzavaId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Pretplata",
                columns: table => new
                {
                    PretplataId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Datum = table.Column<DateTime>(nullable: false),
                    Status = table.Column<bool>(nullable: false),
                    UserId = table.Column<int>(nullable: false),
                    KategorijaNekretnineId = table.Column<int>(nullable: false),
                    KategorijaNekretninaId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pretplata", x => x.PretplataId);
                    table.ForeignKey(
                        name: "FK_Pretplata_KategorijaNekretnina_KategorijaNekretninaId",
                        column: x => x.KategorijaNekretninaId,
                        principalTable: "KategorijaNekretnina",
                        principalColumn: "KategorijaNekretninaId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Pretplata_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Notifikacija",
                columns: table => new
                {
                    NotifikacijaId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DatumSlanja = table.Column<DateTime>(nullable: false),
                    Status = table.Column<bool>(nullable: false),
                    NovostId = table.Column<int>(nullable: true),
                    UserId = table.Column<int>(nullable: false),
                    Naziv = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Notifikacija", x => x.NotifikacijaId);
                    table.ForeignKey(
                        name: "FK_Notifikacija_Novost_NovostId",
                        column: x => x.NovostId,
                        principalTable: "Novost",
                        principalColumn: "NovostId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Notifikacija_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateTable(
                name: "Nekretnina",
                columns: table => new
                {
                    NekretninaId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Naziv = table.Column<string>(nullable: true),
                    Opis = table.Column<string>(nullable: true),
                    KategorijaNekretnineId = table.Column<int>(nullable: false),
                    KategorijaNekretninaId = table.Column<int>(nullable: true),
                    LokacijaId = table.Column<int>(nullable: false),
                    Cijena = table.Column<decimal>(nullable: false),
                    GodinaIzgradnje = table.Column<int>(nullable: false),
                    Kvadratura = table.Column<float>(nullable: false),
                    BrojEtaza = table.Column<int>(nullable: false),
                    Sprat = table.Column<int>(nullable: false),
                    Grijanje = table.Column<string>(nullable: true),
                    PosjedujeLift = table.Column<bool>(nullable: false),
                    PosjedujeKlimu = table.Column<bool>(nullable: false),
                    UkljuceneRezije = table.Column<bool>(nullable: false),
                    Slika = table.Column<byte[]>(nullable: true),
                    SlikaThumb = table.Column<byte[]>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nekretnina", x => x.NekretninaId);
                    table.ForeignKey(
                        name: "FK_Nekretnina_KategorijaNekretnina_KategorijaNekretninaId",
                        column: x => x.KategorijaNekretninaId,
                        principalTable: "KategorijaNekretnina",
                        principalColumn: "KategorijaNekretninaId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Nekretnina_Lokacija_LokacijaId",
                        column: x => x.LokacijaId,
                        principalTable: "Lokacija",
                        principalColumn: "LokacijaId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Rezervacija",
                columns: table => new
                {
                    RezervacijaId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<int>(nullable: false),
                    NekretninaId = table.Column<int>(nullable: false),
                    DatumObilaska = table.Column<DateTime>(nullable: false),
                    DatumKreiranjaRezervacije = table.Column<DateTime>(nullable: false),
                    Napomena = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rezervacija", x => x.RezervacijaId);
                    table.ForeignKey(
                        name: "FK_Rezervacija_Nekretnina_NekretninaId",
                        column: x => x.NekretninaId,
                        principalTable: "Nekretnina",
                        principalColumn: "NekretninaId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Rezervacija_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Ugovor",
                columns: table => new
                {
                    UgovorId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    KlijentId = table.Column<int>(nullable: false),
                    KorisnikId = table.Column<int>(nullable: false),
                    NekretninaId = table.Column<int>(nullable: false),
                    PocetakKoristenja = table.Column<DateTime>(nullable: false),
                    KrajKoristenja = table.Column<DateTime>(nullable: false),
                    Cijena = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ugovor", x => x.UgovorId);
                    table.ForeignKey(
                        name: "FK_Ugovor_AspNetUsers_KlijentId",
                        column: x => x.KlijentId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Ugovor_AspNetUsers_KorisnikId",
                        column: x => x.KorisnikId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Ugovor_Nekretnina_NekretninaId",
                        column: x => x.NekretninaId,
                        principalTable: "Nekretnina",
                        principalColumn: "NekretninaId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Grad_DrzavaId",
                table: "Grad",
                column: "DrzavaId");

            migrationBuilder.CreateIndex(
                name: "IX_Lokacija_GradId",
                table: "Lokacija",
                column: "GradId");

            migrationBuilder.CreateIndex(
                name: "IX_Nekretnina_KategorijaNekretninaId",
                table: "Nekretnina",
                column: "KategorijaNekretninaId");

            migrationBuilder.CreateIndex(
                name: "IX_Nekretnina_LokacijaId",
                table: "Nekretnina",
                column: "LokacijaId");

            migrationBuilder.CreateIndex(
                name: "IX_Notifikacija_NovostId",
                table: "Notifikacija",
                column: "NovostId");

            migrationBuilder.CreateIndex(
                name: "IX_Notifikacija_UserId",
                table: "Notifikacija",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Novost_UserId",
                table: "Novost",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Ocjena_UserId",
                table: "Ocjena",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Pretplata_KategorijaNekretninaId",
                table: "Pretplata",
                column: "KategorijaNekretninaId");

            migrationBuilder.CreateIndex(
                name: "IX_Pretplata_UserId",
                table: "Pretplata",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Rezervacija_NekretninaId",
                table: "Rezervacija",
                column: "NekretninaId");

            migrationBuilder.CreateIndex(
                name: "IX_Rezervacija_UserId",
                table: "Rezervacija",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Ugovor_KlijentId",
                table: "Ugovor",
                column: "KlijentId");

            migrationBuilder.CreateIndex(
                name: "IX_Ugovor_KorisnikId",
                table: "Ugovor",
                column: "KorisnikId");

            migrationBuilder.CreateIndex(
                name: "IX_Ugovor_NekretninaId",
                table: "Ugovor",
                column: "NekretninaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Notifikacija");

            migrationBuilder.DropTable(
                name: "Ocjena");

            migrationBuilder.DropTable(
                name: "Pretplata");

            migrationBuilder.DropTable(
                name: "Rezervacija");

            migrationBuilder.DropTable(
                name: "Ugovor");

            migrationBuilder.DropTable(
                name: "Novost");

            migrationBuilder.DropTable(
                name: "Nekretnina");

            migrationBuilder.DropTable(
                name: "KategorijaNekretnina");

            migrationBuilder.DropTable(
                name: "Lokacija");

            migrationBuilder.DropTable(
                name: "Grad");

            migrationBuilder.DropTable(
                name: "Drzava");
        }
    }
}
