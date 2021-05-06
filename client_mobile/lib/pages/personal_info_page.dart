import 'package:flutter/material.dart';

class PersonalInfoPage extends StatefulWidget {
  @override
  _PersonalInfoPageState createState() => _PersonalInfoPageState();
}

class _PersonalInfoPageState extends State<PersonalInfoPage> {
  bool _adoptSwitchVal = false;
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
        title: Text('Temel Bilgiler'),
        centerTitle: true,
      ),
      body: Container(
        padding: EdgeInsets.all(20),
        child: Column(
          children: [
            Center(
              child: Text(
                'BAHADIR DÖŞER',
                style: TextStyle(fontSize: 28, fontWeight: FontWeight.bold),
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
                '23.03.2021 tarihinde katıldı',
                style: TextStyle(
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
                    'Temel Bilgiler',
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
                    'Benim profilim :',
                    style: TextStyle(fontWeight: FontWeight.bold, fontSize: 16),
                  ),
                )),
            SizedBox(height: 10),
            Container(
              width: double.infinity,
              child: Row(
                crossAxisAlignment: CrossAxisAlignment.center,
                mainAxisAlignment: MainAxisAlignment.center,
                children: [
                  Text('Sahip Adayı',
                      style: TextStyle(
                          fontWeight: FontWeight.normal,
                          color: Colors.black,
                          fontSize: 20)),
                  SizedBox(width: 20),
                  Switch(
                    value: this._adoptSwitchVal,
                    splashRadius: 10,
                    onChanged: (bool val) {
                      setState(() {
                        _adoptSwitchVal = val;
                      });
                    },
                  ),
                  SizedBox(width: 20),
                  Text('Sahiplendirme',
                      style: TextStyle(
                          fontWeight: FontWeight.normal,
                          color: Colors.black,
                          fontSize: 20))
                ],
              ),
            ),
            SizedBox(height: 30),
            SizedBox(
              width: double.infinity,
              child: ElevatedButton(
                child: Text("Detaylı Profilime Git"),
                onPressed: () {},
              ),
            )
          ],
        ),
      ),
    );
  }
}
