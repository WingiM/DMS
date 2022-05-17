import "./Residents.css";
import React from "react";
import Resident from "../Resident";
import rubleImg from './img/negativeRuble.svg'
import TransactionsLayout from "../ModalWindow/ModalWindowLayouts/TransactionsLayout";
import RatingOperationsLayout from "../ModalWindow/ModalWindowLayouts/RatingOperationsLayout";
import ModalWindow from "../ModalWindow";
import DeleteResidentConfirmLayout from "../ModalWindow/ModalWindowLayouts/DeleteResidentConfirmLayout";

function template() {
    return (
        this.props.show ?
            <div className="residents">

                <ModalWindow
                    show={this.state.showModal}
                    layout=
                        {
                            this.state.modalLayout === "transactionOrder" ? <TransactionsLayout
                                resident={this.state.chosenResident}
                                toggleHandler={this.toggleHandler}
                                readOnly={false}
                                updateRoom={this.props.updateResidentsList}
                            /> : this.state.modalLayout === "ratingModal" ? <RatingOperationsLayout
                                resident={this.state.chosenResident}
                                toggleHandler={this.toggleHandler}
                                readOnly={false}
                                updateRoom={this.props.updateResidentsList}
                            /> : <DeleteResidentConfirmLayout
                                toggleHandler={this.toggleHandler}
                                resident={this.state.chosenResident}
                                updateResidentsList={this.props.updateResidentsList}
                                updateChartStats={this.props.updateChartStats}
                                chartStats={this.props.chartStats}
                            />

                        }
                    toggleHandler={this.toggleHandler}
                />

                <div className="residents-block-header">СПИСКИ</div>
                <div className="residents-container">
                    <div className="residents-nav">
                        <input type="text" onInput={(e) => this.filterByName(e)} placeholder="Введите имя"/>
                        <div className="filters">
                            <button onClick={(e) => this.filterBySettlement(e)} className="yellow-btn"><span
                                className={"tooltip-text"}>Незаселенные проживающие</span></button>
                            <button onClick={(e) => this.filterByCourse(e)} className="green-btn"><span
                                className={"tooltip-text"}>Первокурсники</span></button>
                            <button onClick={(e) => this.filterByRating(e)} className="red-btn"><span
                                className={"tooltip-text"}>Отрицательный рейтинг</span></button>

                            <button onClick={this.multicastAccrual} className="w-filter-btn"><img alt={"ruble"} src={rubleImg}/><span
                                className={"tooltip-text"}>Начислить плату</span></button>
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
                                            residentObj={resident}
                                            key={resident["ResidentId"]}
                                            readOnly={false}
                                            id={resident["ResidentId"]}
                                            lastname={resident["LastName"]}
                                            firstName={resident["FirstName"]}
                                            patronymic={resident["Patronymic"]}
                                            gender={resident["Gender"]}
                                            birthDate={resident["BirthDate"]}
                                            passportInformation={resident["PassportInformation"] === null ? "" : resident["PassportInformation"]}
                                            tin={resident["Tin"]}
                                            rating={resident["Rating"]}
                                            debt={resident["Debt"]}
                                            reports={resident["Reports"]}
                                            roomId={resident["RoomId"]}
                                            course={resident["Course"]}
                                            isCommercial={resident["IsCommercial"]}

                                            toggleTransactionModal={this.toggleTransactionModal}
                                            toggleRatingModal={this.toggleRatingModal}
                                            toggleDeleteResidentConfirmModal={this.toggleDeleteResidentConfirmModal}
                                        />) : ''
                            }
                        </div>
                    </div>
                </div>
            </div> : ""
    );
}

export default template;