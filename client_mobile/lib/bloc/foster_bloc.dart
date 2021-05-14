import 'package:bloc_pattern/bloc_pattern.dart';
import 'package:client_mobile/models/foster_profile.dart';
import 'package:client_mobile/resources/foster_repository.dart';
import 'package:rxdart/rxdart.dart';

class FosterBloc extends BlocBase {
  final FosterRepository repository;
  FosterBloc(this.repository);

  final BehaviorSubject<FosterProfile> _fosterProfileSubject =
      BehaviorSubject<FosterProfile>();

  Stream<FosterProfile> get fosterProfile => _fosterProfileSubject.stream;

  getMyFosterProfile() async {
    FosterProfile? response = await repository.getMyProfile();
    _fosterProfileSubject.sink.add(response);
  }

  @override
  void dispose() {
    _fosterProfileSubject.close();
  }
}
