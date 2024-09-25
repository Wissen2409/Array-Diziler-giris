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

// 3 değeri dizinin taşıyacağı eleman sayısını tanımlar.

// int tipinde dizi tanımladık
// dizinin içerisindeki elemanı ekrana yazdıralım
//Console.WriteLine(intDizi[1]);
// dizi içerisimdeki bir elemanı çağırmak isterseniz o elemanın index numarasını vermek zorundasınız
// dizilerde index numaraları 0dan başlar, aynı string ifadelerdeki gibi


// int tipinde dizinin içerisine eleman atalım
// 1. index'e değer atayalım
intDizi[1]=80;

//Console.WriteLine(intDizi[1]);

// int tipinden diziye string değer yerleştirmeye çalışalım
// int tipinden bir dizi string tipinde bir değer alamaz
//intDizi[3]="metin";

byte b =10;
intDizi[2]=b;

// bir dönüşüm işlemi yapıldı(Bilinçsiz dönüşüm)

// dizinin 5. indexine veri atmaya çalışalım


//intDizi[5]=10;

// yukarıdaki gibi bir tanımlama yani 3 elemanlı bir dizinin 5. indexine veri basmaya çalışırsak, çalışma zamanı hatası alırız.

// dizi içeresine atılan elemanları ekrana yazdırmak(for ile )


// length dizinin eleman sayısını verir
/*for(int i=0;i<intDizi.Length;i++){

    // bu for döngüsü dizinin boyutu kadar dönecektir.
    // 0. indexten başlayıpi dizi boyutu kadar ilerleyecektir.
    Console.WriteLine(intDizi[i]);
}

Console.WriteLine("Lütfen gireceğiniz not adedini yazınız");
int notAdet = int.Parse(Console.ReadLine());
int[] nots = new int[notAdet];
*/

// Örnek : 
// Öğrenci not giriş sistemi yapınız
// ilk olarak öğrenciden kaç adet not gireceğini sorunuz
// daha sonra not girişlerini bir dizi içerisinde alınız
// not girişi bittikten sonra notları ekrana yazdırınız

/*
for(int i =0;i<nots.Length;i++){

    Console.WriteLine("{0}. notu giriniz",i+1);
    nots[i]=int.Parse(Console.ReadLine());
}
//notları aldık, şimdi ekrana yazdırm

for(int i=0;i<nots.Length;i++)
{

    Console.WriteLine("{0}. not : {1}",i+1,nots[i]);
}
*/

// Örnek : 

// 10 adet eleman taşıyan bir dizi tanımlayınız ve dizinin tüm elemanlarını 1-100 arası 
//random sayı ile doldurunuz
/*int[] randomDizi = new int[10];

Random rnd = new Random();
for(int i=0;i<randomDizi.Length;i++){

  randomDizi[i]=rnd.Next(1,100);

}
// random elemanlar dizi içerisine dolduruldu şimdi ekrana yazdıralım
for(int i=0;i<10;i++){

  Console.WriteLine(randomDizi[i]);    
}

*/

// Örnek : 

// 100 elamanlı bir string dizi yapıp, dizinin her elemanına, 
//10 karakterli random kelime yazdırınız
string[] randomKelime = new string[100];
Random rnd = new Random();
for(int i=0;i<randomKelime.Length;i++){

    string randomString ="";
    for(int j=0;j<70;j++){

        randomString += Convert.ToChar(rnd.Next('a','z')).ToString();

    }
    randomKelime[i]=randomString;
}
for(int i=0;i<randomKelime.Length;i++){
    Console.WriteLine(randomKelime[i]);
}
