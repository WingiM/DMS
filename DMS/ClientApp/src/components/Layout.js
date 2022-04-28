import React, {Component, Fragment} from 'react';
import {Outlet, Route, Router, Routes, Navigate} from 'react-router-dom'
import Sidebar from "./Sidebar";
import '../custom.css'
import Rooms from "./Rooms";
import Settings from "./Settings";

export class Layout extends Component {
    static displayName = Layout.name;
    constructor(props) {
        super(props);
    }
    render() {
        if (localStorage.getItem("token") === null) {
            console.log(123);
            return <Navigate to="/login" />
        }
        return (
                <Fragment>
                    <Sidebar/>
                    <Routes>
                        <Route path='/' element={<Rooms/>}/>
                        <Route path="/settings" element={<Settings/>}/>
                    </Routes>
                </Fragment>
            // <React.StrictMode>
            //     <Sidebar/>
            //     {this.toRender}
            // </React.StrictMode>
        );
    }
}
