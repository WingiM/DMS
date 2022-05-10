import "./InRoomResidents.css";
import React from "react";
import addButtonImg from './img/addResidentButton.svg'
import closeButtonImg from './img/cross.svg'
import Resident from "../Resident/Resident";
import ModalWindow from "../ModalWindow";
import ResidentsListLayout from "../ModalWindow/ModalWindowLayouts/ResidentsListLayout"

function template() {
    return (
        this.props.show ?
        <div className="in-room-residents">
            <ModalWindow 
                show={this.state.showModal} 
                layout={<ResidentsListLayout residents={this.state.modalResidents}/>}
                toggleHandler={this.toggleModal}
                residents={this.state.modalResidents}
            />
            <button onClick={this.props.closeButtonClickHandler} className="close-residents-button"><img alt="close" src={closeButtonImg}/></button>
            <div className="rooms-header">ПРОЖИВАЮЩИЕ {this.props.room["RoomId"]}</div>
            <div className="in-room-residents-scroll-zone">
                {
                    this.props.room["Residents"] !== undefined ?
                    this.props.room["Residents"].map(resident => 
                    <Resident key={resident} 
                              readOnly={true}
                              showSaveBtn={false}
                              id={resident["ResidentId"]} 
                              lastname={resident["LastName"]} 
                              firstName={resident["FirstName"]}
                              patronymic={resident["Patronymic"]}
                              gender={resident["Gender"]}
                              birthDate={resident["BirthDate"]}
                              passportInformation={resident["PassportInformation"] === null ? '' : resident["PassportInformation"]["SeriesAndNumber"]}
                              tin={resident["Tin"]}
                              rating={resident["Rating"]}
                              debt={resident["Debt"]}
                              reports={resident["Reports"]}
                    />) : ''
                }
                {
                    this.props.room["Capacity"] > this.props.room["Residents"].length ?
                        <button onClick={this.toggleModal} className="add-resident-button"><img alt="plus" src={addButtonImg}/></button>
                        : ''
                }
                
            </div>

        </div> : ''
    );
}

export default template;
