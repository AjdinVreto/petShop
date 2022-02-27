import 'dart:convert';
import 'package:flutter/material.dart';
import 'package:flutter/services.dart';
import 'package:petshop_mobile/models/Kontakt.dart';
import 'package:petshop_mobile/models/Poslovnica.dart';
import 'package:petshop_mobile/services/APIService.dart';
import 'package:petshop_mobile/widgets/alert_dialog.dart';
import 'package:petshop_mobile/widgets/app_drawer.dart';

class KontaktScreen extends StatefulWidget {
  static const routeName = "/kontakt";

  @override
  _KontaktScreenState createState() => _KontaktScreenState();
}

class _KontaktScreenState extends State<KontaktScreen> {
  final _validationKey = GlobalKey<FormState>();

  TextEditingController imePrezimeController = TextEditingController();
  TextEditingController emailController = TextEditingController();
  TextEditingController tekstController = TextEditingController();

  Kontakt? kontaktRequest = null;

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

  Future<List<Poslovnica>?> getPoslovnice() async {
    var poslovnice = await APIService.Get("Poslovnica", null);

    var poslovniceList =
        poslovnice?.map((i) => Poslovnica.fromJson(i)).toList();

    return poslovniceList;
  }

  Future<void> postKontakt() async {
    await APIService.Post("Kontakt", json.encode(kontaktRequest?.toJson()));
  }

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      appBar: AppBar(
        title: const Text("Kontakt"),
      ),
      body: bodyWidget(),
      drawer: AppDrawer(),
    );
  }

  Widget bodyWidget() {
    return SingleChildScrollView(
      child: Center(
        child: Column(
          children: [
            const SizedBox(
              height: 35,
            ),
            Form(
              key: _validationKey,
              child: Column(
                children: [
                  textFormField("Unesite ime i prezime", imePrezimeController,
                      validateImePrezime, 1),
                  const SizedBox(
                    height: 25,
                  ),
                  textFormField(
                      "Unesite e-mail", emailController, validateEmail, 1),
                  const SizedBox(
                    height: 25,
                  ),
                  textFormField("Unesite poruku", tekstController,
                      validateImePrezime, 12),
                  const SizedBox(
                    height: 25,
                  ),
                  ElevatedButton(
                    onPressed: () async {
                      if (_validationKey.currentState!.validate()) {
                        kontaktRequest = Kontakt(
                            id: null,
                            ime: imePrezimeController.text,
                            email: emailController.text,
                            tekst: tekstController.text,
                            odgovoreno: false,
                            korisnikId: APIService.korisnikId);
                        await postKontakt().then((i) {
                          setState(() {
                            ShowAlertDialog.showAlertDialog(context, "Uspjesno",
                                "Vasa poruka je uspjesno poslana", false);
                          });
                        });
                      } else {
                        ShowAlertDialog.showAlertDialog(
                            context, "Greska", "Postoje neke greske", false);
                      }
                    },
                    child: const Text(
                      "Posalji poruku",
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
                    height: 25,
                  ),
                ],
              ),
            ),
            const Divider(
              thickness: 0.2,
              color: Colors.red,
            ),
            const SizedBox(
              height: 15,
            ),
            poslovniceWidget(),
            const SizedBox(
              height: 20,
            ),
          ],
        ),
      ),
    );
  }

  Widget poslovniceWidget() {
    return FutureBuilder<List<Poslovnica>?>(
        future: getPoslovnice(),
        builder:
            (BuildContext context, AsyncSnapshot<List<Poslovnica>?> snapshot) {
          if (snapshot.connectionState == ConnectionState.waiting) {
            return const Center(
              child: CircularProgressIndicator(
                color: Colors.orange,
              ),
            );
          } else {
            if (snapshot.hasError) {
              return const Center(
                child: Text("Greska na serveru, pokusajte ponovo"),
              );
            } else {
              return ListView.builder(
                  shrinkWrap: true,
                  scrollDirection: Axis.vertical,
                  itemCount: snapshot.data?.length,
                  itemBuilder: (ctx, i) => poslovnicaWidget(snapshot.data![i]));
            }
          }
        });
  }

  Widget poslovnicaWidget(poslovnica) {
    return Column(
      children: [
        Center(
          child: Text(
            "Poslovnica " + poslovnica.id.toString(),
            style: const TextStyle(fontSize: 18),
          ),
        ),
        const SizedBox(
          height: 5,
        ),
        Center(
          child: Chip(
            padding: const EdgeInsets.all(12),
            backgroundColor: Colors.purple,
            label: Text(
              "Adresa: " +
                  poslovnica.adresa +
                  "\n" +
                  "Broj telefona: " +
                  poslovnica.brojTelefona,
              maxLines: 3,
              style: const TextStyle(color: Colors.white, fontSize: 18),
            ),
          ),
        ),
        SizedBox(
          height: 10,
        ),
      ],
    );
  }

  Widget textFormField(naziv, controller, validirajPolje, lines) {
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
        maxLength: 500,
        onChanged: (val) {},
        maxLines: lines,
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
