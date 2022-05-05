import React, {Component} from "react";
import template from "./Login.jsx";
import {Redirect, Navigate} from "react-router-dom";

export class Login extends Component {
    static displayName = Login.name;

    constructor(props) {
        super(props);
        this.state = {
            password: "",
            isVisible: false
        }
    }

    loginHandler = async e => {
        console.log(123);
        e.preventDefault();
        await fetch("/api/login", {
            method: "POST", 
            headers: {"password": e},
        }).then(async resp => {
            let responseJson = await resp.json();
            if (resp.status === 200) {
                localStorage.setItem("token", "Bearer " + responseJson["value"]["access_token"]);
                window.location = "/"
            } else {
                this.setState({isVisible: true})
            }
        })
    }

    render() {
        if (localStorage.getItem("token") !== null) {
            return <Navigate to="/" replace />
        }
        
        return template.call(this);
    }
}
export default Login;
