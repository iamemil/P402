$(document).ready(function () {
    $(".tabs .tabNavigation .navButton").click(function () {
        $(this).siblings().removeClass("active");
        $(this).addClass("active");
        $(".tabText").siblings().hide(500);
        $(".tabContent").find("#" + $(this).data("id")).show(500);
    });
});