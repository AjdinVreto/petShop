import 'dart:convert';
import 'package:flutter/material.dart';
import 'package:petshop_mobile/models/NarudzbaProizvod.dart';
import 'package:petshop_mobile/models/Proizvod.dart';
import 'package:petshop_mobile/models/Kategorija.dart';
import 'package:petshop_mobile/models/Proizvodjac.dart';
import 'package:petshop_mobile/screens/proizvod_detalji_screen.dart';
import 'package:petshop_mobile/services/APIService.dart';
import 'package:petshop_mobile/widgets/alert_dialog.dart';
import 'package:petshop_mobile/widgets/app_drawer.dart';

class Proizvodi extends StatefulWidget {
  static const routeName = "/proizvodi";

  @override
  State<Proizvodi> createState() => _ProizvodiState();
}

class _ProizvodiState extends State<Proizvodi> {
  Kategorija? _selectedKategorija = null;
  Proizvodjac? _selectedProizvodjac = null;

  List<DropdownMenuItem> items = [];
  List<DropdownMenuItem> itemsProizvodjaci = [];
  NarudzbaProizvod? narudzbaProizvodRequest;

  TextEditingController pretragaController = TextEditingController();

  Widget customSearchBar = const Text("Proizvodi");
  Icon customIcon = const Icon(Icons.search);

  bool proizvodUKorpi = false;

  Future<List<Proizvod>?> GetProizvodi(Kategorija? selectedItemKategorija,
      Proizvodjac? selectedItemProizvodjac) async {
    Map<String, String>? queryParams = null;

    if (selectedItemKategorija != null &&
        selectedItemKategorija.id != 0 &&
        selectedItemProizvodjac != null &&
        _selectedProizvodjac != 0) {
      queryParams = {
        "naziv": pretragaController.text,
        "proizvodjacid": selectedItemProizvodjac.id.toString(),
        "kategorijaid": selectedItemKategorija.id.toString()
      };
    } else if (selectedItemProizvodjac != null &&
        selectedItemProizvodjac.id != 0) {
      queryParams = {
        "naziv": pretragaController.text,
        "proizvodjacid": selectedItemProizvodjac.id.toString()
      };
    } else if (selectedItemKategorija != null &&
        selectedItemKategorija.id != 0) {
      queryParams = {
        "naziv": pretragaController.text,
        "kategorijaid": selectedItemKategorija.id.toString()
      };
    } else if (pretragaController.text.isNotEmpty) {
      queryParams = {"naziv": pretragaController.text};
    } else {
      queryParams = null;
    }

    var proizvodi = await APIService.Get("Proizvod", queryParams);

    return proizvodi?.map((i) => Proizvod.fromJson(i)).toList();
  }

  Future<List<Kategorija>?> GetKategorije(Kategorija? _selectedItem) async {
    var Kategorije = await APIService.Get('Kategorija', null);
    var kategorijeList =
        Kategorije?.map((i) => Kategorija.fromJson(i)).toList();

    items = kategorijeList!.map((item) {
      return DropdownMenuItem<Kategorija>(
        child: Text(item.naziv!),
        value: item,
      );
    }).toList();

    items
        .add(const DropdownMenuItem<Kategorija>(child: Text("Sve kategorije")));

    if (_selectedItem != null && _selectedItem.id != 0) {
      _selectedKategorija = kategorijeList
          .where((element) => element.id == _selectedItem.id)
          .first;
    }
    return kategorijeList;
  }

  Future<List<Proizvodjac>?> GetProizvodjaci(Proizvodjac? _selectedItem) async {
    var Proizvodjaci = await APIService.Get('Proizvodjac', null);
    var proizvodjaciList =
        Proizvodjaci?.map((i) => Proizvodjac.fromJson(i)).toList();

    itemsProizvodjaci = proizvodjaciList!.map((item) {
      return DropdownMenuItem<Proizvodjac>(
        child: Text(item.naziv!),
        value: item,
      );
    }).toList();

    itemsProizvodjaci.add(
        const DropdownMenuItem<Proizvodjac>(child: Text("Svi proizvodjaci")));

    if (_selectedItem != null && _selectedItem.id != 0) {
      _selectedProizvodjac = proizvodjaciList
          .where((element) => element.id == _selectedItem.id)
          .first;
    }
    return proizvodjaciList;
  }

  Future<void> DodajKorpa(proizvod) async {
    narudzbaProizvodRequest = NarudzbaProizvod(
        id: null,
        narudzbaId: APIService.narudzbaId,
        proizvodId: proizvod.id,
        kolicina: 1,
        proizvod: proizvod);
    await APIService.Post(
        "NarudzbaProizvod", json.encode(narudzbaProizvodRequest?.toJson()));
  }

