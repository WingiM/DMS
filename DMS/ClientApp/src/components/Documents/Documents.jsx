import "./Documents.css";
import React from "react";
import dotsImg from "../Resident/img/resident3Dots.svg";
import ResidentsListLayout from "../ModalWindow/ModalWindowLayouts/ResidentsListLayout";
import ModalWindow from "../ModalWindow";
import SettlementOrderLayout from "../ModalWindow/ModalWindowLayouts/SettlementOrderLayout";
import RatingOperationsLayout from "../ModalWindow/ModalWindowLayouts/RatingOperationsLayout";
import EvictionOrderLayout from "../ModalWindow/ModalWindowLayouts/EvictionOrderLayout";
import TransactionsLayout from "../ModalWindow/ModalWindowLayouts/TransactionsLayout";

function template() {
    return (
        this.props.show ?
            <div className="documents">
                <ModalWindow
                    show={this.state.showModal}
                    toggleHandler={this.toggleModal}
                    layout={this.state.layout}
                    residents={this.state.modalResidents}
                    layoutName={this.state.layoutName}
                />
                <div className="documents-block-name">ДОКУМЕНТЫ</div>

                <div className="documents-container">
                    <div className="documents-nav"><input onInput={(e) => this.filterByName(e)} type="text" placeholder="Введите имя"/></div>
                    
                    <div className="documents-scroll-zone">
                        {
                            this.props.residentsFilterList !== undefined ?
                                this.props.residentsFilterList.map(resident =>
                                    <div className="resident-collapsible">
                                        <button
                                            onClick={(e) => this.openCollapsible(e)}
                                            className="resident-header">
                                            {resident["LastName"].toUpperCase()} {resident["FirstName"].toUpperCase()} {resident["Patronymic"].toUpperCase()}
                                            <img className="header-dots" alt="dots" src={dotsImg}
                                            />

                                        </button>
                                        <div className="resident-content">
                                            {resident["RatingOperations"] !== undefined ?
                                                resident["RatingOperations"].map(doc =>
                                                    <div className="resident-content-row" data-type={"RatingOperations"}
                                                         onClick={() => this.toggleModal(
                                                             <RatingOperationsLayout resident={resident}/>, "rating-operations")}>
                                                        Начисление рейтинга </div>) : ""
                                            }
                                            {resident["SettlementOrders"] !== undefined ?
                                                resident["SettlementOrders"].map(doc =>
                                                    <div className="resident-content-row"
                                                         onClick={() => this.toggleModal(<SettlementOrderLayout
                                                             resident={resident}/>, "settlement-orders")}
                                                         data-type={"SettlementOrders"}>Приказ о заселении </div>) : ""}
                                            {resident["EvictionOrders"] !== undefined ?
                                                resident["EvictionOrders"].map(doc =>
                                                    <div className="resident-content-row"
                                                         onClick={() => this.toggleModal(<EvictionOrderLayout
                                                             resident={resident}/>, "eviction-orders")}
                                                         data-type={"EvictionOrders"}>Приказ о выселении </div>) : ""}
                                            {resident["Transactions"] !== undefined ?
                                                resident["Transactions"].map(doc =>
                                                    <div className="resident-content-row"
                                                         onClick={() => this.toggleModal(<TransactionsLayout resident={resident}/>, "transactions")}
                                                         data-type={"Transactions"}>Транзакции </div>) : ""}
                                        </div>
                                    </div>) : ""
                        }
                    </div>
                </div>

            </div> : ""
    );
};

export default template;
