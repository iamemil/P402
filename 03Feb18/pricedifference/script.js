var oldPrice = Number(prompt('Əvvəlki qiyməti daxil edin.'));
var newPrice = Number(prompt('Yeni qiyməti daxil edin.'));


function priceDifference(oldp, newp) {
    if (oldp == undefined || isNaN(parseFloat(oldp)) || newp == undefined || isNaN(parseFloat(newp))) {
        return false;
    }
    var difference;
    if (oldp < newp) {
        difference = (newp - oldp) * 100 / oldp;
        return difference + "% bahalaşıb.";
    } else if (oldp > newp) {
        difference = (oldp - newp) * 100 / oldp;
        return difference + "% ucuzlaşıb.";
    }
}

priceDiff = priceDifference(oldPrice, newPrice);

alert("Məhsul " + priceDiff);