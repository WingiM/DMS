import "./Sidebar.css";
import "./progresscircle"
import React from "react";
import './scripts'

import settingIco from './img/settingsIco.svg'
import wavesIco from './img/waves.svg'
import {Navigate} from "react-router-dom";

function template() {
    if (localStorage.getItem("token") === null) {
        return <Navigate to="/login" />
    }
    return (
        <div className="sidebar">
            <a id="settings" href="#settings"><img alt="settings"
                                                   src={settingIco}/></a>
            <span id="sidebar-header">DMS</span>

            <div className="stats-block">
                <span id="stats-header">ЧИСЛО ЖИЛЬЦОВ</span> <br/>

                <div className="stats-intel-block">
                    <div className="stats-intel">
                        <span className="marked-span filled">занято</span><br/>
                        <span className="relative-span">{this.props.settled}</span><br/>
                        <span className="marked-span unfilled">свободно</span><br/>
                        <span className="relative-span">{this.props.total}</span><br/>
                    </div>
                    <div className="circlechart"
                         data-percentage={this.props.total / this.props.settled | 0}>
                    </div>
                </div>
            </div>

            <div className="sidebar-btn-block">
                <a id="rooms" onClick={this.props.showRooms}
                   className="sidebar-btn" href="#rooms">
                    Комнаты
                </a>
                <a id="residents"
                   className="sidebar-btn" onClick={this.props.showResidents} href="#residents">
                    Проживающие
                </a>
                <a id="documents"
                   className="sidebar-btn" href="#documents">
                    Документы
                </a>
            </div>

            <img id="waves" src={wavesIco} alt="waves"/>
        </div>

    );
}

export default template;
