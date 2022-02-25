import 'package:flutter/material.dart';
import 'package:intl/intl.dart';

class NovostDetalji extends StatelessWidget {
  final novost;

  NovostDetalji(this.novost);

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      appBar: AppBar(
        title: const Text("Novosti"),
      ),
      body: bodyWidget(),
    );
  }

  Widget bodyWidget() {
    return SingleChildScrollView(
      child: Column(
        children: [
          const SizedBox(
            height: 10,
          ),
          Container(
            margin: EdgeInsets.only(right: 5, left: 5),
            child: Chip(
              backgroundColor: Colors.orangeAccent,
              padding: const EdgeInsets.all(10),
              label: Text(
                novost.naslov,
                style: const TextStyle(
                    fontSize: 28,
                    fontWeight: FontWeight.bold,
                    color: Colors.white),
                maxLines: 2,
                softWrap: true,
                textAlign: TextAlign.center,
              ),
            ),
          ),
          const SizedBox(
            height: 12,
          ),
          Container(
            height: 250,
            width: double.infinity,
            padding: const EdgeInsets.all(12),
            child: Image(
              image: MemoryImage(novost.slika),
              fit: BoxFit.cover,
            ),
          ),
          const SizedBox(
            height: 12,
          ),
          Container(
            height: 250,
            width: double.infinity,
            margin: const EdgeInsets.all(10),
            padding: const EdgeInsets.all(12),
            decoration: BoxDecoration(
              borderRadius: BorderRadius.circular(20),
              color: Colors.purple,
            ),
            child: Text(
              novost.tekst,
              style: const TextStyle(
                fontSize: 18,
                color: Colors.white,
              ),
            ),
          ),
          Center(
            child: Text(
              "Objavljeno:  " + DateFormat("dd/MM/yyyy").format(novost.datum),
              style: const TextStyle(
                fontSize: 16,
                fontWeight: FontWeight.bold,
              ),
            ),
          )
        ],
      ),
    );
  }
}
