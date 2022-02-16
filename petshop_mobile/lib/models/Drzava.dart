class Drzava {
  final int id;
  final String? naziv;

  Drzava({
    required this.id,
    required this.naziv,
  });

  factory Drzava.fromJson(Map<String, dynamic> json) {
    return Drzava(
      id: int.parse(json["id"].toString()),
      naziv: json["naziv"],
    );
  }

  Map<String, dynamic> toJson() => {
    "id": id,
    "naziv": naziv,
  };
}
