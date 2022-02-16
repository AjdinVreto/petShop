class Kontakt {
  final int? id;
  final String? ime;
  final String? email;
  final String? tekst;
  final bool? odgovoreno;
  final int? korisnikId;

  Kontakt({
    required this.id,
    required this.ime,
    required this.email,
    required this.tekst,
    required this.odgovoreno,
    required this.korisnikId,
  });

  factory Kontakt.fromJson(Map<String, dynamic> json) {
    return Kontakt(
      id: int.parse(json["id"].toString()),
      ime: json["imePrezime"],
      email: json["email"],
      tekst: json["tekst"],
      odgovoreno: json["odgovoreno"],
      korisnikId: int.parse(json["korisnikId"]),
    );
  }

  Map<String, dynamic> toJson() => {
        "id": id,
        "ime": ime,
        "email": email,
        "tekst": tekst,
        "odgovoreno": odgovoreno,
        "korisnikId": korisnikId,
      };
}
