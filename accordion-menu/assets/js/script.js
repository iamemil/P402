var menuItems = document.querySelectorAll(".accordion-items");

for (var i = 0; i < menuItems.length; i++) {
    menuItems[i].addEventListener("click", function () {
        if (this.querySelector("ul")) {
            this.querySelector("ul").classList.toggle("show");
        };
    });
};