---
to: src/Areas/<%= area %>/reducers/index.js
---
import {combineReducers} from 'redux'
import isResultReducer from "./isResultReducer"
//IndexImportHygen
const all<%= area %>Reducers = combineReducers({
    isResultReducer,
    //IndexUsingHygen
})

export default all<%= area %>Reducers;