import 'package:flutter/material.dart';

class PersonalInfoScreen extends StatelessWidget {
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
              title: Text('Start Searching'),
              onTap: () {
                // Update the state of the app.
                // ...
              },
            ),
            ListTile(
              title: Text('Personal Info'),
              onTap: () {
                // Update the state of the app.
                // ...
              },
            ),
            ListTile(
              title: Text('Foster Profile'),
              onTap: () {
                // Update the state of the app.
                // ...
              },
            ),
            ListTile(
              title: Text('Candidate Profile'),
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
        title: Text('PERSONAL INFO'),
        centerTitle: true,
      ),
      body: Container(
        padding: EdgeInsets.all(20),
        child: Column(
          children: [
            Center(
              child: Text(
                'BAHADIR DÖŞER',
                style: TextStyle(
                    fontFamily: 'Calibri',
                    fontSize: 28,
                    fontWeight: FontWeight.bold),
              ),
            ),
            SizedBox(height: 10),
            Center(
              child: Image(
                height: 100,
                width: 100,
                image: NetworkImage(
                    'https://cdn3.iconfinder.com/data/icons/avatars-15/64/_Ninja-2-512.png'),
              ),
            ),
            SizedBox(height: 10),
            Center(
              child: Text(
                'Member since 23.03.2021',
                style: TextStyle(
                    fontFamily: 'Calibri',
                    fontSize: 12,
                    fontWeight: FontWeight.normal,
                    fontStyle: FontStyle.italic),
              ),
            ),
            SizedBox(height: 20),
            Container(
                padding: EdgeInsets.all(10),
                alignment: Alignment.centerLeft,
                child: Title(
                  color: Colors.black,
                  child: Text(
                    'BASIC PROFILE',
                    style: TextStyle(fontWeight: FontWeight.bold, fontSize: 20),
                  ),
                )),
            Container(
              padding: EdgeInsets.all(10),
              alignment: Alignment.centerLeft,
              child: Row(
                children: [
                  Icon(
                    Icons.person,
                    size: 20,
                    color: Colors.black,
                  ),
                  SizedBox(width: 20),
                  Text('Bahadır Döşer',
                      style: TextStyle(
                          fontWeight: FontWeight.normal, color: Colors.black))
                ],
              ),
            ),
            Container(
              padding: EdgeInsets.all(10),
              alignment: Alignment.centerLeft,
              child: Row(
                children: [
                  Icon(
                    Icons.mail,
                    size: 20,
                    color: Colors.black,
                  ),
                  SizedBox(width: 20),
                  Text('bahadirdoser@hotmail.com',
                      style: TextStyle(
                          fontWeight: FontWeight.normal, color: Colors.black))
                ],
              ),
            ),
            SizedBox(height: 10),
            Divider(
              color: Colors.grey[500],
              height: 5,
            ),
            Container(
                padding: EdgeInsets.all(10),
                alignment: Alignment.centerLeft,
                child: Title(
                  color: Colors.black,
                  child: Text(
                    'I would like to post :',
                    style: TextStyle(fontWeight: FontWeight.bold, fontSize: 16),
                  ),
                )),
            SizedBox(height: 10),
            Center(
              child: Row(
                children: [
                  Text('Adoption',
                      style: TextStyle(
                          fontWeight: FontWeight.normal,
                          color: Colors.black,
                          fontSize: 20)),
                  SizedBox(width: 20),
                  Switch(
                    value: true,
                    splashRadius: 10,
                  ),
                  SizedBox(width: 20),
                  Text('Rehome',
                      style: TextStyle(
                          fontWeight: FontWeight.normal,
                          color: Colors.black,
                          fontSize: 20))
                ],
              ),
            )
          ],
        ),
      ),
    );
  }
}
