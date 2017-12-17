var n = Number(prompt('Ədədi daxil edin'));

var i = 1;
var div = 0;

if (n > 0) {
    while (i <= n) {
        if (n % i == 0) {
            div++;
            console.log(i);
            i += 1;
        } else {
            i += 1;
        }
    } console.log(n+' ədədinin '+div+' böləni var.');
} else {
    console.log('Sıfırdan böyük ədəd daxil edin');
}



