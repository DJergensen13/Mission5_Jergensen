$(document).ready(function () {
    $("#calculateButton").click(function () {
        var hours = parseFloat($("#hours").val());
        var totalSpan = $("#total");

        if (isNaN(hours) || hours <= 0) {
            alert("Please enter a valid positive number for hours.");
            return;
        }

        var hourlyRate = 25;
        var total = hours * hourlyRate;
        totalSpan.text("$" + total.toFixed(2));
    });
});