import React from "react";
import {renderCircleChart} from "./progresscircle";

document.addEventListener("DOMContentLoaded", function (event) {
    setRootVars()
    
    try{
        let circleChart = document.querySelector(".circlechart");
        renderCircleChart(circleChart)
        let observer = new MutationObserver(function(mutations) {
            renderCircleChart(circleChart)
        });

        observer.observe(circleChart, {attributes: true});
    }
    catch (ex)
    {
    }
    
});

function setRootVars() {
    let root = document.querySelector(':root');
    let borderRadius = 0.018229 * window.screen.width

    root.style.setProperty("--blocks-border-radius", borderRadius + "px");
    root.style.setProperty("--stats-block-height", window.screen.height * 0.26 + "px")
}