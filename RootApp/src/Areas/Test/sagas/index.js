import { call, all } from "redux-saga/effects";
import { watchGetDataTest, watchSetDataTest } from "./testSaga";
// import { watchGetDataTest123, watchSetDataTest123 } from "./test123Saga";
// import { watchGetDataTest123, watchSetDataTest123 } from "./test123Saga";
//IndexImportHygen

export default function* rootTestSaga() {
  yield all([
    call(watchGetDataTest),
    call(watchSetDataTest),
    // call(watchGetDataTest123),
    // call(watchSetDataTest123),
    // call(watchGetDataTest123),
    // call(watchSetDataTest123),
    //IndexUsingHygen
  ]);
}
