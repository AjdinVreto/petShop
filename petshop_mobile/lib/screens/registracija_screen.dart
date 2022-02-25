import 'dart:convert';

import 'package:flutter/material.dart';
import 'package:flutter/services.dart';
import 'package:flutter_datetime_picker/flutter_datetime_picker.dart';
import 'package:petshop_mobile/models/Grad.dart';
import 'package:petshop_mobile/models/Requests/KorisnikRegistracija.dart';
import 'package:petshop_mobile/models/Spol.dart';
import 'package:petshop_mobile/services/APIService.dart';
import 'package:petshop_mobile/widgets/alert_dialog.dart';

class Registracija extends StatefulWidget {
  static const routeName = "/registracija";

  @override
  _RegistracijaState createState() => _RegistracijaState();
}

class _RegistracijaState extends State<Registracija> {
  final _validationKey = GlobalKey<FormState>();

  late KorisnikRegistracija korisnik;
  bool korisnickoImeMailPostoji = false;

  TextEditingController imeController = TextEditingController();
  TextEditingController prezimeController = TextEditingController();
  TextEditingController emailController = TextEditingController();
  TextEditingController korisnickoImeController = TextEditingController();
  TextEditingController adresaController = TextEditingController();
  TextEditingController passwordController = TextEditingController();
  TextEditingController potvrdaPasswordaController = TextEditingController();
  DateTime? datumRodjenja = DateTime.now();

  List<DropdownMenuItem> items = [];
  List<DropdownMenuItem> itemsGradovi = [];
  Spol? selectedSpol = null;
  Grad? selectedGrad = null;

  int brojac = 0;

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

  int validatePassword(String password) {
    String patttern = r'(^[a-zA-Z0-9 ,.-]*$)';
    RegExp regExp = RegExp(patttern);
    if (password.isEmpty || password.length == 0) {
      return 1;
    } else if (password.length < 3) {
      return 1;
    } else {
      return 0;
    }
  }

  Future<List<Spol>?> getSpolovi(Spol? _selectedItem) async {
    var spolovi = await APIService.GetGradSpol("Spol/getspolovi", null);

    var listaSpolovi = spolovi?.map((i) => Spol.fromJson(i)).toList();

    items = listaSpolovi!.map((item) {
      return DropdownMenuItem<Spol>(
        child: Text(item.naziv!),
        value: item,
      );
    }).toList();

    if (_selectedItem != null && _selectedItem.id != 0) {
      selectedSpol =
          listaSpolovi.where((element) => element.id == _selectedItem.id).first;
    }
    return listaSpolovi;
  }

  Future<List<Grad>?> getGradovi(Grad? _selectedItem) async {
    var gradovi = await APIService.GetGradSpol("Grad/getgradovi", null);

    var listaGradovi = gradovi?.map((i) => Grad.fromJson(i)).toList();

    itemsGradovi = listaGradovi!.map((item) {
      return DropdownMenuItem<Grad>(
        child: Text(item.naziv!),
        value: item,
      );
    }).toList();

    if (_selectedItem != null && _selectedItem.id != 0) {
      selectedGrad =
          listaGradovi.where((element) => element.id == _selectedItem.id).first;
    }
    return listaGradovi;
  }

