import { combineReducers } from "redux";
import isResultReducer from "./isResultReducer";
import testReducer from "./testReducer";
//IndexImportHygen
const allTestReducers = combineReducers({
  isResultReducer,
  testReducer,

  //IndexUsingHygen
});

export default allTestReducers;
