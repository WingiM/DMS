import React, {Component} from 'react';
import {Layout} from "./components/Layout";
import {Link, Redirect, Route, Router, Switch} from "react-router-dom";
import Login from "./components/Login";
import Rooms from "./components/Rooms";

import './custom.css'


export default class App extends Component {
    static displayName = App.name;

    constructor(props) {
        super(props);
    }

    render() {
        return (
            <Switch>
                <Route path="/login" component={Login}/>
                <Layout>
                    <Route path='/' component={Rooms}/>
                </Layout>
                <Route path="*" element={<Redirect to="/"/>}/>
            </Switch>
        )
    }
}
