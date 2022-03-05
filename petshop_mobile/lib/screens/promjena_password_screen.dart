import 'dart:convert';

import 'package:flutter/material.dart';
import 'package:flutter/services.dart';
import 'package:petshop_mobile/models/Korisnik.dart';
import 'package:petshop_mobile/models/Requests/KorisnikProfilUpdate.dart';
import 'package:petshop_mobile/services/APIService.dart';
import 'package:petshop_mobile/widgets/alert_dialog.dart';

class PromjenaPassword extends StatefulWidget {
  Korisnik? korisnik;

  PromjenaPassword(this.korisnik);

  @override
  _PromjenaPasswordState createState() => _PromjenaPasswordState();
}

class _PromjenaPasswordState extends State<PromjenaPassword> {
  DateTime? datumRodjenja = null;

  TextEditingController stariPasswordController = TextEditingController();
  TextEditingController noviPasswordController = TextEditingController();
  TextEditingController potvrdaNovogPasswordaController =
      TextEditingController();

  late KorisnikProfilUpdate passwordUpdateRequest;

  final _validationKey = GlobalKey<FormState>();

  Future<void> updatePassword() async {
    await APIService.Update("Korisnik", APIService.korisnikId,
        json.encode(passwordUpdateRequest.toJson()));
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

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      appBar: AppBar(
        title: const Text("Promjena passworda"),
      ),
      body: bodyWidget(),
    );
  }

  Widget bodyWidget() {
    return Center(
      child: Column(
        mainAxisAlignment: MainAxisAlignment.center,
        children: [
          Form(
            key: _validationKey,
            child: Column(
              children: [
                textFormField("Stari password", stariPasswordController,
                    validatePassword),
                const SizedBox(
                  height: 15,
                ),
                textFormField(
                    "Novi password", noviPasswordController, validatePassword),
                const SizedBox(
                  height: 15,
                ),
                textFormField("Potvrdi password",
                    potvrdaNovogPasswordaController, validatePassword),
                const SizedBox(
                  height: 25,
                ),
                ElevatedButton(
                  onPressed: () async {
                    if (stariPasswordController.text != APIService.password) {
                      ShowAlertDialog.showAlertDialog(context, "NEUSPJESNO !",
                          "Stari password nije tacan", false);
                    } else if (noviPasswordController.text !=
                        potvrdaNovogPasswordaController.text) {
                      ShowAlertDialog.showAlertDialog(context, "NEUSPJESNO !",
                          "Passwordi se ne poklapaju", false);
                    } else {
                      if (_validationKey.currentState!.validate()) {
                        passwordUpdateRequest = KorisnikProfilUpdate(
                            ime: widget.korisnik?.ime,
                            prezime: widget.korisnik?.prezime,
                            email: widget.korisnik?.email,
                            adresa: widget.korisnik?.adresa,
                            korisnickoIme: widget.korisnik?.korisnickoIme,
                            datumRodjenja: widget.korisnik?.datumRodjenja,
                            spolId: widget.korisnik?.spolId,
                            gradId: widget.korisnik?.gradId,
                            password: noviPasswordController.text,
                            slika: widget.korisnik?.slika
                        );
                        await updatePassword().then((value) {
                          setState(() {
                            APIService.password = noviPasswordController.text;
                            ShowAlertDialog.showAlertDialog(
                                context,
                                "USPJESNO !",
                                "Vas password je uspjesno izmjenjen",
                                false);
                            stariPasswordController.clear();
                            noviPasswordController.clear();
                            potvrdaNovogPasswordaController.clear();
                          });
                        });
                      } else {
                        ShowAlertDialog.showAlertDialog(
                            context, "Greska", "Postoje neke greske", false);
                      }
                    }
                  },
                  child: const Text(
                    "Sacuvaj password",
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
              ],
            ),
          )
        ],
      ),
    );
  }

  Widget textFormField(naziv, controller, validirajPolje) {
    return Container(
      margin: const EdgeInsets.only(right: 50, left: 50),
      child: TextFormField(
        obscureText: true,
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
}
