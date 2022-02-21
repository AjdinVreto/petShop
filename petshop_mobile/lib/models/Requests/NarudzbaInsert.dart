
class NarudzbaInsert {
  final bool? aktivna;
  final bool? zavrsena;
  final DateTime? datum;
  final int? korisnikId;

  NarudzbaInsert(
      {
        required this.aktivna,
        required this.zavrsena,
        required this.datum,
        required this.korisnikId,
      });

  factory NarudzbaInsert.fromJson(Map<String, dynamic> json) {
    return NarudzbaInsert(
      aktivna: json["aktivna"],
      zavrsena: json["zavrsena"],
      datum: DateTime.tryParse(json['datum']),
      korisnikId: int.parse(json["korisnikId"].toString()),
    );
  }

  Map<String, dynamic> toJson() => {
    "aktivna": aktivna,
    "zavrsena": zavrsena,
    "datum":
    datum == null ? null : datum!.toIso8601String(),
    "korisnikId": korisnikId,
  };
}
