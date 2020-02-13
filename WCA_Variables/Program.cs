using System;

namespace WCA_Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            // tam sayılar
            //ondalıklı sayılar
            //metinsel char,string
            //mantıksal bool
            //ctrl+k+d kodları düzenler
            //ctrl+e+k
            //ctrl+d dublicate
            //ctrl+shift+b buil etme projeyi ilk olarak build etmeliyiz,hata var ise düzeltme yapılabilir.
            //tam sayı değişkenleri byte,sbyte,short,ushort,int,uint,long,ulong,long
            //byte=8 bit ilgiili nesnenin ne kadar yer kapladığını öğrenmek için yazılan kısımda üstüne gelmek yeterli olur.0 dan aşağı değer almaz
            //ssbyte=8 bit
            //ondalık sayılar float,double,decimal
            //byte sayi1 = 56;
            //sbyte sayi2 = 13;
            //short sayi3 = 134;//short ram üzerinde 16 bit işaretlenmiş bir veri tipidir '-' değer alabilir
            //ushort sayi4 = 321;//u short ram üzerinde 16 bit yer tutar
            ////Veri tip değişken adi = içindeki veri değişken tanımlama
            //int sayi5 = 304;//'-' değer içerebilir
            //uint sayi6 = 8944898;//'-'değer alamaz
            //long sayi7 = 213214141414214;//'-' ile'+' değerde alabilir
            //ulong sayi8 = 79889898;//veri tipnin özelliklerini öğrenmek için veri tipinin üstüne gelip sağ tıklayıp go to definition 
            //float sayi9 = 15.0F; //kızdığı yerlerin üzerine gelince istediği şeyi söyler 15.0 yazınca hata verir daha sonra f koymamızı söylüyor
            //double sayi10 = 15.0;
            //decimal sayi11 = 15.0M;
            //char karakter = 'semih';//char veri tipinde tanımlamalırımız tek tırnak arasındadadır ve tek karakter tutar ikincisi yazılamaz,asci kodunuda çeker
            //string metin = "en\n büyük beşiktaş";//\n alt satıra geçirir
            //string metin1 = "en büyük beşiktaş";
            //string metin2 = "en büyük beşiktaş";
            //string metin3 = "en büyük beşiktaş";
            // istenilen kadar karakter tutulabilir
            //string tekkarakter = "a";//tek bir karakterde tutulabilir
            //string bos = "";
            //string tabbosluk = "bilge\Adam"; //\ slash bir tab boşluk
            //Console.WriteLine(metin);//Console.writeline bir fonksiyondur ama bir şey return etmez voiddir,yani bize bir şey döndürmez,parantez içini doldurursak örnek olarak bize bir string değeri girersek bize çıktı olarak string değeri dönecektir.
            //Console.WriteLine(metin1);//Console.writeline bir fonksiyondur ama bir şey return etmez voiddir,yani bize bir şey döndürmez,parantez içini doldurursak örnek olarak bize bir string değeri girersek bize çıktı olarak string değeri dönecektir.
            //Console.WriteLine(metin2);//Console.writeline bir fonksiyondur ama bir şey return etmez voiddir,yani bize bir şey döndürmez,parantez içini doldurursak örnek olarak bize bir string değeri girersek bize çıktı olarak string değeri dönecektir.
            //Console.WriteLine(metin3);//Console.writeline bir fonksiyondur ama bir şey return etmez voiddir,yani bize bir şey döndürmez,parantez içini doldurursak örnek olarak bize bir string değeri girersek bize çıktı olarak string değeri dönecektir.
            // Console.WriteLine(tabbosluk);
            //string metin88="Bilge Adam Beşiktaş \"Yazılım\" Dersleri"; //çift tırnak arasına alma 
            //Console.WriteLine(metin88);
            bool sonuc = false;
            bool result = 10 > 2;
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
