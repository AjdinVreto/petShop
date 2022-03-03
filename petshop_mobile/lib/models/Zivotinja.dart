
class Zivotinja {
  final int id;
  final String? naziv;

  Zivotinja({
    required this.id,
    required this.naziv,
  });

  factory Zivotinja.fromJson(Map<String, dynamic> json) {
    return Zivotinja(
      id: int.parse(json["id"].toString()),
      naziv: json["naziv"],
    );
  }

  Map<String, dynamic> toJson() => {
    "id": id,
    "naziv": naziv,
  };
}