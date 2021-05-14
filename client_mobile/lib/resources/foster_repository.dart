import 'dart:io';
import 'package:client_mobile/models/foster_profile.dart';
import 'package:dio/dio.dart';

class FosterRepository {
  final Dio dio;
  FosterRepository(this.dio);

  Future<FosterProfile> getMyProfile() async {
    try {
      Response response = await dio.get(
        'fosterprofile/get',
        options: Options(headers: {
          HttpHeaders.contentTypeHeader: "application/json",
        }),
      );
      return FosterProfile.fromJson(response.data);
    } catch (error, stacktrace) {
      print("Exception occured: $error stackTrace: $stacktrace");
      throw error;
      // return AuthResult.withError("$error");
    }
  }
}
