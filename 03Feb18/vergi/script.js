var gross = Number(prompt('Maaşınızı daxil edin.'));
var minimumEmekHaqqi = Number(prompt('Minimum əmək haqqını daxil edin.'));

function netRevenue(maash, mek){
    if (maash <= 2500){
        return maash - ((maash - mek) * 0.14) - (maash * 0.03);
    } else if(maash > 2500){
        return maash - ((maash - 2500) * 0.25) - (maash * 0.03) - (2500 * 0.14);
    }
}

var netRevenue = netRevenue(gross, minimumEmekHaqqi);
console.log(netRevenue);


// oldprice 
// newprice
// faiz ferqi