import 'dart:ui';

import 'package:client_mobile/pages/foster_post_form_page.dart';
import 'package:flutter/material.dart';

class FosterPostsPage extends StatefulWidget {
  @override
  _FosterPostsPageState createState() => _FosterPostsPageState();
}

class _FosterPostsPageState extends State<FosterPostsPage> {
  @override
  Widget build(BuildContext context) {
    return Scaffold(
        backgroundColor: Colors.red[50],
        drawer: Drawer(
          child: ListView(
            // Important: Remove any padding from the ListView.
            padding: EdgeInsets.zero,
            children: <Widget>[
              DrawerHeader(
                child: Text('MENU'),
                decoration: BoxDecoration(
                  color: Colors.red[200],
                ),
              ),
              ListTile(
                title: Text(
                  'Aramaya başlayın',
                  style: TextStyle(fontSize: 16),
                ),
                onTap: () {
                  // Update the state of the app.
                  // ...
                },
              ),
              ListTile(
                title: Text(
                  'Kişisel Bilgileriniz',
                  style: TextStyle(fontSize: 16),
                ),
                onTap: () {
                  // Update the state of the app.
                  // ...
                },
              ),
              ListTile(
                title: Text(
                  'Sahiplendirici Profiliniz',
                  style: TextStyle(fontSize: 16),
                ),
                onTap: () {
                  // Update the state of the app.
                  // ...
                },
              ),
              ListTile(
                title: Text(
                  'Sahip adayı Profiliniz',
                  style: TextStyle(fontSize: 16),
                ),
                onTap: () {
                  // Update the state of the app.
                  // ...
                },
              ),
            ],
          ),
        ),
        appBar: AppBar(
          shadowColor: Colors.grey[800],
          backgroundColor: Colors.red[300],
          foregroundColor: Colors.white,
          title: Text('Sahiplendirme Ilanlarım'),
          centerTitle: true,
        ),
        body: Container(
            child: Column(
          children: [
            Expanded(
              child: ListView(
                padding: const EdgeInsets.all(8),
                children: <Widget>[
                  Container(
                      height: 135,
                      margin: EdgeInsets.only(bottom: 10),
                      decoration: BoxDecoration(
                          border: Border.all(color: Colors.black87)),
                      child: Row(
                        children: [
                          Container(
                            width: 100,
                            child: Image(
                                image: NetworkImage(
                                    "https://image.freepik.com/free-vector/cute-orange-robot-cat-avatar_79416-86.jpg")),
                          ),
                          Container(
                            width: 270,
                            padding: EdgeInsets.all(20),
                            child: Column(
                              crossAxisAlignment: CrossAxisAlignment.start,
                              mainAxisAlignment: MainAxisAlignment.start,
                              children: [
                                Title(
                                    color: Colors.black,
                                    child: Text(
                                      "Boncuk",
                                      style: TextStyle(
                                          fontWeight: FontWeight.bold),
                                    )),
                                SizedBox(height: 10),
                                Text(
                                  "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.",
                                  style: TextStyle(fontStyle: FontStyle.italic),
                                )
                              ],
                            ),
                          )
                        ],
                      )),
                  Container(
                      height: 135,
                      margin: EdgeInsets.only(bottom: 10),
                      decoration: BoxDecoration(
                          border: Border.all(color: Colors.black87)),
                      child: Row(
                        children: [
                          Container(
                            width: 100,
                            child: Image(
                                image: NetworkImage(
                                    "https://image.freepik.com/free-vector/cute-orange-robot-cat-avatar_79416-86.jpg")),
                          ),
                          Container(
                            width: 270,
                            padding: EdgeInsets.all(20),
                            child: Column(
                              crossAxisAlignment: CrossAxisAlignment.start,
                              mainAxisAlignment: MainAxisAlignment.start,
                              children: [
                                Title(
                                    color: Colors.black,
                                    child: Text(
                                      "Boncuk",
                                      style: TextStyle(
                                          fontWeight: FontWeight.bold),
                                    )),
                                SizedBox(height: 10),
                                Text(
                                  "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.",
                                  style: TextStyle(fontStyle: FontStyle.italic),
                                )
                              ],
                            ),
                          )
                        ],
                      )),
                  Container(
                      height: 135,
                      margin: EdgeInsets.only(bottom: 10),
                      decoration: BoxDecoration(
                          border: Border.all(color: Colors.black87)),
                      child: Row(
                        children: [
                          Container(
                            width: 100,
                            child: Image(
                                image: NetworkImage(
                                    "https://image.freepik.com/free-vector/cute-orange-robot-cat-avatar_79416-86.jpg")),
                          ),
                          Container(
                            width: 270,
                            padding: EdgeInsets.all(20),
                            child: Column(
                              crossAxisAlignment: CrossAxisAlignment.start,
                              mainAxisAlignment: MainAxisAlignment.start,
                              children: [
                                Title(
                                    color: Colors.black,
                                    child: Text(
                                      "Boncuk",
                                      style: TextStyle(
                                          fontWeight: FontWeight.bold),
                                    )),
                                SizedBox(height: 10),
                                Text(
                                  "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.",
                                  style: TextStyle(fontStyle: FontStyle.italic),
                                )
                              ],
                            ),
                          )
                        ],
                      )),
                  Container(
                      height: 135,
                      margin: EdgeInsets.only(bottom: 10),
                      decoration: BoxDecoration(
                          border: Border.all(color: Colors.black87)),
                      child: Row(
                        children: [
                          Container(
                            width: 100,
                            child: Image(
                                image: NetworkImage(
                                    "https://image.freepik.com/free-vector/cute-orange-robot-cat-avatar_79416-86.jpg")),
                          ),
                          Container(
                            width: 270,
                            padding: EdgeInsets.all(20),
                            child: Column(
                              crossAxisAlignment: CrossAxisAlignment.start,
                              mainAxisAlignment: MainAxisAlignment.start,
                              children: [
                                Title(
                                    color: Colors.black,
                                    child: Text(
                                      "Boncuk",
                                      style: TextStyle(
                                          fontWeight: FontWeight.bold),
                                    )),
                                SizedBox(height: 10),
                                Text(
                                  "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.",
                                  style: TextStyle(fontStyle: FontStyle.italic),
                                )
                              ],
                            ),
                          )
                        ],
                      )),
                  Container(
                      height: 135,
                      margin: EdgeInsets.only(bottom: 10),
                      decoration: BoxDecoration(
                          border: Border.all(color: Colors.black87)),
                      child: Row(
                        children: [
                          Container(
                            width: 100,
                            child: Image(
                                image: NetworkImage(
                                    "https://image.freepik.com/free-vector/cute-orange-robot-cat-avatar_79416-86.jpg")),
                          ),
                          Container(
                            width: 270,
                            padding: EdgeInsets.all(20),
                            child: Column(
                              crossAxisAlignment: CrossAxisAlignment.start,
                              mainAxisAlignment: MainAxisAlignment.start,
                              children: [
                                Title(
                                    color: Colors.black,
                                    child: Text(
                                      "Boncuk",
                                      style: TextStyle(
                                          fontWeight: FontWeight.bold),
                                    )),
                                SizedBox(height: 10),
                                Text(
                                  "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.",
                                  style: TextStyle(fontStyle: FontStyle.italic),
                                )
                              ],
                            ),
                          )
                        ],
                      )),
                  Container(
                      height: 135,
                      margin: EdgeInsets.only(bottom: 10),
                      decoration: BoxDecoration(
                          border: Border.all(color: Colors.black87)),
                      child: Row(
                        children: [
                          Container(
                            width: 100,
                            child: Image(
                                image: NetworkImage(
                                    "https://image.freepik.com/free-vector/cute-orange-robot-cat-avatar_79416-86.jpg")),
                          ),
                          Container(
                            width: 270,
                            padding: EdgeInsets.all(20),
                            child: Column(
                              crossAxisAlignment: CrossAxisAlignment.start,
                              mainAxisAlignment: MainAxisAlignment.start,
                              children: [
                                Title(
                                    color: Colors.black,
                                    child: Text(
                                      "Boncuk",
                                      style: TextStyle(
                                          fontWeight: FontWeight.bold),
                                    )),
                                SizedBox(height: 10),
                                Text(
                                  "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.",
                                  style: TextStyle(fontStyle: FontStyle.italic),
                                )
                              ],
                            ),
                          ),
                        ],
                      )),
                ],
              ),
            ),
            ElevatedButton(
                onPressed: () {
                  Navigator.push(
                      context,
                      MaterialPageRoute(
                          builder: (context) => FosterPostFormPage()));
                },
                child: Icon(Icons.add))
          ],
        )));
  }
}
