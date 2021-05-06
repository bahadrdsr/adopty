import 'dart:async';

import 'package:client_mobile/models/authresult.dart';
import 'package:client_mobile/resources/auth_provider.dart';

class Repository {
  final authProvider = AuthProvider();

  // Get news from server
  Future<AuthResult> login(email, password) =>
      authProvider.login(email, password);

  // // Get news from server
  // Future<NewsModel> fetchSearchNews() => newsApiProvider.fetchSearchNews();

  // // Get favorite news from firebase
  // Future<NewsModel> fetchLikedNews() => newsApiProvider.getFavoriteNews();

  // addFavorit(val) => newsApiProvider.addToFiresstore(val);

  // deliteFavorit(val) => newsApiProvider.deliteFromFirestore(val);
}
