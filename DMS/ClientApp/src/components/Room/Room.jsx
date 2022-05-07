import "./Room.css";
import React from "react";

function template() {
  return (
      <button onClick={() => this.props.openRoom(this.props.name)} className="room-btn -free">
          <span>{this.props.name}</span>
      </button>
  );
};

export default template;