  Future<void> ProizvodProvjera(proizvodId) async {
    proizvodUKorpi = false;

    Map<String, String>? queryParams = null;
    queryParams = {"narudzbaId": APIService.narudzbaId.toString()};

    var korpa = await APIService.Get("NarudzbaProizvod", queryParams);

    var korpaLista = korpa?.map((i) => NarudzbaProizvod.fromJson(i)).toList();

    korpaLista?.forEach((element) {
      if (element.proizvodId == proizvodId) {
        proizvodUKorpi = true;
      }
    });
  }

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      appBar: AppBar(
        title: customSearchBar,
        actions: [SearchBar()],
      ),
      drawer: AppDrawer(),
      body: bodyWidget(),
    );
  }

  Widget bodyWidget() {
    return FutureBuilder<List<Proizvod>?>(
      future: GetProizvodi(_selectedKategorija, _selectedProizvodjac),
      builder: (BuildContext context, AsyncSnapshot<List<Proizvod>?> snapshot) {
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
            return Column(
              children: [
                Row(
                  children: [
                    Expanded(flex: 19, child: dropdownWidget()),
                    Expanded(flex: 20, child: dropdownWidgetProizvodjaci()),
                  ],
                ),
                Expanded(
                  child: Padding(
                    padding: const EdgeInsets.all(10),
                    child: GridView.builder(
                      itemCount: snapshot.data?.length,
                      gridDelegate:
                          const SliverGridDelegateWithFixedCrossAxisCount(
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

  Widget dropdownWidget() {
    return FutureBuilder<List<Kategorija>?>(
        future: GetKategorije(_selectedKategorija),
        builder:
            (BuildContext context, AsyncSnapshot<List<Kategorija>?> snapshot) {
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
              return Padding(
                padding: const EdgeInsets.fromLTRB(30, 10, 30, 10),
                child: DropdownButton<dynamic>(
                  underline: const SizedBox(),
                  hint: const Text('Odaberite vrstu proizvoda'),
                  style: const TextStyle(
                      fontSize: 16,
                      color: Colors.black,
                      fontWeight: FontWeight.bold),
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

  Widget dropdownWidgetProizvodjaci() {
    return FutureBuilder<List<Proizvodjac>?>(
        future: GetProizvodjaci(_selectedProizvodjac),
        builder:
            (BuildContext context, AsyncSnapshot<List<Proizvodjac>?> snapshot) {
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
              return Padding(
                padding: const EdgeInsets.fromLTRB(30, 10, 30, 10),
                child: DropdownButton<dynamic>(
                  underline: const SizedBox(),
                  hint: const Text('Odaberite proizvodjaca'),
                  style: const TextStyle(
                      fontSize: 16,
                      color: Colors.black,
                      fontWeight: FontWeight.bold),
                  isExpanded: true,
                  items: itemsProizvodjaci,
                  onChanged: (newVal) {
                    setState(() {
                      _selectedProizvodjac = newVal as Proizvodjac?;
                      GetProizvodjaci(_selectedProizvodjac);
                    });
                  },
                  value: _selectedProizvodjac,
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
        decoration: BoxDecoration(
          border: Border.all(color: Colors.red),
          color: Colors.white70,
        ),
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
                    style: const TextStyle(
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
                child: Row(
                  mainAxisAlignment: MainAxisAlignment.spaceBetween,
                  children: [
                    Container(
                      margin: const EdgeInsets.only(left: 4),
                      child: Chip(
                        label: Text(
                          proizvod.cijena.toStringAsFixed(2) + " KM",
                          style: const TextStyle(
                              fontSize: 18,
                              fontWeight: FontWeight.bold,
                              color: Colors.white),
                        ),
                        backgroundColor: Colors.purple,
                      ),
                    ),
                    Container(
                      margin: const EdgeInsets.only(right: 4),
                      child: CircleAvatar(
                        backgroundColor: Colors.purple,
                        radius: 25,
                        child: IconButton(
                          iconSize: 30,
                          color: Colors.white,
                          icon: const Icon(Icons.shopping_cart),
                          onPressed: () async {
                            await ProizvodProvjera(proizvod.id)
                                .then((value) async {
                              if (proizvodUKorpi) {
                                ShowAlertDialog.showAlertDialog(context, "NEUSPJESNO !",
                                    "Proizvod se vec nalazi u vasoj korpi", false);
                              } else {
                                await DodajKorpa(proizvod).then((value) {
                                  ShowAlertDialog.showAlertDialog(context, "USPJESNO !",
                                      "Odabrani proizvod je uspjesno dodan u korpu", false);
                                });
                              }
                            });
                          },
                        ),
                      ),
                    )
                  ],
                ),
              ),
            ),
          ],
        ),
      ),
    );
  }

  Widget SearchBar() {
    return IconButton(
      onPressed: () {
        setState(() {
          if (customIcon.icon == Icons.search) {
            customIcon = const Icon(Icons.cancel);
            customSearchBar = Container(
              margin: const EdgeInsets.all(10),
              padding: const EdgeInsets.only(bottom: 5),
              child: TextField(
                onChanged: (value) async {
                  await GetProizvodi(_selectedKategorija, _selectedProizvodjac)
                      .then((value) {
                    setState(() {});
                  });
                },
                controller: pretragaController,
                style: const TextStyle(fontSize: 16),
                decoration: const InputDecoration(
                  border: OutlineInputBorder(
                    borderRadius: BorderRadius.all(Radius.circular(10)),
                  ),
                  hintText: "Unesite naziv proizvoda",
                  hintStyle: TextStyle(color: Colors.black),
                  filled: true,
                  fillColor: Colors.white,
                ),
              ),
            );
          } else {
            customIcon = const Icon(Icons.search);
            customSearchBar = const Text("Proizvodi");
          }
        });
      },
      icon: customIcon,
    );
  }
}
