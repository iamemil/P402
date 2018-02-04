// var n = Number(prompt('Ədədi daxil edin.'));

function numberOfDivisors(n){
    var i = 1;
    var divisor = 0;

    if(n >= 0){
        while(i <= n){
            if(n % i == 0){
                divisor++;
                i += 1;
            } else {
                i += 1;
            }
        } return divisor;
    }
    return false;    
}

//var div = numberOfDivisors(n);

//alert(n + ' ədədinin ' + div + ' böləni var.');


var student = {
    name: 'Emil',
    surname: 'Ismayilzada',
    birthday: 2001,
    getAge:function(){
        return 2018 - this.birthday;
    }
};

console.log(student.getAge());


