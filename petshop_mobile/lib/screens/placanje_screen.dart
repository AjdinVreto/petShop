import 'dart:convert';
import 'package:http/http.dart' as http;
import 'package:flutter/material.dart';
import 'package:flutter_stripe/flutter_stripe.dart';
import 'package:petshop_mobile/models/Narudzba.dart';
import 'package:petshop_mobile/models/NarudzbaProizvod.dart';
import 'package:petshop_mobile/models/PopustKupon.dart';
import 'package:petshop_mobile/models/Requests/NarudzbaInsert.dart';
import 'package:petshop_mobile/models/Requests/NarudzbaUpdate.dart';
import 'package:petshop_mobile/models/Transakcija.dart';
import 'package:petshop_mobile/services/APIService.dart';
import 'package:petshop_mobile/widgets/alert_dialog.dart';

class Placanje extends StatefulWidget {
  double ukCijena;

  Placanje(this.ukCijena);

  @override
  _PlacanjeState createState() => _PlacanjeState();
}

class _PlacanjeState extends State<Placanje> {
  List<PopustKupon>? popustKuponiList = null;
  bool iskoristenKupon = false;
  int kuponId = 0;

  int iznos = 0;
  int iznosInt = 0;
  int? brojac = 0;

  TextEditingController popustKuponController = TextEditingController();

  Map<String, dynamic>? paymentIntentData;
  late Transakcija transakcijaInsertRequest;
  late NarudzbaUpdate narudzbaUpdateRequest;
  late NarudzbaInsert narudzbaInsertRequest;

  @override
  void initState() {
    getPopustKuponi();
    convertIznos();
  }

  Future<List<PopustKupon>?> getPopustKuponi() async {
    var popustKuponi = await APIService.Get("PopustKupon", null);

    popustKuponiList =
        popustKuponi?.map((i) => PopustKupon.fromJson(i)).toList();
  }

  Future<void> postTransakcija() async {
    await APIService.Post(
        "Transakcija", json.encode(transakcijaInsertRequest.toJson()));
  }

  Future<void> ocistiKorpa() async {
    var korpaProizvodi = await APIService.Get("NarudzbaProizvod", null);

    var korpaProizvodiList = korpaProizvodi
        ?.map((i) => NarudzbaProizvod.fromJson(i))
        .where((element) => element.narudzbaId == APIService.narudzbaId)
        .toList();

    korpaProizvodiList?.forEach((element) async {
      if (element.narudzbaId == APIService.narudzbaId) {
        await APIService.Delete("NarudzbaProizvod", element.id!);
      }
    });
  }

  Future<void> updateNarudzba() async {
    narudzbaUpdateRequest = NarudzbaUpdate(aktivna: false, zavrsena: true);

    await APIService.Update("Narudzba", APIService.narudzbaId,
        json.encode(narudzbaUpdateRequest.toJson()));
  }

  Future<void> kreirajNarudzba() async {
    narudzbaInsertRequest = NarudzbaInsert(
        korisnikId: APIService.korisnikId,
        datum: DateTime.now(),
        aktivna: true,
        zavrsena: false);

    await APIService.Post(
            "Narudzba", json.encode(narudzbaInsertRequest.toJson()))
        .then((value) async {
      Map<String, String>? queryParams = null;
      queryParams = {"korisnikId": APIService.korisnikId.toString()};

      var narudzbe = await APIService.Get("Narudzba", queryParams);
      var narudzbeList = narudzbe?.map((i) => Narudzba.fromJson(i)).toList();

      narudzbeList?.forEach((e) {
        if (e.korisnikId == APIService.korisnikId && e.aktivna == true) {
          APIService.narudzbaId = e.id;
        }
      });
    });
  }

  void provjeraPopustKupon() {
    popustKuponiList?.forEach((element) {
      if (element.kod == popustKuponController.text) {
        iskoristenKupon = true;
        iznos = element.iznos!;
        kuponId = element.id;
      }
    });
  }

  void izracunajPopust() {
    widget.ukCijena = widget.ukCijena - (widget.ukCijena * iznos / 100);
    convertIznos();
  }

  void convertIznos() {
    String? toInt;
    toInt = widget.ukCijena
            .toString()
            .substring(0, widget.ukCijena.toString().indexOf(".")) +
        widget.ukCijena.toStringAsFixed(2).substring(
            widget.ukCijena.toStringAsFixed(2).indexOf(".") + 1,
            widget.ukCijena.toStringAsFixed(2).length);

    iznosInt = int.parse(toInt);
  }

  Future<void> makePayment() async {
    try {
      paymentIntentData = await createPaymentIntent(iznosInt.toString(), 'bam');
      await Stripe.instance
          .initPaymentSheet(
              paymentSheetParameters: SetupPaymentSheetParameters(
                  paymentIntentClientSecret:
                      paymentIntentData!['client_secret'],
                  applePay: true,
                  googlePay: true,
                  testEnv: true,
                  style: ThemeMode.dark,
                  merchantCountryCode: 'BIH',
                  merchantDisplayName: 'Ajdin'))
          .then((value) {});

      ///now finally display payment sheeet
      displayPaymentSheet();
    } catch (e, s) {
      print('exception:$e$s');
    }
  }

