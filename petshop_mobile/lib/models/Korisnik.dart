import 'dart:convert';
import 'Grad.dart';
import 'Spol.dart';

class Korisnik {
  final int id;
  final String? ime;
  final String? prezime;
  final String? email;
  final String? adresa;
  final String? korisnickoIme;
  final String? password;
  final DateTime? datumRodjenja;
  final List<int>? slika;
  final int? gradId;
  final int? spolId;
  final Spol? spol;
  final Grad? grad;

  Korisnik(
      {required this.id,
        required this.ime,
        required this.prezime,
        required this.email,
        required this.adresa,
        required this.korisnickoIme,
        required this.password,
        required this.datumRodjenja,
        required this.slika,
        required this.gradId,
        required this.spolId,
        required this.spol,
        required this.grad,
      });

  factory Korisnik.fromJson(Map<String, dynamic> json) {
    return Korisnik(
        id: int.parse(json["id"].toString()),
        ime: json["ime"],
        prezime: json["prezime"],
        email: json["email"],
        adresa: json["adresa"],
        korisnickoIme: json["korisnickoIme"],
        datumRodjenja: DateTime.tryParse(json['datumRodjenja']),
        gradId: int.parse(json["gradId"].toString()),
        spolId: int.parse(json["spolId"].toString()),
        spol: Spol.fromJson(json["spol"]),
        grad: Grad.fromJson(json["grad"]),
        password: null,
        slika: json["slika"] != null
            ? base64.decode(json['slika'] as String)
            : null);
  }

  Map<String, dynamic> toJson() => {
    "id": id,
    "ime": ime,
    "prezime": prezime,
    "email": email,
    "adresa": adresa,
    "korisnickoIme": korisnickoIme,
    "datumRodjenja":
        datumRodjenja == null ? null : datumRodjenja!.toIso8601String(),
    "slika": slika,
    "gradId": gradId,
    "spolId": spolId,
    "spol": spol,
    "grad": grad,
    "password": password,
  };
}
