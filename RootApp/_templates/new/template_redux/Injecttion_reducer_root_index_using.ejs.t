---
to: src/Areas/<%= area %>/reducers/index.js
inject: true
before: "//IndexUsingHygen"
---
    <%= h.changeCase.lowerCaseFirst(name) %>Reducer,