---
to: src/Areas/<%= area %>/reducers/index.js
inject: true
before: "//IndexImportHygen"
---
import <%= h.changeCase.lowerCaseFirst(name) %>Reducer from "./<%= h.changeCase.lowerCaseFirst(name) %>Reducer"