---
to: src/RootSagas/rootSaga.js
inject: true
before: "//IndexImportHygen"
---
import root<%= area %>Saga from '../Areas/<%= area %>/sagas';