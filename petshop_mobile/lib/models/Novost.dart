import 'dart:convert';

class Novost {
  final int id;
  final String? naslov;
  final String? tekst;
  final DateTime? datum;
  final List<int>? slika;
  final int? korisnikId;

  Novost(
      {required this.id,
        required this.naslov,
        required this.tekst,
        required this.datum,
        required this.slika,
        required this.korisnikId
      });

  factory Novost.fromJson(Map<String, dynamic> json) {
    return Novost(
      id: int.parse(json["id"].toString()),
      naslov: json["naslov"],
      tekst: json["tekst"],
      korisnikId: int.parse(json["korisnikId"].toString()),
      datum: DateTime.tryParse(json['datum']),
      slika: json["slika"] != null
            ? base64.decode(json['slika'] as String)
            : null
    );
  }

  Map<String, dynamic> toJson() => {
    "id": id,
    "naslov": naslov,
    "tekst": tekst,
    "korisnikId": korisnikId,
    "datum":
    datum == null ? null : datum!.toIso8601String(),
    "slika": slika,
  };
}
