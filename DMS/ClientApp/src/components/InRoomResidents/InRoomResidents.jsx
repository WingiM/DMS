import "./InRoomResidents.css";
import React from "react";
import addButtonImg from './img/addResidentButton.svg'
import closeButtonImg from './img/cross.svg'
import Resident from "../Resident/Resident";

function template() {
    return (
        this.props.show ?
        <div className="in-room-residents">
            <button onClick={this.props.closeButtonClickHandler} className="close-residents-button"><img alt="close" src={closeButtonImg}/></button>
            <div className="rooms-header">ПРОЖИВАЮЩИЕ 000</div>
            <div className="in-room-residents-scroll-zone">
                <Resident/>
                <Resident/>
                <Resident/>
                <button className="add-resident-button"><img alt="plus" src={addButtonImg}/></button>
            </div>

        </div> : ''
    );
}

export default template;
