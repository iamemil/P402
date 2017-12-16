var x = Number(prompt('Rəqəmi daxil edin'));

if(x>=100&&x<=999){
var last = x%10;
var first = (x - x%100)/100;
if(first>last){
    console.log(first);
} else if(last>first){
    console.log(last);
} else {
    console.log('Bərabərdir')
}
} else {
console.log('3 rəqəmli daxil edin.');
}