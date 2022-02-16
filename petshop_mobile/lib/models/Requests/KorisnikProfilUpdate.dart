import 'dart:convert';

class KorisnikProfilUpdate {
  final String? ime;
  final String? prezime;
  final String? adresa;
  final String? email;
  final String? korisnickoIme;
  final String? password;
  final DateTime? datumRodjenja;
  final int? spolId;
  final int? gradId;

  KorisnikProfilUpdate(
      {required this.ime,
      required this.prezime,
      required this.adresa,
      required this.email,
      required this.korisnickoIme,
      required this.password,
      required this.datumRodjenja,
      required this.spolId,
      required this.gradId});

  Map<String, dynamic> toJson() => {
        "ime": ime,
        "prezime": prezime,
        "adresa": adresa,
        "email": email,
        "korisnickoIme": korisnickoIme,
        "datumRodjenja":
            datumRodjenja == null ? null : datumRodjenja!.toIso8601String(),
        "password": password,
        "spolId": spolId,
        "gradiId": gradId,
      };
}
