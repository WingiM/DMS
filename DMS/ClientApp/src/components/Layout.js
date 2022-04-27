import React, {Component} from 'react';
import Sidebar from "./Sidebar";
import '../custom.css'
import {Redirect} from "react-router-dom";

export class Layout extends Component {
    static displayName = Layout.name;
    
    render() {
        if (!localStorage.getItem("token")) {
            return <Redirect to="/login" />
        }
        return (
            <React.StrictMode>
                <Sidebar/>
                {this.props.children}
            </React.StrictMode>
        );
    }
}
