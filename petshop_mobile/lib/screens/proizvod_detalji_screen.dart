import 'dart:convert';

import 'package:flutter/material.dart';

import 'package:flutter_rating_bar/flutter_rating_bar.dart';
import 'package:petshop_mobile/models/NarudzbaProizvod.dart';
import 'package:petshop_mobile/models/Proizvodjac.dart';
import 'package:petshop_mobile/services/APIService.dart';

class ProizvodDetalji extends StatelessWidget {
  var proizvod;
  var proizvodjac = null;

  NarudzbaProizvod? narudzbaProizvodRequest;

  ProizvodDetalji(this.proizvod);

  Future<void> DodajKorpa() async{
    narudzbaProizvodRequest = new NarudzbaProizvod(narudzbaId: APIService.narudzbaId, proizvodId: proizvod.id, kolicina: 1);
    await APIService.Post("NarudzbaProizvod", json.encode(narudzbaProizvodRequest?.toJson()));
    print("AS");
  }

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      appBar: AppBar(
        title: Text("Proizvod - " + proizvod.naziv),
      ),
      body: bodyWidget(),
    );
  }

  Widget bodyWidget(){
    return FutureBuilder<List<Proizvodjac>?>(
      future: GetProizvodjac(),
      builder: (BuildContext context, AsyncSnapshot<List<Proizvodjac>?> snapshot) {
        if (snapshot.connectionState == ConnectionState.waiting) {
          return Center(
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
                              proizvod.naziv.toString(),
                              style: TextStyle(
                                  fontWeight: FontWeight.bold,
                                  fontSize: 22,
                                  color: Colors.white),
                            ),
                          ),
                        ),
                        SizedBox(
                          height: 10,
                        ),
                        Image(
                          image: MemoryImage(proizvod.slika),
                          height: 250,
                        ),
                        SizedBox(
                          height: 15,
                        ),
                        Row(
                          mainAxisAlignment: MainAxisAlignment.spaceBetween,
                          children: [
                            Chip(
                              padding: EdgeInsets.all(14),
                              backgroundColor: Colors.purple,
                              label: Text(
                                proizvod.cijena.toString() + " KM",
                                style: TextStyle(
                                    fontSize: 20,
                                    fontWeight: FontWeight.bold,
                                    color: Colors.white),
                              ),
                            ),
                            dodaj_korpa_widget(DodajKorpa),
                          ],
                        ),
                        SizedBox(
                          height: 20,
                        ),
                        Divider(
                          thickness: 1,
                        ),
                        ocjeni_proizvod_widget(),
                        SizedBox(
                          height: 10,
                        ),
                        Divider(
                          thickness: 1,
                        ),
                        ElevatedButton(
                          style: ElevatedButton.styleFrom(
                            padding: EdgeInsets.all(12),
                            primary: Colors.blue,
                          ),
                          onPressed: () {},
                          child: Text(
                            "Komentari",
                            style: TextStyle(fontSize: 20),
                          ),
                        ),
                        SizedBox(
                          height: 2,
                        ),
                        Divider(
                          thickness: 1,
                        ),
                        proizvod_opis_widget(proizvod: proizvod, proizvodjac: proizvodjac,)
                      ],
                    ),
                  )),
            );
          }
        }
      },
    );
  }

  Future<List<Proizvodjac>?> GetProizvodjac() async {
    var proizvodjaci = await APIService.Get("Proizvodjac", null);
    var proizvodjaciList = proizvodjaci?.map((i) => Proizvodjac.fromJson(i)).toList();

    proizvodjac = proizvodjaciList?.where((element) => element.id == proizvod.proizvodjacId).first;
  }
}

class dodaj_korpa_widget extends StatelessWidget {
  Function DodajKorpa;

  dodaj_korpa_widget(this.DodajKorpa);

  @override
  Widget build(BuildContext context) {
    return ElevatedButton(
      style: ElevatedButton.styleFrom(
        padding: EdgeInsets.all(12),
        primary: Colors.orange,
      ),
      onPressed: () async {
        await DodajKorpa();
      },
      child: Text.rich(
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
}

class ocjeni_proizvod_widget extends StatelessWidget {
  @override
  Widget build(BuildContext context) {
    return RatingBar.builder(
      initialRating: 3,
      minRating: 1,
      direction: Axis.horizontal,
      allowHalfRating: true,
      itemCount: 5,
      itemPadding: EdgeInsets.symmetric(horizontal: 4.0),
      itemBuilder: (context, _) => Icon(
        Icons.star,
        color: Colors.amber,
      ),
      onRatingUpdate: (rating) {
        print(rating);
      },
    );
  }
}

class proizvod_opis_widget extends StatelessWidget {
  final proizvod;
  final proizvodjac;

  proizvod_opis_widget({this.proizvod, this.proizvodjac});

  @override
  Widget build(BuildContext context) {
    return Container(
      decoration: BoxDecoration(
        border: Border.all(
          color: Colors.orange,
        ),
        borderRadius: BorderRadius.circular(5),
      ),
      width: double.infinity,
      height: 220,
      child: Container(
        color: Colors.purple,
        child: Padding(
          padding: const EdgeInsets.only(top: 5),
          child: Text(
            "O proizvodu \n\nOpis : " + proizvod.opis + "\n" + "Proizvodjac : " + proizvodjac.naziv,
            textAlign: TextAlign.center,
            style: TextStyle(
              fontSize: 20,
              color: Colors.white,
            ),
          ),
        ),
      ),
    );
  }
}

// Widget bodyWidget() {
//   return SingleChildScrollView(
//     child: Center(
//         child: Padding(
//           padding: const EdgeInsets.all(15.0),
//           child: Column(
//             children: [
//               Chip(
//                 backgroundColor: Colors.orange,
//                 label: Padding(
//                   padding: const EdgeInsets.all(4.0),
//                   child: Text(
//                     proizvod.naziv.toString(),
//                     style: TextStyle(
//                         fontWeight: FontWeight.bold,
//                         fontSize: 22,
//                         color: Colors.white),
//                   ),
//                 ),
//               ),
//               SizedBox(
//                 height: 10,
//               ),
//               Image(
//                 image: MemoryImage(proizvod.slika),
//                 height: 250,
//               ),
//               SizedBox(
//                 height: 15,
//               ),
//               Row(
//                 mainAxisAlignment: MainAxisAlignment.spaceBetween,
//                 children: [
//                   Chip(
//                     padding: EdgeInsets.all(14),
//                     backgroundColor: Colors.purple,
//                     label: Text(
//                       proizvod.cijena.toString() + " KM",
//                       style: TextStyle(
//                           fontSize: 20,
//                           fontWeight: FontWeight.bold,
//                           color: Colors.white),
//                     ),
//                   ),
//                   dodaj_korpa_widget(),
//                 ],
//               ),
//               SizedBox(
//                 height: 20,
//               ),
//               Divider(
//                 thickness: 1,
//               ),
//               ocjeni_proizvod_widget(),
//               SizedBox(
//                 height: 10,
//               ),
//               Divider(
//                 thickness: 1,
//               ),
//               ElevatedButton(
//                 style: ElevatedButton.styleFrom(
//                   padding: EdgeInsets.all(12),
//                   primary: Colors.blue,
//                 ),
//                 onPressed: () {},
//                 child: Text(
//                   "Komentari",
//                   style: TextStyle(fontSize: 20),
//                 ),
//               ),
//               SizedBox(
//                 height: 2,
//               ),
//               Divider(
//                 thickness: 1,
//               ),
//               proizvod_opis_widget(proizvod: proizvod)
//             ],
//           ),
//         )),
//   );
// }

