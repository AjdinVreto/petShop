import 'dart:convert';
import 'package:flutter/material.dart';
import 'package:petshop_mobile/models/NarudzbaProizvod.dart';
import 'package:petshop_mobile/models/Requests/NarudzbaProizvodUpdate.dart';
import 'package:petshop_mobile/screens/placanje_screen.dart';
import 'package:petshop_mobile/services/APIService.dart';
import 'package:petshop_mobile/widgets/alert_dialog.dart';
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
  bool korpaPrazna = false;

  Future<List<NarudzbaProizvod>?> getData() async {
    Map<String, String>? queryParams = null;
    queryParams = {"narudzbaId": APIService.narudzbaId.toString()};

    var korpaProizvodi = await APIService.Get("NarudzbaProizvod", queryParams);

    var korpaProizvodiList =
        korpaProizvodi?.map((i) => NarudzbaProizvod.fromJson(i)).toList();

    korpaProizvodiList?.forEach((element) {
      cijena = element.proizvod?.cijena as double;
      ukCijena += cijena * element.kolicina;
    });

    return korpaProizvodiList;
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
    korpaPrazna = false;
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
            child: CircularProgressIndicator(color: Colors.orange,),
          );
        } else {
          if (snapshot.hasError) {
            return Center(
              child: Text("Greska na serveru, pokusajte ponovo"),
            );
          } else {
            if (snapshot.data?.length == 0) {
              korpaPrazna = true;
            }
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
                    height: 40,
                  ),
                  const Divider(
                    thickness: 1,
                    color: Colors.red,
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
                            setState(() {});
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
                  fontSize: 20,
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
            onPressed: () {
              if (!korpaPrazna) {
                Navigator.push(
                  context,
                  MaterialPageRoute(
                    builder: (context) => Placanje(ukCijena),
                  ),
                );
              } else {
                ShowAlertDialog.showAlertDialog(
                    context, "NEUSPJESNO !", "Nemate nista u korpi", false);
              }
            },
            child: const Text(
              "Procesiraj narudzbu",
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
          onPressed: () async {
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
