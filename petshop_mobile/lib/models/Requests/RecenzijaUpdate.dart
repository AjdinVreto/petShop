class RecenzijaUpdate {
  final int? ocjena;

  RecenzijaUpdate({
    required this.ocjena,
  });

  Map<String, dynamic> toJson() => {
        "ocjena": ocjena,
      };
}
