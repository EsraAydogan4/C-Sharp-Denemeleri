public class Constructor
{
    public static void Run()
    {
        var soru1 = new Soru(122, "Hangisi Programlama Dili Değildir?", new string[4] {"Python", "C#", "JAVA", "Void"}, "Void");
        var soru2 = new Soru(125, "Hangisi En Popüler Programlama Dilidir?", new string[4] {"Python", "JAVA", "Void", "C#"}, "C#");
        var soru3 = new Soru(124, "Hangisi wep programlama platformu değildir?", new string[4] {"django", "asp.net", "Spring", "Python"}, "Python");
        //Console.WriteLine(soru3.SoruId); soruid private olduğu için dışarıdan erişilemez 
        var soru4 = new Soru(10); // parametre aldığı için 2. çalıştı soru4 = 10 oldu
        
        Console.WriteLine(soru1.SoruYazdir());
        Console.WriteLine(soru1.CevapKontol("html"));
        Console.WriteLine(soru2.SoruYazdir());
        Console.WriteLine(soru2.CevapKontol("html"));
        Console.WriteLine(soru3.SoruYazdir());
        Console.WriteLine(soru3.CevapKontol("python"));
        // var sorular = new Soru[]{ soru1, soru2, soru3 };

        // foreach(var soru in sorular){
        //     Console.WriteLine(soru.SoruMetni);// soru.soruMetni yazmayı unuttun
        //     foreach (var secenek in soru.Secenekler)
        //     {
        //         Console.WriteLine(secenek);
        //     }
        //     Console.Write("Cevabınız: " ); 
        //     var sonuc = Console.ReadLine();
        //     if (soru.CevapKontol(sonuc))
        //         Console.WriteLine("Doğru");
        //     else
        //         Console.WriteLine("Yanlış");  // aynı soru tekrar nasıl sorulur?
        // }
    }
    public class Soru {
        // CONSTRUCTOR
        public Soru () // her nesne oluşturulduğunda  new oto çalışır
        {
            Console.WriteLine("Constructor 1"); 
            this.SoruId = (new Random()).Next(11111,99999);
        }
        public Soru (int SoruId)
        {
            Console.WriteLine("Constructor 2"); 
            this.SoruId = SoruId;
        }
        public Soru (int SoruId, string SoruMetni, string[] secenekler, string cevap)
        {
            this.SoruId = SoruId;
            this.SoruMetni = SoruMetni;
            this.Secenekler = secenekler;
            this.Cevap = cevap;
        }

        // properties
        private int SoruId { get; set; }
        private string SoruMetni { get; set; }   
        private string[] Secenekler { get; set; }  
        private string Cevap { get; set; }  
        // methodies
        public bool CevapKontol(string sonuc){
            return this.Cevap.ToLower() == sonuc.ToLower();
         } // string cevap alıp bool sonuc döndürdü

        public string SoruYazdir()
        {
            string soru = "";
            soru += this.SoruMetni + "\n";
            foreach(var secenek in this.Secenekler)
            {
                soru += secenek + "\n";
            }
            return soru;
        }
    }
}