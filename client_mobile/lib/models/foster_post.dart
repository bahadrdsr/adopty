import 'package:client_mobile/models/uploaded_asset.dart';

class FosterPost {
  String id = "";
  String name = "";
  String? text = "";
  String specieId = "";
  String? fosterProfileId = "";
  int gender = 10;
  int status = 10;
  DateTime? createdDate = DateTime.now();
  List<UploadedAsset> assets = [];

  FosterPost(
      {required String id,
      required String name,
      required String? text,
      required String specieId,
      required String? fosterProfileId,
      required int gender,
      required int status,
      required DateTime? createdDate,
      required List<UploadedAsset> assets}) {
    this.id = id;
    this.name = name;
    this.text = text;
    this.specieId = specieId;
    this.fosterProfileId = fosterProfileId;
    this.gender = gender;
    this.status = status;
    this.createdDate = createdDate;
    this.assets = assets;
  }

  factory FosterPost.fromJson(Map<String, dynamic> json) {
    return FosterPost(
        id: json['id'],
        name: json['name'],
        text: json['text'],
        specieId: json['specieId'],
        fosterProfileId: json['fosterProfileId'],
        gender: json['gender'],
        status: json['status'],
        createdDate: json['createdDate'],
        assets: List<UploadedAsset>.from(
            json["assets"].map((model) => UploadedAsset.fromJson(model))));
  }
}
