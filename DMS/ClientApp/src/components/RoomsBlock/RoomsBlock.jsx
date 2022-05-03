import "./RoomsBlock.css";
import './scripts'
import React from "react";
import InRoomResidents from "../InRoomResidents/InRoomResidents";
import Room from "../Room/Room";

function template() {
  return (
      this.props.show ?
    <div className="rooms">
        <div className="tabs-block">
            <ul className="nav nav-tabs">
                <li id={2} onClick={(e) => this.tabClick(e)} className="first"><a href="#2">2</a></li>
                <li id={3} onClick={(e) => this.tabClick(e)}><a href="#3">3</a></li>
                <li id={4} onClick={(e) => this.tabClick(e)}><a href="#4">4</a></li>
                <li id={5} onClick={(e) => this.tabClick(e)}><a href="#5">5</a></li>
            </ul>
        </div>

        <div className="rooms-main-block">
            <div className="rooms-header">КОМНАТЫ</div>
            <div className="rooms-btn-block-scroll-zone">
                <div className="rooms-btn-block">
                    <Room openRoom = {this.props.openRoom}/>
                </div>
            </div>
        </div>
    </div> : ''
  );
};

export default template;
