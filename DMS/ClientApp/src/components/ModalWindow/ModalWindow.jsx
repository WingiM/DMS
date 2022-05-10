import "./ModalWindow.css";
import React from "react";
import hmacSHA512 from 'crypto-js/hmac-sha512';
import closeButtonImg from "../InRoomResidents/img/cross.svg";
import dotsImg from "../Resident/img/resident3Dots.svg";

function template() {
    return (
        this.props.show ?
            <div className="modal show-modal">
                <div className="modal-content">
                    <div className="rooms-header in-modal">СПИСКИ</div>
                    <input type="text" placeholder="ВВЕДИТЕ ИМЯ"/>
                    <div className="in-room-residents-scroll-zone">
                        {
                            this.props.residents !== undefined?
                                this.props.residents.map(resident =>
                                    resident["RoomId"] === null ?
                                    <div className="resident-collapsible in-modal">
                                        <button
                                            onClick={(e) => this.openCollapsible(e)}
                                            className="resident-header">
                                            {resident["LastName"].toUpperCase()} {resident["FirstName"].toUpperCase()} {resident["Patronymic"].toUpperCase()}
                                            <img className="header-dots" alt="dots" src={dotsImg}
                                            />
                                        </button>
                                    </div> : '') : ''
                        }
                    </div>
                    <button onClick={() => this.props.toggleHandler()} className="close-residents-button"><img
                        alt="close" src={closeButtonImg}/></button>

                </div>
            </div> : ''
    );
};

export default template;
