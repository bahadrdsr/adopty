import 'dart:io';
import 'package:cloudinary_public/cloudinary_public.dart';
import 'package:flutter/material.dart';
import 'package:image_picker/image_picker.dart';

class FosterPostFormPage extends StatefulWidget {
  @override
  _FosterPostFormPageState createState() => _FosterPostFormPageState();
}

class _FosterPostFormPageState extends State<FosterPostFormPage> {
  final _formKey = GlobalKey<FormState>();
  final cloudinary =
      CloudinaryPublic('dann5o48z', 'UPLOAD_PRESET', cache: false);
  String specieValue = 'Kedi';
  String genderValue = 'Dişi';
  File? _image;
  final picker = ImagePicker();

  Future getImage() async {
    final pickedFile = await picker.getImage(source: ImageSource.gallery);

    setState(() {
      if (pickedFile != null) {
        _image = File(pickedFile.path);
      } else {
        print('No image selected.');
      }
    });
  }

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
          title: Text('Sahiplendirme Ilanı Oluştur'),
          centerTitle: true,
        ),
        body: Container(
          padding: EdgeInsets.all(20),
          child: Form(
              child: Column(
            children: [
              Center(
                child: _image == null
                    ? Text('')
                    : Container(
                        height: 100,
                        width: 100,
                        margin: EdgeInsets.only(bottom: 10),
                        child: Image.file(
                          _image as File,
                          fit: BoxFit.fill,
                        ),
                      ),
              ),
              FloatingActionButton(
                onPressed: getImage,
                tooltip: 'Pick Image',
                child: Icon(Icons.add_a_photo),
              ),
              Padding(
                  padding: EdgeInsets.symmetric(vertical: 16.0, horizontal: 10),
                  child: TextFormField(
                    // The validator receives the text that the user has entered.
                    decoration: const InputDecoration(
                      hintText: 'İsim',
                    ),
                    validator: (value) {
                      if (value == null || value.isEmpty) {
                        return 'Please enter some text';
                      }
                      return null;
                    },
                  )),
              Padding(
                  padding: EdgeInsets.symmetric(vertical: 16.0, horizontal: 10),
                  child: TextFormField(
                    maxLines: 4,
                    decoration: const InputDecoration(
                      hintText: 'Açıklama',
                    ),
                    validator: (value) {
                      if (value == null || value.isEmpty) {
                        return 'Please enter some text';
                      }
                      return null;
                    },
                  )),
              Padding(
                  padding: EdgeInsets.symmetric(vertical: 16.0, horizontal: 10),
                  child: DropdownButton<String>(
                    isExpanded: true,
                    value: specieValue,
                    icon: const Icon(Icons.arrow_downward),
                    iconSize: 24,
                    elevation: 16,
                    underline: Container(
                      height: 2,
                      color: Colors.black54,
                    ),
                    onChanged: (String? newValue) {
                      setState(() {
                        specieValue = newValue!;
                      });
                    },
                    items: <String>['Kedi', 'Köpek', 'Kuş', 'Diğer']
                        .map<DropdownMenuItem<String>>((String value) {
                      return DropdownMenuItem<String>(
                        value: value,
                        child: Text(value),
                      );
                    }).toList(),
                  )),
              Padding(
                  padding: EdgeInsets.symmetric(vertical: 16.0, horizontal: 10),
                  child: DropdownButton<String>(
                    isExpanded: true,
                    value: genderValue,
                    icon: const Icon(Icons.arrow_downward),
                    iconSize: 24,
                    elevation: 16,
                    underline: Container(
                      height: 2,
                      color: Colors.black54,
                    ),
                    onChanged: (String? newValue) {
                      setState(() {
                        genderValue = newValue!;
                      });
                    },
                    items: <String>['Erkek', 'Dişi']
                        .map<DropdownMenuItem<String>>((String value) {
                      return DropdownMenuItem<String>(
                        value: value,
                        child: Text(value),
                      );
                    }).toList(),
                  )),
              Padding(
                padding: EdgeInsets.symmetric(vertical: 16.0, horizontal: 10),
                child: ElevatedButton(
                  onPressed: () async {
                    // Validate returns true if the form is valid, or false otherwise.

                    if (_image != null) {
                      CloudinaryResponse response = await cloudinary.uploadFile(
                        CloudinaryFile.fromFile(_image!.path,
                            resourceType: CloudinaryResourceType.Image),
                      );
                    }
                    ScaffoldMessenger.of(context).showSnackBar(
                        SnackBar(content: Text('Processing Data')));
                  },
                  child: Text('Oluştur'),
                ),
              ),
            ],
          )),
        ));
  }
}
