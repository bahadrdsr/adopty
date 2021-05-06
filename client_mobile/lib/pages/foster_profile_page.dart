import 'package:flutter/material.dart';

class FosterProfilePage extends StatefulWidget {
  @override
  _FosterProfilePageState createState() => _FosterProfilePageState();
}

class _FosterProfilePageState extends State<FosterProfilePage> {
  RangeValues _ageRangeValues = const RangeValues(0, 30);
  RangeValues _weightRangeValues = const RangeValues(0, 50);
  bool _hasExperience = false;
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
        title: Text('Sahiplendirme Profili'),
        centerTitle: true,
      ),
      body: Container(
          padding: EdgeInsets.all(20),
          child: Column(
            children: <Widget>[
              Row(
                children: [
                  Text("Beğenilen adaylar : ",
                      style: TextStyle(color: Colors.black, fontSize: 18)),
                  Text("5",
                      style: TextStyle(
                          color: Colors.red[400],
                          fontSize: 18,
                          decoration: TextDecoration.underline)),
                ],
              ),
              SizedBox(height: 20),
              Row(
                children: [
                  Text("Beğenilmeyen adaylar : ",
                      style: TextStyle(color: Colors.black, fontSize: 18)),
                  Text("33",
                      style: TextStyle(
                          color: Colors.deepOrange[400],
                          fontSize: 18,
                          decoration: TextDecoration.underline)),
                ],
              ),
              Divider(
                color: Colors.black54,
                height: 50,
                thickness: 3,
                indent: 10,
                endIndent: 10,
              ),
              Container(
                  alignment: Alignment.centerLeft,
                  child: Title(
                    color: Colors.black,
                    child: Text(
                      'Arama Terchilerim',
                      style:
                          TextStyle(fontWeight: FontWeight.bold, fontSize: 16),
                    ),
                  )),
              SizedBox(height: 10),
              Row(
                crossAxisAlignment: CrossAxisAlignment.center,
                mainAxisAlignment: MainAxisAlignment.start,
                children: <Widget>[
                  Text("Min / Max Yaş : ",
                      style: TextStyle(color: Colors.black, fontSize: 16)),
                  RangeSlider(
                    values: _ageRangeValues,
                    activeColor: Colors.red[400],
                    min: 0,
                    max: 100,
                    divisions: 15,
                    labels: RangeLabels(
                      _ageRangeValues.start.round().toString(),
                      _ageRangeValues.end.round().toString(),
                    ),
                    onChanged: (RangeValues values) {
                      setState(() {
                        _ageRangeValues = values;
                      });
                    },
                  )
                ],
              ),
              SizedBox(height: 10),
              Row(
                crossAxisAlignment: CrossAxisAlignment.center,
                mainAxisAlignment: MainAxisAlignment.start,
                children: <Widget>[
                  Text("Min / Max Ağırlık : ",
                      style: TextStyle(color: Colors.black, fontSize: 16)),
                  RangeSlider(
                    values: _weightRangeValues,
                    activeColor: Colors.red[400],
                    min: 0,
                    max: 100,
                    divisions: 15,
                    labels: RangeLabels(
                      _weightRangeValues.start.round().toString(),
                      _weightRangeValues.end.round().toString(),
                    ),
                    onChanged: (RangeValues values) {
                      setState(() {
                        _weightRangeValues = values;
                      });
                    },
                  )
                ],
              ),
              SizedBox(height: 10),
              Row(
                crossAxisAlignment: CrossAxisAlignment.center,
                mainAxisAlignment: MainAxisAlignment.start,
                children: <Widget>[
                  Text("Tecrübeli mi : ",
                      style: TextStyle(color: Colors.black, fontSize: 16)),
                  Switch(
                    value: this._hasExperience,
                    splashRadius: 10,
                    onChanged: (bool val) {
                      setState(() {
                        _hasExperience = val;
                      });
                    },
                  ),
                ],
              ),
              SizedBox(height: 10),
              Row(
                crossAxisAlignment: CrossAxisAlignment.center,
                mainAxisAlignment: MainAxisAlignment.start,
                children: <Widget>[
                  Text("Başka evcil hayvanı var mı : ",
                      style: TextStyle(color: Colors.black, fontSize: 16)),
                  Switch(
                    value: this._hasExperience,
                    splashRadius: 10,
                    onChanged: (bool val) {
                      setState(() {
                        _hasExperience = val;
                      });
                    },
                  ),
                ],
              ),
              SizedBox(height: 10),
              Row(
                crossAxisAlignment: CrossAxisAlignment.center,
                mainAxisAlignment: MainAxisAlignment.start,
                children: <Widget>[
                  Text("Profil fotoğrafı var mı : ",
                      style: TextStyle(color: Colors.black, fontSize: 16)),
                  Switch(
                    value: this._hasExperience,
                    splashRadius: 10,
                    onChanged: (bool val) {
                      setState(() {
                        _hasExperience = val;
                      });
                    },
                  ),
                ],
              ),
              SizedBox(height: 10),
              Row(
                crossAxisAlignment: CrossAxisAlignment.center,
                mainAxisAlignment: MainAxisAlignment.start,
                children: <Widget>[
                  Text("Profil bilgisi var mı : ",
                      style: TextStyle(color: Colors.black, fontSize: 16)),
                  Switch(
                    value: this._hasExperience,
                    splashRadius: 10,
                    onChanged: (bool val) {
                      setState(() {
                        _hasExperience = val;
                      });
                    },
                  ),
                ],
              ),
              SizedBox(height: 30),
              Row(
                crossAxisAlignment: CrossAxisAlignment.center,
                mainAxisAlignment: MainAxisAlignment.spaceAround,
                children: [
                  SizedBox(
                    child: ElevatedButton(
                      child: Text("Aramaya başla"),
                      onPressed: () {},
                    ),
                  ),
                  SizedBox(
                    child: ElevatedButton(
                      child: Text("Ilanlarıma Git"),
                      onPressed: () {},
                    ),
                  )
                ],
              )
            ],
          )),
    );
  }
}
