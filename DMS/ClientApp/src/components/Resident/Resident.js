import React    from "react";
import template from "./Resident.jsx";

class Resident extends React.Component {
    constructor(props) {
        super(props);
    }

    render() {
        return template.call(this);
    }

    openCollapsible(e) {
        let elem = e.currentTarget
        elem.classList.toggle("active");
        let content = elem.nextElementSibling;
        if (content.style.maxHeight) {
            content.style.maxHeight = null;
        } else {
            content.style.maxHeight = content.scrollHeight + "px";
        }
    }
}

export default Resident;
