import 'dart:convert';

import 'Proizvodjac.dart';

class Proizvod {
  final int id;
  final String? naziv;
  final double? cijena;
  final String? opis;
  final List<int>? slika;
  final int? kategorijaId;
  final int? proizvodjacId;
  final Proizvodjac? proizvodjac;
  final int? zivotinjaId;

  Proizvod({
    required this.id,
    required this.naziv,
    required this.cijena,
    required this.opis,
    required this.slika,
    required this.kategorijaId,
    required this.proizvodjacId,
    required this.proizvodjac,
    required this.zivotinjaId,
  });

  factory Proizvod.fromJson(Map<String, dynamic> json) {
    return Proizvod(
        id: int.parse(json["id"].toString()),
        naziv: json["naziv"],
        cijena: double.parse(json["cijena"].toString()),
        opis: json["opis"],
        kategorijaId: int.parse(json["kategorijaId"].toString()),
        proizvodjacId: int.parse(json["proizvodjacId"].toString()),
        proizvodjac: Proizvodjac.fromJson(json["proizvodjac"]),
        zivotinjaId: int.parse(json["zivotinjaId"].toString()),
        slika: json["slika"] != null
            ? base64.decode(json['slika'] as String)
            : null);
  }

  Map<String, dynamic> toJson() => {
        "id": id,
        "naziv": naziv,
        "cijena": cijena,
        "opis": opis,
        "slika": slika != null ? base64.encode(slika!) : slika,
        "kategorijaId": kategorijaId,
        "proizvodjacId": proizvodjacId,
        "zivotinjaId": zivotinjaId,
      };
}
