$(document).ready(function(){
    $(".navbar-items").click(function(){
        if($(this).children().length != 0){
            $(this).children().eq(0).toggle();
        }
    });
    $(".dropdown-items").click(function(){
        if($(this).children().length != 0){
            $(this).parent().toggle();
            $(this).children().eq(0).toggle();
        }
    });
});