class Recenzija {
  final int? id;
  final int? ocjena;
  final DateTime? datum;
  final int? korisnikId;
  final int? proizvodId;

  Recenzija({
    required this.id,
    required this.ocjena,
    required this.datum,
    required this.korisnikId,
    required this.proizvodId,
  });

  factory Recenzija.fromJson(Map<String, dynamic> json) {
    return Recenzija(
      id: int.parse(json["id"].toString()),
      ocjena: json["ocjena"],
      datum: DateTime.tryParse(json['datum']),
      korisnikId: int.parse(json["korisnikId"].toString()),
      proizvodId: int.parse(json["proizvodId"].toString()),
    );
  }

  Map<String, dynamic> toJson() => {
        "id": id,
        "ocjena": ocjena,
        "datum":
            datum == null ? null : datum!.toIso8601String(),
        "korisnikId": korisnikId,
        "proizvodId": proizvodId,
      };
}
