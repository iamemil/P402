var m = Number(prompt('Ayı daxil edin. (1-12)'));

if(m==12||m==1||m==2){    
    console.log('Daxil etdiyiniz ay qış ayıdır.');
} else if(m==3||m==4||m==5) {
    console.log('Daxil etdiyiniz ay yaz ayıdır.');
} else if(m==6||m==7||m==8){
    console.log('Daxil etdiyiniz ay yay ayıdır.');
} else if(m==9||m==10||m==11){
    console.log('Daxil etdiyiniz ay payız ayıdır.');
} else{
    console.log('Düzgün ay daxil edin.');
}