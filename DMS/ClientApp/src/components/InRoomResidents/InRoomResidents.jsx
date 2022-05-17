import "./InRoomResidents.css";
import React from "react";
import addButtonImg from './img/addResidentButton.svg'
import closeButtonImg from './img/cross.svg'
import Resident from "../Resident/Resident";
import ModalWindow from "../ModalWindow";
import ResidentsListLayout from "../ModalWindow/ModalWindowLayouts/ResidentsListLayout";
import EvictionOrderLayout from "../ModalWindow/ModalWindowLayouts/EvictionOrderLayout";
import TransactionsLayout from "../ModalWindow/ModalWindowLayouts/TransactionsLayout";
import RatingOperationsLayout from "../ModalWindow/ModalWindowLayouts/RatingOperationsLayout";

function template() {

    return (
        this.props.show ?
        <div className="in-room-residents">
            <ModalWindow
                show={this.state.showModal}
                layout=
                    {
                        this.state.modalLayout === "residentsList" ?
                        <ResidentsListLayout
                            residentsList={this.state.modalResidentsList}
                            residentsFilterList={this.state.modalResidentsFilterList}
                            filterHandler={this.filterHandler}
                            roomId={this.props.room["RoomId"]}
                            updateRoom={this.props.updateRoom}
                            toggleHandler={this.toggleHandler}
                            readOnly={false}
                            updateChartStats={this.props.updateChartStats}
                            chartStats={this.props.chartStats}
                        /> 
                            : this.state.modalLayout === "evictionOrder" ?
                            <EvictionOrderLayout 
                                resident={this.state.chosenResident}
                                updateRoom={this.props.updateRoom}
                                toggleHandler={this.toggleHandler}
                                readOnly={false}
                                updateChartStats={this.props.updateChartStats}
                                chartStats={this.props.chartStats}
                            /> 
                                : this.state.modalLayout === "transactionOrder" ? <TransactionsLayout
                                    resident={this.state.chosenResident}
                                    toggleHandler={this.toggleHandler}
                                    readOnly={false}
                                    updateRoom={this.props.updateRoom}
                                /> : <RatingOperationsLayout 
                                    resident={this.state.chosenResident}
                                    toggleHandler={this.toggleHandler}
                                    readOnly={false}
                                    updateRoom={this.props.updateRoom}
                                    />
                            
                    }
                toggleHandler={this.toggleHandler}
            />
            <button onClick={this.props.closeButtonClickHandler} className="close-residents-button"><img alt="close" src={closeButtonImg}/></button>
            <div className="rooms-header">ПРОЖИВАЮЩИЕ {this.props.room["RoomId"]}</div>
            
            <form>
                <div style={{display: "inline-block"}} className={"rooms-header mini type"}>пол комнаты:</div>
                <input id={"resident_gender_male" + this.props.room["RoomId"] + this.props.room["Gender"]} 
                       type="radio" 
                       onChange={this.handleChange} 
                       disabled={this.props.room["Residents"].length > 0} 
                       checked={this.state.roomGender !== null ? this.state.roomGender == 'М' : this.props.room["Gender"] == "M"}  
                       name="roomGender" value={"М"}/>
                <label className="radio-label" htmlFor={"resident_gender_male" + this.props.room["RoomId"] + this.props.room["Gender"]}>М</label>

                <input id={"resident_gender_female" + this.props.room["RoomId"] + this.props.room["Gender"]} 
                       type="radio" 
                       onChange={this.handleChange}
                       disabled={this.props.room["Residents"].length > 0} 
                       checked={this.state.roomGender !== null ? this.state.roomGender == 'Ж' : this.props.room["Gender"] == "F"} 
                       name="roomGender" value={"Ж"}/>
                <label className="radio-label" htmlFor={"resident_gender_female" + this.props.room["RoomId"] + this.props.room["Gender"]}>Ж</label>
            </form>
            
            <div className="in-room-residents-scroll-zone">
                {
                    this.props.room["Residents"] !== undefined ?
                    this.props.room["Residents"].map(resident => 
                    <Resident key={resident} 
                              residentObj={resident}
                              readOnly={true}
                              id={resident["ResidentId"]} 
                              lastname={resident["LastName"]} 
                              firstName={resident["FirstName"]}
                              patronymic={resident["Patronymic"]}
                              gender={resident["Gender"]}
                              birthDate={resident["BirthDate"]}
                              passportInformation={resident["PassportInformation"]}
                              course={resident["Course"]}
                              tin={resident["Tin"]}
                              rating={resident["Rating"]}
                              debt={resident["Debt"]}
                              reports={resident["Reports"]}
                              roomId={resident["RoomId"]}
                              isCommercial={resident["IsCommercial"]}
                              
                              toggleEvictionModal={this.toggleEvictionModal}
                              toggleTransactionModal={this.toggleTransactionModal}
                              toggleRatingModal={this.toggleRatingModal}
                    />) : ''
                }
                {
                    this.props.room["Residents"] !== undefined && this.props.room["Capacity"] > this.props.room["Residents"].length ?
                        <button onClick={this.toggleResidentsListModal} className="add-resident-button"><img alt="plus" src={addButtonImg}/></button>
                        : ''
                }
                
            </div>

        </div> : ''
    );
}

export default template;
