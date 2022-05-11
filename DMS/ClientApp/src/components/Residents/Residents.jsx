import "./Residents.css";
import React from "react";
import Resident from "../Resident";

function template() {
    return (
        this.props.show ?
            <div className="residents">
                <div className="residents-block-header">СПИСКИ</div>
                <div className="residents-container">
                    <div className="residents-nav">
                        <input type="text" placeholder="Введите имя"/>
                        <div className="filters">
                            <button className="yellow-btn"/>
                            <button className="green-btn"/>
                            <button className="red-btn"/>

                            <button className="w-filter-btn">Ж</button>
                            <button className="m-filter-btn">М</button>
                            <button onClick={this.props.addResidentBtnClickHandler} className="resident-add-btn"/>

                        </div>
                    </div>
                    <div className="residents-list-scroll">
                        <div className="residents-list">
                            {
                                this.props.residentsList !== undefined ?
                                    this.props.residentsList.map(resident =>
                                        <Resident key={resident}
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
                                        />) : ''
                            }
                        </div>
                    </div>
                </div>
            </div> : ""
    );
}

export default template;