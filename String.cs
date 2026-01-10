// Console.Write("1. Sayi: ");
// var sayi1 = Convert.ToInt32(Console.ReadLine()); 

// Console.Write("2. Sayi: ");
// var sayi2 = Convert.ToInt32(Console.ReadLine());

// var toplam = sayi1 + sayi2;
// Console.WriteLine("Toplam: " + toplam);

// int a = 10;
// byte b = (byte)a;

/* int? maas = null;

Console.WriteLine(maas.HasValue); 

if (maas.HasValue)
{
    Console.WriteLine("maas var");
}
else
{
    Console.WriteLine("maas yok");
}

Console.WriteLine(maas.GetValueOrDefault()); */

//  .GetValueOrDefalt eğer bir veri yoksa false döndürmez 0 yazar 

DateTime now = DateTime.Now;
Console.WriteLine(DateTime.Now);


string mesaj = "12345  K AHDLedlr  ofnvjs";
int adet = mesaj.Length; // boşlukları da alır
var sonuc = mesaj.ToLower(); // stringi küçük karakterlere çevirir
var sonuc2 = mesaj.ToUpper(); // stringi büyük karakterlere çevirir
var sonuc3 = mesaj.Trim(); // baştaki ve sondaki boşlukları alarak yazdırır
var sonuc4 = mesaj.Split(" "); // boşuk karakterlerini ayırır
var sonuc5 = mesaj[3];
var sonuc6 = mesaj.Split(" ")[0]; // split belirtilen karakterlerden ayırma işlemi yapar " " veya , kullanılır [] kullanarak istenilen karaktere erişim sağlanır
var sonuc7 = mesaj.EndsWith("."); // belirtilen karakterle mi bitiyor diye boolen sorgulama yapar
var sonuc8 = mesaj.StartsWith("1"); // başlama ile sorgulama yapar true false
var sonuc9 = mesaj.Contains("123"); // string içinde arama yap true false döndür
var sonuc10 = mesaj.IndexOf("ofnvjs"); // stringde arar ve bulduğu indexi döndürür yoksa -1 döndürür
var sonuc11 = mesaj.Substring(10); // 10. indexten sonrasını getir (10, 6) diyerek 10 dan sonraki 6 karakteri getirir

Console.WriteLine("sonuç: " + sonuc);
Console.WriteLine("sonuç2: " +sonuc2);
Console.WriteLine("sonuç: " +adet);
Console.WriteLine("sonuç3: " +sonuc3);
Console.WriteLine("sonuç4: " +sonuc4);
Console.WriteLine("sonuç5: " +sonuc5);
Console.WriteLine("sonuç6: " +sonuc6);
Console.WriteLine("sonuç7: " +sonuc7);
Console.WriteLine("sonuç8: " +sonuc8);
Console.WriteLine("sonuç9: " +sonuc9);
Console.WriteLine("sonuç10: " +sonuc10);
Console.WriteLine("sonuç9: " +sonuc9);
Console.WriteLine("sonuç11: " +sonuc11);