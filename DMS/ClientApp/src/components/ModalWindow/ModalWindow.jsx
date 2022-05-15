import "./ModalWindow.css";
import React from "react";
import closeButtonImg from "../InRoomResidents/img/cross.svg";
import "./ModalWindowLayouts/Layouts.css"

function template() {
    return (
        this.props.show ?
            <div className="modal show-modal">
                <div className={`modal-content ${this.props.layoutName}`}>
                    {this.props.layout}
                    <button onClick={() => this.props.toggleHandler()} className="close-residents-button"><img
                        alt="close" src={closeButtonImg}/></button>
                </div>
            </div> : ''
    );
};

export default template;
