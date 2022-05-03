import React from "react";
import template from "./RoomsBlock.jsx";

class RoomsBlock extends React.Component {
    constructor(props) {
        super(props);
    }

    render() {
        return template.call(this);
    }

    tabClick(e) {
        try {
            e.preventDefault();
            try {
                document.querySelector('.active').classList.remove('active');
            }
            catch (TypeError) {
            }
            document.getElementById(e.currentTarget.id).classList.add('active');
        }
        catch (TypeError) {
        }
    }
}

export default RoomsBlock;
