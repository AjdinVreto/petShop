
class NarudzbaProizvod {
  final int? narudzbaId;
  final int? proizvodId;
  final int? kolicina;

  NarudzbaProizvod(
      {
        required this.narudzbaId,
        required this.proizvodId,
        required this.kolicina,
      });

  factory NarudzbaProizvod.fromJson(Map<String, dynamic> json) {
    return NarudzbaProizvod(
      narudzbaId: int.parse(json["narudzbaId"].toString()),
      proizvodId: int.parse(json["proizvodId"].toString()),
      kolicina: int.parse(json["kolicina"].toString()),
    );
  }

  Map<String, dynamic> toJson() => {
    "narudzbaId": narudzbaId,
    "proizvodId": proizvodId,
    "kolicina": kolicina,
  };
}
