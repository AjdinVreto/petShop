import 'dart:convert';

import 'package:http/http.dart' as http;

import 'package:flutter/material.dart';
import 'package:flutter_stripe/flutter_stripe.dart';
import 'package:petshop_mobile/models/PopustKupon.dart';
import 'package:petshop_mobile/services/APIService.dart';

class Placanje extends StatefulWidget {
  double ukCijena;

  Placanje(this.ukCijena);

  @override
  _PlacanjeState createState() => _PlacanjeState();
}

class _PlacanjeState extends State<Placanje> {
  List<PopustKupon>? popustKuponiList = null;
  bool iskoristenKupon = false;
  int iznos = 0;
  int iznosInt = 0;

  TextEditingController popustKuponController = TextEditingController();

  Map<String, dynamic>? paymentIntentData;

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

  void provjeraPopustKupon() {
    popustKuponiList?.forEach((element) {
      if (element.kod == popustKuponController.text) {
        iskoristenKupon = true;
        iznos = element.iznos!;
      }
    });
  }

  void izracunajPopust(){
    widget.ukCijena = widget.ukCijena - (widget.ukCijena * iznos / 100);
  }

  void convertIznos(){
    String? prvidio;
    String? drugidio;
    prvidio = widget.ukCijena.toString().substring(0,widget.ukCijena.toString().indexOf("."));
    drugidio = widget.ukCijena.toStringAsFixed(2).substring(widget.ukCijena.toStringAsFixed(2).indexOf(".") + 1, widget.ukCijena.toStringAsFixed(2).length);
    print(prvidio + " " + drugidio);
    iznosInt = int.parse(prvidio + drugidio);
    print(iznosInt);
  }

  Future<void> makePayment() async {
    try {

      paymentIntentData =
      await createPaymentIntent('10', 'KM');
      await Stripe.instance.initPaymentSheet(
          paymentSheetParameters: SetupPaymentSheetParameters(
              paymentIntentClientSecret: paymentIntentData!['client_secret'],
              applePay: true,
              googlePay: true,
              testEnv: true,
              style: ThemeMode.dark,
              merchantCountryCode: 'US',
              merchantDisplayName: 'ANNIE')).then((value){
      });


      ///now finally display payment sheeet
      displayPaymentSheet();
    } catch (e, s) {
      print('exception:$e$s');
    }
  }

  displayPaymentSheet() async {

    try {
      await Stripe.instance.presentPaymentSheet(
          parameters: PresentPaymentSheetParameters(
            clientSecret: paymentIntentData!['client_secret'],
            confirmPayment: true,
          )).then((newValue){

        print('payment intent'+paymentIntentData!['id'].toString());
        print('payment intent'+paymentIntentData!['client_secret'].toString());
        print('payment intent'+paymentIntentData!['amount'].toString());
        print('payment intent'+paymentIntentData.toString());
        //orderPlaceApi(paymentIntentData!['id'].toString());
        ScaffoldMessenger.of(context).showSnackBar(SnackBar(content: Text("Uplata uspjesna")));

        paymentIntentData = null;

      }).onError((error, stackTrace){
        print('Exception/DISPLAYPAYMENTSHEET==> $error $stackTrace');
      });


    } on StripeException catch (e) {
      print('Exception/DISPLAYPAYMENTSHEET==> $e');
      showDialog(
          context: context,
          builder: (_) => AlertDialog(
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
        'amount': calculateAmount(iznosInt.toString()),
        'currency': currency,
        'payment_method_types[]': 'card'
      };

      var response = await http.post(
          Uri.parse('https://api.stripe.com/v1/payment_intents'),
          body: body,
          headers: {
            'Authorization': 'Bearer sk_test_51KUEEACcGdmoO9FehK7CtmodSs7QC7IDOcOPvrjMcPWFswftvhyEngW1ZeGRqItX9qQCKpZB56cOEVw2RaZ1z0fA005v2y49Sd',
            'Content-Type': 'application/x-www-form-urlencoded'
          });
      print('Create Intent reponse ===> ${response.body.toString()}');
      return jsonDecode(response.body);
    } catch (err) {
      print('err charging user: ${err.toString()}');
    }
  }

  calculateAmount(String amount) {
    final a = (int.parse(amount)) * 1 ;
    return a.toString();
  }

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      appBar: AppBar(
        title: Text("Placanje"),
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
                showAlertDialog(
                    context, "NEUSPJESNO !", "Kupon kod ne postoji");
              } else {
                izracunajPopust();
                setState(() {
                  showAlertDialog(context, "USPJESNO !",
                      "Uspjesno ste iskoristili kupon kod");
                });
              }
            } else {
              showAlertDialog(
                  context, "NEUSPJESNO !", "Vec ste iskoristili kupon kod");
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
        SizedBox(
          height: 15,
        ),
        Chip(
          label: Text(
            widget.ukCijena.toStringAsFixed(2) + " KM",
            style: TextStyle(
              fontSize: 18,
              fontWeight: FontWeight.bold,
              color: Colors.white,
            ),
          ),
          padding: EdgeInsets.all(10),
          backgroundColor: Colors.purple,
        ),
        SizedBox(
          height: 10,
        ),
        Divider(
          thickness: 1,
          color: Colors.red,
        ),
        SizedBox(
          height: 15,
        ),
        ElevatedButton.icon(
          icon: Icon(Icons.payment),
          onPressed: () {
            makePayment();
          },
          label: Text(
            "PLATI",
            style: TextStyle(fontSize: 24),
          ),
          style: ElevatedButton.styleFrom(
            primary: Colors.blue,
            padding: EdgeInsets.all(14),
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
