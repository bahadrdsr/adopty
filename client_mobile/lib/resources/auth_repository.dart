import 'dart:io';
import 'package:client_mobile/models/authresult.dart';
import 'package:dio/dio.dart';

class AuthRepository {
  final Dio dio;
  AuthRepository(this.dio);

  Future<AuthResult> login(String email, String password) async {
    var params = {
      'email': email,
      'password': password,
    };

    try {
      Response response = await dio.post(
        'Account/login',
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
