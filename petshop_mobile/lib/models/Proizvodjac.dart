import 'Drzava.dart';

class Proizvodjac {
  final int id;
  final String? naziv;
  final int? drzavaId;
  final Drzava? drzava;

  Proizvodjac({
    required this.id,
    required this.naziv,
    required this.drzavaId,
    required this.drzava,
  });

  factory Proizvodjac.fromJson(Map<String, dynamic> json) {
    return Proizvodjac(
      id: int.parse(json["id"].toString()),
      naziv: json["naziv"],
      drzavaId: int.parse(json["drzavaId"].toString()),
      drzava: Drzava.fromJson(json["drzava"]),
    );
  }

  Map<String, dynamic> toJson() => {
    "id": id,
    "naziv": naziv,
    "drzavaId": drzavaId,
  };
}
