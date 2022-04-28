import React, {Component} from 'react';
import {Layout} from "./components/Layout";
import {Link, Redirect, Route, Router, Routes, Navigate} from "react-router-dom";
import Login from "./components/Login";
import Rooms from "./components/Rooms";

import './custom.css'
import Settings from "./components/Settings";


export default class App extends Component {
    static displayName = App.name;

    render() {

        return (
            <Routes>
                <Route path="/login" element={<Login/>}/>
                <Route path="/" element={<Layout/>}> 
                    <Route path="/"/>
                    <Route path="/settings"/>
                </Route>
                <Route path="*" element={<Navigate to="/"/>}/>
            </Routes>
        )
    }
}
