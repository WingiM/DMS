import React from "react";
import dotsImg from "../../Resident/img/resident3Dots.svg";
import template from "../ModalWindow";

class SettlementOrderLayout extends React.Component {
    constructor(props) {
        super(props);
    }

    filterByName(e) {
        this.props.filterHandler(this.props.residentsList.filter(i=>
            (~(i["FirstName"] + i["LastName"] + i["Patronymic"]).toLowerCase().indexOf(e.target.value.toLowerCase()))))
    }
    
    render() {
        return (
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
                                            className="resident-header">
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

export default SettlementOrderLayout;   