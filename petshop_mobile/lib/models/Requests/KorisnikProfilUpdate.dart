import 'dart:convert';

class KorisnikProfilUpdate {
  final String? ime;
  final String? prezime;
  final String? email;
  final String? korisnickoIme;
  final DateTime? datumRodjenja;

  KorisnikProfilUpdate(
      {required this.ime,
      required this.prezime,
      required this.email,
      required this.korisnickoIme,
      required this.datumRodjenja});

  Map<String, dynamic> toJson() => {
        "ime": ime,
        "prezime": prezime,
        "email": email,
        "korisnickoIme": korisnickoIme,
        "datumRodjenja":
            datumRodjenja == null ? null : datumRodjenja!.toIso8601String(),
      };
}
