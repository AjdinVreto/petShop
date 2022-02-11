
import 'package:petshop_mobile/models/Proizvod.dart';

class NarudzbaProizvod {
  final int? id;
  final int? narudzbaId;
  final int? proizvodId;
  final int kolicina;
  final Proizvod? proizvod;

  NarudzbaProizvod(
      {
        required this.id,
        required this.narudzbaId,
        required this.proizvodId,
        required this.kolicina,
        required this.proizvod,
      });

  factory NarudzbaProizvod.fromJson(Map<String, dynamic> json) {
    return NarudzbaProizvod(
      id: int.parse(json["id"].toString()),
      narudzbaId: int.parse(json["narudzbaId"].toString()),
      proizvodId: int.parse(json["proizvodId"].toString()),
      kolicina: int.parse(json["kolicina"].toString()),
      proizvod: Proizvod.fromJson(json["proizvod"]),
    );
  }

  Map<String, dynamic> toJson() => {
    "narudzbaId": narudzbaId,
    "proizvodId": proizvodId,
    "kolicina": kolicina,
    "proizvod": proizvod
  };
}
