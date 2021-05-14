class FosterPreference {
  String id = "";
  int minimumAge = 0;
  bool profileInfoExists = false;
  bool profilePhotoExists = false;
  bool hasExperience = false;
  bool alreadyHasPets = false;
  String? fosterProfileId;
  int friendlyWithPeople = -1;
  int friendlyWithPets = -1;

  FosterPreference(
      {required String id,
      required int minimumAge,
      required bool profileInfoExists,
      required bool profilePhotoExists,
      required bool hasExperience,
      required bool alreadyHasPets,
      String? fosterProfileId,
      required int friendlyWithPeople,
      required int friendlyWithPets}) {
    this.alreadyHasPets = alreadyHasPets;
    this.fosterProfileId = fosterProfileId;
    this.friendlyWithPeople = friendlyWithPeople;
    this.friendlyWithPets = friendlyWithPets;
    this.hasExperience = hasExperience;
    this.id = id;
    this.minimumAge = minimumAge;
    this.profileInfoExists = profileInfoExists;
    this.profilePhotoExists = profilePhotoExists;
  }

  factory FosterPreference.fromJson(Map<String, dynamic> json) {
    return FosterPreference(
        alreadyHasPets: json["alreadyHasPets"],
        fosterProfileId: json["fosterProfileId"],
        friendlyWithPeople: json["friendlyWithPeople"],
        friendlyWithPets: json["friendlyWithPets"],
        hasExperience: json["hasExperience"],
        id: json["id"],
        minimumAge: json["minimumAge"],
        profileInfoExists: json["profileInfoExists"],
        profilePhotoExists: json["profilePhotoExists"]);
  }
}
