class Poslovnica {
  final int id;
  final String? adresa;
  final String? brojTelefona;
  final int? gradId;

  Poslovnica({
    required this.id,
    required this.adresa,
    required this.brojTelefona,
    required this.gradId,
  });

  factory Poslovnica.fromJson(Map<String, dynamic> json) {
    return Poslovnica(
      id: int.parse(json["id"].toString()),
      adresa: json["adresa"],
      brojTelefona: json["brojTelefona"],
      gradId: int.parse(json["gradId"].toString()),
    );
  }

  Map<String, dynamic> toJson() => {
    "id": id,
    "adresa": adresa,
    "brojTelefona": brojTelefona,
    "gradId": gradId,
  };
}
