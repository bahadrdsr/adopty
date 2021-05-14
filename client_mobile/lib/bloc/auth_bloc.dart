import 'package:client_mobile/models/authresult.dart';
import 'package:client_mobile/resources/auth_repository.dart';
import 'package:flutter_secure_storage/flutter_secure_storage.dart';
import 'package:rxdart/rxdart.dart';

class AuthBloc {
  final AuthRepository repository;
  AuthBloc(this.repository);
  FlutterSecureStorage storage = new FlutterSecureStorage();
  final BehaviorSubject<AuthResult> _subject = BehaviorSubject<AuthResult>();

  Future<bool> login(String email, String password) async {
    AuthResult response = await repository.login(email, password);
    storage.write(key: 'accessToken', value: response.token);
    _subject.sink.add(response);
    return true;
  }

  dispose() {
    _subject.close();
  }

  BehaviorSubject<AuthResult> get subject => _subject;
}
