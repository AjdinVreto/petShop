import 'dart:convert';

import 'package:flutter/material.dart';
import 'package:petshop_mobile/models/Narudzba.dart';
import 'package:petshop_mobile/screens/proizvodi_screen.dart';

import '../services/APIService.dart';

class Login extends StatefulWidget {
  @override
  State<Login> createState() => _LoginState();
}

class _LoginState extends State<Login> {
  TextEditingController usernameController = TextEditingController();
  TextEditingController passwordController = TextEditingController();

  Narudzba? narudzbaRequest;

  var result = null;
  var narudzbe = null;
  var narudzbeList = null;
  var narId = null;

  bool narudzbaPostoji = false;

  Future<void> GetData() async {
    result = await APIService.Login("Korisnik/login");

    narudzbe = await APIService.Get("Narudzba", null);
    narudzbeList = narudzbe?.map((i) => Narudzba.fromJson(i)).toList();
  }

  Future<void> kreirajNarudzbu() async{
    narudzbeList.forEach((item) {
      if(item.korisnikId == APIService.korisnikId){
        narudzbaPostoji = true;
        APIService.narudzbaId = item.id;
      };
    });

    if(!narudzbaPostoji){
      var id = narudzbeList.length + 1;
      narudzbaRequest = Narudzba(id: id, aktivna: true, zavrsena: false, datum: DateTime.now(), korisnikId: APIService.korisnikId);
      await APIService.Post("Narudzba", json.encode(narudzbaRequest?.toJson()));
      APIService.narudzbaId = id;
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
                    await kreirajNarudzbu();
                    Navigator.of(context)
                        .pushReplacementNamed(Proizvodi.routeName);
                  } else {
                    print("Pogresni login podaci");
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
              )
            ],
          ),
        ),
      ),
    );
  }
}
