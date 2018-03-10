$(document).ready(function () {
    $("#table-search").keyup(function () {
        $(".find-table td").css("background-color", "white");
        var key = $(this).val();
        if (key != "") {
            $(".find-table td").filter(":contains('" + key + "')").css("background-color", "#ffff006b");
            $(".find-table td").filter(":not(:contains('" + key + "'))").parent().hide();
            $(".find-table td").filter(":not(:contains('" + key + "'))").css("background-color", "white");
            $(".find-table td").filter(":contains('" + key + "')").parent().show();
        }
    });
});