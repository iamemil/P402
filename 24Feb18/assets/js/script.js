// var tabBtn = document.querySelectorAll(".tabs .tabButtons");
// var activeTabs = document.querySelectorAll(".tabs .active");

// for (var i = 0; i < tabBtn.length; i++) {
//     tabBtn[i].addEventListener("click", function () {
//         this.parentNode.classList.remove("active");
//         if (this.parentNode.previousElementSibling == null) {
//             this.parentNode.classList.add("active");
//             this.parentNode.nextElementSibling.classList.remove("active");
//         } else {
//             this.parentNode.previousElementSibling.classList.remove("active");
//             if (this.parentNode.nextElementSibling != null) {
//                 this.parentNode.nextElementSibling.classList.remove("active");
//             } else {                
//             }
//             this.parentNode.classList.add("active");
//         }
//     });
// };

var input = document.querySelector("#input");
var addBtn = document.querySelector("#add");
var noteArea = document.querySelector("#noteArea");
var RemoveAllBtn = document.querySelector("#removeAll");

addBtn.addEventListener("click", function(){
    if(input.value == ""){
        input.setAttribute("placeholder", "There is nothing to add");
    } else{
        var li = document.createElement("li");
        li.innerText = input.value;
        var deleteButton = document.createElement("i");
        deleteButton.setAttribute("class", "fas fa-times");
        deleteButton.addEventListener("click", function(){
            this.parentNode.remove();
        });
        li.appendChild(deleteButton);
        noteArea.appendChild(li);
        input.value == "";
        
    }
});
RemoveAllBtn.addEventListener("click", function(){
    noteArea.childNodes.remove();
});
