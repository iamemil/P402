var a = Number(prompt('Birinci rəqəmi daxil edin'));
var b = Number(prompt('İkinci rəqəmi daxil edin'));
var c = Number(prompt('Üçüncü rəqəmi daxil edin'));

a = a%2;
b = b%2;
c = c%2;

if((a==1&&b==1&&c==1)||(a==0&&b==0&&c==0)){
    console.log('Bütün ədədlər tək/cütdür.');
} else {
    console.log('Ədədlərdən bəziləri tək/cütdür.');
}