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

//int[] intDizi =new int[3];

// 3 değeri dizinin taşıyacağı eleman sayısını tanımlar.

// int tipinde dizi tanımladık
// dizinin içerisindeki elemanı ekrana yazdıralım
//Console.WriteLine(intDizi[1]);
// dizi içerisimdeki bir elemanı çağırmak isterseniz o elemanın index numarasını vermek zorundasınız
// dizilerde index numaraları 0dan başlar, aynı string ifadelerdeki gibi


// int tipinde dizinin içerisine eleman atalım
// 1. index'e değer atayalım
//intDizi[1]=80;

//Console.WriteLine(intDizi[1]);

// int tipinden diziye string değer yerleştirmeye çalışalım
// int tipinden bir dizi string tipinde bir değer alamaz
//intDizi[3]="metin";

//byte b =10;
//intDizi[2]=b;

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
/*string[] randomKelime = new string[100];
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
}*/






// Örnek : 
// Sayısal loto oyunu 
// kullanıcıdan 6 adet 1-49 arasında sayı alınız ve bir diziye doldurunuz
// daha sonra, 6 adet 1-49 arasında random sayı üretiniz ve diziye doldurunuz

// bu iki diziyi birbiri ile karşılaştırınız

// iki dizide de olan sayıları ekrana yazdırınız yada, ekrana şu kadar doğru tahmin ettiniz yazdırınız


/*
0 - 5

6 - 5
*/


/*int[] random = new int[6];
int[] kullanici = new int[6];

Random rnd = new Random();
for(int i = 0; i < random.Length;i++){

    // hem kullanıcıdan alalım, hemde random dolduralım

    Console.WriteLine("{0}. sayı tahminini giriniz",i+1);
    kullanici[i]=int.Parse(Console.ReadLine());

    // random sayıyı üretip diziye basalım
    random[i]=rnd.Next(1,49);
}
// iki diziyi kartezyen karşılaştırıp doğru sayı var yok kontrolü yapalım
for(int i = 0;i<random.Length;i++){

    for(int j=0;j<random.Length;j++){

        if(random[i]==kullanici[j]){

            Console.WriteLine("Doğru tahmin edilen sayı : {0}",random[i]);

        }
    }
}
*/


// Örnek 
// 6 tane sayı belirleyip, 30 yıl boyunca aynı sayıya oynamak
// altı sayı belirleyip, devamlı farklı random sayılar çekip, bu sayılar ile karşılaştırın
// her bir for bir haftayı belirlesin Datetime kullanabilirsiniz
// bakım bakalım, kaç hafta aynı sayılara oynayıp, 5 sayı biliyorsunuz

// haftayı for döngüsü olarak alınız
// bir hafta 15 tl olarak, hesaplayın, 5 bulduğunuz haftayı ve ne kadar para ödediğinizi 
// ekrana yazdırınız
// Datetime kullanarak her hafta yı dateyime olarak atayın, 5 tutturma zamanı hangi yılda olacak 
// ve kaç para harcamış olacaksınız bunu ekrana yansıtın

// 

// datetime konusu 
// for döngüsünde bir hafta bir hafta artırarak devem etmek

/*for(int i = 0; i < 1000;i++){

    
    Console.WriteLine(DateTime.Now.AddDays(7).ToString());
     

    // Derleyici istediğiniz kadar bekletebilirsiniz
    // Sleep fonksiyonu milisaniye cinsinden değer alır.

    // örnek 1000 girdiğimizde derleyici alttaki kodu çalıştırması için 1 saniye bekleyecektir.

    System.Threading.Thread.Sleep(5000);

}*/

// ekrandan aldığınız 10 elemanlı diziyi ekrandan aldığınız değerlerle doldurunuz
// daha sonra bu diziyi ters çeviriniz

// 1-5-7-9-10
// ters .
// 10-9-7-5-1

/*int[] dizi = new int[10];
int[] tersDizi = new int[dizi.Length];
for (int i = 0;i<dizi.Length;i++){

    Console.WriteLine("{0}. elemanı giriniz",i);
    dizi[i]=int.Parse(Console.ReadLine());
}
int sayac = 0;
for (int i = tersDizi.Length - 1; i >= 0 ; i--)
{
     tersDizi[sayac]=dizi[i];
     sayac++;
}
// 
// ekrandan verileri aldık söz konusu diziyi ters çevirelim

// Ters diziyi ekrana yazdıralım

for (int i = 0;i<dizi.Length;i++){

    Console.WriteLine("Düz dizi : {0}",dizi[i]);
    Console.WriteLine("Ters Dizi : {0}",tersDizi[i]);

}

// 1,2,3,4,5
// 5,4,3,2,1

/*
dizi[5] - tersDizi[0]
dizi[4] - tersDizi[1]
dizi[3]-  tersDizi[2]

*/

