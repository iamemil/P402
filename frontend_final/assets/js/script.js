$(document).ready(function () {
    new WOW().init();
    $(window).scroll(function(){
        if($(this).scrollTop()>50){
            $(".navbar").addClass("bg-black");
            $(".navbar").addClass("fixed-top");
        }else{
            $(".navbar").removeClass("bg-black");
            $(".navbar").removeClass("fixed-top");
        }
        console.log();
    });
    
    $(".nav-item.hover").hover(function(){
        $(this).children().eq(1).toggleClass("show");
        $(this).children().eq(1).toggleClass("animated fadeIn");        
    });

    $(".nav-item.click").click(function(){
        $(this).children().eq(1).toggleClass("show");
        $(this).children().eq(1).toggleClass("animated fadeIn");        
    });

    $('.facts').appear(function(){        
         $('.count-text').countTo();
    });   

});