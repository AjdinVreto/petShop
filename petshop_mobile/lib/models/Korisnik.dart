import 'dart:convert';

class Korisnik {
  final int id;
  final String? ime;
  final String? prezime;
  final String? email;
  final String? korisnickoIme;
  final DateTime? datumRodjenja;
  final List<int>? slika;
  final int? gradId;
  final int? spolId;

  Korisnik(
      {required this.id,
        required this.ime,
        required this.prezime,
        required this.email,
        required this.korisnickoIme,
        required this.datumRodjenja,
        required this.slika,
        required this.gradId,
        required this.spolId,
      });

  factory Korisnik.fromJson(Map<String, dynamic> json) {
    return Korisnik(
        id: int.parse(json["id"].toString()),
        ime: json["ime"],
        prezime: json["prezime"],
        email: json["email"],
        korisnickoIme: json["korisnickoIme"],
        datumRodjenja: DateTime.tryParse(json['datumRodjenja']),
        gradId: int.parse(json["gradId"].toString()),
        spolId: int.parse(json["spolId"].toString()),
        slika: json["slika"] != null
            ? base64.decode(json['slika'] as String)
            : null);
  }

  Map<String, dynamic> toJson() => {
    "id": id,
    "ime": ime,
    "prezime": prezime,
    "email": email,
    "korisnickoIme": korisnickoIme,
    "datumRodjenja":
        datumRodjenja == null ? null : datumRodjenja!.toIso8601String(),
    "slika": slika,
    "gradId": gradId,
    "spolId": spolId,
  };
}
