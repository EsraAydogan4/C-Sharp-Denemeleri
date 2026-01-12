

using System.Data;

public class Files
{
    public static void Run()
    {
                
        /*
        var sr = File.OpenText("String.cs");
        // StreamReader tipindeki sr yi var yakaladı

        var s = " ";

        while((s=sr.ReadLine()) != null)
        {
            Console.WriteLine(s);
        }
        */

        //string sonuc = File.ReadAllText("Kitap.cs");

        /*
        string[] sonuc = File.ReadAllLines("Kitap.cs");

        Console.WriteLine(sonuc[4]);
        */


        /*
        var sw = File.CreateText("Kitap.cs");
        sw.WriteLine("public string Kitap {}");
        sw.Close();
        // sayfadaki her şeyi siler senin yazdığını sayfaya kopyalar
        */


        /*   
        using (var sw = File.CreateText("Kitap.cs")){  // obje oluşturduk
        sw.WriteLine("public string Kitap {}");
        } // close kullanmaya gerek kalmadı

        using (var sw = File.AppendText("Kitap.cs"))
        {  // bilgileri dosyayı silemeden ekler
            sw.WriteLine("public string Kitap {}");
            
        }
        */

        /*
        using System.Text;

        string path = @"C:\";
        string path2 = Directory.GetCurrentDirectory() + "\temp";
        Directory.CreateDirectory(path);

        */
        string yol = "/Users/esra2/Desktopr/esimler/esra.jpg";

        string rootPath = Directory.GetCurrentDirectory();
        // Programın şu anda çalıştığı klasörün yolunu (path) verir.
        

        // * -> her şey demek   ,   Sadece rootPath’in BİR SEVİYE altındaki klasörleri al iç içe olanları alma
        string[] dirs =  Directory.GetDirectories(rootPath, "*", SearchOption.TopDirectoryOnly); 
        // SearchOption.AllDirectories ->  her klasör gelir
        foreach (var dir in dirs)
        {    // ilgili konumdaki klasörler gelir
            Console.WriteLine(dir);
        }


        string[] files = Directory.GetFiles(yol, "*.jpg", SearchOption.AllDirectories);
        foreach (var dir in files)
        {    // ilgili konumdaki klasörler gelir
            Console.WriteLine(Path.GetExtension(dir));

            var info = new FileInfo(dir);
            Console.WriteLine($"{Path.GetFileName(dir)}: {info.Length}");

        }

    }
}