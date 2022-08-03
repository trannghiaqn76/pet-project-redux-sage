---
to: src/Areas/<%= area %>/sagas/index.js
inject: true
before: "//IndexImportHygen"
---
import {watchGetData<%= name %>, watchSetData<%= name %>} from "./<%= h.changeCase.lowerCaseFirst(name) %>Saga";