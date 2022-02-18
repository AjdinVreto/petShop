import 'package:flutter/material.dart';
import 'package:petshop_mobile/screens/kontakt_screen.dart';

import 'package:petshop_mobile/screens/korpa_screen.dart';
import 'package:petshop_mobile/screens/pocetna_screen.dart';
import 'package:petshop_mobile/screens/profil_screen.dart';
import 'package:petshop_mobile/screens/proizvodi_screen.dart';
import 'package:petshop_mobile/screens/registracija_screen.dart';
import './screens/login_screen.dart';

void main() {
  runApp(const MyApp());
}

class MyApp extends StatelessWidget {
  const MyApp({Key? key}) : super(key: key);

  @override
  Widget build(BuildContext context) {
    return MaterialApp(
      title: "Pet Shop",
      theme: ThemeData(
        primarySwatch: Colors.purple,
        accentColor: Colors.deepOrange,
        fontFamily: "Raleway",
      ),
      home: Login(),
      routes: {
        Proizvodi.routeName: (ctx) => Proizvodi(),
        Korpa.routeName: (ctx) => Korpa(),
        Pocetna.routeName: (ctx) => Pocetna(),
        Profil.routeName: (ctx) => Profil(),
        KontaktScreen.routeName: (ctx) => KontaktScreen(),
        Registracija.routeName: (ctx) => Registracija(),
      },
    );
  }
}