// Diziler ile ilgili hazır fonksiyonlar

// Diziler ile ilgili yapılacak işlemleri yapan hazır fonksiyonlar bulunmaktadır.

using System.Collections;
using System.Net.NetworkInformation;

int[] ints= new int[100];
ints[89]=10;


// diziler ile ilgili hazır fonksiyonara Array sınıfı üzerinden erişebilirsiniz


// girmiş olduğumuz değerin hangi index numarasında olduğu söyler.
// Dizi içerisinde arama yapan fonksiyondur
int hangiIndex = Array.IndexOf(ints,10);
Console.WriteLine(hangiIndex);
// hangi değerden birden fazla index'te varsa, aranan sayının ilk bulunduğu index'i verecek

// IndexOf fonksiyonu ile araba yaptığımız değer dizinin içerisinde yoksa, -1 değerini verir

// IndexOf'un tersine, aranan değerin görüldüğü en son index numarası verir.
// Özetle  : 9. indexte 10 değeri ve 50. indexte 10 değeri var. 10 değerini lastindexof ile aratırsak bize 50. index numarasını verir.
//Array.LastIndexOf();



int[] reverseArray = new int[5];
reverseArray[0]=7;
reverseArray[1]=80;
reverseArray[2]=6;  
reverseArray[3]=2;

// yukarıdaki diziyi Array.Reverse ile ters çevirelim 
// ters çevirmemizi istediği diziyi aldı ve ters çevirdi.
//Array.Reverse(reverseArray);
//for(int i=0;i<reverseArray.Length;i++){
//    Console.WriteLine(reverseArray[i]);
//}

// Tarihe not : Fonksiyonlar konusu : Geriye değer döndürmeyen fonksiyonlar ile ilgili konuşcaz.
// Cumartesi günü dizi konusun arasında işleyeceğimiz konu 
// Değer tip ve Referans tip konusu

// Array.Sort diziyi sıralar(rakamları küçükten büyüğe, harfleri ise, alfabetik sıraya göre sıralar)
/*Array.Sort(reverseArray);
for(int i=0;i<reverseArray.Length;i++){
    Console.WriteLine(reverseArray[i]);
}*/

// Dizi sıralamak
// Kabarcık Sıralama(Bubble Sorting)
// Hızlı Sıralama ( Quick Sorting)

// Ödev : Bubble sorting ile 20 elemanlı bir diziyi sıralayınız


// Array.Clear diziyi temizlemek için kullanılır(Dizi içerisindeki tüm elemanlar siliniz);
//Array.Clear(reverseArray);

// Array.Copy
// bir dizinin kopyasını oluşturmak için Array.Copy fonksiyonu kullanılabilir


/*int[] destinationArray = new int[5];
Array.Copy(reverseArray,destinationArray,reverseArray.Length);
for(int i=0; i<reverseArray.Length;i++){
    Console.WriteLine(destinationArray[i]);

}
*/

// Örnek
// Kullanıcıdan 10 adet sayı alınız.
// bu sayıların tek sayı olanları tek sayi dizisine, çift sayı olanları çift sayı dizine atalım

/*int[] ciftDizi = new int[10];
int[] tekDizi = new int[10];

for(int i = 0; i <ciftDizi.Length;i++){

    Console.WriteLine("Bir sayı giriniz");
    int sayi = int.Parse(Console.ReadLine());
    if(sayi%2==0){

        ciftDizi[i]=sayi;
    }
    else{
        tekDizi[i]=sayi;
    }
}
// Dizileri listeyelim 
for(int i = 0;i<ciftDizi.Length;i++){

    Console.WriteLine("Çift Dizi {0}",ciftDizi[i]);
    Console.WriteLine("Tek Dizi  {0}",tekDizi[i]);
}
*/


// Örnek : 
// Bir string dizisi içerisinde, 10 adet isim giriniz

// daha sonrada  bu 10 adet isim dizisinin, içerisinde gezip, ilk harf ve son harfi gösterip, 
// aradaki harfleri ** yapıp yeni diziye atan uygulama

