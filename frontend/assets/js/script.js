$(document).ready(function () {

    	//Hide Loading Box (Preloader)
	function handlePreloader() {
		if($('.preloader').length){
			$('.preloader').delay(200).fadeOut(500);
		}
    }
   
        handlePreloader();
   
    
    new WOW().init();


    $(window).scroll(function(){
        if($(this).scrollTop()>50){
            $(".navbar").addClass("bg-black");
            $(".navbar").addClass("fixed-top");
        }else{
            $(".navbar").removeClass("bg-black");
            $(".navbar").removeClass("fixed-top");
        }
    });
    
    $(".nav-item.hover").hover(function(){
        $(this).children().eq(1).toggleClass("show");
        $(this).children().eq(1).toggleClass("animated fadeIn");        
    });

    $(".nav-item.click").click(function(){
        $(this).children().eq(1).toggleClass("show");
        $(this).children().eq(1).toggleClass("animated fadeIn");        
    });
    if($(".facts").length){
    $(".facts").appear(function(){        
         $(".count-text").countTo();
    });
}
    if($(".accordion").length){
        $(".accordion li").click(function(){
            if($(this).hasClass("active")){
                $(this).removeClass("active");
            } else {
                $(this).addClass("active");
            }            
        });
    }
     // Clients Carousel
     if($("#clients-karusel").length) {
     $("#clients-karusel").owlCarousel({
        loop:true,
        margin:0,
        nav:false,
        smartSpeed:700,
        autoplay:4000,
        responsive:{
            0:{
                items:1
            },
            600:{
                items:2
            },
            800:{
                items:3
            },
            1024:{
                items:3
            },
            1200:{
                items:3
            },
            1600:{
                items:5
            }
        }
    });
}

    	// Fancybox
	if($(".fancybox").length) {
		$(".fancybox").fancybox({
			openEffect  : 'fade',
            closeEffect : 'fade',
            helpers : {
				media : {}
			}
		});
	}

    //Testimonial Slider one
    if($(".testimonial-slider").length){
        $(".testimonial-slider").bxSlider({
            adaptiveHeight: true,
            auto:true,
            controls: true,
            mode: 'fade',
            pause: 7000,
            speed: 500,
            pagerCustom: ".testimonial-thumbnail",
            nextText:["<span class='fas fa-caret-right' style='font-size: 50px !important;color: white;margin: 5px;'></span>"],
            prevText:["<span class='fas fa-caret-left' style='font-size: 50px !important;color: white;margin: 5px;'></span>"]
        });
    }
   
});


window.onscroll = function() {scrollFunction()};
    
function scrollFunction() {
    if (document.body.scrollTop > 20 || document.documentElement.scrollTop > 20) {
        document.getElementById("back-to-top").style.display = "block";
    } else {
        document.getElementById("back-to-top").style.display = "none";
    }
}

// When the user clicks on the button, scroll to the top of the document
function topFunction() {
    document.body.scrollTop = 0; // For Safari
    document.documentElement.scrollTop = 0; // For Chrome, Firefox, IE and Opera
}