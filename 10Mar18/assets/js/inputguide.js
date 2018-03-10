$(document).ready(function(){
    $(".inputguide #phone").hover(function(){
        $(this).attr("placeholder", "+994-__-___-__-__");
    }, function(){
        $(this).removeAttr("placeholder")});
    $(".inputguide #phone").focus(function(){
        $(this).val("+994-__-___-__-__");
    });
    $(".inputguide #phone").keyup(function(){
        
        var inputNum = $(this).val();
        
    });
});