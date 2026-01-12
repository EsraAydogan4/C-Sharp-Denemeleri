// Kitap class’ı yaz

// Ad, Yazar, Sayfa

// Constructor ile hepsi zorunlu olsun

// Sayfa dışarıdan değişemesin




public class Kitap
{

    public string Ad;
    public string Yazar;
    public int Sayfa;
    public Kitap(string ad, string yazar, int sayfa) // veri tiplerini constructor da belitmen gerekiyor
    {
        Ad = ad;
        Yazar = yazar;
        Sayfa = sayfa; // constructor ın içindeki nesleri dışındakilere atadık
       
    }
    public static void Run()
    {
        Kitap k1 = new Kitap("olasiliksiz", "fatih", 382);
        Kitap k2 = k1;
        k2.Ad = "köpek";
        Console.WriteLine(k1.Ad);  //reference oldu k1 değişti 
        k1.AdDegistir("pembe");
        Console.WriteLine(k1.Ad);  // sadece k1 yazmak mantıklı değil döndürecek bir özelliği yok
    }
    public void AdDegistir(string yeniAd)
    {
        Ad = yeniAd;
    }
}
