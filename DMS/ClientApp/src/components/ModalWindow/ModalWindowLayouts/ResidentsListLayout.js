import React from "react";
import dotsImg from "../../Resident/img/resident3Dots.svg";
import template from "../ModalWindow";
import ModalWindow from "../ModalWindow";
import SettlementOrderLayout from "./SettlementOrderLayout";

class ResidentsListLayout extends React.Component {
    constructor(props) {
        super(props);

        this.state = {
            showSettlementModal: false,
            chosenResident: null,
        }

        this.toggleSettlementModal = this.toggleSettlementModal.bind(this)
    }

    filterByName(e) {
        this.props.filterHandler(this.props.residentsList.filter(i =>
            (~(i["FirstName"] + i["LastName"] + i["Patronymic"]).toLowerCase().indexOf(e.target.value.toLowerCase()))))
    }

    async toggleSettlementModal(resident) {
        await this.setState({
            showSettlementModal: !this.state.showSettlementModal,
            chosenResident: resident,
        })

        document.querySelector(".modal-content").className = this.state.showSettlementModal ? 
            "modal-content settlement-order" : "modal-content"
    }

    render() {
        return (
            this.state.showSettlementModal ?
                <SettlementOrderLayout
                    toggleModal={this.toggleSettlementModal}
                    resident={this.state.chosenResident}
                    roomId={this.props.roomId}
                />

                :
                <div>
                    <div className="rooms-header in-modal">СПИСКИ</div>
                    <input type="text" onInput={(e) => this.filterByName(e)} placeholder="ВВЕДИТЕ ИМЯ"/>
                    <div className="in-room-residents-scroll-zone">
                        {
                            this.props.residentsFilterList !== undefined ?
                                this.props.residentsFilterList.map(resident =>
                                    resident["RoomId"] === null ?
                                        <div className="resident-collapsible in-modal">
                                            <button
                                                className="resident-header"
                                                onClick={() => this.toggleSettlementModal(resident)}
                                            >
                                                {resident["LastName"].toUpperCase()} {resident["FirstName"].toUpperCase()} {resident["Patronymic"].toUpperCase()}
                                                <img className="header-dots" alt="dots" src={dotsImg}
                                                />
                                            </button>
                                        </div> : '') : ''
                        }
                    </div>
                </div>
        )
    }
}

export default ResidentsListLayout;   