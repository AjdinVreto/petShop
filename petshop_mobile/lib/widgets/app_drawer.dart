import 'package:flutter/material.dart';


class AppDrawer extends StatelessWidget {
  @override
  Widget build(BuildContext context) {
    return Drawer(
      child: Column(
        children: [
          AppBar(
            title: const Text("Meni"),
            automaticallyImplyLeading: false,
            centerTitle: true,
          ),
          const Divider(),
          ListTile(
            leading: const Icon(Icons.home),
            title: const Text("Pocetna"),
            onTap: () {
              Navigator.of(context).pushReplacementNamed('/pocetna');
            },
          ),
          const Divider(),
          ListTile(
            leading: const Icon(Icons.shop),
            title: const Text("Shop"),
            onTap: () {
              Navigator.of(context).pushReplacementNamed('/proizvodi');
            },
          ),
          const Divider(),
          ListTile(
            leading: const Icon(Icons.add_shopping_cart),
            title: const Text("Korpa"),
            onTap: () {
              Navigator.of(context).pushReplacementNamed('/korpa');
            },
          ),
          const Divider(),
          ListTile(
            leading: const Icon(Icons.person),
            title: const Text("Profil"),
            onTap: () {
              Navigator.of(context).pushReplacementNamed('/profil');
            },
          ),
          const Divider(),
          ListTile(
            leading: const Icon(Icons.logout),
            title: const Text("Odjava"),
            onTap: () {
              Navigator.of(context).pushReplacementNamed('/');
            },
          ),
        ],
      ),
    );
  }
}
