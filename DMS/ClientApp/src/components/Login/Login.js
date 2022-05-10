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
        e.preventDefault();
        await fetch("/api/login", {
            method: "POST",
            headers: {"password": this.state.password},
        }).then(async resp => {
            let responseJson = await resp.json();
            if (resp.status === 200) {
                localStorage.setItem("password", this.state.password);
                localStorage.setItem("token", "Bearer " + responseJson["Value"]["AccessToken"]);
                window.location = "/"
            } else {
                this.setState({isVisible: true})
            }
        })
    }
    
    keyUpController(e) {
        if (e.key === "Enter") {
            this.loginHandler(e);
        } 
    }

    keyUpController(e) {
        if (e.key === "Enter") {
            this.loginHandler(e);
        }
    }

    render() {
        if (localStorage.getItem("token") !== null) {
            return <Navigate to="/" replace />
        }

        return template.call(this);
    }
}
export default Login;