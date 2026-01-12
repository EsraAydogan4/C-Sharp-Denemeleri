

public class Ogrenci
{
    public static void Run()
    {
        // Dizi Uygulana

        //ogrenciler ve notlar isminde 2 tane dizi oluşturunuz ve dizi elemanlarını kullanıcıdan aldığınız değerlerle doldurunuz. (3 öğrenci)
        //ogrenciler dizisi kaç elemanlıdır, yazdırınız.
        //i1k 2 öğrencinin ad ve not bilgisini yazdırınız.
        // tüm öğrencilerin not ortalaması nedir?
        string[] ogrenciler = new string[3];
        Console.Write("1. Öğrencini adı: ");
        ogrenciler[0] = Console.ReadLine() ?? ""; // readLine ın uyarısını giderdik
        Console.Write("2. Öğrencini adı: ");
        ogrenciler[1] = Console.ReadLine() ?? "";
        Console.Write("3. Öğrencini adı: ");
        ogrenciler[2] = Console.ReadLine() ?? "";

        double[] notlar = new double[ogrenciler.Length];
        Console.WriteLine(ogrenciler.Length + " öğrenci vardır");


        // for (int i=0; i < ogrenciler.Length; i++)
        // {
        //     Console.Write("Öğrenci " + (i+1) +  " in notu: " );
        //     notlar[i] = int.Parse(Console.ReadLine());
        //     // readLine her zaman string değer döndürür 
        //     // parse bu stringi inte çevirir
        // }
        foreach (var ogrenci in ogrenciler[..2]){
         Console.WriteLine(ogrenci);

        }
        Console.WriteLine(ogrenciler[0] + " " + notlar[0]);
        Console.WriteLine(ogrenciler[1] + " " + notlar[1]);

        double ortalama = (notlar[0] + notlar[1] + notlar[2])/3;
        Console.WriteLine("Öğrencilerin ortalaması: " + ortalama);

        
    }
}