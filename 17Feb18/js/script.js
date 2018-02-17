var sozler = "   Salam Azerbaycan   ";

// function trim(str) {
//     result = "";
//     for (var i = 0; i < str.length; i++) {
//         if (i == 0 || !(str.charAt(i - 1) == " ")) {
//             var temp = str.charAt(i);
//             result += temp.replace(" ", "");
//         } else {
//             result += temp.replace(" ", "");
//         }
//     }
//     return result;
// }

// function trim(str) {
//     var startIndex = "";
//     var endIndex = "";
//     for (var i = 0; i < str.length; i++) {
//         if (str.charAt(i) != " "){
//             startIndex = i;
//             endIndex = str.lastIndexOf(" ");
//             return startIndex + " "+ endIndex;

//         }
//     }
// }

// console.log(trim(sozler));

var divs = [
    {
        width: 25,
        height: 150,
        backgroundColor: "black"
    },
    {
        width: 15,
        height: 200,
        backgroundColor: "green"
    },
    {
        width: 10,
        height: 100,
        backgroundColor: "blue"
    },
    {
        width: 25,
        height: 100,
        backgroundColor: "green"
    },
    {
        width: 25,
        height: 200,
        backgroundColor: "yellow"
    }
];

document.write("<div class='main'>");
for (var i = 0; i < divs.length; i++) {
    document.write("<div style='width:" + divs[i].width + "%;height:" + divs[i].height + "px;background:" + divs[i].backgroundColor + "'></div>");

}
document.write("</div>");