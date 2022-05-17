import React from "react";
import template from "./Registration.jsx";
import {Navigate} from "react-router-dom";

class Registration extends React.Component {
    constructor(props) {
        super(props);
        this.state = {
            password: "",
            repeatPassword: "",
        }
        
        this.setPassword = this.setPassword.bind(this);
    }

    async setPassword() {
        await fetch("/api/login/set_password",
            {
                method: "POST",
                headers: {
                    "password": this.state.password,
                    "repeat_password": this.state.repeatPassword
                },
            }
        )
          .then((response) => response.json())
          .then((val) => {
              if (val["StatusCode"] === 200) {
                  window.location = "/login";
              }
          })
    }

    keyDownController(e) {
        if (e.key === "Enter") {
            this.loginHandler(e);
        }
    }

    render() {
        return template.call(this);
    }

}

export default Registration;
