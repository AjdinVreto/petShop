import 'dart:convert';

import 'package:flutter/material.dart';
import 'package:petshop_mobile/models/NarudzbaProizvod.dart';
import 'package:petshop_mobile/models/Requests/NarudzbaProizvodUpdate.dart';
import 'package:petshop_mobile/services/APIService.dart';
import 'package:petshop_mobile/widgets/app_drawer.dart';

class Korpa extends StatefulWidget {
  static const routeName = "/korpa";

  @override
  _KorpaState createState() => _KorpaState();
}

class _KorpaState extends State<Korpa> {
  late double cijena;
  late double ukCijena;
  late NarudzbaProizvodUpdate? narudzbaProizvodRequest;

  Future<List<NarudzbaProizvod>?> getData() async {
    var korpaProizvodi = await APIService.Get("NarudzbaProizvod", null);

    var korpaProizvodiList =
    korpaProizvodi?.map((i) => NarudzbaProizvod.fromJson(i)).toList();

    return korpaProizvodiList?.where((element) {
      cijena = element.proizvod?.cijena as double;
      ukCijena += cijena * element.kolicina;

      return element.narudzbaId == APIService.narudzbaId;
    }).toList();
  }

  Future<void> obrisiProizvod(id) async {
    await APIService.Delete("NarudzbaProizvod", id);
  }

  Future<void> izmjeniKolicinu(id) async {
    await APIService.Update(
        "NarudzbaProizvod", id, json.encode(narudzbaProizvodRequest?.toJson()));
  }

  @override
  Widget build(BuildContext context) {
    cijena = 0.0;
    ukCijena = 0.0;
    narudzbaProizvodRequest = null;
    return Scaffold(
      appBar: AppBar(
        title: const Text("Korpa"),
      ),
      drawer: AppDrawer(),
      body: bodyWidget(),
    );
  }

  Widget bodyWidget() {
    return FutureBuilder(
      future: getData(),
      builder: (BuildContext context,
          AsyncSnapshot<List<NarudzbaProizvod>?> snapshot) {
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
              child: Column(
                children: [
                  ListView.builder(
                    scrollDirection: Axis.vertical,
                    shrinkWrap: true,
                    physics: const ScrollPhysics(),
                    itemBuilder: (ctx, i) => KorpaItem(snapshot.data![i]),
                    itemCount: snapshot.data?.length,
                  ),
                  const SizedBox(
                    height: 30,
                  ),
                  narudzbaInfo(),
                ],
              ),
            );
          }
        }
      },
    );
  }

  Widget KorpaItem(korpaItem) {
    return Card(
      child: Container(
        height: 150,
        width: double.infinity,
        child: Row(
          children: [
            Expanded(
              child: Row(
                mainAxisAlignment: MainAxisAlignment.spaceEvenly,
                children: [
                  Image(
                    image: MemoryImage(korpaItem.proizvod.slika),
                    height: 100,
                  ),
                  Column(
                    mainAxisAlignment: MainAxisAlignment.center,
                    children: [
                      Container(
                        width: 130,
                        child: Text(
                          korpaItem.proizvod.naziv,
                          style: const TextStyle(
                            fontWeight: FontWeight.bold,
                            fontSize: 18,
                          ),
                          textAlign: TextAlign.center,
                          maxLines: 2,
                        ),
                      ),
                      Chip(
                        backgroundColor: Colors.purple,
                        label: Text(
                          korpaItem.proizvod.cijena.toStringAsFixed(2) + " KM",
                          style: const TextStyle(
                              color: Colors.white, fontSize: 17),
                          maxLines: 2,
                        ),
                      )
                    ],
                  ),
                  Column(
                    mainAxisAlignment: MainAxisAlignment.spaceAround,
                    children: [
                      Row(
                        children: [
                          _decrementButton(korpaItem.id, korpaItem.kolicina),
                          const SizedBox(
                            width: 8,
                          ),
                          Text(
                            korpaItem.kolicina.toString(),
                            style: const TextStyle(
                              fontSize: 20,
                              fontWeight: FontWeight.bold,
                            ),
                          ),
                          const SizedBox(
                            width: 8,
                          ),
                          _incrementButton(korpaItem.id, korpaItem.kolicina),
                        ],
                      ),
                      IconButton(
                        onPressed: () async {
                          await obrisiProizvod(korpaItem.id).then((value) {
                            setState(() {

                            });
                          });
                        },
                        icon: const Icon(
                          Icons.delete,
                          color: Colors.red,
                          size: 35,
                        ),
                      )
                    ],
                  )
                ],
              ),
            ),
          ],
        ),
      ),
    );
  }

  Widget narudzbaInfo() {
    return Container(
      margin: const EdgeInsets.all(10),
      child: Column(
        mainAxisAlignment: MainAxisAlignment.spaceBetween,
        children: [
          Chip(
            label: Text(
              "Ukupno za platiti : " + ukCijena.toStringAsFixed(2) + " KM",
              style: const TextStyle(
                  fontSize: 19,
                  fontWeight: FontWeight.bold,
                  color: Colors.white),
            ),
            padding: const EdgeInsets.all(10),
            backgroundColor: Colors.purple,
          ),
          const SizedBox(
            height: 10,
          ),
          ElevatedButton(
            onPressed: () {},
            child: const Text(
              "Izvrsi narudzbu",
              style: TextStyle(
                fontSize: 24,
                fontWeight: FontWeight.bold,
              ),
            ),
            style: ElevatedButton.styleFrom(
              primary: Colors.orangeAccent,
              padding: const EdgeInsets.all(10),
            ),
          )
        ],
      ),
    );
  }

  Widget _incrementButton(id, kolicina) {
    return SizedBox(
      width: 45,
      height: 45,
      child: FittedBox(
        child: FloatingActionButton(
          heroTag: null,
          child: const Icon(
            Icons.add,
            color: Colors.black87,
          ),
          backgroundColor: Colors.white,
          onPressed: () async {
            narudzbaProizvodRequest =
                NarudzbaProizvodUpdate(kolicina: kolicina + 1);
            await izmjeniKolicinu(id).then((value) {
              setState(() {});
            });
          },
        ),
      ),
    );
  }

  Widget _decrementButton(id, kolicina) {
    return SizedBox(
      width: 45,
      height: 45,
      child: FittedBox(
        child: FloatingActionButton(
          heroTag: null,
          child: const Icon(
            Icons.remove,
            color: Colors.black87,
          ),
          backgroundColor: Colors.white,
          onPressed: () async{
            narudzbaProizvodRequest =
                NarudzbaProizvodUpdate(kolicina: kolicina - 1);
            await izmjeniKolicinu(id).then((value) {
              setState(() {});
            });
          },
        ),
      ),
    );
  }
}
