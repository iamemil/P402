var qiymet = document.querySelector("#price");
var initPrc = document.querySelector("#initialPrice");
var month = document.querySelector("#month");
var calculate = document.querySelector("#calculate");
var currency = "AZN";
var priceTimetable = document.querySelector("#priceTimetable");
calculate.addEventListener("click", function () {
    var price = Math.ceil(parseFloat(qiymet.value));
    var initialPrice = parseFloat(initPrc.value);
    var creditMonth = parseInt(month.value);
    if (price < initialPrice) {
        alert("İlkin ödəniş qiymətdən çox ola bilməz");
    } else {
        var monthPrice = ((price - initialPrice) / creditMonth).toPrecision(4);
        priceTimetable.innerHTML = "";

        var tableHead = document.createElement("tr");
        var tableHeadId = document.createElement("th");
        tableHeadId.innerText = "#";
        var tableMonth = document.createElement("th"); 
        tableMonth.innerText = "Aylıq ödəniş";
        var tableDate = document.createElement("th");
        tableDate.innerText = "Ödənilməli tarix";
        tableHead.appendChild(tableHeadId);  
        tableHead.appendChild(tableMonth);  
        tableHead.appendChild(tableDate);
        priceTimetable.appendChild(tableHead);      

        for (var i = 1; i <= creditMonth; i++) {
            var tableBody = document.createElement("tr");

            var tableId = document.createElement("td");
            tableId.innerText = i;

            var tableMonthlyPrice = document.createElement("td");
            tableMonthlyPrice.innerText = monthPrice + ' ' + currency;

            var payDate = new Date();
            var payDateYear = payDate.getFullYear();
            var months = ["Yanvar", "Fevral", "Mart", "Aprel", "May", "İyun", "İyul", "Avqust", "Sentyabr", "Oktyabr", "Noyabr", "Dekabr"];
            var payDateMonth = months[payDate.getMonth() + i];
            var payDateDay = payDate.getDate();
            var payDateTime = document.createElement("td");
            payDateTime.innerText = payDateDay + " " + payDateMonth + " " + payDateYear;

            tableBody.appendChild(tableId);
            tableBody.appendChild(tableMonthlyPrice);
            tableBody.appendChild(payDateTime);
            priceTimetable.appendChild(tableBody);
        }
    }
});