import 'package:bloc_pattern/bloc_pattern.dart';
import 'package:client_mobile/bloc/auth_bloc.dart';
import 'package:client_mobile/bloc/foster_bloc.dart';
import 'package:client_mobile/pages/login_page.dart';
import 'package:client_mobile/resources/auth_repository.dart';
import 'package:client_mobile/resources/custom_dio.dart';
import 'package:client_mobile/resources/foster_repository.dart';
import 'package:flutter/material.dart';

void main() {
  runApp(MyApp());
}

class MyApp extends StatelessWidget {
  @override
  Widget build(BuildContext context) {
    return BlocProvider(
      child: MaterialApp(
        debugShowCheckedModeBanner: false,
        title: 'Adopty',
        theme: ThemeData(
            brightness: Brightness.light,
            primaryColor: Color(0xffd32f2f),
            accentColor: Color(0xffff8f00),
            backgroundColor: Colors.red[50],
            textTheme: TextTheme(
                bodyText1: TextStyle(fontFamily: 'OpenSans', fontSize: 24)),
            buttonTheme: ButtonThemeData(
                buttonColor: Color(0xffff8f00),
                shape: RoundedRectangleBorder(),
                textTheme: ButtonTextTheme.accent),
            elevatedButtonTheme: ElevatedButtonThemeData(
                style: ElevatedButton.styleFrom(
              onPrimary: Colors.white,
              primary: Color(0xffff8f00),
            ))),
        home: LoginPage(),
      ),
      blocs: [
        Bloc((i) => AuthBloc(i.get<AuthRepository>())),
        Bloc((i) => FosterBloc(i.get<FosterRepository>()))
      ],
      dependencies: [
        Dependency((i) => AdoptyDio()),
        Dependency((i) => AuthRepository(i.get<AdoptyDio>().getClient())),
        Dependency((i) => FosterRepository(i.get<AdoptyDio>().getClient())),
      ],
    );
  }
}
