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
            <div className="rooms-header">ПРОЖИВАЮЩИЕ {this.props.room["roomId"]}</div>
            <div className="in-room-residents-scroll-zone">
                {
                    this.props.room["residents"] !== undefined ?
                    this.props.room["residents"].map(resident => 
                    <Resident key={resident} 
                              id={resident["residentId"]} 
                              lastname={resident["lastName"]} 
                              firstName={resident["firstName"]}
                              patronymic={resident["patronymic"]}
                              gender={resident["gender"]}
                              birthDate={resident["birthDate"]}
                              passportInformation={resident["passportInformation"]}
                              tin={resident["tin"]}
                              rating={resident["rating"]}
                              debt={resident["debt"]}
                              reports={resident["reports"]}
                    />) : ''
                }
                <button className="add-resident-button"><img alt="plus" src={addButtonImg}/></button>
            </div>

        </div> : ''
    );
}

export default template;
