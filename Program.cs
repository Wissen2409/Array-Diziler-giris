// Diziler : 
// Birden fazla aynı tipte veriyi taşıyabilen yapılara dizi(Array) denir.

// Örnek : 

// ekrandan 10 adet not değeri alınız
// ekrandan 50 tane not değeri alınız
// ekrandan 100 tane not değeri alınız
// ekrandan 1000 tane not değeri alınız

// bir noktadan sonra, bir sürü değişken tanımlamak imkanız hale geliyor
// dizileri şu şekilde hayal edin, 30 adet yumurtayı taşımak için yumurta kolisine ihtiyacımız var
// aynı şekilde 100 tane int'i taşımak içinde dizilere ihtiyacımız var

// Dizi syntax 
// Not : dizi tanımlanırken hangi tipi taşıyacağı belirtilmelidir.
// int[] intDizi = new int[1000];

// Kurallar, 
/* 1 : dizi tanımlanırken kesinlikle kaç elemanlı olduğunu bildirmemiz gerekmektedir.
   2 : dizi tanımlanırken tipi verilmelidir. Dizi tanımlandığı tipte veriler içerebilir(yani int tipinde diziye string değer atılamaz)
   3 : Dizilerin başlangıç değerleri onların kapasitesi belirler. Kapasite aşımı yapmaya çalıştığınızda çalışma zamanı hatası alırsınız

*/

// int tipinde bir dizi tanımlayalım

int[] intDizi =new int[3];

// int tipinde dizi tanımladık
// dizinin içerisindeki elemanı ekrana yazdıralım
Console.WriteLine(intDizi[1]);
// dizi içerisimdeki bir elemanı çağırmak isterseniz o elemanın index numarasını vermek zorundasınız
// dizilerde index numaraları 0dan başlar, aynı string ifadelerdeki gibi


// int tipinde dizinin içerisine eleman atalım
// 1. index'e değer atayalım
intDizi[1]=80;

Console.WriteLine(intDizi[1]);
