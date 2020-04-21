import React from 'react';
import './App.css';
import {Employee} from './Componenets/Employee'
import {Login} from './Componenets/Login'
import {Container} from 'react-bootstrap';
import {Navigation} from "./Componenets/Navigation"
import {BrowserRouter, Route, Switch} from 'react-router-dom'

function App() {
  return (
  <BrowserRouter>
  <div className="Container">
      <h2 className = "m-3 d-flex justify-content-center">
      Welcome Employee Management Information.
      </h2>
      <Navigation/>
    </div>
    </BrowserRouter>
  );
}

export default App;