using Microsoft.EntityFrameworkCore;
using PetShop.Database;
using System;
using System.Collections.Generic;
using System.IO;
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
                context.SaveChanges();
                context.Drzavas.Add(new Drzava { Naziv = "Hrvatska" });
                context.SaveChanges();
                context.Drzavas.Add(new Drzava { Naziv = "Srbija" });
                context.SaveChanges();
                context.Drzavas.Add(new Drzava { Naziv = "Slovenija" });
                context.SaveChanges();
            }

            if (!context.Grads.Any())
            {
                context.Grads.Add(new Grad { Naziv = "Sarajevo", DrzavaId = 1 });
                context.SaveChanges();
                context.Grads.Add(new Grad { Naziv = "Mostar", DrzavaId = 1 });
                context.SaveChanges();
                context.Grads.Add(new Grad { Naziv = "Zenica", DrzavaId = 1 });
                context.SaveChanges();
                context.Grads.Add(new Grad { Naziv = "Tuzla", DrzavaId = 1 });
                context.SaveChanges();
                context.Grads.Add(new Grad { Naziv = "Beograd", DrzavaId = 3 });
                context.SaveChanges();
                context.Grads.Add(new Grad { Naziv = "Zagreb", DrzavaId = 2 });
                context.SaveChanges();
                context.Grads.Add(new Grad { Naziv = "Ljubljana", DrzavaId = 4 });
                context.SaveChanges();
            }

            if (!context.Spols.Any())
            {
                context.Spols.Add(new Spol { Naziv = "Musko" });
                context.SaveChanges();
                context.Spols.Add(new Spol { Naziv = "Zensko" });
                context.SaveChanges();
            }

            if (!context.Rolas.Any())
            {
                context.Rolas.Add(new Rola { Naziv = "Administrator" });
                context.SaveChanges();
                context.Rolas.Add(new Rola { Naziv = "Uposlenik" });
                context.SaveChanges();
                context.Rolas.Add(new Rola { Naziv = "Korisnik" });
                context.SaveChanges();
            }

            if (!context.Korisniks.Any())
            {
                string passwordSalt = GenerateSalt();
                context.Korisniks.Add(new Korisnik { Ime = "Ajdin", Prezime = "Vreto", DatumRodjenja = DateTime.Now, Adresa = "Rukodol 7", Email = "ajdintotti5@gmail.com", GradId = 1, KorisnickoIme = "admin", SpolId = 1, PasswordSalt = passwordSalt, PasswordHash = GenerateHash(passwordSalt, "test") });
                context.SaveChanges();
                context.Korisniks.Add(new Korisnik { Ime = "John", Prezime = "Doe", DatumRodjenja = DateTime.Now, Adresa = "NY 1", Email = "john@gmail.com", GradId = 1, KorisnickoIme = "uposlenik", SpolId = 1, PasswordSalt = passwordSalt, PasswordHash = GenerateHash(passwordSalt, "test") });
                context.SaveChanges();
                context.Korisniks.Add(new Korisnik { Ime = "Tammy", Prezime = "Abraham", DatumRodjenja = DateTime.Now, Adresa = "Roma 22", Email = "tammy@gmail.com", GradId = 1, KorisnickoIme = "korisnik", SpolId = 1, PasswordSalt = passwordSalt, PasswordHash = GenerateHash(passwordSalt, "roma") });
                context.SaveChanges();
                context.Korisniks.Add(new Korisnik { Ime = "Admir", Prezime = "Vreto", DatumRodjenja = DateTime.Now, Adresa = "Rukdol 77", Email = "admir@gmail.com", GradId = 1, KorisnickoIme = "admirvreto", SpolId = 1, PasswordSalt = passwordSalt, PasswordHash = GenerateHash(passwordSalt, "test") });
                context.SaveChanges();
                context.Korisniks.Add(new Korisnik { Ime = "Samir", Prezime = "Sinanovic", DatumRodjenja = DateTime.Now, Adresa = "Zelenih beretki 213", Email = "samke@gmail.com", GradId = 2, KorisnickoIme = "samke", SpolId = 1, PasswordSalt = passwordSalt, PasswordHash = GenerateHash(passwordSalt, "test") });
                context.SaveChanges();
                context.Korisniks.Add(new Korisnik { Ime = "Tarik", Prezime = "Vreto", DatumRodjenja = DateTime.Now, Adresa = "Bistricki put 12", Email = "Tare@gmail.com", GradId = 3, KorisnickoIme = "tarikv", SpolId = 1, PasswordSalt = passwordSalt, PasswordHash = GenerateHash(passwordSalt, "test") });
                context.SaveChanges();
                context.Korisniks.Add(new Korisnik { Ime = "Edin", Prezime = "Dzeko", DatumRodjenja = DateTime.Now, Adresa = "Sarajevska 123", Email = "dzeko@hotmail.com", GradId = 1, KorisnickoIme = "edzeko", SpolId = 1, PasswordSalt = passwordSalt, PasswordHash = GenerateHash(passwordSalt, "test") });
                context.SaveChanges();
                context.Korisniks.Add(new Korisnik { Ime = "Lara", Prezime = "Croft", DatumRodjenja = DateTime.Now, Adresa = "142, Abbingdon Road", Email = "lara@gmail.com", GradId = 2, KorisnickoIme = "mobile", SpolId = 1, PasswordSalt = passwordSalt, PasswordHash = GenerateHash(passwordSalt, "test") });
                context.SaveChanges();
            }

            if (!context.KorisnikRolas.Any())
            {
                context.KorisnikRolas.Add(new KorisnikRola { KorisnikId = 1, RolaId = 1 });
                context.SaveChanges();
                context.KorisnikRolas.Add(new KorisnikRola { KorisnikId = 2, RolaId = 2 });
                context.SaveChanges();
                context.KorisnikRolas.Add(new KorisnikRola { KorisnikId = 3, RolaId = 3 });
                context.SaveChanges();
                context.KorisnikRolas.Add(new KorisnikRola { KorisnikId = 4, RolaId = 3 });
                context.SaveChanges();
                context.KorisnikRolas.Add(new KorisnikRola { KorisnikId = 5, RolaId = 3 });
                context.SaveChanges();
                context.KorisnikRolas.Add(new KorisnikRola { KorisnikId = 6, RolaId = 3 });
                context.SaveChanges();
                context.KorisnikRolas.Add(new KorisnikRola { KorisnikId = 7, RolaId = 3 });
                context.SaveChanges();
                context.KorisnikRolas.Add(new KorisnikRola { KorisnikId = 8, RolaId = 3 });
                context.SaveChanges();
            }

            if (!context.Kategorijas.Any())
            {
                context.Kategorijas.Add(new Kategorija { Naziv = "Hrana" });
                context.SaveChanges();
                context.Kategorijas.Add(new Kategorija { Naziv = "Igracke" });
                context.SaveChanges();
                context.Kategorijas.Add(new Kategorija { Naziv = "Odjeca" });
                context.SaveChanges();
                context.Kategorijas.Add(new Kategorija { Naziv = "Higijena" });
                context.SaveChanges();
                context.Kategorijas.Add(new Kategorija { Naziv = "Oprema" });
                context.SaveChanges();
            }

            if (!context.Proizvodjacs.Any())
            {
                context.Proizvodjacs.Add(new Proizvodjac { Naziv = "Whiskas", DrzavaId = 1 });
                context.SaveChanges();
                context.Proizvodjacs.Add(new Proizvodjac { Naziv = "Kras", DrzavaId = 2 });
                context.SaveChanges();
                context.Proizvodjacs.Add(new Proizvodjac { Naziv = "OASY", DrzavaId = 3 });
                context.SaveChanges();
                context.Proizvodjacs.Add(new Proizvodjac { Naziv = "Trixie", DrzavaId = 1 });
                context.SaveChanges();
                context.Proizvodjacs.Add(new Proizvodjac { Naziv = "Beaphar", DrzavaId = 1 });
                context.SaveChanges();
                context.Proizvodjacs.Add(new Proizvodjac { Naziv = "ErbaGatta", DrzavaId = 4 });
                context.SaveChanges();
            }

            if (!context.Novosts.Any())
            {
                context.Novosts.Add(new Novost { Naslov = "Nova snizenja u online trgovini", Datum = DateTime.Now, KorisnikId = 1, Tekst = "Postovani kupci, obavijestavamo vas da su u toku velika snizenja u nasoj online trgovini. Jedinstvena prilika da obradujete vase kucne ljubimce !", Slika = File.ReadAllBytes("Images/discountsnovost.jpg") });
                context.Novosts.Add(new Novost { Naslov = "Otvaranje nove poslovnice u Zenici", Datum = DateTime.Now, KorisnikId = 1, Tekst = "Postovani kupci, obavijestavamo vas da se narednog mjeseca otvara nasa nova trgovina u Zenici. Posjetite nas !", Slika = File.ReadAllBytes("Images/poslovnicanovost.jpg") });
                context.SaveChanges();
            }

            if (!context.Proizvods.Any())
            {
                context.Proizvods.Add(new Proizvod { Naziv = "Whiskas hrana za macke 150g", KategorijaId = 1, Opis = "Kompletna hrana za macke. Formulirana za zadovoljavanje povecanih prehrambenih potreba aktivnih macaka, ukljucujuci i gravidne mace.", Cijena = (decimal)4.90, ProizvodjacId = 1, Slika = File.ReadAllBytes("Images/whiskashranazamacke.jpg") });
                context.SaveChanges();
                context.Proizvods.Add(new Proizvod { Naziv = "Beaphar igracka za macke - Plisana ribica", KategorijaId = 2, Opis = "Odlicna plisana igracka za vasu macku.", Cijena = (decimal)6.00, ProizvodjacId = 5, Slika = File.ReadAllBytes("Images/beapharigrackazamacke.jpg") });
                context.SaveChanges();
                context.Proizvods.Add(new Proizvod { Naziv = "Kras hrana za pse 100g", KategorijaId = 1, Opis = "Kompletna hrana za pse. Formulirana za zadovoljavanje povecanih prehrambenih potreba aktivnih pasa, ukljucujuci i gravidne pse.", Cijena = (decimal)3.90, ProizvodjacId = 2, Slika = File.ReadAllBytes("Images/krashranazapse.jpg") });
                context.SaveChanges();
                context.Proizvods.Add(new Proizvod { Naziv = "Trixie dzemper za pse", KategorijaId = 3, Opis = "Veoma ugodan dzemper za vaseg najboljeg prijatelja.", Cijena = (decimal)9.00, ProizvodjacId = 4, Slika = File.ReadAllBytes("Images/trixiedzemperzapse.jpg") });
                context.SaveChanges();
                context.Proizvods.Add(new Proizvod { Naziv = "ErbaGatta hrana za ptice 50g", KategorijaId = 1, Opis = "Zdrava i sadrzajna hrana za vase ptice.", Cijena = (decimal)1.50, ProizvodjacId = 6, Slika = File.ReadAllBytes("Images/erbagattahranazaptice.jpg") });
                context.SaveChanges();
                context.Proizvods.Add(new Proizvod { Naziv = "OASY igracka za pse - Cuddle Ball", KategorijaId = 2, Opis = "Zive i izdrzljive, stvorene su za pse, pune energije, igracke aktivnog psa izradene su od mjesavine koja ih cini zabavnim za igru.", Cijena = (decimal)3.50, ProizvodjacId = 3, Slika = File.ReadAllBytes("Images/oasyigrackazapse.jpg") });
                context.SaveChanges();
                context.Proizvods.Add(new Proizvod { Naziv = "Whiskas hrana za pse 200g", KategorijaId = 1, Opis = "Idealno za pse s tendencijom prekomjerne tjelesne tezine, sadrzi smanjenu razinu masnoce", Cijena = (decimal)7.00, ProizvodjacId = 1, Slika = File.ReadAllBytes("Images/whiskashranazapse.jpg") });
                context.SaveChanges();
                context.Proizvods.Add(new Proizvod { Naziv = "OASY hrana za ptice 100g", KategorijaId = 1, Opis = "Vrhunska i sadrzajna hrana za vase ptice.", Cijena = (decimal)2.50, ProizvodjacId = 3, Slika = File.ReadAllBytes("Images/oasyhranazaptice.jpg") });
                context.SaveChanges();
                context.Proizvods.Add(new Proizvod { Naziv = "Beaphar Desinfektos spray za macke", KategorijaId = 4, Opis = "Brzo i ucinkovito uklanja 99,9% bakterija oko pasa i macaka. Takoder se pouzdano bori protiv virusa.", Cijena = (decimal)3.00, ProizvodjacId = 5, Slika = File.ReadAllBytes("Images/beapharsprayzamacke.jpg") });
                context.SaveChanges();
                context.Proizvods.Add(new Proizvod { Naziv = "Trixie hrana za ribe 30g", KategorijaId = 1, Opis = "Hrana u boji koja se sastoji od polako tonucih mekih granula.", Cijena = (decimal)1.50, ProizvodjacId = 4, Slika = File.ReadAllBytes("Images/trixiehranazaribe.jpg") });
                context.SaveChanges();
                context.Proizvods.Add(new Proizvod { Naziv = "Trixie hrana za pse 100g", KategorijaId = 1, Opis = "Trixie hrana je cjeloviti prehrambeni proizvod za odrasle pse sa normalnom tjelesnom aktivnoscu, sadrzi najbolje sastojke za zdravu i uravnotezenu prehranu: losos, tuna i riza osiguravaju pravi unos kalorija i proteina te visoku probavljivost.", Cijena = (decimal)5.00, ProizvodjacId = 4, Slika = File.ReadAllBytes("Images/trixiehranazapse.jpg") });
                context.SaveChanges();
                context.Proizvods.Add(new Proizvod { Naziv = "Kras hrana za macke 50g", KategorijaId = 1, Opis = "Kras hrana je cjeloviti prehrambeni proizvod za odrasle macke sa normalnom tjelesnom aktivnoscu, sadrzi najbolje sastojke za zdravu i uravnotezenu prehranu: losos, tuna i riza osiguravaju pravi unos kalorija i proteina te visoku probavljivost.", Cijena = (decimal)4.20, ProizvodjacId = 2, Slika = File.ReadAllBytes("Images/krashranazamacke.jpg") });
                context.SaveChanges();
                context.Proizvods.Add(new Proizvod { Naziv = "Beaphar sampon za pse", KategorijaId = 4, Opis = "Beaphar šampon posebno formuliran za sve vrste pasa za prekrasno hidratiziranu, super mekanu i sjajnu dlaku.", Cijena = (decimal)3.00, ProizvodjacId = 5, Slika = File.ReadAllBytes("Images/beapharsamponzapse.jpg") });
                context.SaveChanges();
                context.Proizvods.Add(new Proizvod { Naziv = "OASY lezaljka za macke", KategorijaId = 5, Opis = "Dizajniran kako bi upotpunio dekor vaše kuce, ovaj krevet nudi maksimalnu udobnost za Vašu macku.", Cijena = (decimal)12.00, ProizvodjacId = 3, Slika = File.ReadAllBytes("Images/oasylezaljkazamacke.jpg") });
                context.SaveChanges();
                context.Proizvods.Add(new Proizvod { Naziv = "ErbaGatta transporter", KategorijaId = 1, Opis = "Dimenzije 28,5 x 44 x 29,5 cm U nekoliko varijanti boja.", Cijena = (decimal)20.00, ProizvodjacId = 6, Slika = File.ReadAllBytes("Images/erbagattatransporterzamacke.jpg") });
                context.SaveChanges();
                context.Proizvods.Add(new Proizvod { Naziv = "OASY ogrlica za pse", KategorijaId = 5, Opis = "Ogrlica protiv parazita za pse s prirodnim sastojcima i podesivom duzinom.", Cijena = (decimal)3.00, ProizvodjacId = 3, Slika = File.ReadAllBytes("Images/oasyogrlicazapse.jpg") });
                context.SaveChanges();
                context.Proizvods.Add(new Proizvod { Naziv = "Kras Joint Sticks za pse", KategorijaId = 1, Opis = "Poslastica za zdrave zglobove i glatke pokrete Vaseg ljubimca. Potpuna hrana za pse je ukusna mesna poslastica.", Cijena = (decimal)1.20, ProizvodjacId = 2, Slika = File.ReadAllBytes("Images/krasjointstickszapse.jpg") });
                context.SaveChanges();
                context.Proizvods.Add(new Proizvod { Naziv = "Beaphar dzemper za macke", KategorijaId = 3, Opis = "Udoban i topao dzemper za vasu macku.", Cijena = (decimal)7.00, ProizvodjacId = 5, Slika = File.ReadAllBytes("Images/beaphardzemperzamacke.jpg") });
                context.SaveChanges();
                context.Proizvods.Add(new Proizvod { Naziv = "Beaphar gel za pse", KategorijaId = 4, Opis = "Beaphar gel za zube za pse 100g je brz i jednostavan nacin da svom ljubimcu osigurate dobru oralnu higijenu", Cijena = (decimal)6.20, ProizvodjacId = 5, Slika = File.ReadAllBytes("Images/beaphargelzapse.jpg") });
                context.SaveChanges();
                context.Proizvods.Add(new Proizvod { Naziv = "ErbaGatta povodac za macke", KategorijaId = 5, Opis = "Veoma kvalitetan i fleksibilan povodac za macke", Cijena = (decimal)2.50, ProizvodjacId = 6, Slika = File.ReadAllBytes("Images/erbagattapovodaczamacke.jpg") });
                context.SaveChanges();
            }

            if (!context.PopustKupons.Any())
            {
                context.PopustKupons.Add(new PopustKupon { Iznos = 10, Kod = "Discount" });
                context.PopustKupons.Add(new PopustKupon { Iznos = 20, Kod = "Dvadeset" });
                context.SaveChanges();
            }

            if (!context.Poslovnicas.Any())
            {
                context.Poslovnicas.Add(new Poslovnica { Adresa = "Edina Dzeke 9", GradId = 1, BrojTelefona = "044214123" });
                context.Poslovnicas.Add(new Poslovnica { Adresa = "Mostarska 123", GradId = 2, BrojTelefona = "066412367" });
                context.SaveChanges();
            }

            if (!context.Uposleniks.Any())
            {
                context.Uposleniks.Add(new Uposlenik { KorisnikId = 2, PoslovnicaId = 1, DatumZaposlenja = DateTime.Now, Aktivan = true });
                context.SaveChanges();
            }

            if (!context.Komentars.Any())
            {
                context.Komentars.Add(new Komentar { Datum = DateTime.Now, KorisnikId = 5, ProizvodId = 7, Tekst = "Odlican proizvod !" });
                context.SaveChanges();
                context.Komentars.Add(new Komentar { Datum = DateTime.Now, KorisnikId = 6, ProizvodId = 4, Tekst = "Svidja mi se ovaj proizvod !" });
                context.SaveChanges();
                context.Komentars.Add(new Komentar { Datum = DateTime.Now, KorisnikId = 5, ProizvodId = 5, Tekst = "Svidja mi se !" });
                context.SaveChanges();
                context.Komentars.Add(new Komentar { Datum = DateTime.Now, KorisnikId = 6, ProizvodId = 2, Tekst = "Vrhunski proizvod. Ponovo cu ga kupiti !" });
                context.SaveChanges();
                context.Komentars.Add(new Komentar { Datum = DateTime.Now, KorisnikId = 4, ProizvodId = 1, Tekst = "Pohvale za proizvod !" });
                context.SaveChanges();
                context.Komentars.Add(new Komentar { Datum = DateTime.Now, KorisnikId = 6, ProizvodId = 10, Tekst = "Nije nesto !" });
                context.SaveChanges();
                context.Komentars.Add(new Komentar { Datum = DateTime.Now, KorisnikId = 6, ProizvodId = 1, Tekst = "Kupujem ponovo. Odlicno !" });
                context.SaveChanges();
                context.Komentars.Add(new Komentar { Datum = DateTime.Now, KorisnikId = 5, ProizvodId = 2, Tekst = "Odlicno, sigurno cu ponovo kupiti !" });
                context.SaveChanges();
                context.Komentars.Add(new Komentar { Datum = DateTime.Now, KorisnikId = 6, ProizvodId = 3, Tekst = "Odlicno, sigurno cu ponovo kupiti. Sve pohvale !" });
                context.SaveChanges();
                context.Komentars.Add(new Komentar { Datum = DateTime.Now, KorisnikId = 5, ProizvodId = 6, Tekst = "Vrhunski proizvod !" });
                context.SaveChanges();
                context.Komentars.Add(new Komentar { Datum = DateTime.Now, KorisnikId = 4, ProizvodId = 11, Tekst = "Ma odlicno !" });
                context.SaveChanges();
                context.Komentars.Add(new Komentar { Datum = DateTime.Now, KorisnikId = 4, ProizvodId = 8, Tekst = "Sjajan proizvod !" });
                context.SaveChanges();
                context.Komentars.Add(new Komentar { Datum = DateTime.Now, KorisnikId = 4, ProizvodId = 12, Tekst = "nije lose " });
                context.SaveChanges();
                context.Komentars.Add(new Komentar { Datum = DateTime.Now, KorisnikId = 5, ProizvodId = 11, Tekst = "Preporuke za proizvod" });
                context.SaveChanges();
            }

            context.SaveChanges();

            if (!context.Recenzijas.Any())
            {
                context.Recenzijas.Add(new Recenzija { ProizvodId = 1, KorisnikId = 6, Ocjena = 5, Datum = DateTime.Now });
                context.SaveChanges();
                context.Recenzijas.Add(new Recenzija { ProizvodId = 1, KorisnikId = 5, Ocjena = 3, Datum = DateTime.Now });
                context.SaveChanges();
                context.Recenzijas.Add(new Recenzija { ProizvodId = 2, KorisnikId = 6, Ocjena = 5, Datum = DateTime.Now });
                context.SaveChanges();
                context.Recenzijas.Add(new Recenzija { ProizvodId = 3, KorisnikId = 6, Ocjena = 4, Datum = DateTime.Now });
                context.SaveChanges();
                context.Recenzijas.Add(new Recenzija { ProizvodId = 4, KorisnikId = 6, Ocjena = 4, Datum = DateTime.Now });
                context.SaveChanges();
                context.Recenzijas.Add(new Recenzija { ProizvodId = 5, KorisnikId = 6, Ocjena = 2, Datum = DateTime.Now });
                context.SaveChanges();
                context.Recenzijas.Add(new Recenzija { ProizvodId = 6, KorisnikId = 6, Ocjena = 4, Datum = DateTime.Now });
                context.SaveChanges();
                context.Recenzijas.Add(new Recenzija { ProizvodId = 7, KorisnikId = 6, Ocjena = 5, Datum = DateTime.Now });
                context.SaveChanges();
                context.Recenzijas.Add(new Recenzija { ProizvodId = 8, KorisnikId = 6, Ocjena = 4, Datum = DateTime.Now });
                context.SaveChanges();
                context.Recenzijas.Add(new Recenzija { ProizvodId = 9, KorisnikId = 6, Ocjena = 5, Datum = DateTime.Now });
                context.SaveChanges();
                context.Recenzijas.Add(new Recenzija { ProizvodId = 2, KorisnikId = 5, Ocjena = 5, Datum = DateTime.Now });
                context.SaveChanges();
                context.Recenzijas.Add(new Recenzija { ProizvodId = 3, KorisnikId = 4, Ocjena = 3, Datum = DateTime.Now });
                context.SaveChanges();
                context.Recenzijas.Add(new Recenzija { ProizvodId = 4, KorisnikId = 4, Ocjena = 2, Datum = DateTime.Now });
                context.SaveChanges();
                context.Recenzijas.Add(new Recenzija { ProizvodId = 10, KorisnikId = 5, Ocjena = 5, Datum = DateTime.Now });
                context.SaveChanges();
                context.Recenzijas.Add(new Recenzija { ProizvodId = 11, KorisnikId = 4, Ocjena = 4, Datum = DateTime.Now });
                context.SaveChanges();
                context.Recenzijas.Add(new Recenzija { ProizvodId = 8, KorisnikId = 4, Ocjena = 5, Datum = DateTime.Now });
                context.SaveChanges();
            }

            if (!context.Narudzbas.Any())
            {
                context.Narudzbas.Add(new Narudzba { KorisnikId = 4, Zavrsena = true, Aktivna = false, Datum = DateTime.Now });
                context.SaveChanges();
                context.Narudzbas.Add(new Narudzba { KorisnikId = 4, Zavrsena = true, Aktivna = false, Datum = DateTime.Now });
                context.SaveChanges();
                context.Narudzbas.Add(new Narudzba { KorisnikId = 4, Zavrsena = true, Aktivna = false, Datum = DateTime.Now });
                context.SaveChanges();
                context.Narudzbas.Add(new Narudzba { KorisnikId = 5, Zavrsena = true, Aktivna = false, Datum = DateTime.Now });
                context.SaveChanges();
                context.Narudzbas.Add(new Narudzba { KorisnikId = 5, Zavrsena = true, Aktivna = false, Datum = DateTime.Now });
                context.SaveChanges();
                context.Narudzbas.Add(new Narudzba { KorisnikId = 6, Zavrsena = true, Aktivna = false, Datum = DateTime.Now });
                context.SaveChanges();
            }

            if (!context.NarudzbaProizvods.Any())
            {
                context.NarudzbaProizvods.Add(new NarudzbaProizvod { NarudzbaId = 1, ProizvodId = 1, Kolicina = 2 });
                context.NarudzbaProizvods.Add(new NarudzbaProizvod { NarudzbaId = 1, ProizvodId = 2, Kolicina = 2 });
                context.NarudzbaProizvods.Add(new NarudzbaProizvod { NarudzbaId = 1, ProizvodId = 3, Kolicina = 2 });
                context.NarudzbaProizvods.Add(new NarudzbaProizvod { NarudzbaId = 2, ProizvodId = 5, Kolicina = 6 });
                context.NarudzbaProizvods.Add(new NarudzbaProizvod { NarudzbaId = 3, ProizvodId = 1, Kolicina = 3 });
                context.NarudzbaProizvods.Add(new NarudzbaProizvod { NarudzbaId = 4, ProizvodId = 7, Kolicina = 4 });
                context.NarudzbaProizvods.Add(new NarudzbaProizvod { NarudzbaId = 5, ProizvodId = 11, Kolicina = 1 });
                context.NarudzbaProizvods.Add(new NarudzbaProizvod { NarudzbaId = 5, ProizvodId = 1, Kolicina = 2 });
                context.NarudzbaProizvods.Add(new NarudzbaProizvod { NarudzbaId = 6, ProizvodId = 6, Kolicina = 1 });
            }

            if (!context.Transakcijas.Any())
            {
                context.Transakcijas.Add(new Transakcija { NarudzbaId = 1, NacinPlacanja = "Kartica", Datum = DateTime.Now, PopustKuponId = null, StripePaymentId = "paymentid", Iznos = (decimal)29.60 });
                context.SaveChanges();
                context.Transakcijas.Add(new Transakcija { NarudzbaId = 2, NacinPlacanja = "Kartica", Datum = DateTime.Now, PopustKuponId = null, StripePaymentId = "paymentid", Iznos = (decimal)9.00 });
                context.SaveChanges();
                context.Transakcijas.Add(new Transakcija { NarudzbaId = 3, NacinPlacanja = "Kartica", Datum = DateTime.Now, PopustKuponId = null, StripePaymentId = "paymentid", Iznos = (decimal)14.70 });
                context.SaveChanges();
                context.Transakcijas.Add(new Transakcija { NarudzbaId = 4, NacinPlacanja = "Kartica", Datum = DateTime.Now, PopustKuponId = null, StripePaymentId = "paymentid", Iznos = (decimal)28.00 });
                context.SaveChanges();
                context.Transakcijas.Add(new Transakcija { NarudzbaId = 5, NacinPlacanja = "Kartica", Datum = DateTime.Now, PopustKuponId = null, StripePaymentId = "paymentid", Iznos = (decimal)14.80 });
                context.SaveChanges();
                context.Transakcijas.Add(new Transakcija { NarudzbaId = 6, NacinPlacanja = "Kartica", Datum = DateTime.Now, PopustKuponId = null, StripePaymentId = "paymentid", Iznos = (decimal)3.50 });
                context.SaveChanges();
            }
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
