var addBtn = document.querySelector("#addImages");
var imagesDiv = document.querySelector(".images");
var display = document.querySelector(".display");
var displayImg = document.querySelector("#displayImg");
var displayClose = document.querySelector("#closeDiv");

addBtn.addEventListener("click", function () {
    var imgSrc = document.querySelector("#imgSrc");

    if (imgSrc.value != "") {
        var li = document.createElement("li");
        var img = document.createElement("img");
        imagesDiv.appendChild(li);
        li.appendChild(img);
        img.setAttribute("src", imgSrc.value);
        imgSrc.value = "";
    }

    var imgSelected = document.querySelectorAll(".images li img");
    for (i = 0; i < imgSelected.length; i++) {
        imgSelected[i].addEventListener("click", function () {
            imgValue = this.getAttribute("src");
            console.log(imgValue);
            display.classList.add("show");
            displayImg.setAttribute("src", imgValue);

        });
    };
    displayClose.addEventListener("click", function(){        
        display.classList.remove("show");
        displayImg.removeAttribute("src");
    });

});