
class NarudzbaProizvodUpdate {
  late final int? kolicina;

  NarudzbaProizvodUpdate(
      {
        required this.kolicina,
      });

  factory NarudzbaProizvodUpdate.fromJson(Map<String, dynamic> json) {
    return NarudzbaProizvodUpdate(
      kolicina: int.parse(json["kolicina"].toString()),
    );
  }

  Map<String, dynamic> toJson() => {
    "kolicina": kolicina,
  };
}
