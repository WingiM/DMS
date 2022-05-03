import React from "react";
import template from "./InRoomResidents.jsx";

class InRoomResidents extends React.Component {
    constructor(props) {
        super(props);
        this.state = {
            show: true,
        }
    }

    render() {
        return template.call(this);
    }

}

export default InRoomResidents;
