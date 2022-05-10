import "./Residents.css";
import React from "react";
import Resident from "../Resident";
import rubleImg from './img/negativeRuble.svg'

function template() {
    return (
        this.props.show ?
            <div className="residents">
                <div className="residents-block-name">СПИСКИ</div>
                <div className="residents-container">
                    <div className="residents-nav">
                        <input type="text" onInput={(e) => this.filterByName(e)} placeholder="Введите имя"/>
                        <div className="filters">
                            <button onClick={(e) => this.filterBySettlement(e)} className="yellow-btn"/>
                            <button onClick={(e) => this.filterByCourse(e)} className="green-btn"/>
                            <button onClick={(e) => this.filterByRating(e)} className="red-btn"/>

                            <button className="w-filter-btn"><img alt={"ruble"} src={rubleImg}/></button>
                            <button onClick={(e) => this.filterByGender(e)} className="w-filter-btn">Ж</button>
                            <button onClick={(e) => this.filterByGender(e)} className="m-filter-btn">М</button>
                            <button onClick={this.props.addResidentBtnClickHandler} className="resident-add-btn"/>
                        </div>
                    </div>
                    <div className="residents-list-scroll">
                        <div className="residents-list">
                            {
                                this.props.residentsFilterList !== undefined ?
                                    this.props.residentsFilterList.map(resident =>
                                        <Resident
                                                  updateResidentsList={this.props.updateResidentsList}    
                                                  key={resident["ResidentId"]}
                                                  readOnly={false}
                                                  showSaveBtn={true}
                                                  id={resident["ResidentId"]}
                                                  lastname={resident["LastName"]}
                                                  firstName={resident["FirstName"]}
                                                  patronymic={resident["Patronymic"]}
                                                  gender={resident["Gender"]}
                                                  birthDate={resident["BirthDate"]}
                                                  passportInformation={resident["PassportInformation"] === 
                                                    null ? '' : resident["PassportInformation"]["SeriesAndNumber"]}
                                                  tin={resident["Tin"]}
                                                  rating={resident["Rating"]}
                                                  debt={resident["Debt"]}
                                                  reports={resident["Reports"]}
                                                  roomId={resident["RoomId"]}
                                                  course={resident["Course"]}
                                        />) : ''
                            }
                        </div>
                    </div>
                </div>
            </div> : ""
    );
}

export default template;