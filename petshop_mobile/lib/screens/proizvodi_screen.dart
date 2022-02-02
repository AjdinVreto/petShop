import 'package:flutter/material.dart';

import 'package:petshop_mobile/models/Proizvod.dart';
import 'package:petshop_mobile/models/Kategorija.dart';
import 'package:petshop_mobile/screens/proizvod_detalji_screen.dart';
import 'package:petshop_mobile/services/APIService.dart';
import 'package:petshop_mobile/widgets/app_drawer.dart';

class Proizvodi extends StatefulWidget {
  static const routeName = "/proizvodi";

  @override
  State<Proizvodi> createState() => _ProizvodiState();
}

class _ProizvodiState extends State<Proizvodi> {
  Kategorija? _selectedKategorija = null;
  List<DropdownMenuItem> items = [];

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      appBar: AppBar(
        title: Text("Proizvodi"),
      ),
      drawer: AppDrawer(),
      body: bodyWidget(),
    );
  }

  Widget bodyWidget() {
    return FutureBuilder<List<Proizvod>?>(
      future: GetProizvodi(_selectedKategorija),
      builder: (BuildContext context, AsyncSnapshot<List<Proizvod>?> snapshot) {
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
            return Column(
              children: [
                Row(
                  children: [
                    Expanded(child: dropdownWidget()),
                    Text("Search"),
                  ],
                ),
                Expanded(
                  child: Padding(
                    padding: EdgeInsets.all(10),
                    child: GridView.builder(
                      itemCount: snapshot.data?.length,
                      gridDelegate: SliverGridDelegateWithFixedCrossAxisCount(
                          crossAxisCount: 2,
                          childAspectRatio: 0.55,
                          crossAxisSpacing: 10,
                          mainAxisSpacing: 25),
                      itemBuilder: (ctx, i) =>
                          ProizvodWidget(snapshot.data![i]),
                    ),
                  ),
                ),
              ],
            );
          }
        }
      },
    );
  }

  Future<List<Proizvod>?> GetProizvodi(Kategorija? selectedItem) async {
    Map<String, String>? queryParams = null;
    if(selectedItem != null && selectedItem.id != 0){
      queryParams = {"kategorijaid": selectedItem.id.toString()};
    }

    var proizvodi = await APIService.Get("Proizvod", queryParams);
    return proizvodi?.map((i) => Proizvod.fromJson(i)).toList();
  }

  Future<List<Kategorija>?> GetKategorije(Kategorija? _selectedItem) async {
    var Kategorije = await APIService.Get('Kategorija', null);
    var kategorijeList = Kategorije?.map((i) => Kategorija.fromJson(i)).toList();

    items = kategorijeList!.map((item) {
      return DropdownMenuItem<Kategorija>(
        child: Text(item.naziv!),
        value: item,
      );
    }).toList();

    if (_selectedItem != null && _selectedItem.id != 0)
    {
      _selectedKategorija = kategorijeList.where((element) => element.id == _selectedItem.id).first;
    }
    return kategorijeList;
  }

  Widget dropdownWidget(){
    return FutureBuilder<List<Kategorija>?>(
        future: GetKategorije(_selectedKategorija),
        builder: (BuildContext context,
            AsyncSnapshot<List<Kategorija>?> snapshot) {
          if (snapshot.connectionState == ConnectionState.waiting) {
            return Center(
              child: Text('Loading...'),
            );
          }
          else {
            if (snapshot.hasError) {
              return Center(
                child: Text('${snapshot.error}'),
              );
            }
            else {
              return Padding(
                padding: EdgeInsets.fromLTRB(30, 10, 30, 10),
                child: DropdownButton<dynamic>(
                  hint: Text('Odaberite vrstu proizvoda'),
                  isExpanded: true,
                  items: items,
                  onChanged: (newVal) {
                    setState(() {
                      _selectedKategorija = newVal as Kategorija?;
                      GetKategorije(_selectedKategorija);
                    });
                  },
                  value: _selectedKategorija,
                ),
              );
            }
          }
        });
  }

  Widget ProizvodWidget(proizvod) {
    return ClipRRect(
      borderRadius: BorderRadius.circular(20),
      child: Container(
        color: Colors.indigoAccent,
        child: Column(
          children: [
            GestureDetector(
              onTap: () {
                Navigator.push(
                  context,
                  MaterialPageRoute(
                    builder: (context) => ProizvodDetalji(proizvod),
                  ),
                );
              },
              child: Container(
                color: Colors.orangeAccent,
                height: 50,
                width: double.infinity,
                child: Padding(
                  padding: const EdgeInsets.all(2.5),
                  child: Text(
                    proizvod.naziv,
                    textAlign: TextAlign.center,
                    style: TextStyle(
                      fontSize: 19,
                      fontWeight: FontWeight.bold,
                    ),
                    maxLines: 2,
                  ),
                ),
              ),
            ),
            GestureDetector(
              onTap: () {
                Navigator.push(
                  context,
                  MaterialPageRoute(
                    builder: (context) => ProizvodDetalji(proizvod),
                  ),
                );
              },
              child: Image(
                image: MemoryImage(proizvod.slika),
                height: 200,
                width: double.infinity,
              ),
            ),
            Expanded(
              child: Container(
                color: Colors.orangeAccent,
                child: Container(
                  margin: EdgeInsets.only(left: 6, right: 5),
                  child: Row(
                    mainAxisAlignment: MainAxisAlignment.spaceBetween,
                    children: [
                      Chip(
                        label: Text(
                          proizvod.cijena.toString() + " KM",
                          style: TextStyle(
                              fontSize: 18,
                              fontWeight: FontWeight.bold,
                              color: Colors.white),
                        ),
                        backgroundColor: Colors.purple,
                      ),
                      CircleAvatar(
                        backgroundColor: Colors.purple,
                        radius: 25,
                        child: IconButton(
                          iconSize: 30,
                          color: Colors.white,
                          icon: Icon(Icons.shopping_cart),
                          onPressed: () {},
                        ),
                      )
                    ],
                  ),
                ),
              ),
            )
          ],
        ),
      ),
    );
  }
}
