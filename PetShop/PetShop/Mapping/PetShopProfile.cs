﻿using AutoMapper;
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
            CreateMap<Database.Korisnik, Model.Korisnik>();
            CreateMap<Database.KorisnikRola, Model.KorisnikRola>();
            CreateMap<Database.Narudzba, Model.Narudzba>();
            CreateMap<Database.NarudzbaProizvod, Model.NarudzbaProizvod>();
            CreateMap<Database.Novost, Model.Novost>();
            CreateMap<Database.Osoba, Model.Osoba>();
            CreateMap<Database.PopustKupon, Model.PopustKupon>();
            CreateMap<Database.Poslovnica, Model.Poslovnica>();
            CreateMap<Database.Proizvod, Model.Proizvod>();
            CreateMap<Database.Proizvodjac, Model.Proizvodjac>();
            CreateMap<Database.Recenzija, Model.Recenzija>();
            CreateMap<Database.Rola, Model.Rola>();
            CreateMap<Database.Slika, Model.Slika>();
            CreateMap<Database.Transkacija, Model.Transakcija>();
            CreateMap<Database.Uposlenik, Model.Uposlenik>();

            CreateMap<ProizvodInsertRequest, Database.Proizvod>();
            CreateMap<ProizvodUpdateRequest, Database.Proizvod>();
        }
    }
}
