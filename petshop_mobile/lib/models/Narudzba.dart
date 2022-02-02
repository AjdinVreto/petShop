
class Narudzba {
  final int id;
  final bool? aktivna;
  final bool? zavrsena;
  final DateTime? datum;
  final int? korisnikId;

  Narudzba(
      {required this.id,
        required this.aktivna,
        required this.zavrsena,
        required this.datum,
        required this.korisnikId,
      });

  factory Narudzba.fromJson(Map<String, dynamic> json) {
    return Narudzba(
        id: int.parse(json["id"].toString()),
        aktivna: json["aktivna"],
        zavrsena: json["zavrsena"],
        datum: DateTime.tryParse(json['datum']),
        korisnikId: int.parse(json["korisnikId"].toString()),
        );
  }

  Map<String, dynamic> toJson() => {
    "id": id,
    "aktivna": aktivna,
    "zavrsena": zavrsena,
    "datum":
      datum == null ? null : datum!.toIso8601String(),
    "korisnikId": korisnikId,
  };
}
