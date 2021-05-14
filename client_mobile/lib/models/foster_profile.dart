import 'package:client_mobile/models/foster_preference.dart';

class FosterProfile {
  String id = "";
  String appUserId = "";
  String? info = "";
  FosterPreference fosterPreference = new FosterPreference(
      id: "",
      minimumAge: 0,
      alreadyHasPets: false,
      friendlyWithPeople: -1,
      friendlyWithPets: -1,
      hasExperience: false,
      profileInfoExists: false,
      profilePhotoExists: false);

  FosterProfile(
      {required String id,
      required String appUserId,
      required String? info,
      required FosterPreference fosterPreference}) {
    this.id = id;
    this.appUserId = appUserId;
    this.info = info;
    this.fosterPreference = fosterPreference;
  }

  factory FosterProfile.fromJson(Map<String, dynamic> json) {
    return FosterProfile(
        id: json['id'],
        appUserId: json['appUserId'],
        info: json["info"],
        fosterPreference: FosterPreference.fromJson(json["fosterPreference"]));
  }
}
