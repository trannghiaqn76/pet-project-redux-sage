---
to: src/Areas/<%= area %>/sagas/index.js
---
import { call, all } from 'redux-saga/effects';
//IndexImportHygen

export default function* root<%= area %>Saga() {
  yield all([
    //IndexUsingHygen
    ])
}