// Örnek : Elif -> E**f
// Hüsamettin -> H********n
/*string[] isimler = new string[10];
string[] gizliIsimler = new string[10];
isimler[0]="Ayşe";
isimler[1]="Ali";
isimler[2]="Selçuk";
isimler[3]="Pınar";
isimler[4]="Orhun";
isimler[5]="Ebru";
isimler[6]="Barış";
isimler[7]="Özlem";
isimler[8]="Alihan";
isimler[9]="Bahadır";

for(int i=0;i<isimler.Length;i++){
    // isimler dizisi içerisinde dön!!
    
    // ismin ilk karakteri için
    string start = isimler[i].Substring(0,1);
    // ismin son karakteri için
    string end = isimler[i].Substring(isimler[i].Length-1,1);
    //string newIsim ="";

    // V1
    /*for(int j=0;j<isimler[i].Length-2;j++){

         newIsim +="*";
         
    }

    //V2
    //gizliIsimler[i]=start.PadRight(isimler[i].Length-1,'*')+end;

}
// işler bitti, ekrana yazdıralım
for(int i=0;i<gizliIsimler.Length;i++){
    Console.WriteLine(gizliIsimler[i]);
}
*/

// Örnek 
// Uygulama 5 adet not istesin, ve bu notlari dizide tutalim, 
//notlari aldiktan sonra kullaniciya asagidaki soruyu sorup, geregini yapalim. 
//Degistirmek istediginiz not varsa 1 e basin, (hangi notun degisecegini sorup degeri 
//sormak gerekecek) notlari siralanmis listelemek icin 2 e basin, cikmak icin 3 e basin.
/*int[] nots = new int[5];


 for(int i=0; i<5;i++){
    Console.WriteLine("{0}. notu giriniz",i+1);
    nots[i]=int.Parse(Console.ReadLine());

 }

// uygulama exit yapana kadar sonsuza kadar dönecek
 while(true){
 //Not alımı bitti
 Console.WriteLine("Not alımı bitti");
 Console.WriteLine("Aşağıdaki işlemleri yapabilirsiniz");
 Console.WriteLine("Not Değiştirmek için 1");
 Console.WriteLine("Not Sıralamak için 2");
 Console.WriteLine("Çıkmak için 3'e basınız");
 string secim = Console.ReadLine();
 if(secim=="1"){

    //[1][3][4][5][100][2]
    //100 değerini 500 değeri ile değiştir
    Console.WriteLine("Not değiştirme bölümüme hoşgeldiniz");
    Console.WriteLine("Değiştirmek istediğiniz notu giriniz");
    int not = int.Parse(Console.ReadLine());
    Console.WriteLine("Yeni notu giriniz");
    int newNot = int.Parse(Console.ReadLine());
    int arrayIndexNo = Array.IndexOf(nots,not);
    nots[arrayIndexNo]=newNot;
    for(int i=0; i<nots.Length;i++){
        Console.WriteLine(nots[i]);
    }
 }
 else if(secim=="2"){

    Array.Sort(nots);
    for(int i=0; i<nots.Length;i++){

        Console.WriteLine(nots[i]);
    }
 }
 else if(secim=="3"){

    // uygulama sonlandı
    break;
 }
 }
 */

 // Örnek Anlatım

string[] isimler = new string[3];
isimler[0]="Ayşe";
isimler[1]="Ali";
isimler[2]="Mehmet";

// Örnek : Örnekteki dizinin ilk harflerini ekrana yazdırınız
for(int i=0;i<3;i++){

    Console.WriteLine(isimler[i][0]);

}
// yukarıdaki örnekte, isimler dizisi içerisindeki string değer ekrana yazdırılıyor.
// string bir idade de ayrıca bir dizi olduğu için tekrar index numarası ile char değer çağrılabilir.
// String bir ifade, char dizisidir.
string deger = "wissen";
Console.WriteLine(deger[0]);
// bu sebeple, string ifade de istenilen karaktere ulaşmak için [] kullanılabilir.

// Unutmamanız için tekrar
// DİKKAT !!!! String bir char dizisidir.

// string'in char dizisi olması ile ilgili bir örnek yapalım
// 10 adet ismin olduğu bir dizi alınız kullanıcıdan,
// dizi giriş tamamlandıktan sonra, 
// dizi içerisinde isimlerin, tersten yazılışlarını ekrana yazdırınız

string[] names = new string[10];
for(int i =0;i<10;i++){

    Console.WriteLine("{0}. ismi giriniz",i+1);
    names[i]=Console.ReadLine();
}
for(int i =0;i<names.Length;i++){
// dizi içerisinde dönmek için
    string ters ="";
   for (int j = names[i].Length - 1; j>= 0 ; j--)
   {
        ters+=names[i][j];
        // i = 0  = Ali - > j=2 = i
        // i = 0  = Ali - > j=1 = l
   }
   Console.WriteLine(ters);
}

//Ali    i = 0 
//Veli   i = 1
//Mehmet i = 2

// A  j = 0
// l  j = 1
// i =j = 2
