$(document).ready(function(){
    $(".slider-thumbnails > img").mouseover(function(){
        $(".slider-thumbnails").parent().find(".active").removeClass("active");
        $(this).parent().addClass("active");
        $(".slider > img").attr("src",$(this).data("img"));
    });
});