  Future<void> registrujKorisnika() async {
    korisnickoImeMailPostoji = false;
    var k = await APIService.Registracija(
        "Korisnik/registracija", json.encode(korisnik.toJson()));

    if (k == null) {
      korisnickoImeMailPostoji = true;
    }
  }

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      appBar: AppBar(
        title: const Text("Registracija"),
        centerTitle: true,
      ),
      body: bodyWidget(),
    );
  }

  Widget bodyWidget() {
    return SingleChildScrollView(
      child: Center(
        child: Column(
          children: [
            const SizedBox(
              height: 25,
            ),
            Form(
              key: _validationKey,
              child: Column(
                children: [
                  textFormField("Ime", imeController, validateImePrezime),
                  const SizedBox(
                    height: 25,
                  ),
                  textFormField(
                      "Prezime", prezimeController, validateImePrezime),
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
                  Container(
                      width: double.infinity,
                      margin: const EdgeInsets.only(right: 50, left: 50),
                      child: izmjeniDatumRodjenja()),
                  const SizedBox(
                    height: 25,
                  ),
                  textFormField("Adresa", adresaController, validateImePrezime),
                  const SizedBox(
                    height: 25,
                  ),
                  textFormField("Email", emailController, validateEmail),
                  const SizedBox(
                    height: 25,
                  ),
                  textFormField("Korisnicko ime", korisnickoImeController,
                      validateImePrezime),
                  const SizedBox(
                    height: 25,
                  ),
                  textFormField(
                      "Password", passwordController, validatePassword),
                  const SizedBox(
                    height: 25,
                  ),
                  textFormField("Potvrdi password", potvrdaPasswordaController,
                      validatePassword),
                  const SizedBox(
                    height: 25,
                  ),
                  registrujSe(),
                  const SizedBox(
                    height: 35,
                  ),
                ],
              ),
            ),
          ],
        ),
      ),
    );
  }

  Widget textFormField(naziv, controller, validirajPolje) {
    return Container(
      margin: const EdgeInsets.only(right: 50, left: 50),
      child: TextFormField(
        autovalidateMode: AutovalidateMode.onUserInteraction,
        /* autovalidate is disabled */
        controller: controller,
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

  Widget registrujSe() {
    return ElevatedButton(
      onPressed: () async {
        if (selectedSpol != null || selectedGrad != null) {
          if (passwordController.text == potvrdaPasswordaController.text) {
            if (_validationKey.currentState!.validate()) {
              korisnik = KorisnikRegistracija(
                ime: imeController.text,
                prezime: prezimeController.text,
                adresa: adresaController.text,
                email: emailController.text,
                korisnickoIme: korisnickoImeController.text,
                password: passwordController.text,
                potvrdaPassword: potvrdaPasswordaController.text,
                datumRodjenja: datumRodjenja,
                spolId: selectedSpol?.id,
                gradId: selectedGrad?.id,
                slika: null,
              );
              await registrujKorisnika().then((value) {
                if (korisnickoImeMailPostoji == false) {
                  ShowAlertDialog.showAlertDialog(
                      context,
                      "Uspjesno !",
                      "Uspjesno ste registrovani, sada se mozete logirati",
                      true);
                } else {
                  setState(() {
                    ShowAlertDialog.showAlertDialog(context, "NEUSPJESNO !",
                        "Korisnicko ime ili email vec postoji", false);
                  });
                }
              });
            } else {
              ShowAlertDialog.showAlertDialog(
                  context, "Neuspjesno !", "Postoje neke greske", false);
            }
          } else {
            ShowAlertDialog.showAlertDialog(
                context, "Greska", "Passwordi se ne poklapaju", false);
          }
        } else {
          ShowAlertDialog.showAlertDialog(
              context, "Greska", "Niste oznacili grad ili spol", false);
        }
      },
      child: const Text(
        "Registruj se",
        style: TextStyle(
          fontSize: 26,
          fontWeight: FontWeight.bold,
        ),
      ),
      style: ElevatedButton.styleFrom(
        primary: Colors.orangeAccent,
        padding: const EdgeInsets.all(12),
      ),
    );
  }

  Widget spoloviDropdown() {
    return FutureBuilder<List<Spol>?>(
        future: getSpolovi(selectedSpol),
        builder: (BuildContext context, AsyncSnapshot<List<Spol>?> snapshot) {
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
              return Container(
                margin: const EdgeInsets.only(right: 50, left: 50),
                child: DropdownButtonFormField<dynamic>(
                  decoration: const InputDecoration(
                    border: OutlineInputBorder(),
                  ),
                  hint: const Text("Izaberite spol"),
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
        builder: (BuildContext context, AsyncSnapshot<List<Grad>?> snapshot) {
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
              return Container(
                margin: const EdgeInsets.only(right: 50, left: 50),
                child: DropdownButtonFormField<dynamic>(
                  decoration: const InputDecoration(
                    border: OutlineInputBorder(),
                  ),
                  hint: const Text("Izaberite grad"),
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

  Widget izmjeniDatumRodjenja() {
    return ElevatedButton.icon(
      icon: const Icon(Icons.date_range),
      onPressed: () {
        DatePicker.showDatePicker(context,
            showTitleActions: true,
            minTime: DateTime(1930, 1, 1),
            maxTime: DateTime.now(),
            onChanged: (date) {}, onConfirm: (date) {
          datumRodjenja = date;
        }, currentTime: DateTime.now(), locale: LocaleType.en);
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
