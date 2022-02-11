import 'dart:convert';

import 'package:flutter/material.dart';
import 'package:flutter/services.dart';
import 'package:flutter_datetime_picker/flutter_datetime_picker.dart';
import 'package:petshop_mobile/models/Korisnik.dart';
import 'package:petshop_mobile/screens/promjena_password_screen.dart';
import 'package:petshop_mobile/services/APIService.dart';
import 'package:petshop_mobile/widgets/app_drawer.dart';
import '../models/Requests/KorisnikProfilUpdate.dart';

class Profil extends StatefulWidget {
  static const routeName = "/profil";

  @override
  _ProfilState createState() => _ProfilState();
}

class _ProfilState extends State<Profil> {
  late KorisnikProfilUpdate? korisnikProfilUpdateRequest;

  TextEditingController imeController = TextEditingController();
  TextEditingController prezimeController = TextEditingController();
  TextEditingController emailController = TextEditingController();
  TextEditingController korisnickoImeController = TextEditingController();

  DateTime? datumRodjenja = null;

  final _validationKey = GlobalKey<FormState>();

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

  Widget bodyWidget() {
    return FutureBuilder(
      future: getData(),
      builder: (BuildContext context, AsyncSnapshot<dynamic> snapshot) {
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
                  image: MemoryImage(korisnik.slika),
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
                      "Ime", korisnik.ime, imeController, validateImePrezime),
                  const SizedBox(
                    height: 15,
                  ),
                  textFormField("Prezime", korisnik.prezime, prezimeController,
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
                      "E-mail", korisnik.email, emailController, validateEmail),
                  const SizedBox(
                    height: 15,
                  ),
                  textFormField("Korisnicko ime", korisnik.korisnickoIme,
                      korisnickoImeController, validateImePrezime),
                  const SizedBox(
                    height: 15,
                  ),
                  Container(
                    width: double.infinity,
                    margin: const EdgeInsets.only(right: 50, left: 50),
                    child: ElevatedButton(
                      onPressed: () {
                        Navigator.push(
                          context,
                          MaterialPageRoute(
                            builder: (context) => PromjenaPassword(korisnik),
                          ),
                        );
                      },
                      child: const Text(
                        "Promjeni password",
                        style: TextStyle(
                          fontSize: 20,
                        ),
                      ),
                      style:
                          ElevatedButton.styleFrom(padding: const EdgeInsets.all(10)),
                    ),
                  ),
                  const SizedBox(
                    height: 25,
                  ),
                  ElevatedButton(
                    onPressed: () {
                      if (_validationKey.currentState!.validate()) {
                        korisnikProfilUpdateRequest = KorisnikProfilUpdate(
                          ime: imeController.text,
                          prezime: prezimeController.text,
                          email: emailController.text,
                          korisnickoIme: korisnickoImeController.text,
                          datumRodjenja: datumRodjenja,
                        );
                        sacuvajProfil().then((value) {
                          setState(() {
                            showAlertDialog(context, "Uspjesno !",
                                "Podaci na vasem profilu su uspjesno sacuvani");
                          });
                        });
                      } else {
                        showAlertDialog(context, "Neuspjesno !",
                            "Podaci nisu izmjenjeni, postoje neke greske");
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

  showAlertDialog(BuildContext context, title, info) {
    // set up the button
    Widget okButton = TextButton(
      child: const Text("U redu"),
      onPressed: () {
        Navigator.of(context).pop();
      },
    );

    // set up the AlertDialog
    AlertDialog alert = AlertDialog(
      title: Text(title),
      content: Text(info),
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
