import React    from "react";
import template from "./Room.jsx";

class Room extends React.Component {
  constructor(props) {
    super(props);

  }

  render() {
    return template.call(this);
  }
}

export default Room;
