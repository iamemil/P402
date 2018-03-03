var navbar = document.querySelector(".navbar");
var trigBtn = document.querySelector(".navbar-trigger");

trigBtn.addEventListener("click", function(){
    navbar.classList.add("active");
});
window.addEventListener("click", function (e) {
    if (e.target.classList.contains("navbar") && navbar.classList.contains("active")) {
        navbar.classList.remove("active");
    }
});