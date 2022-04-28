import { Link } from "react-router-dom"

import "./Sidebar.css";
import "./progresscircle"
import React from "react";
import $ from 'jquery';
import './scripts'

import settingIco from './img/settingsIco.svg'
import wavesIco from './img/waves.svg'

function template() {
    return (
        <div className="sidebar">
            <Link to="/settings"><a id="settings"><img alt="settings"
                                                   src={settingIco}/></a></Link>
            <span id="sidebar-header">DMS</span>

            <div className="stats-block">
                <span id="stats-header">ЧИСЛО ЖИЛЬЦОВ</span> <br/>

                <div className="stats-intel-block">
                    <div className="stats-intel">
                        <span className="marked-span filled">занято</span><br/>
                        <span className="relative-span">304</span><br/>
                        <span className="marked-span unfilled">свободно</span><br/>
                        <span className="relative-span">93</span><br/>
                    </div>
                    <div className="circlechart"
                         data-percentage="78">
                    </div>
                </div>
            </div>

            <div className="sidebar-btn-block">
                <a id="residents" className="sidebar-btn" href="#residents">
                    Проживающие
                </a>
                <a id="documents" className="sidebar-btn" href="#documents">
                    Документы
                </a>
            </div>

            <img id="waves" src={wavesIco} alt="waves"/>
            <script>
                $(function(){
                    $('.circlechart').circlechart()
            });
            </script>

        </div>

    );
}

export default template;
