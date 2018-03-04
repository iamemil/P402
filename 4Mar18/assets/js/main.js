$(document).ready(function () {
    $(".accordion-items").click(function () {
        $(this).find("ul").slideToggle("fast");
        $(this).find("ul").toggleClass("show");
    });
});