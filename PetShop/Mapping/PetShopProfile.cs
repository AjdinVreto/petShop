using AutoMapper;
using PetShop.Model.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PetShop.Mapping
{
    public class PetShopProfile : Profile
    {
        public PetShopProfile()
        {
            CreateMap<Database.Drzava, Model.Drzava>();
            CreateMap<Database.Grad, Model.Grad>();
            CreateMap<Database.Kategorija, Model.Kategorija>();
            CreateMap<Database.Komentar, Model.Komentar>();
            CreateMap<Database.Kontakt, Model.Kontakt>();
            CreateMap<Database.Korisnik, Model.Korisnik>().ReverseMap();
            CreateMap<Database.KorisnikRola, Model.KorisnikRola>();
            CreateMap<Database.Narudzba, Model.Narudzba>();
            CreateMap<Database.NarudzbaProizvod, Model.NarudzbaProizvod>();
            CreateMap<Database.Novost, Model.Novost>();
            CreateMap<Database.PopustKupon, Model.PopustKupon>();
            CreateMap<Database.Poslovnica, Model.Poslovnica>();
            CreateMap<Database.Proizvod, Model.Proizvod>();
            CreateMap<Database.Proizvodjac, Model.Proizvodjac>();
            CreateMap<Database.Recenzija, Model.Recenzija>();
            CreateMap<Database.Rola, Model.Rola>();
            CreateMap<Database.Transkacija, Model.Transakcija>();
            CreateMap<Database.Uposlenik, Model.Uposlenik>();
            CreateMap<Database.Spol, Model.Spol>().ReverseMap();

            CreateMap<ProizvodInsertRequest, Database.Proizvod>();
            CreateMap<ProizvodUpdateRequest, Database.Proizvod>();
            CreateMap<KorisnikInsertRequest, Database.Korisnik>();
            CreateMap<KorisnikUpdateRequest, Database.Korisnik>();
            CreateMap<UposlenikInsertRequest, Database.Uposlenik>();
            CreateMap<UposlenikUpdateRequest, Database.Uposlenik>();
            CreateMap<KategorijaInsertRequest, Database.Kategorija>();
            CreateMap<ProizvodjacInsertRequest, Database.Proizvodjac>();
            CreateMap<KontaktUpdateRequest, Database.Kontakt>();
            CreateMap<PoslovnicaInsertRequest, Database.Poslovnica>();
            CreateMap<PoslovnicaUpdateRequest, Database.Poslovnica>();
            CreateMap<NovostInsertRequest, Database.Novost>();
            CreateMap<NovostUpdateRequest, Database.Novost>();
            CreateMap<NarudzbaInsertRequest, Database.Narudzba>();
            CreateMap<NarudzbaUpdateRequest, Database.Narudzba>();
            CreateMap<NarudzbaProizvodInsertRequest, Database.NarudzbaProizvod>();
            CreateMap<NarudzbaProizvodUpdateRequest, Database.NarudzbaProizvod>();
            CreateMap<KontaktInsertRequest, Database.Kontakt>();
            CreateMap<RecenzijaInsertRequest, Database.Recenzija>();
            CreateMap<RecenzijaUpdateRequest, Database.Recenzija>();
            CreateMap<KomentarInsertRequest, Database.Komentar>();
            CreateMap<KomentarUpdateRequest, Database.Komentar>();
        }
    }
}
