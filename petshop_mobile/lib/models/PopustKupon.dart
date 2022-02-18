
class PopustKupon {
  final int id;
  final int? iznos;
  final String? kod;

  PopustKupon(
      {required this.id,
        required this.iznos,
        required this.kod,
      });

  factory PopustKupon.fromJson(Map<String, dynamic> json) {
    return PopustKupon(
      id: int.parse(json["id"].toString()),
      iznos: int.parse(json["iznos"].toString()),
      kod: json["kod"],
    );
  }

  Map<String, dynamic> toJson() => {
    "id": id,
    "iznos": iznos,
    "kod": kod,
  };
}
