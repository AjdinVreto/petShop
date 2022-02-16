using Microsoft.EntityFrameworkCore;
using PetShop.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace PetShop
{
    public class SetupService
    {
        public void Init(PetShopContext context)
        {
            context.Database.Migrate();

            if (!context.Drzavas.Any())
            {
                context.Drzavas.Add(new Drzava { Naziv = "Bosna i Hercegovina" });
            }

            if (!context.Grads.Any())
            {
                context.Grads.Add(new Grad { Naziv = "Sarajevo", DrzavaId = 1 });
            }

            if (!context.Spols.Any())
            {
                context.Spols.Add(new Spol { Naziv = "Musko" });
                context.Spols.Add(new Spol { Naziv = "Zensko" });
            }

            if (!context.Rolas.Any())
            {
                context.Rolas.Add(new Rola { Naziv = "Administrator" });
                context.Rolas.Add(new Rola { Naziv = "Uposlenik" });
                context.Rolas.Add(new Rola { Naziv = "Korisnik" });
            }

            context.SaveChanges();

            if (!context.Korisniks.Any())
            {
                string passwordSalt = GenerateSalt();
                context.Korisniks.Add(new Korisnik { Ime = "Ajdin", Prezime = "Vreto", DatumRodjenja = DateTime.Now, Adresa = "Rukodol 7", Email = "ajdintotti5@gmail.com", GradId = 1, KorisnickoIme = "admin", SpolId = 1, PasswordSalt = passwordSalt, PasswordHash = GenerateHash(passwordSalt, "test")});
                context.Korisniks.Add(new Korisnik { Ime = "John", Prezime = "Doe", DatumRodjenja = DateTime.Now, Adresa = "NY 1", Email = "john@gmail.com", GradId = 1, KorisnickoIme = "uposlenik", SpolId = 1, PasswordSalt = passwordSalt, PasswordHash = GenerateHash(passwordSalt, "test") });
                context.Korisniks.Add(new Korisnik { Ime = "Tammy", Prezime = "Abraham", DatumRodjenja = DateTime.Now, Adresa = "Roma 22", Email = "tammy@gmail.com", GradId = 1, KorisnickoIme = "korisnik", SpolId = 1, PasswordSalt = passwordSalt, PasswordHash = GenerateHash(passwordSalt, "roma") });
            }

            if (!context.KorisnikRolas.Any())
            {
                context.KorisnikRolas.Add(new KorisnikRola { KorisnikId = 3, RolaId = 1 });
                context.KorisnikRolas.Add(new KorisnikRola { KorisnikId = 2, RolaId = 2 });
                context.KorisnikRolas.Add(new KorisnikRola { KorisnikId = 1, RolaId = 3 });
            }

            context.SaveChanges();

            if (!context.Kategorijas.Any())
            {
                context.Kategorijas.Add(new Kategorija { Naziv = "Hrana" });
            }

            if (!context.Proizvodjacs.Any())
            {
                context.Proizvodjacs.Add(new Proizvodjac { Naziv = "Whiskas", DrzavaId = 1 });
            }

            if (!context.Novosts.Any())
            {
                context.Novosts.Add(new Novost { Naslov = "Test naslov", Datum = DateTime.Now, KorisnikId = 1, Tekst = "Tekst novost test" });
            }

            context.SaveChanges();

            if (!context.Proizvods.Any())
            {
                context.Proizvods.Add(new Proizvod { Naziv = "Hrana za macke", KategorijaId = 1, Opis = "Odlicna hrana", Cijena = (decimal)1.20, ProizvodjacId = 1});
            }

            if (!context.PopustKupons.Any())
            {
                context.PopustKupons.Add(new PopustKupon { Iznos = 10, Kod = "Discount" });
            }

            if (!context.Poslovnicas.Any())
            {
                context.Poslovnicas.Add(new Poslovnica { Adresa = "Rukodol 7", GradId = 1, BrojTelefona = "044214123" });
            }

            context.SaveChanges();

            if (!context.Uposleniks.Any())
            {
                context.Uposleniks.Add(new Uposlenik { KorisnikId = 2, PoslovnicaId = 1, DatumZaposlenja = DateTime.Now, Aktivan = true });
            }

            if (!context.Narudzbas.Any())
            {
                context.Narudzbas.Add(new Narudzba { Aktivna = true, Zavrsena = false, Datum = DateTime.Now, KorisnikId = 3 });
            }

            context.SaveChanges();
        }

        public static string GenerateSalt()
        {
            var buf = new byte[16];
            (new RNGCryptoServiceProvider()).GetBytes(buf);
            return Convert.ToBase64String(buf);
        }

        public static string GenerateHash(string salt, string password)
        {
            byte[] src = Convert.FromBase64String(salt);
            byte[] bytes = Encoding.Unicode.GetBytes(password);
            byte[] dst = new byte[src.Length + bytes.Length];

            System.Buffer.BlockCopy(src, 0, dst, 0, src.Length);
            System.Buffer.BlockCopy(bytes, 0, dst, src.Length, bytes.Length);

            HashAlgorithm algorithm = HashAlgorithm.Create("SHA1");
            byte[] inArray = algorithm.ComputeHash(dst);
            return Convert.ToBase64String(inArray);
        }
    }
}
