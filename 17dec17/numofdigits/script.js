var n = Number(prompt('Ədədi daxil edin'));
var hedd = 1;
var digit = 0;

if(n>0){
 while(n >= hedd){
     digit++;
     hedd = hedd * 10;
 } console.log('Bu ədəd '+ digit + ' həddlidir.');
} else {
console.log('Müsbət ədəd daxil edin');
}