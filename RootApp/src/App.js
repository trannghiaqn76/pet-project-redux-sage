import React from 'react';

import { NotificationContainer } from 'react-notifications';
import 'react-notifications/lib/notifications.css';
import RootRouters from './RootRouters/rootRouters';
import { BrowserRouter } from "react-router-dom";

import './App.css';

function App() {

  return (
    <>
      <BrowserRouter>
        <RootRouters />
      </BrowserRouter>
      <NotificationContainer />
    </>
  );
}
export default App;
