class AuthResult {
  final String token;
  final String username;

  AuthResult({required this.token, required this.username});

  factory AuthResult.fromJson(Map<String, dynamic> json) {
    return AuthResult(
      token: json['token'],
      username: json['username'],
    );
  }
}
