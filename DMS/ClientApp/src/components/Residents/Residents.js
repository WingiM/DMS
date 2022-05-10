import React    from "react";
import template from "./Residents.jsx";

class Residents extends React.Component {
  constructor(props) {
    super(props);
  }
  
  render() {
    return template.call(this);
  }
}

export default Residents;
