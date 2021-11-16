﻿using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace PetShop.Database
{
    public partial class PetShopContext : DbContext
    {
        public PetShopContext()
        {
        }

        public PetShopContext(DbContextOptions<PetShopContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Drzava> Drzavas { get; set; }
        public virtual DbSet<Grad> Grads { get; set; }
        public virtual DbSet<Kategorija> Kategorijas { get; set; }
        public virtual DbSet<Komentar> Komentars { get; set; }
        public virtual DbSet<Kontakt> Kontakts { get; set; }
        public virtual DbSet<Korisnik> Korisniks { get; set; }
        public virtual DbSet<KorisnikRola> KorisnikRolas { get; set; }
        public virtual DbSet<Narudzba> Narudzbas { get; set; }
        public virtual DbSet<NarudzbaProizvod> NarudzbaProizvods { get; set; }
        public virtual DbSet<Novost> Novosts { get; set; }
        public virtual DbSet<Osoba> Osobas { get; set; }
        public virtual DbSet<PopustKupon> PopustKupons { get; set; }
        public virtual DbSet<Poslovnica> Poslovnicas { get; set; }
        public virtual DbSet<Proizvod> Proizvods { get; set; }
        public virtual DbSet<Proizvodjac> Proizvodjacs { get; set; }
        public virtual DbSet<Recenzija> Recenzijas { get; set; }
        public virtual DbSet<Rola> Rolas { get; set; }
        public virtual DbSet<Slika> Slikas { get; set; }
        public virtual DbSet<Transkacija> Transkacijas { get; set; }
        public virtual DbSet<Uposlenik> Uposleniks { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=localhost,1433;Initial Catalog=PetShop; user=sa; Password=Asroma11927");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Drzava>(entity =>
            {
                entity.ToTable("Drzava");

                entity.Property(e => e.Naziv).IsRequired();
            });

            modelBuilder.Entity<Grad>(entity =>
            {
                entity.ToTable("Grad");

                entity.Property(e => e.Naziv).IsRequired();

                entity.HasOne(d => d.Drzava)
                    .WithMany(p => p.Grads)
                    .HasForeignKey(d => d.DrzavaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Grad_Drzava");
            });

            modelBuilder.Entity<Kategorija>(entity =>
            {
                entity.ToTable("Kategorija");

                entity.Property(e => e.Naziv).IsRequired();
            });

            modelBuilder.Entity<Komentar>(entity =>
            {
                entity.ToTable("Komentar");

                entity.Property(e => e.Datum).HasColumnType("date");

                entity.Property(e => e.Tekst).IsRequired();

                entity.HasOne(d => d.Osoba)
                    .WithMany(p => p.Komentars)
                    .HasForeignKey(d => d.OsobaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Komentar_Osoba");

                entity.HasOne(d => d.Proizvod)
                    .WithMany(p => p.Komentars)
                    .HasForeignKey(d => d.ProizvodId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Komentar_Proizvod");
            });

            modelBuilder.Entity<Kontakt>(entity =>
            {
                entity.ToTable("Kontakt");

                entity.Property(e => e.Email).IsRequired();

                entity.Property(e => e.ImePrezime).IsRequired();

                entity.Property(e => e.Tekst).IsRequired();

                entity.HasOne(d => d.Osoba)
                    .WithMany(p => p.Kontakts)
                    .HasForeignKey(d => d.OsobaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Kontakt_Osoba");
            });

            modelBuilder.Entity<Korisnik>(entity =>
            {
                entity.ToTable("Korisnik");

                entity.Property(e => e.Email).IsRequired();

                entity.Property(e => e.KorisnickoIme).IsRequired();

                entity.Property(e => e.PasswordHash).IsRequired();

                entity.Property(e => e.PasswordSalt).IsRequired();

                entity.Property(e => e.Token).IsRequired();

                entity.HasOne(d => d.Osoba)
                    .WithMany(p => p.Korisniks)
                    .HasForeignKey(d => d.OsobaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Korisnik_Osoba");
            });

            modelBuilder.Entity<KorisnikRola>(entity =>
            {
                entity.HasKey(e => new { e.KorisnikId, e.RolaId });

                entity.ToTable("KorisnikRola");

                entity.HasOne(d => d.Korisnik)
                    .WithMany(p => p.KorisnikRolas)
                    .HasForeignKey(d => d.KorisnikId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("PK_KorisnikRola_Korisnik");

                entity.HasOne(d => d.Rola)
                    .WithMany(p => p.KorisnikRolas)
                    .HasForeignKey(d => d.RolaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("PK_KorisnikRola_Rola");
            });

            modelBuilder.Entity<Narudzba>(entity =>
            {
                entity.ToTable("Narudzba");

                entity.Property(e => e.Datum).HasColumnType("date");

                entity.HasOne(d => d.Osoba)
                    .WithMany(p => p.Narudzbas)
                    .HasForeignKey(d => d.OsobaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Narudzba_Osoba");
            });

            modelBuilder.Entity<NarudzbaProizvod>(entity =>
            {
                entity.HasKey(e => new { e.NarudzbaId, e.ProizvodId });

                entity.ToTable("NarudzbaProizvod");

                entity.HasOne(d => d.Narudzba)
                    .WithMany(p => p.NarudzbaProizvods)
                    .HasForeignKey(d => d.NarudzbaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("PK_NarudzbaProizvod_Narudzba");

                entity.HasOne(d => d.Proizvod)
                    .WithMany(p => p.NarudzbaProizvods)
                    .HasForeignKey(d => d.ProizvodId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("PK_NarudzbaProizvod_Proizvod");
            });

            modelBuilder.Entity<Novost>(entity =>
            {
                entity.ToTable("Novost");

                entity.Property(e => e.Datum).HasColumnType("date");

                entity.Property(e => e.Naslov).IsRequired();

                entity.Property(e => e.Tekst).IsRequired();

                entity.HasOne(d => d.Osoba)
                    .WithMany(p => p.Novosts)
                    .HasForeignKey(d => d.OsobaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Novost_Osoba");

                entity.HasOne(d => d.Slika)
                    .WithMany(p => p.Novosts)
                    .HasForeignKey(d => d.SlikaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Novost_Slika");
            });

            modelBuilder.Entity<Osoba>(entity =>
            {
                entity.ToTable("Osoba");

                entity.Property(e => e.DatumRodjenja).IsRequired();

                entity.Property(e => e.Ime).IsRequired();

                entity.Property(e => e.Jmbg)
                    .IsRequired()
                    .HasColumnName("JMBG");

                entity.Property(e => e.Prezime).IsRequired();

                entity.Property(e => e.Spol)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.HasOne(d => d.Grad)
                    .WithMany(p => p.Osobas)
                    .HasForeignKey(d => d.GradId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Osoba_Grad");
            });

            modelBuilder.Entity<PopustKupon>(entity =>
            {
                entity.ToTable("PopustKupon");

                entity.Property(e => e.Kod).IsRequired();
            });

            modelBuilder.Entity<Poslovnica>(entity =>
            {
                entity.ToTable("Poslovnica");

                entity.Property(e => e.Adresa).IsRequired();

                entity.Property(e => e.BrojTelefona).IsRequired();

                entity.HasOne(d => d.Grad)
                    .WithMany(p => p.Poslovnicas)
                    .HasForeignKey(d => d.GradId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Poslovnica_Grad");
            });

            modelBuilder.Entity<Proizvod>(entity =>
            {
                entity.ToTable("Proizvod");

                entity.Property(e => e.Cijena).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Naziv).IsRequired();

                entity.Property(e => e.Opis).IsRequired();

                entity.HasOne(d => d.Kategorija)
                    .WithMany(p => p.Proizvods)
                    .HasForeignKey(d => d.KategorijaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Proizvod_Kategorija");

                entity.HasOne(d => d.Proizvodjac)
                    .WithMany(p => p.Proizvods)
                    .HasForeignKey(d => d.ProizvodjacId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Proizvod_Proizvodjac");

                entity.HasOne(d => d.Slika)
                    .WithMany(p => p.Proizvods)
                    .HasForeignKey(d => d.SlikaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Proizvod_Slika");
            });

            modelBuilder.Entity<Proizvodjac>(entity =>
            {
                entity.ToTable("Proizvodjac");

                entity.Property(e => e.Naziv).IsRequired();

                entity.HasOne(d => d.Drzava)
                    .WithMany(p => p.Proizvodjacs)
                    .HasForeignKey(d => d.DrzavaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Proizvodjac_Drzava");
            });

            modelBuilder.Entity<Recenzija>(entity =>
            {
                entity.ToTable("Recenzija");

                entity.Property(e => e.Datum).HasColumnType("date");

                entity.HasOne(d => d.Osoba)
                    .WithMany(p => p.Recenzijas)
                    .HasForeignKey(d => d.OsobaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Recenzija_Osoba");

                entity.HasOne(d => d.Proizvod)
                    .WithMany(p => p.Recenzijas)
                    .HasForeignKey(d => d.ProizvodId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Recenzija_Proizvod");
            });

            modelBuilder.Entity<Rola>(entity =>
            {
                entity.ToTable("Rola");

                entity.Property(e => e.Naziv).IsRequired();
            });

            modelBuilder.Entity<Slika>(entity =>
            {
                entity.ToTable("Slika");

                entity.Property(e => e.Putanja).IsRequired();
            });

            modelBuilder.Entity<Transkacija>(entity =>
            {
                entity.ToTable("Transkacija");

                entity.Property(e => e.Datum).HasColumnType("date");

                entity.Property(e => e.Iznos).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.NacinPlacanja).IsRequired();

                entity.HasOne(d => d.Narudzba)
                    .WithMany(p => p.Transkacijas)
                    .HasForeignKey(d => d.NarudzbaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Transakcija_Narudzba");

                entity.HasOne(d => d.PopustKupon)
                    .WithMany(p => p.Transkacijas)
                    .HasForeignKey(d => d.PopustKuponId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Transkacija_PopustKupon");
            });

            modelBuilder.Entity<Uposlenik>(entity =>
            {
                entity.ToTable("Uposlenik");

                entity.Property(e => e.DatumZaposlenja).HasColumnType("date");

                entity.HasOne(d => d.Osoba)
                    .WithMany(p => p.Uposleniks)
                    .HasForeignKey(d => d.OsobaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Uposlenik_Osoba");

                entity.HasOne(d => d.Poslovnica)
                    .WithMany(p => p.Uposleniks)
                    .HasForeignKey(d => d.PoslovnicaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Uposlenik_Poslovnica");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
