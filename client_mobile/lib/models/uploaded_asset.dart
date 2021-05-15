class UploadedAsset {
  String id = "";
  String url = "";
  String publicId = "";

  UploadedAsset({
    required String id,
    required String url,
    required String publicId,
  }) {
    this.id = id;
    this.url = url;
    this.publicId = publicId;
  }

  factory UploadedAsset.fromJson(Map<String, dynamic> json) {
    return UploadedAsset(
      id: json['id'],
      url: json['url'],
      publicId: json['publicId'],
    );
  }
}
