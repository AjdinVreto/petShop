
class NarudzbaUpdate {
  final bool? aktivna;
  final bool? zavrsena;

  NarudzbaUpdate({
        required this.aktivna,
        required this.zavrsena,
      });

  factory NarudzbaUpdate.fromJson(Map<String, dynamic> json) {
    return NarudzbaUpdate(
      aktivna: json["aktivna"],
      zavrsena: json["zavrsena"],
    );
  }

  Map<String, dynamic> toJson() => {
    "aktivna": aktivna,
    "zavrsena": zavrsena,
  };
}
