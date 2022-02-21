class Transakcija {
  final double? iznos;
  final String? nacinPlacanja;
  final DateTime? datum;
  final String? stripePaymentId;
  final int? popustKuponId;
  final int? narudzbaId;

  Transakcija({
    required this.iznos,
    required this.nacinPlacanja,
    required this.datum,
    required this.stripePaymentId,
    required this.popustKuponId,
    required this.narudzbaId,
  });

  factory Transakcija.fromJson(Map<String, dynamic> json) {
    return Transakcija(
      iznos: json["iznos"],
      nacinPlacanja: json["nacinPlacanja"],
      datum: DateTime.tryParse(json['datum']),
      stripePaymentId: json["stripePaymentId"],
      popustKuponId: int.parse(json["popustKuponId"].toString()),
      narudzbaId: int.parse(json["narudzbaId"].toString()),
    );
  }

  Map<String, dynamic> toJson() => {
    "iznos": iznos,
    "nacinPlacanja": nacinPlacanja,
    "datum": datum == null ? null : datum!.toIso8601String(),
    "stripePaymentId": stripePaymentId,
    "popustKuponId": popustKuponId,
    "narudzbaId": narudzbaId,
  };
}
