/*
    String Uygulamaları
*/

// eğer projede birden fazla cs dosyan varsa class kullanmak zorundasın
// yoksa üst düzey deyimler olmalı diye hata alırsıın
// top-level statements
public class Uygulama1
{
    public static void Run()
    {
        string kursAdi = ".NET 7 ile C# Programlama Dili";
        // 1- Kaç karaktere sahiptir? +
        // 2- Hepsini küçük harf yapınız. +
        // 3. ile mi başlamaktadır? +
        //4-C# bilgisi hangi konumda bulunmaktadır? +
        //5-String 'C#' bilgisini içeriyor mu? +
        //6- 'Dili' kelimesi yerine 'Derslerı yazınız. (replace) +

        var sonuc1 = kursAdi.Length;
        Console.WriteLine("Sonuç 1 :" + sonuc1);

       

        var sonuc3 = kursAdi.StartsWith(".");
        Console.WriteLine("Sonuç 3 :" + sonuc3);

        Console.WriteLine("Sonuç 4 :" + kursAdi.IndexOf("C#"));
        Console.WriteLine("Sonuç 5 :" + kursAdi.Contains("C#"));
        Console.WriteLine(kursAdi.IndexOf("Dili"));
        Console.WriteLine(kursAdi.Replace("Dili", "Dersleri")); // güncellenen stringi yeni bir ada atamak daha mantıklı çünkü ana dizin değişmiyor
        var sonuc2 = kursAdi.ToLower();
        Console.WriteLine("Sonuç 2 :" + sonuc2);
    }

}