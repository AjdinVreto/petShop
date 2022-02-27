import 'dart:convert';
import 'package:flutter/material.dart';
import 'package:flutter_rating_bar/flutter_rating_bar.dart';
import 'package:petshop_mobile/models/NarudzbaProizvod.dart';
import 'package:petshop_mobile/models/Recenzija.dart';
import 'package:petshop_mobile/models/Requests/RecenzijaUpdate.dart';
import 'package:petshop_mobile/services/APIService.dart';
import 'package:petshop_mobile/widgets/alert_dialog.dart';

import 'komentar_screen.dart';

class ProizvodDetalji extends StatefulWidget {
  final proizvod;

  ProizvodDetalji(this.proizvod);

  @override
  State<ProizvodDetalji> createState() => _ProizvodDetaljiState();
}

class _ProizvodDetaljiState extends State<ProizvodDetalji> {
  NarudzbaProizvod? narudzbaProizvodRequest;
  Recenzija? recenzijaInsertRequest;
  RecenzijaUpdate? recenzijaUpdateRequest;

  int ocjena = 0;
  double prosjecnaOcjena = 0.0;
  int brojac = 0;

  late int recenzijaId;
  bool proizvodUKorpi = false;

  Future<List<Recenzija>?> getRecenzije() async {
    Map<String, String>? queryParams = null;
    queryParams = {"proizvodId": widget.proizvod.id.toString()};

    var recenzije = await APIService.Get("Recenzija", queryParams);
    var recenzijeList = recenzije?.map((i) => Recenzija.fromJson(i)).toList();

    int suma = 0;
    recenzijeList?.forEach((element) {
      if (element.proizvodId == widget.proizvod.id) {
        suma += element.ocjena!;
        brojac++;
      }
    });

    if (suma > 0) {
      prosjecnaOcjena = suma / brojac;
    }

    recenzijeList?.forEach((element) {
      if (element.korisnikId == APIService.korisnikId &&
          element.proizvodId == widget.proizvod.id) {
        ocjena = element.ocjena!;
        recenzijaId = element.id!;
      }
    });
  }

  Future<void> DodajKorpa() async {
    await APIService.Post(
        "NarudzbaProizvod", json.encode(narudzbaProizvodRequest?.toJson()));
  }

  Future<void> postRecenzija() async {
    await APIService.Post(
        "Recenzija", json.encode(recenzijaInsertRequest?.toJson()));
  }

  Future<void> updateRecenzija() async {
    await APIService.Update("Recenzija", recenzijaId,
        json.encode(recenzijaUpdateRequest?.toJson()));
  }

  Future<void> ProizvodProvjera(proizvodId) async {
    proizvodUKorpi = false;
    var korpa = await APIService.Get("NarudzbaProizvod", null);

    var korpaLista = korpa?.map((i) => NarudzbaProizvod.fromJson(i)).toList();

    korpaLista?.forEach((element) {
      if (APIService.narudzbaId == element.narudzbaId &&
          element.proizvodId == proizvodId) {
        proizvodUKorpi = true;
      }
    });
  }

  @override
  Widget build(BuildContext context) {
    prosjecnaOcjena = 0.0;
    brojac = 0;
    return Scaffold(
      appBar: AppBar(
        title: Text("Proizvod - " + widget.proizvod.naziv),
      ),
      body: bodyWidget(),
    );
  }

