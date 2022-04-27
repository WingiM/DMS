import $ from "jquery";

    document.addEventListener("DOMContentLoaded", function(event) {
    setRootVars()

    $(function(){
        $('.circlechart').circlechart()
    });
});

function setRootVars() {
    let root = document.querySelector(':root');
    let borderRadius = 0.018229 * window.screen.width

    root.style.setProperty("--blocks-border-radius", borderRadius + "px");
    root.style.setProperty("--stats-block-height", window.screen.height * 0.26 + "px")
}