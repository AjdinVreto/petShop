
class Proizvodjac {
  final int id;
  final String? naziv;
  final int? drzavaId;

  Proizvodjac({
    required this.id,
    required this.naziv,
    required this.drzavaId
  });

  factory Proizvodjac.fromJson(Map<String, dynamic> json) {
    return Proizvodjac(
      id: int.parse(json["id"].toString()),
      naziv: json["naziv"],
      drzavaId: int.parse(json["drzavaId"].toString()),
    );
  }

  Map<String, dynamic> toJson() => {
    "id": id,
    "naziv": naziv,
    "drzavaId": drzavaId,
  };
}
