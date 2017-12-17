var a1 = Number(prompt('Birinci çadırın çəkisi'));
var b1 = Number(prompt('Birinci çadırın tuta bildiyi adam sayı'));

var a2 = Number(prompt('İkinci çadırın çəkisi'));
var b2 = Number(prompt('İkinci çadırın tuta bildiyi adam sayı'));

var a3 = Number(prompt('Üçüncü çadırın çəkisi'));
var b3 = Number(prompt('Üçüncü çadırın tuta bildiyi adam sayı'));

var k = Number(prompt('Toplam adam sayı'));
var w = Number(prompt('Toplam çəki'));

if(a1<=w&&b1>=k){
    console.log('1ci çadır');
} else if(a2<=w&&b2>=k){
    console.log('2ci çadır');
} else if(a3<=w&&b3>=k){
    console.log('3cü çadır');
} else if((a1+a2)<=w&&(b1+b2)>=k){
    console.log('1 və 2ci çadır');
} else if((a1+a3)<=w&&(b1+b3)>=k){
    console.log('1 və 3cü çadır');
} else if((a2+a3)<=w&&(b2+b3)>=k){
    console.log('2 və 3cü çadır');
} else if((a1+a2+a3)<=w&&(b1+b2+b3)>=k){
    console.log('1,2 və 3cü çadır');
} else {
    console.log('Alınmır');
}