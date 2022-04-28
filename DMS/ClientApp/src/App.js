import React, {Component} from 'react';
import {Layout} from "./components/Layout";
import {Link, Redirect, Route, Router, Routes, Navigate} from "react-router-dom";
import Login from "./components/Login";
import Rooms from "./components/Rooms";

import './custom.css'


export default class App extends Component {
    static displayName = App.name;

    render() {

        return (
            <Routes>
                <Route path="/login" element={<Login/>}/>
                <Route exact path="/" element={<Layout/>}> 
                    <Route exact path="/" element={<Rooms/>}/>
                </Route>
                <Route path="*" element={<Navigate to="/"/>}/>
            </Routes>
        )
    }
}
