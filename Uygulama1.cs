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
        // 1- Kaç karaktere sahiptir?
        // 2- Hepsini küçük harf yapınız.
        // 3. ile mi başlamaktadır?
        //4-C# bilgisi hangi konumda bulunmaktadır?
        //5-String 'C#' bilgisini içeriyor mu?
        //6- 'Dili' kelimesi yerine 'Derslerı yazınız. (replace)

        var sonuc1 = kursAdi.Length;
        Console.WriteLine(sonuc1);
    }
}