import 'dart:convert';

import 'package:flutter/material.dart';
import 'package:http/http.dart' as http;
import 'dart:convert';
import 'dart:io';

class APIService {
  static late String username;
  static late String password;
  String route;

  APIService({required this.route});

  void SetParameter(String Username, String Password){
    username = Username;
    password = Password;
  }

  static Future<String> Get(String route) async {
    String baseUrl = "http://109.175.98.154:5013/"+route;
    final String basicAuth = "Basic "+base64Encode(utf8.encode("$username:$password"));
    final response = await http.get(
      Uri.parse(baseUrl),
      headers: {HttpHeaders.authorizationHeader:basicAuth}
    );
    if(response.statusCode == 200) {
      return JsonDecoder().convert(response.body);
    }
  }
}