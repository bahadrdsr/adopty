import 'package:client_mobile/models/authresult.dart';
import 'package:client_mobile/resources/repository.dart';
import 'package:rxdart/rxdart.dart';

class FosterBloc {
  final Repository _repository = Repository();
  final _profileFetcher = PublishSubject<NewsModel>();



}

final fosterBloc = FosterBloc();
