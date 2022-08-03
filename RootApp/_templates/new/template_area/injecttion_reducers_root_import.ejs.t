---
to: src/RootReducers/rootReducers.js
inject: true
before: "//IndexImportHygen"
---
import all<%= area %>Reducers from '../Areas/<%= area %>/reducers';