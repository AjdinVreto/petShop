import 'dart:convert';
import 'package:flutter/material.dart';
import 'package:flutter/services.dart';
import 'package:flutter_datetime_picker/flutter_datetime_picker.dart';
import 'package:petshop_mobile/models/Grad.dart';
import 'package:petshop_mobile/models/Korisnik.dart';
import 'package:petshop_mobile/models/Spol.dart';
import 'package:petshop_mobile/screens/promjena_password_screen.dart';
import 'package:petshop_mobile/services/APIService.dart';
import 'package:petshop_mobile/widgets/alert_dialog.dart';
import 'package:petshop_mobile/widgets/app_drawer.dart';
import '../models/Requests/KorisnikProfilUpdate.dart';

class Profil extends StatefulWidget {
  static const routeName = "/profil";

  @override
  _ProfilState createState() => _ProfilState();
}

class _ProfilState extends State<Profil> {
  final _validationKey = GlobalKey<FormState>();
  late KorisnikProfilUpdate? korisnikProfilUpdateRequest;

  TextEditingController imeController = TextEditingController();
  TextEditingController prezimeController = TextEditingController();
  TextEditingController emailController = TextEditingController();
  TextEditingController korisnickoImeController = TextEditingController();
  TextEditingController adresaController = TextEditingController();
  DateTime? datumRodjenja = null;

  List<DropdownMenuItem> items = [];
  List<DropdownMenuItem> itemsGradovi = [];
  Spol? selectedSpol = null;
  Grad? selectedGrad = null;

  int brojac = 0;

  @override
  Widget build(BuildContext context) {
    korisnikProfilUpdateRequest = null;
    return Scaffold(
      appBar: AppBar(
        title: const Text("Profil"),
      ),
      body: bodyWidget(),
      drawer: AppDrawer(),
    );
  }

  int validateImePrezime(String ime) {
    String patttern = r'(^[a-zA-Z0-9 ,.-]*$)';
    RegExp regExp = RegExp(patttern);
    if (ime.isEmpty || ime.length == 0) {
      return 1;
    } else if (ime.length < 10) {
      return 3;
    } else {
      return 0;
    }
  }

  int validateEmail(String? value) {
    String pattern =
        r"^[a-zA-Z0-9.!#$%&'*+/=?^_`{|}~-]+@[a-zA-Z0-9](?:[a-zA-Z0-9-]"
        r"{0,253}[a-zA-Z0-9])?(?:\.[a-zA-Z0-9](?:[a-zA-Z0-9-]"
        r"{0,253}[a-zA-Z0-9])?)*$";
    RegExp regex = RegExp(pattern);
    if (value == null || value.isEmpty || !regex.hasMatch(value))
      return 1;
    else
      return 0;
  }

  Future<dynamic> getData() async {
    var korisnik = await APIService.GetById("Korisnik", APIService.korisnikId);

    return Korisnik.fromJson(korisnik);
  }

  Future<void> sacuvajProfil() async {
    await APIService.Update("Korisnik", APIService.korisnikId,
        json.encode(korisnikProfilUpdateRequest?.toJson()));
  }

  Future<List<Spol>?> getSpolovi(Spol? _selectedItem) async {
    var spolovi = await APIService.Get("Spol", null);

    var listaSpolovi = spolovi?.map((i) => Spol.fromJson(i)).toList();

    items = listaSpolovi!.map((item) {
      return DropdownMenuItem<Spol>(
        child: Text(item.naziv!),
        value: item,
      );
    }).toList();

    if (_selectedItem != null && _selectedItem.id != 0) {
      selectedSpol = listaSpolovi
          .where((element) => element.id == _selectedItem.id)
          .first;
    }
    return listaSpolovi;
  }

  Future<List<Grad>?> getGradovi(Grad? _selectedItem) async {
    var gradovi = await APIService.Get("Grad", null);

    var listaGradovi = gradovi?.map((i) => Grad.fromJson(i)).toList();

    itemsGradovi = listaGradovi!.map((item) {
      return DropdownMenuItem<Grad>(
        child: Text(item.naziv!),
        value: item,
      );
    }).toList();

    if (_selectedItem != null && _selectedItem.id != 0) {
      selectedGrad = listaGradovi
          .where((element) => element.id == _selectedItem.id)
          .first;
    }
    return listaGradovi;
  }

