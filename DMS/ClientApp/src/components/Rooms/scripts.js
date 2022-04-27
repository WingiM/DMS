import React from "react";

export default function tabClick(e) {
    try {
        e.preventDefault();
        document.querySelector('.active').classList.remove('active');
        document.getElementById(e.currentTarget.id).classList.add('active');
    } catch (TypeError) {
        console.log("TypeError")
    }
}


document.addEventListener("DOMContentLoaded", function(event) {
    setRootVars()
});

function setRootVars() {
    let root = document.querySelector(':root');

    let rooms_size = 0.045 * window.screen.width
    let rooms_mainBlock_height = 0.61 * window.screen.height - window.screen.height * 0.02;
    let border_radius = 0.018229 * window.screen.width

    root.style.setProperty("--room-btn-size", rooms_size + "px");
    root.style.setProperty("--rooms-main-block-max-height", rooms_mainBlock_height + "px");
    root.style.setProperty("--blocks-border-radius", border_radius + "px");
}