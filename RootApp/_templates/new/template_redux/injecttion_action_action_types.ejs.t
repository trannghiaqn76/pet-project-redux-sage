---
to: src/Areas/<%= area %>/actions/actionTypes.js
inject: true
before: "//IndexHygen"
---

//<%= name%>
export const GET_DATA_<%= h.changeCase.upperCase(name) %>_<%= h.changeCase.upperCase(area) %> = 'GET_DATA_<%= h.changeCase.upperCase(name) %>_<%= h.changeCase.upperCase(area) %>';
export const GET_DATA_<%= h.changeCase.upperCase(name) %>_<%= h.changeCase.upperCase(area) %>_SUCCEEDED = 'GET_DATA_<%= h.changeCase.upperCase(name) %>_<%= h.changeCase.upperCase(area) %>_SUCCEEDED';
export const REQUERT_<%= h.changeCase.upperCase(name) %>_<%= h.changeCase.upperCase(area) %>_FAILED = 'REQUERT_<%= h.changeCase.upperCase(name) %>_<%= h.changeCase.upperCase(area) %>_FAILED';
export const SET_DATA_<%= h.changeCase.upperCase(name) %>_<%= h.changeCase.upperCase(area) %> = 'SET_DATA_<%= h.changeCase.upperCase(name) %>_<%= h.changeCase.upperCase(area) %>';