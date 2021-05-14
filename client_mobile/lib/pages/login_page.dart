import 'package:bloc_pattern/bloc_pattern.dart';
import 'package:client_mobile/bloc/auth_bloc.dart';
import 'package:client_mobile/pages/personal_info_page.dart';
import 'package:flutter/material.dart';
import '';

class LoginPage extends StatefulWidget {
  @override
  _LoginPageState createState() => _LoginPageState();
}

class _LoginPageState extends State<LoginPage> {
  final _formKey = GlobalKey<FormState>();
  final TextEditingController _emailController = TextEditingController();
  final TextEditingController _passwordController = TextEditingController();

  var authBloc = BlocProvider.getBloc<AuthBloc>();
  @override
  Widget build(BuildContext context) {
    return Scaffold(
        body: Container(
            padding: EdgeInsets.all(30),
            alignment: Alignment.center,
            child: Column(
              children: <Widget>[
                Expanded(
                  child: Container(
                    child: Form(
                        key: _formKey,
                        child: Column(
                          crossAxisAlignment: CrossAxisAlignment.center,
                          mainAxisAlignment: MainAxisAlignment.center,
                          children: <Widget>[
                            Image(image: AssetImage("assets/images/logo.png")),
                            TextFormField(
                              controller: _emailController,
                              decoration: const InputDecoration(
                                hintText: 'Email',
                              ),
                              validator: (String? value) {
                                if (value == null || value.isEmpty) {
                                  return 'Please enter some text';
                                }
                                return null;
                              },
                            ),
                            TextFormField(
                              controller: _passwordController,
                              obscureText: true,
                              decoration:
                                  const InputDecoration(hintText: 'Sifre'),
                              validator: (String? value) {
                                if (value == null || value.isEmpty) {
                                  return '';
                                }
                                return null;
                              },
                            ),
                            SizedBox(height: 10),
                            SizedBox(
                              width: double.infinity,
                              child: ElevatedButton(
                                  onPressed: () async {
                                    if (_formKey.currentState!.validate()) {
                                      // If the form is valid, display a snackbar. In the real world,
                                      // you'd often call a server or save the information in a database.
                                      print(_formKey);
                                      ScaffoldMessenger.of(context)
                                          .showSnackBar(SnackBar(
                                              content:
                                                  Text('Giriş yapılıyor...')));
                                    }

                                    var success = authBloc.login(
                                        _emailController.text,
                                        _passwordController.text);
                                    if (await success) {
                                      Navigator.push(
                                          context,
                                          MaterialPageRoute(
                                              builder: (context) =>
                                                  PersonalInfoPage()));
                                    }
                                  },
                                  child: Text("Giris")),
                            )
                          ],
                        )),
                  ),
                )
              ],
            )));
  }
}
