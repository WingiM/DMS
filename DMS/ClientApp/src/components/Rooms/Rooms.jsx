import "./Rooms.css";
import './scripts'
import tabClick from './scripts'
import React from "react";

function template() {
  return (
    <div className="rooms">
        <div className="tabs-block">
            <ul className="nav nav-tabs">
                <li id={2} onClick={(e) => tabClick(e)} className="first active"><a href="#2">2</a></li>
                <li id={3} onClick={(e) => tabClick(e)}><a href="#3">3</a></li>
                <li id={4} onClick={(e) => tabClick(e)}><a href="#4">4</a></li>
                <li id={5} onClick={(e) => tabClick(e)}><a href="#5">5</a></li>
            </ul>
        </div>

        <div className="rooms-main-block">
            <div className="rooms-header">КОМНАТЫ</div>
            <div className="rooms-btn-block-scroll-zone">
                <div className="rooms-btn-block">
                    <div className="room-btn-free">
                        <span>201</span>
                    </div>
                    <div className="room-btn-free">
                        <span>201</span>
                    </div>
                    <div className="room-btn-free">
                        <span>201</span>
                    </div>

                    <div className="room-btn-free">
                        <span>201</span>
                    </div>
                    <div className="room-btn-free">
                        <span>201</span>
                    </div>
                    <div className="room-btn-free">
                        <span>201</span>
                    </div>

                    <div className="room-btn-free">
                        <span>201</span>
                    </div>
                    <div className="room-btn-free">
                        <span>201</span>
                    </div>
                    <div className="room-btn-free">
                        <span>201</span>
                    </div>

                    <div className="room-btn-free">
                        <span>201</span>
                    </div>
                    <div className="room-btn-free">
                        <span>201</span>
                    </div>
                    <div className="room-btn-free">
                        <span>201</span>
                    </div>

                    <div className="room-btn-free">
                        <span>201</span>
                    </div>
                    <div className="room-btn-free">
                        <span>201</span>
                    </div>
                    <div className="room-btn-free">
                        <span>201</span>
                    </div>

                    <div className="room-btn-free">
                        <span>201</span>
                    </div>
                    <div className="room-btn-free">
                        <span>201</span>
                    </div>
                    <div className="room-btn-free">
                        <span>201</span>
                    </div>

                    <div className="room-btn-free">
                        <span>201</span>
                    </div>
                    <div className="room-btn-free">
                        <span>201</span>
                    </div>
                    <div className="room-btn-free">
                        <span>201</span>
                    </div>

                    <div className="room-btn-free">
                        <span>201</span>
                    </div>
                    <div className="room-btn-free">
                        <span>201</span>
                    </div>
                    <div className="room-btn-free">
                        <span>201</span>
                    </div>

                    <div className="room-btn-free">
                        <span>201</span>
                    </div>
                    <div className="room-btn-free">
                        <span>201</span>
                    </div>
                    <div className="room-btn-free">
                        <span>201</span>
                    </div>

                    <div className="room-btn-free">
                        <span>201</span>
                    </div>
                    <div className="room-btn-free">
                        <span>201</span>
                    </div>
                    <div className="room-btn-free">
                        <span>201</span>
                    </div>

                    <div className="room-btn-free">
                        <span>201</span>
                    </div>
                    <div className="room-btn-free">
                        <span>201</span>
                    </div>
                    <div className="room-btn-free">
                        <span>201</span>
                    </div>

                    <div className="room-btn-free">
                        <span>201</span>
                    </div>
                    <div className="room-btn-free">
                        <span>201</span>
                    </div>
                    <div className="room-btn-free">
                        <span>201</span>
                    </div>
                </div>
            </div>
        </div>
    </div>
  );
};

export default template;
