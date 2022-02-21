import 'package:flutter/material.dart';

class ShowAlertDialog{
  static showAlertDialog(BuildContext context, title, info, repNamed) {
    // set up the button
    Widget okButton = TextButton(
      child: const Text("U redu"),
      onPressed: () {
        if(!repNamed){
          Navigator.of(context).pop();
        } else{
          Navigator.of(context).pushReplacementNamed("/");
        }
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