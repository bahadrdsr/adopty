import 'dart:convert';
import 'dart:io';

import 'package:client_mobile/models/authresult.dart';
import 'package:dio/dio.dart';

class AuthProvider {
  static String mainUrl = "http://10.0.2.2:5000/api/account";

  final Dio _dio = Dio();
  var loginUrl = '$mainUrl/login';

  Future<AuthResult> login(String email, String password) async {
    var params = {
      'email': email,
      'password': password,
    };

    try {
      Response response = await _dio.post(
        loginUrl,
        data: params,
        options: Options(headers: {
          HttpHeaders.contentTypeHeader: "application/json",
        }),
      );
      return AuthResult.fromJson(response.data);
    } catch (error, stacktrace) {
      print("Exception occured: $error stackTrace: $stacktrace");
      return new AuthResult(token: "", username: "");
      // return AuthResult.withError("$error");
    }
  }
}
