import 'package:client_mobile/resources/constants.dart';
import 'package:dio/dio.dart';
import 'package:flutter_secure_storage/flutter_secure_storage.dart';
import 'package:fluttertoast/fluttertoast.dart';

class AdoptyDio {
  Dio dio = Dio();
  FlutterSecureStorage storage = new FlutterSecureStorage();

  AdoptyDio() {
    dio.options.baseUrl = URL_API;

    dio.interceptors.add(InterceptorsWrapper(onRequest: (RequestOptions options,
        RequestInterceptorHandler interceptorHandler) async {
      print(options.uri);
      options.headers["Content-Type"] = "application/json";
      String? token = await storage.read(key: "accessToken");
      if (token != null) {
        options.headers["Authorization"] = "Bearer " + token;
      }
      interceptorHandler.next(options);
    }, onResponse:
        (Response response, ResponseInterceptorHandler interceptorHandler) {
      interceptorHandler.next(response);
      print(response);
    }, onError: (DioError e, ErrorInterceptorHandler errorInterceptorHandler) {
      print(e);
      errorInterceptorHandler.next(e);
      Fluttertoast.showToast(msg: e.message);
    }));
  }

  Dio getClient() => dio;
}
