---
to: src/Areas/<%= area %>/actions/index.js
inject: true
before: "//IndexImportHygen"
---
    GET_DATA_<%= h.changeCase.upperCase(name) %>_<%= h.changeCase.upperCase(area) %>, GET_DATA_<%= h.changeCase.upperCase(name) %>_<%= h.changeCase.upperCase(area) %>_SUCCEEDED, REQUERT_<%= h.changeCase.upperCase(name) %>_<%= h.changeCase.upperCase(area) %>_FAILED, SET_DATA_<%= h.changeCase.upperCase(name) %>_<%= h.changeCase.upperCase(area) %>,