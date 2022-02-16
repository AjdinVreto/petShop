class Spol {
  final int id;
  final String? naziv;

  Spol({
    required this.id,
    required this.naziv,
  });

  factory Spol.fromJson(Map<String, dynamic> json) {
    return Spol(
      id: int.parse(json["id"].toString()),
      naziv: json["naziv"],
    );
  }

  Map<String, dynamic> toJson() => {
    "id": id,
    "naziv": naziv,
  };
}
