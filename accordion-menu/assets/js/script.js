var accordion = [
{
name:"Profile",
icon:"fas fa-user",
subItems:["Posts","Media","Friends"]
},
{
name:"Messages",
icon:"fas fa-envelope",
subItems:["Inbox","Send","Drafts","Important","Receipts"]
},
{
name:"Settings",
icon:"fas fa-cog",
subItems:["Account Settings","Website Configuration"]
},
{
name:"Logout",
icon:"fas fa-bolt",
subItems:[]
}
];

document.write("<ul class='accordion-tabs'>");
for (var x = 0; x < accordion.length; x++) {
document.write("<li class='accordion-items'><i class='" + accordion[x].icon + "'></i> " + accordion[x].name);
if(accordion[x].subItems != ""){
document.write("<ul>");
for (var a = 0; a < accordion[x].subItems.length; a++){
document.write("<li>" + accordion[x].subItems[a] + "</li>");
}
document.write("</ul>");
}
document.write("</li>");
}
document.write("<li class='copyright'>Design by <a href='https://dribbble.com/shots/989145-Flat-Accordion'>Marion Serenio</a></li>");
document.write("</ul>");

    var menuItems = document.querySelectorAll(".accordion-items");

for (var i = 0; i < menuItems.length; i++) {
    menuItems[i].addEventListener("click", function () {
        if (this.querySelector("ul")) {
            this.querySelector("ul").classList.toggle("show");
        };
    });
};