  displayPaymentSheet() async {
    try {
      await Stripe.instance
          .presentPaymentSheet(
              parameters: PresentPaymentSheetParameters(
        clientSecret: paymentIntentData!['client_secret'],
        confirmPayment: true,
      ))
          .then((newValue) async {
        print('payment intent' + paymentIntentData!['id'].toString());
        print(
            'payment intent' + paymentIntentData!['client_secret'].toString());
        print('payment intent' + paymentIntentData!['amount'].toString());
        print('payment intent' + paymentIntentData.toString());
        //orderPlaceApi(paymentIntentData!['id'].toString());
        ScaffoldMessenger.of(context)
            .showSnackBar(const SnackBar(content: Text("Uplata uspjesna")));

        transakcijaInsertRequest = Transakcija(
            narudzbaId: APIService.narudzbaId,
            popustKuponId: iskoristenKupon == true ? kuponId : null,
            stripePaymentId: paymentIntentData!["id"].toString(),
            datum: DateTime.now(),
            iznos: widget.ukCijena,
            nacinPlacanja: "Kartica");
        paymentIntentData = null;

        await postTransakcija();
        await ocistiKorpa().then((value) async {
          await updateNarudzba().then((value) async {
            await kreirajNarudzba();
            Navigator.of(context).pushReplacementNamed("/proizvodi");
          });
        });
      }).onError((error, stackTrace) {
        print('Exception/DISPLAYPAYMENTSHEET==> $error $stackTrace');
      });
    } on StripeException catch (e) {
      showDialog(
          context: context,
          builder: (_) => const AlertDialog(
                content: Text("Ponisteno "),
              ));
    } catch (e) {
      print('$e');
    }
  }

  //  Future<Map<String, dynamic>>
  createPaymentIntent(String amount, String currency) async {
    try {
      Map<String, dynamic> body = {
        'amount': amount,
        'currency': currency,
        'payment_method_types[]': 'card'
      };

      var response = await http.post(
          Uri.parse('https://api.stripe.com/v1/payment_intents'),
          body: body,
          headers: {
            'Authorization':
                'Bearer sk_test_51KUEEACcGdmoO9FehK7CtmodSs7QC7IDOcOPvrjMcPWFswftvhyEngW1ZeGRqItX9qQCKpZB56cOEVw2RaZ1z0fA005v2y49Sd',
            'Content-Type': 'application/x-www-form-urlencoded'
          });
      return jsonDecode(response.body);
    } catch (err) {
      print('err charging user: ${err.toString()}');
    }
  }

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      appBar: AppBar(
        title: const Text("Placanje"),
      ),
      body: bodyWidget(),
    );
  }

  Widget bodyWidget() {
    return Column(
      children: [
        Container(
          margin: const EdgeInsets.all(30),
          child: TextFormField(
            controller: popustKuponController,
            decoration: const InputDecoration(
              labelText: "Unesite kupon kod",
              counterText: "",
              filled: true,
              fillColor: Colors.white,
              focusedBorder: OutlineInputBorder(
                borderRadius: BorderRadius.all(Radius.circular(4)),
                borderSide: BorderSide(
                  width: 1,
                  color: Colors.orangeAccent,
                ),
              ),
              enabledBorder: OutlineInputBorder(
                borderRadius: BorderRadius.all(Radius.circular(4)),
                borderSide: BorderSide(
                  width: 1,
                  color: Colors.purple,
                ),
              ),
            ),
          ),
        ),
        ElevatedButton(
          onPressed: () {
            if (!iskoristenKupon) {
              provjeraPopustKupon();
              if (!iskoristenKupon) {
                ShowAlertDialog.showAlertDialog(
                    context, "NEUSPJESNO !", "Kupon kod ne postoji", false);
              } else {
                izracunajPopust();
                setState(() {
                  ShowAlertDialog.showAlertDialog(context, "USPJESNO !",
                      "Uspjesno ste iskoristili kupon kod", false);
                });
              }
            } else {
              ShowAlertDialog.showAlertDialog(context, "NEUSPJESNO !",
                  "Vec ste iskoristili kupon kod", false);
            }
          },
          child: const Text("Potvrdi kupon kod"),
          style: ElevatedButton.styleFrom(
              primary: Colors.orangeAccent,
              textStyle: const TextStyle(
                fontSize: 24,
              ),
              padding: const EdgeInsets.all(10)),
        ),
        const SizedBox(
          height: 15,
        ),
        Chip(
          label: Text(
            widget.ukCijena.toStringAsFixed(2) + " KM",
            style: const TextStyle(
              fontSize: 18,
              fontWeight: FontWeight.bold,
              color: Colors.white,
            ),
          ),
          padding: const EdgeInsets.all(10),
          backgroundColor: Colors.purple,
        ),
        const SizedBox(
          height: 10,
        ),
        const Divider(
          thickness: 1,
          color: Colors.red,
        ),
        const SizedBox(
          height: 15,
        ),
        ElevatedButton.icon(
          icon: const Icon(Icons.payment),
          onPressed: () {
            makePayment();
          },
          label: const Text(
            "PLATI",
            style: TextStyle(fontSize: 24),
          ),
          style: ElevatedButton.styleFrom(
            primary: Colors.blue,
            padding: const EdgeInsets.all(14),
          ),
        )
      ],
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
