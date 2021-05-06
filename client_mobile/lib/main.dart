import 'package:client_mobile/pages/candidate_profile_page.dart';
import 'package:client_mobile/pages/foster_post_form_page.dart';
import 'package:client_mobile/pages/foster_posts_page.dart';
import 'package:client_mobile/pages/foster_profile_page.dart';
import 'package:client_mobile/pages/login_page.dart';
import 'package:client_mobile/pages/personal_info_page.dart';
import 'package:flutter/material.dart';

void main() {
  runApp(MyApp());
}

class MyApp extends StatelessWidget {
  @override
  Widget build(BuildContext context) {
    return MaterialApp(
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
    );
  }
}
