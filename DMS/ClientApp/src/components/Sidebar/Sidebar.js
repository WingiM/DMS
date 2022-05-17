import React    from "react";
import template from "./Sidebar.jsx";

class Sidebar extends React.Component {
    constructor(props) {
        super(props);
    }

    render() {
        return template.call(this);
    }
}

export default Sidebar;
