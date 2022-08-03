---
to: src/Areas/<%= area %>/sagas/index.js
inject: true
before: "//IndexUsingHygen"
---
    call(watchGetData<%= name %>),
    call(watchSetData<%= name %>),