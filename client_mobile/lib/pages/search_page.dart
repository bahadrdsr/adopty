import 'package:flutter/material.dart';
import 'package:photo_card_swiper/models/photo_card.dart';
import 'package:photo_card_swiper/photo_card_swiper.dart';

class SearchPage extends StatefulWidget {
  @override
  _SearchPageState createState() => _SearchPageState();
}

class _SearchPageState extends State<SearchPage> {
  List<PhotoCard> _photos = [
    PhotoCard(
        description: "Looking for a cute kitten!",
        title: "John Doe",
        imagePath:
            "https://res.cloudinary.com/dann5o48z/image/upload/v1621109609/matheus-ferrero-167947_igw0tj.jpg",
        isLocalImage: false),
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
        title: "John Doe",
        imagePath:
            "https://res.cloudinary.com/dann5o48z/image/upload/v1621109609/matheus-ferrero-167947_igw0tj.jpg",
        isLocalImage: false),
    PhotoCard(
        description: "Looking for a cute kitten!",
        title: "Jane Doe",
        imagePath:
            "https://res.cloudinary.com/dann5o48z/image/upload/v1621109609/philipe-cavalcante-xe68QiMaDrQ-2_ckdwu9.jpg",
        isLocalImage: false),
    PhotoCard(
        description: "Looking for a cute kitten!",
        title: "Rachel Green",
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
      ),
      body: Container(
        child: PhotoCardSwiper(
          photos: _photos,
          showLoading: false,
        ),
      ),
    );
  }
}
