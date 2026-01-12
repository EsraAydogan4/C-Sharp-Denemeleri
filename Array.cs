

public class Array
{
    public static void Run()
    {
        /*var kursAdi = ".net 7 ile c# programlama dersleri".Split(" ");
        Console.WriteLine(kursAdi[4]); // split ile böldüğümüzde bu string artık bir array oldu

        // string[] isimler = new string[5];
        // isimler[0] = "Ahmet";
        // isimler[1] = "Ali";
        // isimler[2] = "Canan";
        // isimler[3] = "Esra";
        // isimler[4] = "Esma";
        string[] isimler = {"Ahmet", "ghl", " lkj", "jkkş", "lm"};

        int[] numaralar = new int[5];
        numaralar[0] = 100;
        numaralar[1] = 200;
        numaralar[2] = 300;
        numaralar[3] = 400;
        numaralar[4] = 500;*/

        /*
        string[] sehirler= {"istanbul", "Ankara", " Antalya"};
        sehirler[0] = "sakarya";
        sehirler.SetValue("hatay", 2);
        Console.WriteLine(sehirler.GetValue(2));
        Console.WriteLine(sehirler.Max());
        Console.WriteLine(sehirler.Length);
        Console.WriteLine(sehirler.IndexOf("hatay"));
        */

        //Array.Clear(sehirler, 1);       ???????????

        // foreach (var sehir in sehirler) // sehirleri tek tek yazdırır
        // {
        //     Console.WriteLine(sehir);
        // }

        string[] sehirler = {"zonguldak", "rize", "kilis", "bitlis", "karaman"};
        var sonuc = sehirler[0..3];
        Console.WriteLine(sonuc.Length);

        // foreach(var sehir in sehirler[1..3])
        // {
        //     Console.WriteLine(sehir);
        // }
        foreach(var sehir in sehirler[..3]) // [2..] 2 den sona kadar yazar
        {
            Console.WriteLine(sehir);
        }


        //  ÇOK BOYUTLU DİZİLER UYGULAMA \\
        string[]  ogrenciler = {"ALi", "Mehmet", "Cem"}; // string yazınca [] kullanmayı unutuyorsun
        int[,] notlar = {{50,60,70},{60,80,90},{50,70,30}};

        Console.WriteLine(ogrenciler[0] + "'nin not ortalaması " + ((notlar[0,0] + notlar[0,1] + notlar[0,2])/3));
        Console.WriteLine(ogrenciler[1] + "'in not ortalaması " + ((notlar[1,0] + notlar[1,1] + notlar[1,2])/3));
        Console.WriteLine(ogrenciler[2] + "'in not ortalaması " + ((notlar[2,0] + notlar[2,1] + notlar[2,2])/3));


        }
}