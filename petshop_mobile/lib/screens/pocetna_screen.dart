import 'package:flutter/material.dart';
import 'package:petshop_mobile/models/Novost.dart';
import 'package:petshop_mobile/screens/novost_detalji_screen.dart';
import 'package:petshop_mobile/services/APIService.dart';
import 'package:petshop_mobile/widgets/app_drawer.dart';

class Pocetna extends StatefulWidget {
  static const routeName = "/pocetna";

  @override
  State<Pocetna> createState() => _PocetnaState();
}

class _PocetnaState extends State<Pocetna> {

  Future<List<Novost>?> getData() async {
    var novosti = await APIService.Get("Novost", null);

    return novosti?.map((i) => Novost.fromJson(i)).toList();
  }

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      appBar: AppBar(
        title: const Text("Pocetna"),
      ),
      body: bodyWidget(),
      drawer: AppDrawer(),
    );
  }

  Widget bodyWidget() {
    return FutureBuilder(
      future: getData(),
      builder: (BuildContext context, AsyncSnapshot<List<Novost>?> snapshot) {
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
            return ListView.builder(
              itemBuilder: (ctx, i) => NovostWidget(snapshot.data![i]),
              itemCount: snapshot.data?.length,
            );
          }
        }
      },
    );
  }

  Widget NovostWidget(novost) {
    return Column(
      children: [
        GestureDetector(
          onTap: () {
            Navigator.push(
              context,
              MaterialPageRoute(
                builder: (context) => NovostDetalji(novost),
              ),
            );
          },
          child: Container(
            decoration: BoxDecoration(
              border: Border.all(
                color: Colors.orangeAccent,
                width: 3
              ),
            ),
            width: double.infinity,
            margin: const EdgeInsets.only(left: 20, right: 20, top: 20),
            child: Stack(
              children: [
                Container(
                  height: 250,
                  width: double.infinity,
                  child: Image(
                    image: MemoryImage(novost.slika),
                    fit: BoxFit.cover,
                  ),
                ),
                Positioned(
                  right: 1,
                  bottom: 10,
                  child: Container(
                    color: Colors.black54,
                    width: 250,
                    padding: const EdgeInsets.all(3),
                    child: Text(
                      novost.naslov,
                      textAlign: TextAlign.center,
                      style: const TextStyle(
                          color: Colors.white,
                          fontSize: 26,
                          fontWeight: FontWeight.bold),
                      maxLines: 3,
                    ),
                  ),
                ),
              ],
            ),
          ),
        ),
        const Divider(
          thickness: 1,
          color: Colors.orangeAccent,
        ),
      ],
    );
  }
}
