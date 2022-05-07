import jQuery from 'jquery'

function makesvg(percentage) {

    const abs_percentage = Math.abs(percentage).toString();
    const percentage_str = percentage.toString();
    const classes = "diagram-stroke circle-chart__circle--negative";

    let svg = '<svg style="overflow: visible" class="circle-chart" viewbox="0 0 33.83098862 33.83098862" xmlns="http://www.w3.org/2000/svg">'
        + '<circle class="circle-chart__background" cx="16.9" cy="16.9" r="15.9" />'
        + '<circle class="circle-chart__circle ' + classes + '"'
        + 'stroke-dasharray="' + abs_percentage + ',100"    cx="16.9" cy="16.9" r="15.9" />'
        + '<g class="circle-chart__info">'
        + '   <text style="fill: #2E84A8; font: Bold 6px Ubuntu" class="circle-chart__percent" x="17.9" y="17.5">' + percentage_str + '%</text>';

    svg += ' </g></svg>';
    return svg
}

(function ($) {

    $.fn.circlechart = function () {
        this.each(function () {
            let percentage = $(this).data("percentage");
            $(this).html(makesvg(percentage));
        });
        return this;
    };

}(jQuery));