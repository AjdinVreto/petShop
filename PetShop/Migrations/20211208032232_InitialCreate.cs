using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PetShop.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Drzava",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Drzava", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Kategorija",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kategorija", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PopustKupon",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Iznos = table.Column<int>(type: "int", nullable: false),
                    Kod = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PopustKupon", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Rola",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rola", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Spol",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Spol", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Grad",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DrzavaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Grad", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Grad_Drzava",
                        column: x => x.DrzavaId,
                        principalTable: "Drzava",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Proizvodjac",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DrzavaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Proizvodjac", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Proizvodjac_Drzava",
                        column: x => x.DrzavaId,
                        principalTable: "Drzava",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Korisnik",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ime = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Prezime = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DatumRodjenja = table.Column<DateTime>(type: "date", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Slika = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    KorisnickoIme = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PasswordSalt = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GradId = table.Column<int>(type: "int", nullable: false),
                    SpolId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Korisnik", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Korisnik_Grad",
                        column: x => x.GradId,
                        principalTable: "Grad",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Korisnik_Spol",
                        column: x => x.SpolId,
                        principalTable: "Spol",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Poslovnica",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Adresa = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BrojTelefona = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GradId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Poslovnica", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Poslovnica_Grad",
                        column: x => x.GradId,
                        principalTable: "Grad",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Proizvod",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cijena = table.Column<decimal>(type: "decimal(4,2)", nullable: false),
                    Opis = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Slika = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    KategorijaId = table.Column<int>(type: "int", nullable: false),
                    ProizvodjacId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Proizvod", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Proizvod_Kategorija",
                        column: x => x.KategorijaId,
                        principalTable: "Kategorija",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Proizvod_Proizvodjac",
                        column: x => x.ProizvodjacId,
                        principalTable: "Proizvodjac",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Kontakt",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ImePrezime = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Tekst = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Odgovoreno = table.Column<bool>(type: "bit", nullable: false),
                    KorisnikId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kontakt", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Kontakt_Korisnik",
                        column: x => x.KorisnikId,
                        principalTable: "Korisnik",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "KorisnikRola",
                columns: table => new
                {
                    KorisnikId = table.Column<int>(type: "int", nullable: false),
                    RolaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KorisnikRola", x => new { x.KorisnikId, x.RolaId });
                    table.ForeignKey(
                        name: "PK_KorisnikRola_Korisnik",
                        column: x => x.KorisnikId,
                        principalTable: "Korisnik",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "PK_KorisnikRola_Rola",
                        column: x => x.RolaId,
                        principalTable: "Rola",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Narudzba",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Aktivna = table.Column<bool>(type: "bit", nullable: false),
                    Zavrsena = table.Column<bool>(type: "bit", nullable: false),
                    Datum = table.Column<DateTime>(type: "date", nullable: false),
                    KorisnikId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Narudzba", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Narudzba_Korisnik",
                        column: x => x.KorisnikId,
                        principalTable: "Korisnik",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Novost",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naslov = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Tekst = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Datum = table.Column<DateTime>(type: "date", nullable: false),
                    Slika = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    KorisnikId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Novost", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Novost_Korisnik",
                        column: x => x.KorisnikId,
                        principalTable: "Korisnik",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Uposlenik",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DatumZaposlenja = table.Column<DateTime>(type: "date", nullable: false),
                    Aktivan = table.Column<bool>(type: "bit", nullable: false),
                    KorisnikId = table.Column<int>(type: "int", nullable: false),
                    PoslovnicaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Uposlenik", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Uposlenik_Korisnik",
                        column: x => x.KorisnikId,
                        principalTable: "Korisnik",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Uposlenik_Poslovnica",
                        column: x => x.PoslovnicaId,
                        principalTable: "Poslovnica",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Komentar",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tekst = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Datum = table.Column<DateTime>(type: "date", nullable: false),
                    KorisnikId = table.Column<int>(type: "int", nullable: false),
                    ProizvodId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Komentar", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Komentar_Korisnik",
                        column: x => x.KorisnikId,
                        principalTable: "Korisnik",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Komentar_Proizvod",
                        column: x => x.ProizvodId,
                        principalTable: "Proizvod",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Recenzija",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ocjena = table.Column<int>(type: "int", nullable: false),
                    Datum = table.Column<DateTime>(type: "date", nullable: false),
                    KorisnikId = table.Column<int>(type: "int", nullable: false),
                    ProizvodId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Recenzija", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Recenzija_Korisnik",
                        column: x => x.KorisnikId,
                        principalTable: "Korisnik",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Recenzija_Proizvod",
                        column: x => x.ProizvodId,
                        principalTable: "Proizvod",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "NarudzbaProizvod",
                columns: table => new
                {
                    NarudzbaId = table.Column<int>(type: "int", nullable: false),
                    ProizvodId = table.Column<int>(type: "int", nullable: false),
                    Kolicina = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NarudzbaProizvod", x => new { x.NarudzbaId, x.ProizvodId });
                    table.ForeignKey(
                        name: "PK_NarudzbaProizvod_Narudzba",
                        column: x => x.NarudzbaId,
                        principalTable: "Narudzba",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "PK_NarudzbaProizvod_Proizvod",
                        column: x => x.ProizvodId,
                        principalTable: "Proizvod",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Transkacija",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Iznos = table.Column<decimal>(type: "decimal(6,2)", nullable: false),
                    NacinPlacanja = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Datum = table.Column<DateTime>(type: "date", nullable: false),
                    PopustKuponId = table.Column<int>(type: "int", nullable: false),
                    NarudzbaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transkacija", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Transakcija_Narudzba",
                        column: x => x.NarudzbaId,
                        principalTable: "Narudzba",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Transkacija_PopustKupon",
                        column: x => x.PopustKuponId,
                        principalTable: "PopustKupon",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Grad_DrzavaId",
                table: "Grad",
                column: "DrzavaId");

            migrationBuilder.CreateIndex(
                name: "IX_Komentar_KorisnikId",
                table: "Komentar",
                column: "KorisnikId");

            migrationBuilder.CreateIndex(
                name: "IX_Komentar_ProizvodId",
                table: "Komentar",
                column: "ProizvodId");

            migrationBuilder.CreateIndex(
                name: "IX_Kontakt_KorisnikId",
                table: "Kontakt",
                column: "KorisnikId");

            migrationBuilder.CreateIndex(
                name: "IX_Korisnik_GradId",
                table: "Korisnik",
                column: "GradId");

            migrationBuilder.CreateIndex(
                name: "IX_Korisnik_SpolId",
                table: "Korisnik",
                column: "SpolId");

            migrationBuilder.CreateIndex(
                name: "IX_KorisnikRola_RolaId",
                table: "KorisnikRola",
                column: "RolaId");

            migrationBuilder.CreateIndex(
                name: "IX_Narudzba_KorisnikId",
                table: "Narudzba",
                column: "KorisnikId");

            migrationBuilder.CreateIndex(
                name: "IX_NarudzbaProizvod_ProizvodId",
                table: "NarudzbaProizvod",
                column: "ProizvodId");

            migrationBuilder.CreateIndex(
                name: "IX_Novost_KorisnikId",
                table: "Novost",
                column: "KorisnikId");

            migrationBuilder.CreateIndex(
                name: "IX_Poslovnica_GradId",
                table: "Poslovnica",
                column: "GradId");

            migrationBuilder.CreateIndex(
                name: "IX_Proizvod_KategorijaId",
                table: "Proizvod",
                column: "KategorijaId");

            migrationBuilder.CreateIndex(
                name: "IX_Proizvod_ProizvodjacId",
                table: "Proizvod",
                column: "ProizvodjacId");

            migrationBuilder.CreateIndex(
                name: "IX_Proizvodjac_DrzavaId",
                table: "Proizvodjac",
                column: "DrzavaId");

            migrationBuilder.CreateIndex(
                name: "IX_Recenzija_KorisnikId",
                table: "Recenzija",
                column: "KorisnikId");

            migrationBuilder.CreateIndex(
                name: "IX_Recenzija_ProizvodId",
                table: "Recenzija",
                column: "ProizvodId");

            migrationBuilder.CreateIndex(
                name: "IX_Transkacija_NarudzbaId",
                table: "Transkacija",
                column: "NarudzbaId");

            migrationBuilder.CreateIndex(
                name: "IX_Transkacija_PopustKuponId",
                table: "Transkacija",
                column: "PopustKuponId");

            migrationBuilder.CreateIndex(
                name: "IX_Uposlenik_KorisnikId",
                table: "Uposlenik",
                column: "KorisnikId");

            migrationBuilder.CreateIndex(
                name: "IX_Uposlenik_PoslovnicaId",
                table: "Uposlenik",
                column: "PoslovnicaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Komentar");

            migrationBuilder.DropTable(
                name: "Kontakt");

            migrationBuilder.DropTable(
                name: "KorisnikRola");

            migrationBuilder.DropTable(
                name: "NarudzbaProizvod");

            migrationBuilder.DropTable(
                name: "Novost");

            migrationBuilder.DropTable(
                name: "Recenzija");

            migrationBuilder.DropTable(
                name: "Transkacija");

            migrationBuilder.DropTable(
                name: "Uposlenik");

            migrationBuilder.DropTable(
                name: "Rola");

            migrationBuilder.DropTable(
                name: "Proizvod");

            migrationBuilder.DropTable(
                name: "Narudzba");

            migrationBuilder.DropTable(
                name: "PopustKupon");

            migrationBuilder.DropTable(
                name: "Poslovnica");

            migrationBuilder.DropTable(
                name: "Kategorija");

            migrationBuilder.DropTable(
                name: "Proizvodjac");

            migrationBuilder.DropTable(
                name: "Korisnik");

            migrationBuilder.DropTable(
                name: "Grad");

            migrationBuilder.DropTable(
                name: "Spol");

            migrationBuilder.DropTable(
                name: "Drzava");
        }
    }
}