  Widget bodyWidget() {
    return FutureBuilder(
      future: getData(),
      builder: (BuildContext context, AsyncSnapshot<dynamic> snapshot) {
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
            if(selectedSpol == null){
              selectedSpol = snapshot.data.spol;
            }
            if(selectedGrad == null){
              selectedGrad = snapshot.data.grad;
            }
            datumRodjenja = snapshot.data.datumRodjenja;
            return ProfilWidget(snapshot.data);
          }
        }
      },
    );
  }

  Widget ProfilWidget(korisnik) {
    return SingleChildScrollView(
      child: Center(
        child: Column(
          children: [
            const SizedBox(
              height: 20,
            ),
            Container(
              width: 150,
              height: 150,
              decoration: BoxDecoration(
                shape: BoxShape.circle,
                image: DecorationImage(
                  fit: BoxFit.cover,
                  image: korisnik.slika.isEmpty
                      ? const AssetImage("./assets/images/userprofile.jpg")
                          as ImageProvider
                      : MemoryImage(korisnik.slika),
                ),
              ),
            ),
            const SizedBox(
              height: 30,
            ),
            Form(
              key: _validationKey,
              child: Column(
                children: [
                  textFormField(
                      "Ime", brojac > 0 ? imeController.text : korisnik.ime, imeController, validateImePrezime),
                  const SizedBox(
                    height: 15,
                  ),
                  textFormField("Prezime", brojac > 0 ? prezimeController.text : korisnik.prezime, prezimeController,
                      validateImePrezime),
                  const SizedBox(
                    height: 25,
                  ),
                  spoloviDropdown(),
                  const SizedBox(
                    height: 25,
                  ),
                  gradoviDropdown(),
                  const SizedBox(
                    height: 25,
                  ),
                  textFormField("Adresa", brojac > 0 ? adresaController.text : korisnik.adresa, adresaController,
                      validateImePrezime),
                  const SizedBox(
                    height: 25,
                  ),
                  Container(
                      width: double.infinity,
                      margin: const EdgeInsets.only(right: 50, left: 50),
                      child: izmjeniDatumRodjenja(korisnik)),
                  const SizedBox(
                    height: 25,
                  ),
                  textFormField(
                      "E-mail", brojac > 0 ? emailController.text : korisnik.email, emailController, validateEmail),
                  const SizedBox(
                    height: 15,
                  ),
                  textFormField("Korisnicko ime", brojac > 0 ? korisnickoImeController.text : korisnik.korisnickoIme,
                      korisnickoImeController, validateImePrezime),
                  const SizedBox(
                    height: 35,
                  ),
                  Container(
                    width: double.infinity,
                    margin: const EdgeInsets.only(right: 50, left: 50),
                    child: ElevatedButton.icon(
                      icon: const Icon(Icons.password),
                      onPressed: () {
                        Navigator.push(
                          context,
                          MaterialPageRoute(
                            builder: (context) => PromjenaPassword(korisnik),
                          ),
                        );
                      },
                      label: const Text(
                        "Promjeni password",
                        style: TextStyle(
                          fontSize: 22,
                        ),
                      ),
                      style: ElevatedButton.styleFrom(
                        padding: const EdgeInsets.all(10),
                        primary: Colors.blue,
                      ),
                    ),
                  ),
                  const SizedBox(
                    height: 30,
                  ),
                  ElevatedButton(
                    onPressed: () async{
                      if (_validationKey.currentState!.validate()) {
                        korisnikProfilUpdateRequest = KorisnikProfilUpdate(
                          ime: imeController.text,
                          prezime: prezimeController.text,
                          adresa: adresaController.text,
                          email: emailController.text,
                          korisnickoIme: korisnickoImeController.text,
                          password: null,
                          datumRodjenja: datumRodjenja,
                          spolId: selectedSpol?.id,
                          gradId: selectedGrad?.id,
                        );
                        await sacuvajProfil().then((value) {
                          APIService.username = korisnickoImeController.text;
                          setState(() {
                            ShowAlertDialog.showAlertDialog(context, "Uspjesno !",
                                "Podaci na vasem profilu su uspjesno sacuvani", false);
                          });
                        });
                      } else {
                        ShowAlertDialog.showAlertDialog(context, "Neuspjesno !",
                            "Podaci nisu izmjenjeni, postoje neke greske", false);
                      }
                    },
                    child: const Text(
                      "Sacuvaj profil",
                      style: TextStyle(
                        fontSize: 26,
                        fontWeight: FontWeight.bold,
                      ),
                    ),
                    style: ElevatedButton.styleFrom(
                      primary: Colors.orangeAccent,
                      padding: const EdgeInsets.all(12),
                    ),
                  ),
                  const SizedBox(
                    height: 15,
                  ),
                ],
              ),
            ),
          ],
        ),
      ),
    );
  }

  Widget textFormField(naziv, korisnik, controller, validirajPolje) {
    return Container(
      margin: const EdgeInsets.only(right: 50, left: 50),
      child: TextFormField(
        autovalidateMode: AutovalidateMode.onUserInteraction,
        /* autovalidate is disabled */
        controller: controller..text = korisnik,
        inputFormatters: [
          FilteringTextInputFormatter.deny(RegExp(r"\s\s")),
          FilteringTextInputFormatter.deny(RegExp(
              r'(\u00a9|\u00ae|[\u2000-\u3300]|\ud83c[\ud000-\udfff]|\ud83d[\ud000-\udfff]|\ud83e[\ud000-\udfff])')),
        ],
        keyboardType: TextInputType.text,
        maxLength: 160,
        onChanged: (val) {},
        maxLines: 1,
        validator: (value) {
          int res = validirajPolje(value!);
          if (res == 1) {
            return "Polje prazno ili nije u ispravnom formatu";
          } else {
            return null;
          }
        },
        autofocus: false,
        decoration: InputDecoration(
          labelText: naziv,
          errorMaxLines: 3,
          counterText: "",
          filled: true,
          fillColor: Colors.white,
          focusedBorder: const OutlineInputBorder(
            borderRadius: BorderRadius.all(Radius.circular(4)),
            borderSide: BorderSide(
              width: 1,
              color: Colors.orangeAccent,
            ),
          ),
          disabledBorder: const OutlineInputBorder(
            borderRadius: BorderRadius.all(Radius.circular(4)),
            borderSide: BorderSide(
              width: 1,
              color: Color(0xffE5E5E5),
            ),
          ),
          enabledBorder: const OutlineInputBorder(
            borderRadius: BorderRadius.all(Radius.circular(4)),
            borderSide: BorderSide(
              width: 1,
              color: Colors.purple,
            ),
          ),
          border: const OutlineInputBorder(
            borderRadius: BorderRadius.all(Radius.circular(4)),
            borderSide: BorderSide(
              width: 1,
            ),
          ),
          errorBorder: const OutlineInputBorder(
              borderRadius: BorderRadius.all(Radius.circular(4)),
              borderSide: BorderSide(
                width: 1,
                color: Colors.red,
              )),
          focusedErrorBorder: const OutlineInputBorder(
            borderRadius: BorderRadius.all(Radius.circular(4)),
            borderSide: BorderSide(
              width: 1,
              color: Colors.red,
            ),
          ),
        ),
      ),
    );
  }

  Widget spoloviDropdown() {
    return FutureBuilder<List<Spol>?>(
        future: getSpolovi(selectedSpol),
        builder:
            (BuildContext context, AsyncSnapshot<List<Spol>?> snapshot) {
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
              return Container(
                margin: const EdgeInsets.only(right: 50, left: 50),
                child: DropdownButtonFormField<dynamic>(
                  decoration: const InputDecoration(
                    border: OutlineInputBorder(),
                  ),
                  isExpanded: true,
                  items: items,
                  onChanged: (newVal) {
                    setState(() {
                      selectedSpol = newVal as Spol?;
                      brojac++;
                    });
                  },
                  value: selectedSpol,
                ),
              );
            }
          }
        });
  }

  Widget gradoviDropdown() {
    return FutureBuilder<List<Grad>?>(
        future: getGradovi(selectedGrad),
        builder:
            (BuildContext context, AsyncSnapshot<List<Grad>?> snapshot) {
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
              return Container(
                margin: const EdgeInsets.only(right: 50, left: 50),
                child: DropdownButtonFormField<dynamic>(
                  decoration: const InputDecoration(
                    border: OutlineInputBorder(),
                  ),
                  isExpanded: true,
                  items: itemsGradovi,
                  onChanged: (newVal) {
                    setState(() {
                      selectedGrad = newVal as Grad?;
                      brojac++;
                    });
                  },
                  value: selectedGrad,
                ),
              );
            }
          }
        });
  }

  Widget izmjeniDatumRodjenja(korisnik) {
    return ElevatedButton.icon(
      icon: const Icon(Icons.date_range),
      onPressed: () {
        DatePicker.showDatePicker(context,
            showTitleActions: true,
            minTime: DateTime(1930, 1, 1),
            maxTime: DateTime.now(),
            onChanged: (date) {}, onConfirm: (date) {
          datumRodjenja = date;
        }, currentTime: korisnik.datumRodjenja, locale: LocaleType.en);
      },
      label: const Text(
        "Datum rodjenja",
        style: TextStyle(fontSize: 20),
      ),
      style: ElevatedButton.styleFrom(
        padding: const EdgeInsets.all(10),
      ),
    );
  }
}
