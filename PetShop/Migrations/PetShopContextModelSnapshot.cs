﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PetShop.Database;

namespace PetShop.Migrations
{
    [DbContext(typeof(PetShopContext))]
    partial class PetShopContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.12")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("PetShop.Database.Drzava", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Naziv")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Drzava");
                });

            modelBuilder.Entity("PetShop.Database.Grad", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("DrzavaId")
                        .HasColumnType("int");

                    b.Property<string>("Naziv")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("DrzavaId");

                    b.ToTable("Grad");
                });

            modelBuilder.Entity("PetShop.Database.Kategorija", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Naziv")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Kategorija");
                });

            modelBuilder.Entity("PetShop.Database.Komentar", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Datum")
                        .HasColumnType("date");

                    b.Property<int>("KorisnikId")
                        .HasColumnType("int");

                    b.Property<int>("ProizvodId")
                        .HasColumnType("int");

                    b.Property<string>("Tekst")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("KorisnikId");

                    b.HasIndex("ProizvodId");

                    b.ToTable("Komentar");
                });

            modelBuilder.Entity("PetShop.Database.Kontakt", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImePrezime")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("KorisnikId")
                        .HasColumnType("int");

                    b.Property<bool>("Odgovoreno")
                        .HasColumnType("bit");

                    b.Property<string>("Tekst")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("KorisnikId");

                    b.ToTable("Kontakt");
                });

            modelBuilder.Entity("PetShop.Database.Korisnik", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DatumRodjenja")
                        .HasColumnType("date");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("GradId")
                        .HasColumnType("int");

                    b.Property<string>("Ime")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("KorisnickoIme")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PasswordSalt")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Prezime")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("Slika")
                        .HasColumnType("varbinary(max)");

                    b.Property<int>("SpolId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("GradId");

                    b.HasIndex("SpolId");

                    b.ToTable("Korisnik");
                });

            modelBuilder.Entity("PetShop.Database.KorisnikRola", b =>
                {
                    b.Property<int>("KorisnikId")
                        .HasColumnType("int");

                    b.Property<int>("RolaId")
                        .HasColumnType("int");

                    b.HasKey("KorisnikId", "RolaId");

                    b.HasIndex("RolaId");

                    b.ToTable("KorisnikRola");
                });

            modelBuilder.Entity("PetShop.Database.Narudzba", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Aktivna")
                        .HasColumnType("bit");

                    b.Property<DateTime>("Datum")
                        .HasColumnType("date");

                    b.Property<int>("KorisnikId")
                        .HasColumnType("int");

                    b.Property<bool>("Zavrsena")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("KorisnikId");

                    b.ToTable("Narudzba");
                });

            modelBuilder.Entity("PetShop.Database.NarudzbaProizvod", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Kolicina")
                        .HasColumnType("int");

                    b.Property<int>("NarudzbaId")
                        .HasColumnType("int");

                    b.Property<int>("ProizvodId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("NarudzbaId");

                    b.HasIndex("ProizvodId");

                    b.ToTable("NarudzbaProizvod");
                });

            modelBuilder.Entity("PetShop.Database.Novost", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Datum")
                        .HasColumnType("date");

                    b.Property<int>("KorisnikId")
                        .HasColumnType("int");

                    b.Property<string>("Naslov")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("Slika")
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("Tekst")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("KorisnikId");

                    b.ToTable("Novost");
                });

            modelBuilder.Entity("PetShop.Database.PopustKupon", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Iznos")
                        .HasColumnType("int");

                    b.Property<string>("Kod")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("PopustKupon");
                });

            modelBuilder.Entity("PetShop.Database.Poslovnica", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Adresa")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BrojTelefona")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("GradId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("GradId");

                    b.ToTable("Poslovnica");
                });

            modelBuilder.Entity("PetShop.Database.Proizvod", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("Cijena")
                        .HasColumnType("decimal(4,2)");

                    b.Property<int>("KategorijaId")
                        .HasColumnType("int");

                    b.Property<string>("Naziv")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Opis")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ProizvodjacId")
                        .HasColumnType("int");

                    b.Property<byte[]>("Slika")
                        .HasColumnType("varbinary(max)");

                    b.HasKey("Id");

                    b.HasIndex("KategorijaId");

                    b.HasIndex("ProizvodjacId");

                    b.ToTable("Proizvod");
                });

            modelBuilder.Entity("PetShop.Database.Proizvodjac", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("DrzavaId")
                        .HasColumnType("int");

                    b.Property<string>("Naziv")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("DrzavaId");

                    b.ToTable("Proizvodjac");
                });

            modelBuilder.Entity("PetShop.Database.Recenzija", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Datum")
                        .HasColumnType("date");

                    b.Property<int>("KorisnikId")
                        .HasColumnType("int");

                    b.Property<int>("Ocjena")
                        .HasColumnType("int");

                    b.Property<int>("ProizvodId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("KorisnikId");

                    b.HasIndex("ProizvodId");

                    b.ToTable("Recenzija");
                });

            modelBuilder.Entity("PetShop.Database.Rola", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Naziv")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Rola");
                });

            modelBuilder.Entity("PetShop.Database.Spol", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Naziv")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.HasKey("Id");

                    b.ToTable("Spol");
                });

            modelBuilder.Entity("PetShop.Database.Transkacija", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Datum")
                        .HasColumnType("date");

                    b.Property<decimal>("Iznos")
                        .HasColumnType("decimal(6,2)");

                    b.Property<string>("NacinPlacanja")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NarudzbaId")
                        .HasColumnType("int");

                    b.Property<int>("PopustKuponId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("NarudzbaId");

                    b.HasIndex("PopustKuponId");

                    b.ToTable("Transkacija");
                });

            modelBuilder.Entity("PetShop.Database.Uposlenik", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Aktivan")
                        .HasColumnType("bit");

                    b.Property<DateTime>("DatumZaposlenja")
                        .HasColumnType("date");

                    b.Property<int>("KorisnikId")
                        .HasColumnType("int");

                    b.Property<int>("PoslovnicaId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("KorisnikId");

                    b.HasIndex("PoslovnicaId");

                    b.ToTable("Uposlenik");
                });

            modelBuilder.Entity("PetShop.Database.Grad", b =>
                {
                    b.HasOne("PetShop.Database.Drzava", "Drzava")
                        .WithMany("Grads")
                        .HasForeignKey("DrzavaId")
                        .HasConstraintName("FK_Grad_Drzava")
                        .IsRequired();

                    b.Navigation("Drzava");
                });

            modelBuilder.Entity("PetShop.Database.Komentar", b =>
                {
                    b.HasOne("PetShop.Database.Korisnik", "Korisnik")
                        .WithMany("Komentars")
                        .HasForeignKey("KorisnikId")
                        .HasConstraintName("FK_Komentar_Korisnik")
                        .IsRequired();

                    b.HasOne("PetShop.Database.Proizvod", "Proizvod")
                        .WithMany("Komentars")
                        .HasForeignKey("ProizvodId")
                        .HasConstraintName("FK_Komentar_Proizvod")
                        .IsRequired();

                    b.Navigation("Korisnik");

                    b.Navigation("Proizvod");
                });

            modelBuilder.Entity("PetShop.Database.Kontakt", b =>
                {
                    b.HasOne("PetShop.Database.Korisnik", "Korisnik")
                        .WithMany("Kontakts")
                        .HasForeignKey("KorisnikId")
                        .HasConstraintName("FK_Kontakt_Korisnik")
                        .IsRequired();

                    b.Navigation("Korisnik");
                });

            modelBuilder.Entity("PetShop.Database.Korisnik", b =>
                {
                    b.HasOne("PetShop.Database.Grad", "Grad")
                        .WithMany("Korisniks")
                        .HasForeignKey("GradId")
                        .HasConstraintName("FK_Korisnik_Grad")
                        .IsRequired();

                    b.HasOne("PetShop.Database.Spol", "Spol")
                        .WithMany("Korisniks")
                        .HasForeignKey("SpolId")
                        .HasConstraintName("FK_Korisnik_Spol")
                        .IsRequired();

                    b.Navigation("Grad");

                    b.Navigation("Spol");
                });

            modelBuilder.Entity("PetShop.Database.KorisnikRola", b =>
                {
                    b.HasOne("PetShop.Database.Korisnik", "Korisnik")
                        .WithMany("KorisnikRolas")
                        .HasForeignKey("KorisnikId")
                        .HasConstraintName("PK_KorisnikRola_Korisnik")
                        .IsRequired();

                    b.HasOne("PetShop.Database.Rola", "Rola")
                        .WithMany("KorisnikRolas")
                        .HasForeignKey("RolaId")
                        .HasConstraintName("PK_KorisnikRola_Rola")
                        .IsRequired();

                    b.Navigation("Korisnik");

                    b.Navigation("Rola");
                });

            modelBuilder.Entity("PetShop.Database.Narudzba", b =>
                {
                    b.HasOne("PetShop.Database.Korisnik", "Korisnik")
                        .WithMany("Narudzbas")
                        .HasForeignKey("KorisnikId")
                        .HasConstraintName("FK_Narudzba_Korisnik")
                        .IsRequired();

                    b.Navigation("Korisnik");
                });

            modelBuilder.Entity("PetShop.Database.NarudzbaProizvod", b =>
                {
                    b.HasOne("PetShop.Database.Narudzba", "Narudzba")
                        .WithMany("NarudzbaProizvods")
                        .HasForeignKey("NarudzbaId")
                        .HasConstraintName("PK_NarudzbaProizvod_Narudzba")
                        .IsRequired();

                    b.HasOne("PetShop.Database.Proizvod", "Proizvod")
                        .WithMany("NarudzbaProizvods")
                        .HasForeignKey("ProizvodId")
                        .HasConstraintName("PK_NarudzbaProizvod_Proizvod")
                        .IsRequired();

                    b.Navigation("Narudzba");

                    b.Navigation("Proizvod");
                });

            modelBuilder.Entity("PetShop.Database.Novost", b =>
                {
                    b.HasOne("PetShop.Database.Korisnik", "Korisnik")
                        .WithMany("Novosts")
                        .HasForeignKey("KorisnikId")
                        .HasConstraintName("FK_Novost_Korisnik")
                        .IsRequired();

                    b.Navigation("Korisnik");
                });

            modelBuilder.Entity("PetShop.Database.Poslovnica", b =>
                {
                    b.HasOne("PetShop.Database.Grad", "Grad")
                        .WithMany("Poslovnicas")
                        .HasForeignKey("GradId")
                        .HasConstraintName("FK_Poslovnica_Grad")
                        .IsRequired();

                    b.Navigation("Grad");
                });

            modelBuilder.Entity("PetShop.Database.Proizvod", b =>
                {
                    b.HasOne("PetShop.Database.Kategorija", "Kategorija")
                        .WithMany("Proizvods")
                        .HasForeignKey("KategorijaId")
                        .HasConstraintName("FK_Proizvod_Kategorija")
                        .IsRequired();

                    b.HasOne("PetShop.Database.Proizvodjac", "Proizvodjac")
                        .WithMany("Proizvods")
                        .HasForeignKey("ProizvodjacId")
                        .HasConstraintName("FK_Proizvod_Proizvodjac")
                        .IsRequired();

                    b.Navigation("Kategorija");

                    b.Navigation("Proizvodjac");
                });

            modelBuilder.Entity("PetShop.Database.Proizvodjac", b =>
                {
                    b.HasOne("PetShop.Database.Drzava", "Drzava")
                        .WithMany("Proizvodjacs")
                        .HasForeignKey("DrzavaId")
                        .HasConstraintName("FK_Proizvodjac_Drzava")
                        .IsRequired();

                    b.Navigation("Drzava");
                });

            modelBuilder.Entity("PetShop.Database.Recenzija", b =>
                {
                    b.HasOne("PetShop.Database.Korisnik", "Korisnik")
                        .WithMany("Recenzijas")
                        .HasForeignKey("KorisnikId")
                        .HasConstraintName("FK_Recenzija_Korisnik")
                        .IsRequired();

                    b.HasOne("PetShop.Database.Proizvod", "Proizvod")
                        .WithMany("Recenzijas")
                        .HasForeignKey("ProizvodId")
                        .HasConstraintName("FK_Recenzija_Proizvod")
                        .IsRequired();

                    b.Navigation("Korisnik");

                    b.Navigation("Proizvod");
                });

            modelBuilder.Entity("PetShop.Database.Transkacija", b =>
                {
                    b.HasOne("PetShop.Database.Narudzba", "Narudzba")
                        .WithMany("Transkacijas")
                        .HasForeignKey("NarudzbaId")
                        .HasConstraintName("FK_Transakcija_Narudzba")
                        .IsRequired();

                    b.HasOne("PetShop.Database.PopustKupon", "PopustKupon")
                        .WithMany("Transkacijas")
                        .HasForeignKey("PopustKuponId")
                        .HasConstraintName("FK_Transkacija_PopustKupon")
                        .IsRequired();

                    b.Navigation("Narudzba");

                    b.Navigation("PopustKupon");
                });

            modelBuilder.Entity("PetShop.Database.Uposlenik", b =>
                {
                    b.HasOne("PetShop.Database.Korisnik", "Korisnik")
                        .WithMany("Uposleniks")
                        .HasForeignKey("KorisnikId")
                        .HasConstraintName("FK_Uposlenik_Korisnik")
                        .IsRequired();

                    b.HasOne("PetShop.Database.Poslovnica", "Poslovnica")
                        .WithMany("Uposleniks")
                        .HasForeignKey("PoslovnicaId")
                        .HasConstraintName("FK_Uposlenik_Poslovnica")
                        .IsRequired();

                    b.Navigation("Korisnik");

                    b.Navigation("Poslovnica");
                });

            modelBuilder.Entity("PetShop.Database.Drzava", b =>
                {
                    b.Navigation("Grads");

                    b.Navigation("Proizvodjacs");
                });

            modelBuilder.Entity("PetShop.Database.Grad", b =>
                {
                    b.Navigation("Korisniks");

                    b.Navigation("Poslovnicas");
                });

            modelBuilder.Entity("PetShop.Database.Kategorija", b =>
                {
                    b.Navigation("Proizvods");
                });

            modelBuilder.Entity("PetShop.Database.Korisnik", b =>
                {
                    b.Navigation("Komentars");

                    b.Navigation("Kontakts");

                    b.Navigation("KorisnikRolas");

                    b.Navigation("Narudzbas");

                    b.Navigation("Novosts");

                    b.Navigation("Recenzijas");

                    b.Navigation("Uposleniks");
                });

            modelBuilder.Entity("PetShop.Database.Narudzba", b =>
                {
                    b.Navigation("NarudzbaProizvods");

                    b.Navigation("Transkacijas");
                });

            modelBuilder.Entity("PetShop.Database.PopustKupon", b =>
                {
                    b.Navigation("Transkacijas");
                });

            modelBuilder.Entity("PetShop.Database.Poslovnica", b =>
                {
                    b.Navigation("Uposleniks");
                });

            modelBuilder.Entity("PetShop.Database.Proizvod", b =>
                {
                    b.Navigation("Komentars");

                    b.Navigation("NarudzbaProizvods");

                    b.Navigation("Recenzijas");
                });

            modelBuilder.Entity("PetShop.Database.Proizvodjac", b =>
                {
                    b.Navigation("Proizvods");
                });

            modelBuilder.Entity("PetShop.Database.Rola", b =>
                {
                    b.Navigation("KorisnikRolas");
                });

            modelBuilder.Entity("PetShop.Database.Spol", b =>
                {
                    b.Navigation("Korisniks");
                });
#pragma warning restore 612, 618
        }
    }
}
