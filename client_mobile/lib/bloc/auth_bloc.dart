import 'package:client_mobile/models/authresult.dart';
import 'package:client_mobile/resources/repository.dart';
import 'package:rxdart/rxdart.dart';

class AuthBloc {
  final Repository _repository = Repository();
  final BehaviorSubject<AuthResult> _subject = BehaviorSubject<AuthResult>();

  login(String email, String password) async {
    AuthResult response = await _repository.login(email, password);
    _subject.sink.add(response);
  }

  dispose() {
    _subject.close();
  }

  BehaviorSubject<AuthResult> get subject => _subject;
}

final authBloc = AuthBloc();
