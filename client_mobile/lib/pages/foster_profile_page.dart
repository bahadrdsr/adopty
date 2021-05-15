import 'package:bloc_pattern/bloc_pattern.dart';
import 'package:client_mobile/bloc/foster_bloc.dart';
import 'package:client_mobile/models/foster_preference.dart';
import 'package:client_mobile/models/foster_profile.dart';
import 'package:client_mobile/pages/foster_posts_page.dart';
import 'package:client_mobile/pages/search_page.dart';
import 'package:flutter/material.dart';
import 'package:flutter/services.dart';

class FosterProfilePage extends StatefulWidget {
  @override
  _FosterProfilePageState createState() => _FosterProfilePageState();
}

class _FosterProfilePageState extends State<FosterProfilePage> {
  TextEditingController minAgeController = TextEditingController();

  final fosterBloc = BlocProvider.getBloc<FosterBloc>();
  bool _hasExperience = false;
  bool _alreadyHasPets = true;
  bool _profileInfoExists = true;
  bool _profilePhotoExists = true;
  @override
  Widget build(BuildContext context) {
    fosterBloc.getMyFosterProfile();
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
      body: StreamBuilder<FosterProfile>(
        stream: fosterBloc.fosterProfile,
        builder: (context, snapshot) {
          if (!snapshot.hasData) {
            return Center(
              child: CircularProgressIndicator(),
            );
          }
          FosterProfile profile = snapshot.data as FosterProfile;
          FosterPreference preference = profile.fosterPreference;
          // minAgeController.text = preference.minimumAge.toString();
          // _alreadyHasPets = preference.alreadyHasPets;
          // _profileInfoExists = preference.profileInfoExists;
          // _profilePhotoExists = preference.profilePhotoExists;

          return Container(
              padding: EdgeInsets.symmetric(horizontal: 10, vertical: 20),
              child: Column(
                children: [
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
                  SizedBox(
                    height: 20,
                  ),
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
                          'Terchilerim',
                          style: TextStyle(
                              fontWeight: FontWeight.bold, fontSize: 16),
                        ),
                      )),
                  SizedBox(height: 10),
                  Container(
                    child: TextField(
                      keyboardType: TextInputType.number,
                      controller: minAgeController,
                      decoration: new InputDecoration(labelText: "Min Yaş"),
                      inputFormatters: <TextInputFormatter>[
                        FilteringTextInputFormatter.digitsOnly
                      ], // Only numbers can be entered
                    ),
                  ),
                  Row(
                    crossAxisAlignment: CrossAxisAlignment.center,
                    mainAxisAlignment: MainAxisAlignment.start,
                    children: <Widget>[
                      Expanded(
                          child: Text("Tecrübeli mi : ",
                              style: TextStyle(
                                  color: Colors.black, fontSize: 16))),
                      Switch(
                        value: this._hasExperience,
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
                      Expanded(
                          child: Text("Başka evcil hayvanı var mı : ",
                              style: TextStyle(
                                  color: Colors.black, fontSize: 16))),
                      Switch(
                        value: this._alreadyHasPets,
                        onChanged: (bool val) {
                          setState(() {
                            _alreadyHasPets = val;
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
                      Expanded(
                          child: Text("Profil fotoğrafı var mı : ",
                              style: TextStyle(
                                  color: Colors.black, fontSize: 16))),
                      Switch(
                        value: this._profilePhotoExists,
                        onChanged: (bool val) {
                          setState(() {
                            _profilePhotoExists = val;
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
                      Expanded(
                          child: Text("Profil bilgisi var mı : ",
                              style: TextStyle(
                                  color: Colors.black, fontSize: 16))),
                      Switch(
                        value: this._profileInfoExists,
                        onChanged: (bool val) {
                          setState(() {
                            _profileInfoExists = val;
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
                        width: 150,
                        child: ElevatedButton(
                          child: Text("Aramaya başla"),
                          onPressed: () {
                            Navigator.push(
                                context,
                                MaterialPageRoute(
                                    builder: (context) => SearchPage()));
                          },
                        ),
                      ),
                      SizedBox(
                        width: 150,
                        child: ElevatedButton(
                          child: Text("Ilanlarıma Git"),
                          onPressed: () {
                            Navigator.push(
                                context,
                                MaterialPageRoute(
                                    builder: (context) => FosterPostsPage()));
                          },
                        ),
                      )
                    ],
                  )
                ],
              ));
        },
      ),
    );
  }
}
