import 'dart:convert';
import 'package:intl/intl.dart';

import 'package:flutter/material.dart';
import 'package:flutter/services.dart';
import 'package:petshop_mobile/models/Komentar.dart';
import 'package:petshop_mobile/models/Proizvod.dart';
import 'package:petshop_mobile/models/Requests/KomentarInsert.dart';
import 'package:petshop_mobile/services/APIService.dart';

class Komentari extends StatefulWidget {
  final Proizvod proizvod;

  Komentari(this.proizvod);

  @override
  _KomentariState createState() => _KomentariState();
}

class _KomentariState extends State<Komentari> {
  final _validationKey = GlobalKey<FormState>();

  TextEditingController komentarController = TextEditingController();

  KomentarInsert? komentarInsertRequest;

  Future<void> postKomentar() async {
    await APIService.Post(
        "Komentar", json.encode(komentarInsertRequest?.toJson()));
  }

  Future<List<Komentar>?> getKomentari() async {
    var komentari = await APIService.Get("Komentar", null);
    var komentariList = komentari?.map((i) => Komentar.fromJson(i)).toList();

    return komentariList?.where((element) {
      return element.proizvodId == widget.proizvod.id;
    }).toList();
  }

  Future<void> obrisiKomentar(komentarId) async {
    await APIService.Delete("Komentar", komentarId);
  }

  int validateKomentar(String ime) {
    String patttern = r'(^[a-zA-Z0-9 ,.-]*$)';
    RegExp regExp = RegExp(patttern);
    if (ime.isEmpty || ime.length == 0) {
      return 1;
    } else if (ime.length > 150) {
      return 3;
    } else {
      return 0;
    }
  }

  @override
  Widget build(BuildContext context) {
    komentarController.clear();
    return Scaffold(
      appBar: AppBar(
        title: Text("Komentari"),
      ),
      body: bodyWidget(),
    );
  }

  Widget bodyWidget() {
    return SingleChildScrollView(
      child: Center(
        child: Column(
          children: [
            SizedBox(
              height: 20,
            ),
            Form(
              key: _validationKey,
              child: Column(
                children: [
                  textFormField("Upisite komentar (max 150 karaktera)",
                      komentarController, validateKomentar, 3),
                  SizedBox(
                    height: 20,
                  ),
                  ElevatedButton(
                    onPressed: () async {
                      if (_validationKey.currentState!.validate()) {
                        komentarInsertRequest = KomentarInsert(
                          id: null,
                          tekst: komentarController.text,
                          datum: DateTime.now(),
                          korisnikId: APIService.korisnikId,
                          proizvodId: widget.proizvod.id,
                        );
                        await postKomentar().then((value) {
                          setState(() {
                            showAlertDialog(context, "Uspjesno !",
                                "Vas komentar je uspjesno objavljen");
                          });
                        });
                      } else {
                        showAlertDialog(
                            context, "GRESKA !", "Postoje neke greske");
                      }
                    },
                    child: const Text(
                      "Ostavite komentar",
                      style: TextStyle(
                        fontSize: 22,
                        fontWeight: FontWeight.bold,
                      ),
                    ),
                    style: ElevatedButton.styleFrom(
                      primary: Colors.orangeAccent,
                      padding: const EdgeInsets.all(12),
                    ),
                  ),
                  SizedBox(
                    height: 20,
                  ),
                  Divider(
                    height: 3,
                    thickness: 0.5,
                    color: Colors.red,
                  ),
                  SizedBox(
                    height: 10,
                  ),
                  Text(
                    "Komentari ostalih korisnika",
                    style: TextStyle(fontSize: 16),
                  ),
                  Center(
                    child: Icon(Icons.arrow_downward),
                  ),
                  SizedBox(
                    height: 25,
                  ),
                  ucitajKomentare(),
                ],
              ),
            )
          ],
        ),
      ),
    );
  }

  Widget textFormField(naziv, controller, validirajPolje, lines) {
    return Container(
      margin: const EdgeInsets.only(right: 10, left: 10),
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
        maxLength: 150,
        onChanged: (val) {},
        maxLines: lines,
        validator: (value) {
          int res = validirajPolje(value!);
          if (res == 1) {
            return "Polje prazno ili nije u ispravnom formatu";
          } else if (res == 3) {
            return "Dozvoljen broj karaktera je 150";
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

  Widget ucitajKomentare() {
    return FutureBuilder(
      future: getKomentari(),
      builder: (BuildContext context, AsyncSnapshot<List<Komentar>?> snapshot) {
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
            return ListView.builder(
              scrollDirection: Axis.vertical,
              shrinkWrap: true,
              physics: ScrollPhysics(),
              itemBuilder: (ctx, i) => KomentarWidget(snapshot.data![i]),
              itemCount: snapshot.data?.length,
            );
          }
        }
      },
    );
  }

  Widget KomentarWidget(komentar) {
    return SingleChildScrollView(
      child: Column(
        children: [
          Container(
            height: 150,
            width: double.infinity,
            margin: EdgeInsets.only(right: 15, left: 15),
            padding: EdgeInsets.all(5),
            decoration: BoxDecoration(
              borderRadius: BorderRadius.circular(10),
              color: Colors.purple,
            ),
            child: Column(
              mainAxisAlignment: MainAxisAlignment.spaceBetween,
              children: [
                Text(
                  komentar.tekst,
                  style: TextStyle(
                    fontSize: 16,
                    color: Colors.white,
                  ),
                  maxLines: 4,
                ),
                Divider(
                  thickness: 0.7,
                  color: Colors.white,
                ),
                Row(
                  mainAxisAlignment: MainAxisAlignment.spaceBetween,
                  children: [
                    Container(
                      margin: EdgeInsets.only(left: 5, bottom: 5),
                      child: Text(
                        komentar.korisnik.ime + " " + komentar.korisnik.prezime,
                        style: TextStyle(
                          fontSize: 16,
                          color: Colors.white,
                        ),
                      ),
                    ),
                    Container(
                      child: Text(
                        DateFormat("dd/MM/yyyy").format(komentar.datum),
                        style: TextStyle(
                          color: Colors.white,
                          fontSize: 16,
                        ),
                      ),
                    ),
                    komentar.korisnikId == APIService.korisnikId
                        ? IconButton(
                            onPressed: () async {
                              await obrisiKomentar(komentar.id).then((value) {
                                setState(() {});
                              });
                            },
                            icon: Icon(Icons.delete),
                            color: Colors.red,
                          )
                        : Icon(
                            Icons.delete,
                            color: Colors.black,
                          ),
                  ],
                )
              ],
            ),
          ),
          SizedBox(
            height: 5,
          ),
          Divider(
            thickness: 1,
            color: Colors.red,
          ),
          SizedBox(
            height: 5,
          ),
        ],
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
