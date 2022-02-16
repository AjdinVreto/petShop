import 'dart:convert';

class KorisnikRegistracija {
  final String? ime;
  final String? prezime;
  final String? email;
  final String? adresa;
  final String? korisnickoIme;
  final String? password;
  final String? potvrdaPassword;
  final DateTime? datumRodjenja;
  final List<int>? slika;
  final int? gradId;
  final int? spolId;

  KorisnikRegistracija({
    required this.ime,
    required this.prezime,
    required this.email,
    required this.adresa,
    required this.korisnickoIme,
    required this.password,
    required this.potvrdaPassword,
    required this.datumRodjenja,
    required this.slika,
    required this.gradId,
    required this.spolId,
  });

  Map<String, dynamic> toJson() => {
        "ime": ime,
        "prezime": prezime,
        "email": email,
        "adresa": adresa,
        "korisnickoIme": korisnickoIme,
        "password": password,
        "potvrdaPassword": potvrdaPassword,
        "datumRodjenja":
            datumRodjenja == null ? null : datumRodjenja!.toIso8601String(),
        "slika": slika,
        "gradId": gradId,
        "spolId": spolId,
      };
}
