import 'package:dio/dio.dart';
import 'package:flutter_secure_storage/flutter_secure_storage.dart';

class BaseProvider {
  static String mainUrl = "http://10.0.2.2:5000/api/";
  final storage = new FlutterSecureStorage();

  final Dio _dio = Dio();
  BaseProvider() {
    _dio.interceptors.add(InterceptorsWrapper(
      onRequest: (options, handler) async {
        String? token = await storage.read(key: "accessToken");
        if (token != null) {
          options.headers["Authorization"] = "Bearer " + token;
        }
      },
    ));
  }
}
