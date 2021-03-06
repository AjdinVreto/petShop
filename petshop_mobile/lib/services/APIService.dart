import 'dart:convert';

import 'package:http/http.dart' as http;
import 'dart:io';

import 'package:petshop_mobile/models/Korisnik.dart';

class APIService {
  static const String _baseRoute = "http://10.0.2.2:5013/api/";

  static late int korisnikId;
  static late int narudzbaId;
  static late String username;
  static late String password;
  String route;

  APIService({required this.route});

  static void SetParameter(int KorisnikId) {
    korisnikId = KorisnikId;
  }

  static Future<List<dynamic>?> Get(String route, dynamic object) async {
    String queryString = Uri(queryParameters: object).query;
    String baseUrl = _baseRoute + route;
    if (object != null) {
      baseUrl = baseUrl + '?' + queryString;
    }

    final String basicAuth =
        'Basic ' + base64Encode(utf8.encode('$username:$password'));

    final response = await http.get(Uri.parse(baseUrl),
        headers: {HttpHeaders.authorizationHeader: basicAuth});

    if (response.statusCode == 200) {
      return json.decode(response.body) as List;
    }

    return null;
  }

  static Future<dynamic> GetById(String route, int id) async {
    String baseUrl = _baseRoute + route + "/" + id.toString();
    final String basicAuth =
        'Basic ' + base64Encode(utf8.encode('$username:$password'));
    final response = await http.get(
      Uri.parse(baseUrl),
      headers: {HttpHeaders.authorizationHeader: basicAuth},
    );
    if (response.statusCode == 200) {
      return json.decode(response.body);
    }

    return null;
  }

  static Future<dynamic> Post(String route, String body) async {
    String baseUrl = _baseRoute + route;

    final String basicAuth =
        'Basic ' + base64Encode(utf8.encode('$username:$password'));

    final response = await http.post(
      Uri.parse(baseUrl),
      headers: <String, String>{
        'Content-Type': 'application/json; charset=UTF-8',
        HttpHeaders.authorizationHeader: basicAuth
      },
      body: body,
    );

    if (response.statusCode == 200) {
      return json.decode(response.body);
    }

    return null;
  }

  static Future<dynamic> Update(String route, int id, String body) async {
    String baseUrl = _baseRoute + route + "/" + id.toString();

    final String basicAuth =
        'Basic ' + base64Encode(utf8.encode('$username:$password'));

    final response = await http.put(Uri.parse(baseUrl),
        headers: <String, String>{
          'Content-Type': 'application/json; charset=UTF-8',
          HttpHeaders.authorizationHeader: basicAuth
        },
        body: body);

    if (response.statusCode == 200) {
      json.decode(response.body);
    }

    return null;
  }

  static Future<dynamic> Delete(String route, int id) async {
    String baseUrl = _baseRoute + route + "/" + id.toString();

    final String basicAuth =
        'Basic ' + base64Encode(utf8.encode('$username:$password'));

    final response = await http.delete(
      Uri.parse(baseUrl),
      headers: {HttpHeaders.authorizationHeader: basicAuth},
    );

    if (response.statusCode == 201) {
      json.decode(response.body);
    }

    return null;
  }

  static Future<Korisnik?> Login(String route) async {
    String baseUrl = _baseRoute + route;

    final String basicAuth =
        'Basic ' + base64Encode(utf8.encode('$username:$password'));

    final response = await http.get(
      Uri.parse(baseUrl),
      headers: {HttpHeaders.authorizationHeader: basicAuth},
    );

    if (response.statusCode == 200) {
      return Korisnik.fromJson(json.decode(response.body));
    }

    return null;
  }

  static Future<List<dynamic>?> GetGradSpol(
      String route, dynamic object) async {
    String queryString = Uri(queryParameters: object).query;
    String baseUrl = _baseRoute + route;
    if (object != null) {
      baseUrl = baseUrl + '?' + queryString;
    }

    final response = await http.get(
      Uri.parse(baseUrl),
      headers: <String, String>{
        'Content-Type': 'application/json; charset=UTF-8'
      },
    );

    if (response.statusCode == 200) {
      return json.decode(response.body) as List;
    }

    return null;
  }

  static Future<dynamic> Registracija(String route, String body) async {
    String baseUrl = _baseRoute + route;

    final response = await http.post(
      Uri.parse(baseUrl),
      headers: <String, String>{
        'Content-Type': 'application/json; charset=UTF-8'
      },
      body: body,
    );

    if (response.statusCode == 200) {
      return json.decode(response.body);
    }

    return null;
  }
}
