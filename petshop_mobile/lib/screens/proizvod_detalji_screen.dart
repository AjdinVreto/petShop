import 'dart:convert';

import 'package:flutter/material.dart';

import 'package:flutter_rating_bar/flutter_rating_bar.dart';
import 'package:petshop_mobile/models/NarudzbaProizvod.dart';
import 'package:petshop_mobile/models/Recenzija.dart';
import 'package:petshop_mobile/models/Requests/RecenzijaUpdate.dart';
import 'package:petshop_mobile/services/APIService.dart';

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

  Future<List<Recenzija>?> getRecenzije() async {
    var recenzije = await APIService.Get("Recenzija", null);

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
            child: Text("Loading..."),
          );
        } else {
          if (snapshot.hasError) {
            return Center(
              child: Text("${snapshot.error}"),
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
                              widget.proizvod.cijena.toString() + " KM",
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
                      SizedBox(
                        height: 6,
                      ),
                      Text(
                        prosjecnaOcjena.toString() +
                            "/5.0" +
                            "   ( ${brojac} ocjena )",
                        style: TextStyle(
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
                        onPressed: () {},
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
                      SizedBox(
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
        await DodajKorpa().then((value) {
          showAlertDialog(
              context, "Uspjesno", "Proizvod uspjesno dodan u korpu");
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
    return Container(
      decoration: BoxDecoration(
        border: Border.all(
          color: Colors.orange,
        ),
        borderRadius: BorderRadius.circular(5),
      ),
      width: double.infinity,
      height: 350,
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
    );
  }

  showAlertDialog(BuildContext context, title, info) {
    // set up the button
    Widget okButton = TextButton(
      child: const Text("OK"),
      onPressed: () {
        Navigator.of(context).pop();
      },
    );

    // set up the AlertDialog
    AlertDialog alert = AlertDialog(
      title: const Text("My title"),
      content: const Text("This is my message."),
      actions: [
        okButton,
      ],
    );

    // show the dialog
    showDialog(
      context: context,
      builder: (BuildContext context) {
        return alert;
      },
    );
  }
}
