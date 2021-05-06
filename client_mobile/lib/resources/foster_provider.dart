import 'dart:convert';
import 'dart:io';

import 'package:client_mobile/models/authresult.dart';
import 'package:client_mobile/models/foster_profile.dart';
import 'package:client_mobile/resources/base_provider.dart';
import 'package:dio/dio.dart';

class FosterProvider extends BaseProvider {
  FosterProvider() {}

  Future<FosterProfile> getMyProfile() async {
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
