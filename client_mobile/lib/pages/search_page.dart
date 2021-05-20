import 'package:client_mobile/pages/chat_page.dart';
import 'package:flutter/material.dart';
import 'package:photo_card_swiper/models/photo_card.dart';
import 'package:photo_card_swiper/photo_card_swiper.dart';

class SearchPage extends StatefulWidget {
  @override
  _SearchPageState createState() => _SearchPageState();
}

class _SearchPageState extends State<SearchPage> {
  int matchCount = 0;
  List<PhotoCard> _photos = [
    PhotoCard(
        description: "Looking for a cute kitten!",
        title: "Jane Doe",
        imagePath:
            "https://res.cloudinary.com/dann5o48z/image/upload/v1621109609/philipe-cavalcante-xe68QiMaDrQ-2_ckdwu9.jpg",
        isLocalImage: false),
    PhotoCard(
        description: "Looking for a cute kitten!",
        title: "Monica Geller",
        imagePath:
            "https://res.cloudinary.com/dann5o48z/image/upload/v1621109612/pexels-photo-27411-scaled_tpvd6t.jpg",
        isLocalImage: false),
    PhotoCard(
        description: "Looking for a cute kitten!",
        title: "Ahmet Mehmet",
        imagePath:
            "https://res.cloudinary.com/dann5o48z/image/upload/v1621109609/matheus-ferrero-167947_igw0tj.jpg",
        isLocalImage: false),
    PhotoCard(
        description: "Looking for a cute kitten!",
        title: "John Doe",
        imagePath:
            "https://res.cloudinary.com/dann5o48z/image/upload/v1621109609/matheus-ferrero-167947_igw0tj.jpg",
        isLocalImage: false),
    PhotoCard(
        description: "Looking for a cute kitten!",
        title: "Selami Sahin",
        imagePath:
            "https://res.cloudinary.com/dann5o48z/image/upload/v1621109609/philipe-cavalcante-xe68QiMaDrQ-2_ckdwu9.jpg",
        isLocalImage: false),
    PhotoCard(
        description: "Looking for a cute kitten!",
        title: "Ayse Muge",
        imagePath:
            "https://res.cloudinary.com/dann5o48z/image/upload/v1621109617/robert-godwin-cdksyTqEXzo_tsbznu.jpg",
        isLocalImage: false),
    PhotoCard(
        description: "Looking for a cute kitten!",
        title: "Jessica Simpson",
        imagePath:
            "https://res.cloudinary.com/dann5o48z/image/upload/v1621109614/pexels-photo-195825_wl7y35.jpg",
        isLocalImage: false),
    PhotoCard(
        description: "Looking for a cute kitten!",
        title: "Axl Rose",
        imagePath:
            "https://res.cloudinary.com/dann5o48z/image/upload/v1621109608/lesly-b-juarez-276953-scaled_nz7kee.jpg",
        isLocalImage: false)
  ];
  //  List<PhotoCard> _photos = [
  //   PhotoCard(
  //       description: "Looking for a cute kitten!",
  //       title: "John Doe",
  //       imagePath: "/assets/images/users/matheus.jpg",
  //       isLocalImage: true),
  //   PhotoCard(
  //       description: "Looking for a cute kitten!",
  //       title: "Jane Doe",
  //       imagePath: "/assets/images/users/lesly.jpg",
  //       isLocalImage: true),
  //   PhotoCard(
  //       description: "Looking for a cute kitten!",
  //       title: "Monica Geller",
  //       imagePath: "/assets/images/users/philipe.jpg",
  //       isLocalImage: true)
  // ];
  @override
  Widget build(BuildContext context) {
    return Scaffold(
      appBar: AppBar(
        title: Text("Arama"),
        actions: <Widget>[
          // Using Stack to show Notification Badge
          new Stack(
            children: <Widget>[
              new IconButton(
                  icon: Icon(Icons.notifications),
                  onPressed: () {
                    if (matchCount != 0) {
                      Navigator.push(context,
                          MaterialPageRoute(builder: (context) => ChatPage()));
                      setState(() {
                        matchCount = 0;
                      });
                    }
                  }),
              matchCount != 0
                  ? new Positioned(
                      right: 11,
                      top: 11,
                      child: new Container(
                        padding: EdgeInsets.all(2),
                        decoration: new BoxDecoration(
                          color: Colors.red,
                          borderRadius: BorderRadius.circular(6),
                        ),
                        constraints: BoxConstraints(
                          minWidth: 14,
                          minHeight: 14,
                        ),
                        child: Text(
                          '$matchCount',
                          style: TextStyle(
                            color: Colors.white,
                            fontSize: 8,
                          ),
                          textAlign: TextAlign.center,
                        ),
                      ),
                    )
                  : new Container()
            ],
          ),
        ],
      ),
      body: Container(
        child: PhotoCardSwiper(
          photos: _photos,
          showLoading: false,
          onCardTap: (args) {
            setState(() {
              matchCount++;
            });
          },
        ),
      ),
    );
  }
}
