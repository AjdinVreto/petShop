import 'package:flutter/material.dart';

import 'package:petshop_mobile/screens/proizvodi_screen.dart';
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
        fontFamily: "Lato",
      ),
      home: Login(),
      routes: {
        Proizvodi.routeName: (ctx) => Proizvodi(),
      },
    );
  }
}

