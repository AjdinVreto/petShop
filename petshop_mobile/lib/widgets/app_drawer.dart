import 'package:flutter/material.dart';


class AppDrawer extends StatelessWidget {
  @override
  Widget build(BuildContext context) {
    return Drawer(
      child: Column(
        children: [
          AppBar(
            title: Text("Meni"),
            automaticallyImplyLeading: false,
            centerTitle: true,
          ),
          Divider(),
          ListTile(
            leading: Icon(Icons.home),
            title: Text("Pocetna"),
            onTap: () {
              Navigator.of(context).pushReplacementNamed('/proizvodi');
            },
          ),
          Divider(),
          ListTile(
            leading: Icon(Icons.shop),
            title: Text("Shop"),
            onTap: () {
              Navigator.of(context).pushReplacementNamed('/proizvodi');
            },
          ),
          Divider(),
          ListTile(
            leading: Icon(Icons.add_shopping_cart),
            title: Text("Korpa"),
            onTap: () {
              Navigator.of(context).pushReplacementNamed('/orders');
            },
          ),
          Divider(),
          ListTile(
            leading: Icon(Icons.person),
            title: Text("Profil"),
            onTap: () {
              Navigator.of(context).pushReplacementNamed('/orders');
            },
          ),
          Divider(),
          ListTile(
            leading: Icon(Icons.logout),
            title: Text("Odjava"),
            onTap: () {
              Navigator.of(context).pushReplacementNamed('/');
            },
          ),
        ],
      ),
    );
  }
}
