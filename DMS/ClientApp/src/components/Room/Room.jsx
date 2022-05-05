import "./Room.css";
import React from "react";

function template() {
  return (
      <div onClick={() => this.props.openRoom(this.props.name)} className="room-btn -free">
          <span>{this.props.name}</span>
      </div>
  );
};

export default template;