  Widget bodyWidget() {
    return FutureBuilder<List<Recenzija>?>(
      future: getRecenzije(),
      builder:
          (BuildContext context, AsyncSnapshot<List<Recenzija>?> snapshot) {
        if (snapshot.connectionState == ConnectionState.waiting) {
          return const Center(
            child: CircularProgressIndicator(color: Colors.orange,),
          );
        } else {
          if (snapshot.hasError) {
            return const Center(
              child: Text("Greska na serveru, pokusajte ponovo"),
            );
          } else {
            return SingleChildScrollView(
              child: Center(
                child: Padding(
                  padding: const EdgeInsets.all(15.0),
                  child: Column(
                    children: [
                      Chip(
                        backgroundColor: Colors.orange,
                        label: Padding(
                          padding: const EdgeInsets.all(4.0),
                          child: Text(
                            widget.proizvod.naziv.toString(),
                            style: const TextStyle(
                                fontWeight: FontWeight.bold,
                                fontSize: 22,
                                color: Colors.white),
                            maxLines: 2,
                            softWrap: true,
                            textAlign: TextAlign.center,
                          ),
                        ),
                      ),
                      const SizedBox(
                        height: 10,
                      ),
                      Image(
                        image: MemoryImage(widget.proizvod.slika),
                        height: 250,
                      ),
                      const SizedBox(
                        height: 15,
                      ),
                      Row(
                        mainAxisAlignment: MainAxisAlignment.spaceBetween,
                        children: [
                          Chip(
                            padding: const EdgeInsets.all(14),
                            backgroundColor: Colors.purple,
                            label: Text(
                              widget.proizvod.cijena.toStringAsFixed(2) + " KM",
                              style: const TextStyle(
                                  fontSize: 20,
                                  fontWeight: FontWeight.bold,
                                  color: Colors.white),
                            ),
                          ),
                          dodajKorpa(context),
                        ],
                      ),
                      const SizedBox(
                        height: 20,
                      ),
                      const Divider(
                        thickness: 1,
                      ),
                      ocjeniProizvod(),
                      const SizedBox(
                        height: 6,
                      ),
                      Text(
                        prosjecnaOcjena.toStringAsFixed(1) +
                            "/5.0" +
                            "   ( ${brojac} ocjena )",
                        style: const TextStyle(
                          fontSize: 18,
                          fontWeight: FontWeight.bold,
                        ),
                      ),
                      const SizedBox(
                        height: 12,
                      ),
                      const Divider(
                        thickness: 1,
                      ),
                      ElevatedButton(
                        style: ElevatedButton.styleFrom(
                          padding: const EdgeInsets.all(12),
                          primary: Colors.blue,
                        ),
                        onPressed: () {
                          Navigator.push(
                            context,
                            MaterialPageRoute(
                              builder: (context) => Komentari(widget.proizvod),
                            ),
                          );
                        },
                        child: const Text(
                          "Komentari",
                          style: TextStyle(fontSize: 20),
                        ),
                      ),
                      const SizedBox(
                        height: 2,
                      ),
                      const Divider(
                        thickness: 1,
                      ),
                      const SizedBox(
                        height: 5,
                      ),
                      proizvodOpis(),
                    ],
                  ),
                ),
              ),
            );
          }
        }
      },
    );
  }

  Widget dodajKorpa(context) {
    return ElevatedButton(
      style: ElevatedButton.styleFrom(
        padding: const EdgeInsets.all(12),
        primary: Colors.orange,
      ),
      onPressed: () async {
        narudzbaProizvodRequest = NarudzbaProizvod(
            id: null,
            narudzbaId: APIService.narudzbaId,
            proizvodId: widget.proizvod.id,
            kolicina: 1,
            proizvod: widget.proizvod);

        await ProizvodProvjera(widget.proizvod.id).then((value) async {
          if (proizvodUKorpi) {
            ShowAlertDialog.showAlertDialog(context, "NEUSPJESNO !",
                "Proizvod se vec nalazi u vasoj korpi", false);
          } else {
            await DodajKorpa().then((value) {
              ShowAlertDialog.showAlertDialog(context, "USPJESNO !",
                  "Odabrani proizvod je uspjesno dodan u korpu", false);
            });
          }
        });
      },
      child: const Text.rich(
        TextSpan(children: [
          TextSpan(
            text: "Dodaj u korpu  ",
            style: TextStyle(
              fontSize: 22,
              fontWeight: FontWeight.bold,
            ),
          ),
          WidgetSpan(
            child: Icon(Icons.shopping_cart),
          ),
        ]),
      ),
    );
  }

  Widget ocjeniProizvod() {
    return RatingBar.builder(
      initialRating: ocjena.toDouble(),
      minRating: 1,
      direction: Axis.horizontal,
      itemCount: 5,
      itemPadding: const EdgeInsets.symmetric(horizontal: 4.0),
      itemBuilder: (context, _) => const Icon(
        Icons.star,
        color: Colors.amber,
      ),
      onRatingUpdate: (rating) async {
        if (ocjena > 0) {
          recenzijaUpdateRequest = RecenzijaUpdate(ocjena: rating.toInt());
          await updateRecenzija().then((value) {
            setState(() {});
          });
        } else {
          recenzijaInsertRequest = Recenzija(
            id: null,
            ocjena: rating.toInt(),
            datum: DateTime.now(),
            korisnikId: APIService.korisnikId,
            proizvodId: widget.proizvod.id,
          );
          await postRecenzija().then((value) {
            setState(() {});
          });
        }
      },
    );
  }

  Widget proizvodOpis() {
    return SingleChildScrollView(
      child: Container(
        decoration: BoxDecoration(
          border: Border.all(
            color: Colors.orange,
          ),
          borderRadius: BorderRadius.circular(5),
        ),
        width: double.infinity,
        child: SingleChildScrollView(
          scrollDirection: Axis.vertical,
          child: Container(
            color: Colors.purple,
            child: Padding(
              padding: const EdgeInsets.all(6),
              child: Text(
                "O proizvodu \n\nOpis : " +
                    widget.proizvod.opis +
                    "\n\n" +
                    "Proizvodjac : " +
                    widget.proizvod.proizvodjac.naziv +
                    "\n\n" +
                    "Zemlja porijekla : " +
                    widget.proizvod.proizvodjac.drzava.naziv,
                textAlign: TextAlign.center,
                style: const TextStyle(
                  fontSize: 20,
                  color: Colors.white,
                ),
              ),
            ),
          ),
        ),
      ),
    );
  }
}
