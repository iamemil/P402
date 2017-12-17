var n = Number(prompt('İntervalın sonuncu həddini qeyd edin'));

var tek = 1;


if(n>0){
while(tek<=n){
    console.log(tek);
    tek+=2;
}
} else{
    console.log('Sıfırdan böyük ədəd daxil edin');
}