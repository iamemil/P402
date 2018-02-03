// 2005 2010
// 2.0 3.0

var carYear = Number(prompt('İli daxil edin.'));
var motorSize = Number(prompt('Motor ölçüsünü daxil edin.'));;

if((carYear >= 2005 && carYear <= 2010) && (motorSize >= 2.0 && motorSize <= 3.0)){
    alert("Maşın var");
} else{
    alert("Maşın yoxdur");
}