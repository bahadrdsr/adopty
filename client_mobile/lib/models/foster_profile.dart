class FosterProfile {
  final String token;
  final String username;

  FosterProfile({required this.token, required this.username});

  factory FosterProfile.fromJson(Map<String, dynamic> json) {
    return FosterProfile(
      token: json['token'],
      username: json['username'],
    );
  }
}
