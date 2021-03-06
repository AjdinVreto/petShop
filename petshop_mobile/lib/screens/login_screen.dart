import 'dart:convert';
import 'package:flutter/material.dart';
import 'package:petshop_mobile/models/Narudzba.dart';
import 'package:petshop_mobile/models/Requests/NarudzbaInsert.dart';
import 'package:petshop_mobile/screens/proizvodi_screen.dart';
import 'package:petshop_mobile/screens/registracija_screen.dart';
import 'package:petshop_mobile/widgets/alert_dialog.dart';

import '../services/APIService.dart';

class Login extends StatefulWidget {
  @override
  State<Login> createState() => _LoginState();
}

class _LoginState extends State<Login> {
  TextEditingController usernameController = TextEditingController();
  TextEditingController passwordController = TextEditingController();

  NarudzbaInsert? narudzbaRequest;

  var result = null;
  var narudzbe = null;
  var narudzbeList = null;

  bool narudzbaPostoji = false;

  Future<void> GetData() async {
    result = await APIService.Login("Korisnik/login");
  }

  Future<void> GetNarudzbe() async{
    Map<String, String>? queryParams = null;
    queryParams = {"korisnikId": APIService.korisnikId.toString()};

    narudzbe = await APIService.Get("Narudzba", queryParams);
    narudzbeList = narudzbe?.map((i) => Narudzba.fromJson(i)).toList();
  }

  Future<void> kreirajNarudzbu() async {
    narudzbeList.forEach((item) {
      if (item.korisnikId == APIService.korisnikId && item.aktivna == true) {
        narudzbaPostoji = true;
        APIService.narudzbaId = item.id;
      }
    });

    if (!narudzbaPostoji) {
      narudzbaRequest = NarudzbaInsert(
        aktivna: true,
        zavrsena: false,
        datum: DateTime.now(),
        korisnikId: APIService.korisnikId,
      );
      await APIService.Post("Narudzba", json.encode(narudzbaRequest?.toJson())).then((value) async {
        await GetNarudzbe().then((value) {
          narudzbeList.forEach((item){
            if(item.korisnikId == APIService.korisnikId && item.aktivna == true){
              APIService.narudzbaId = item.id;
            }
          });
        });
      });
    }
  }

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      appBar: AppBar(
        title: const Text("Prijava"),
        centerTitle: true,
        backgroundColor: Theme.of(context).primaryColor,
      ),
      body: SingleChildScrollView(
        child: Padding(
          padding: const EdgeInsets.all(30),
          child: Column(
            children: [
              const Image(
                image: AssetImage("./assets/images/logo.png"),
                width: 180,
                height: 220,
              ),
              const SizedBox(
                height: 10,
              ),
              TextField(
                controller: usernameController,
                decoration: InputDecoration(
                    border: OutlineInputBorder(
                      borderRadius: BorderRadius.circular(20),
                    ),
                    hintText: "Korisnicko ime"),
              ),
              const SizedBox(
                height: 15,
              ),
              TextField(
                obscureText: true,
                controller: passwordController,
                decoration: InputDecoration(
                    border: OutlineInputBorder(
                      borderRadius: BorderRadius.circular(20),
                    ),
                    hintText: "Password"),
              ),
              const SizedBox(
                height: 25,
              ),
              ElevatedButton(
                style: ButtonStyle(
                  shape: MaterialStateProperty.all(
                    RoundedRectangleBorder(
                      borderRadius: BorderRadius.circular(20),
                    ),
                  ),
                ),
                onPressed: () async {
                  APIService.username = usernameController.text;
                  APIService.password = passwordController.text;
                  await GetData();
                  if (result != null) {
                    APIService.SetParameter(result.id);
                    await GetNarudzbe().then((value) async{
                      await kreirajNarudzbu().then((value) {
                        Navigator.of(context)
                            .pushReplacementNamed(Proizvodi.routeName);
                      });
                    });
                  } else {
                    ShowAlertDialog.showAlertDialog(
                        context, "Greska", "Login podaci nisu tacni", false);
                  }
                },
                child: const Padding(
                  padding: EdgeInsets.all(10),
                  child: Text(
                    "Prijavi se",
                    style: TextStyle(
                      fontSize: 30,
                      fontWeight: FontWeight.bold,
                    ),
                  ),
                ),
              ),
              const SizedBox(
                height: 15,
              ),
              ElevatedButton(
                style: ElevatedButton.styleFrom(
                  primary: Colors.blue,
                ),
                onPressed: () {
                  Navigator.push(
                    context,
                    MaterialPageRoute(
                      builder: (context) => Registracija(),
                    ),
                  );
                },
                child: const Padding(
                  padding: EdgeInsets.all(10),
                  child: Text(
                    "Registruj se",
                    style: TextStyle(
                      fontSize: 30,
                      fontWeight: FontWeight.bold,
                    ),
                  ),
                ),
              ),
            ],
          ),
        ),
      ),
    );
  }
}
