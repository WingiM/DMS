import React, { Component } from 'react';
import {BrowserRouter, Route, Routes} from "react-router-dom";
import {Layout} from "./Layout";
import Rooms from "./Rooms";

export class Home extends Component {
  static displayName = Home.name;

  render () {
    return (
      <h1>Home</h1>
    );
  }
}
