var esiz = Number(prompt('Endirimsiz qiymət'));
var eli = Number(prompt('Endirimli qiymət'));


if(esiz>eli){
var faiz = ((esiz - eli) / esiz) * 100;
console.log('Endirim '+ faiz.toFixed(2) +'%-dir.'); 
} else {
    console.log('Endirim yoxdur.'); 
}


