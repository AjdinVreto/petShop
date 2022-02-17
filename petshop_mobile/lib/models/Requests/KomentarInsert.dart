
class KomentarInsert {
  final int? id;
  final String? tekst;
  final DateTime? datum;
  final int? korisnikId;
  final int? proizvodId;

  KomentarInsert({
    required this.id,
    required this.tekst,
    required this.datum,
    required this.korisnikId,
    required this.proizvodId,
  });

  factory KomentarInsert.fromJson(Map<String, dynamic> json) {
    return KomentarInsert(
      id: int.parse(json["id"].toString()),
      tekst: json["tekst"],
      datum: DateTime.tryParse(json['datum']),
      korisnikId: json["korisnikId"],
      proizvodId: json["proizvodId"],
    );
  }

  Map<String, dynamic> toJson() => {
    "id": id,
    "tekst": tekst,
    "datum": datum == null ? null : datum!.toIso8601String(),
    "proizvodId": proizvodId,
    "korisnikId": korisnikId,
  };
}
