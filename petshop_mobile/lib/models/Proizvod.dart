import 'dart:convert';

class Proizvod {
  final int id;
  final String? naziv;
  final double? cijena;
  final String? opis;
  final List<int>? slika;
  final int? kategorijaId;
  final int? proizvodjacId;

  Proizvod(
      {required this.id,
      required this.naziv,
      required this.cijena,
      required this.opis,
      required this.slika,
      required this.kategorijaId,
      required this.proizvodjacId,
   });

  factory Proizvod.fromJson(Map<String, dynamic> json) {
    return Proizvod(
        id: int.parse(json["id"].toString()),
        naziv: json["naziv"],
        cijena: json["cijena"],
        opis: json["opis"],
        kategorijaId: int.parse(json["kategorijaId"].toString()),
        proizvodjacId: int.parse(json["proizvodjacId"].toString()),
        slika: json["slika"] != null
            ? base64.decode(json['slika'] as String)
            : null);
  }

  Map<String, dynamic> toJson() => {
        "id": id,
        "naziv": naziv,
        "cijena": cijena,
        "opis": opis,
        "slika": slika,
        "kategorijaId": kategorijaId,
        "proizvodjacId": proizvodjacId,
      };
}
