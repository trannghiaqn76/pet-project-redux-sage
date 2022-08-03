   
import { call, all } from 'redux-saga/effects';
import rootTestSaga from '../Areas/Test/sagas';
//IndexImportHygen

export default function* rootSaga() {
  yield all([
    call(rootTestSaga),
    //IndexUsingHygen
])
}