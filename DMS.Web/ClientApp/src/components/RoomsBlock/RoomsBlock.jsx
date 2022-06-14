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
                {this.props.floors.map(floor =>
                    <li key={floor} 
                        id={floor} 
                        onClick={(e) => this.tabClick(e)}
                    >
                        <a href={"#" + floor}>{floor}</a>
                    </li>)
                }
            </ul>
        </div>

        <div className="rooms-main-block">
            <div className="rooms-header">КОМНАТЫ</div>
            <div className="rooms-btn-block-scroll-zone">
                <div className="rooms-btn-block">
                    {this.state.rooms.map(room => 
                        <Room key={room["Id"]} name={room["Id"]} isFull={room["IsFull"]} openRoom={this.props.openRoom}/>)}
                </div>
            </div>
        </div>
    </div> : ''
  );
};

export default template;
