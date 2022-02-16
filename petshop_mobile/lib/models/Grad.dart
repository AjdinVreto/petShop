class Grad {
  final int id;
  final String? naziv;

  Grad({
    required this.id,
    required this.naziv,
  });

  factory Grad.fromJson(Map<String, dynamic> json) {
    return Grad(
      id: int.parse(json["id"].toString()),
      naziv: json["naziv"],
    );
  }

  Map<String, dynamic> toJson() => {
    "id": id,
    "naziv": naziv,
  };
}
