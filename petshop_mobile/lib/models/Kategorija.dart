
class Kategorija {
  final int id;
  final String? naziv;

  Kategorija({
    required this.id,
    required this.naziv,
  });

  factory Kategorija.fromJson(Map<String, dynamic> json) {
    return Kategorija(
      id: int.parse(json["id"].toString()),
      naziv: json["naziv"],
    );
  }

  Map<String, dynamic> toJson() => {
        "id": id,
        "naziv": naziv,
      };
}
