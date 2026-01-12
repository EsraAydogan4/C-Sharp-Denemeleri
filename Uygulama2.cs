

public class Uygulama2
{
    public static void Run()
    {
        // Karşılaştırma Operatör Uygulamaları \\

        // Klavyeden girilen yaş bilgisine göre oy kullanabilme durumunu inceleyiniz.
        // Girilen bir sayının işaretini kontrol ediniz.
        // Girilen bir sayının tek/çift durumunu kontrol ediniz.

        /*
        Console.Write("Yaşınız: ");
        int sonuc = int.Parse(Console.ReadLine() ?? "0");
        bool sonuc2 = sonuc >= 18;
        Console.WriteLine(sonuc2);

        Console.Write("Bir sayı girin: ");
        //int sayi = int.Parse(Console.ReadLine() ?? "0");
        var sayi = Convert.ToInt32(Console.ReadLine()); 
        string sonuc3 = sayi > 0 ? "pozitif" : (sayi == 0 ? "0" : "negatif");
        Console.WriteLine(sonuc3);

        Console.Write("Bir sayı daha girin: ");
        int sayi2 = int.Parse(Console.ReadLine() ?? "0");
        string sonuc4 = ((sayi2 % 2) == 1) ? "Tek" : "Çift";
        Console.WriteLine(sonuc4);
        

        var rnd = new Random();
        int sayi3 = rnd.Next(100); // 100 bir sınır oldu (10, 100) sınır verir
        Console.WriteLine(sayi);
*/


        var gun = (int)DateTime.Now.DayOfWeek;
        switch (gun)
        {
            case 0:
                Console.WriteLine("pazar");
                break;
            case 1:
                Console.WriteLine("pazartesi");
                break;
            case 2:
                Console.WriteLine("salı");
                break;
            case 3:
                Console.WriteLine("çarşamba");
                break;
            case 4:
                Console.WriteLine("perşembe");
                break;
            case 5:
                Console.WriteLine("cuma");
                break;
            case 6:
                Console.WriteLine("cumartesi");
                break;
            default:
                Console.WriteLine("Hatalı Gün");
                break;
        }
         switch (gun)
        {
            case 0:             // her 3 durum için de aynı mesajı yayınlar
            case 1:
            case 2:
                Console.WriteLine("salı");
                break;
        }
    }
}