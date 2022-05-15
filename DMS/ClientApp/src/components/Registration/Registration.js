import React    from "react";
import template from "./Registration.jsx";

class Registration extends React.Component {
  constructor(props) {
    super(props);
    this.state = {
      password: "",
      repeatPassword: "",      
    }
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
