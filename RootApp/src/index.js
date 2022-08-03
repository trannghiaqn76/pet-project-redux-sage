import React from "react";
import ReactDOM from "react-dom";
import App from "./App";
import 'bootstrap/dist/css/bootstrap.min.css';

import { createStore, applyMiddleware } from "redux";
import { Provider } from "react-redux";
import allReducers from "./RootReducers/rootReducers";
import createSagaMiddleware from "redux-saga";
import rootSaga from "./RootSagas/rootSaga";

const sagaMiddleware = createSagaMiddleware();
let store = createStore(allReducers, applyMiddleware(sagaMiddleware));
sagaMiddleware.run(rootSaga);

ReactDOM.render(
  <Provider store={store}>
      <App />
  </Provider>,
  document.getElementById("root")
);

