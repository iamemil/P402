// var imgBoard = document.querySelector(".imgBoard");
// var image = document.querySelector(".imgBoard img");

// image.addEventListener("mouseover", function (e) {
//     if (!(e.ctrlKey)) {
//         var span = document.createElement("span");
//         span.classList.add("draw");
//         span.style.top = (e.offsetY - 7.5) + "px";
//         span.style.left = (e.offsetX - 7.5) + "px";
//     }
//     span.addEventListener("click", function () {
//         span.remove(this);
//     });
//     imgBoard.appendChild(span);
// });


// vaxt < 24 saat ->  X saat evvel
// vaxt > 24 saat -> X gun evvel
// vaxt > (24*7) saat -> X hefte evvel
// vaxt > (24*7)*4 saat -> X ay evvel
// vaxt > 12 ay -> date



var postDate = new Date(2018, 1, 25, 10, 10);
var tarix = new Date();
document.querySelector(".date").innerText = postDate.getHours() + ":" + postDate.getMinutes() + " " + postDate.getFullYear();

if (tarix - postDate < 86400000) {
    var diff = Math.floor((tarix - postDate)/1000/60/60);
    document.querySelector(".info").innerText = diff + " saat öncə";
}
if(tarix - postDate > 86400000 && tarix - postDate < 604800000){
    var diff = Math.floor((tarix - postDate)/1000/60/60/24);
    document.querySelector(".info").innerText = diff + " gün öncə";
}
if(tarix - postDate > 604800000 && tarix - postDate < 2629746000){
    var diff = Math.floor((tarix - postDate)/1000/60/60/24/7);
    document.querySelector(".info").innerText = diff + " həftə öncə";
}
if(tarix - postDate > 2629746000 && tarix - postDate < 31556952000){
    var diff = Math.floor((tarix - postDate)/1000/60/60/24/7/4);
    document.querySelector(".info").innerText = diff + " ay öncə";
}
if(tarix - postDate > 31556952000){
    document.querySelector(".info").innerText = postDate;
}