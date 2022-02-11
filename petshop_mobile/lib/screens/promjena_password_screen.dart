import 'package:flutter/material.dart';
import 'package:flutter/services.dart';
import 'package:petshop_mobile/models/Korisnik.dart';
import 'package:petshop_mobile/services/APIService.dart';

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

  final _validationKey = GlobalKey<FormState>();

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      appBar: AppBar(
        title: const Text("Promjena passworda"),
      ),
      body: bodyWidget(),
    );
  }

  int validatePassword(String password) {
    String patttern = r'(^[a-zA-Z0-9 ,.-]*$)';
    RegExp regExp = RegExp(patttern);
    if (password.isEmpty || password.length == 0) {
      return 1;
    } else if (password.length < 5) {
      return 1;
    } else {
      return 0;
    }
  }

  Widget bodyWidget() {
    return Center(
      child: Column(
        mainAxisAlignment: MainAxisAlignment.center,
        children: [
          Form(
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
                  onPressed: () {},
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
