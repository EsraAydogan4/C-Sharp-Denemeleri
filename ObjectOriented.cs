
using System.Security.AccessControl;

public class ObjectOriented
{
    
    public static void Run()
    {
        // class => object (ogr1, ogr2)
        Ogrencip ogr1  = new Ogrencip(){OgrenciNo = "100", AdSoyad = "Esra Aydoğan", Sube = "a"};
        var ogr2 = new Ogrencip(){OgrenciNo = "200", AdSoyad = "Esma Aydoğan", Sube = "b"};
        var ogr3 = new Ogrencip(){OgrenciNo = "300", AdSoyad = "Eslem Aydoğan", Sube = "c"};


        Ogrencip[] ogrenciler = new Ogrencip[3] {ogr1, ogr2, ogr3};
        // sınıftan üretilen her property için methotlar kullanılır
        // veriyi bir değişkende saklamak gerekiyor
        Console.WriteLine(ogr1.bilgileriYazdir());

        }
}


class Ogrencip // class büyük harfle başlamalı
{
    // property => string, int
    // DOLDURULMAYI BEKLEYEN BOŞ ALANLAR
    public string OgrenciNo {get; set;}  // get set veri alırken kontrol sağlar
    public string AdSoyad { get; set; }
    public string Sube { get; set; }


    // methods => bilgileriYazdir()

    // public void bilgileriYazdir()
    // {
    //     Console.WriteLine($"{this.OgrenciNo} numaralı öğrencinin adı {this.AdSoyad} ve şubesi {this.Sube}'dir");
    //     // this ogr1, ogr2, ogr3 ü temsil eder
    // }

    public string bilgileriYazdir()     // geriye değer döndür dediğinde verinin tipini girmeyi unutma
    {           // döndürülen bilgiyi yukarıda bri değişkene ata
        return ($"{this.OgrenciNo} numaralı öğrencinin adı {this.AdSoyad} ve şubesi {this.Sube}'dir");
    }              // method console a bağlı kalmadı
}