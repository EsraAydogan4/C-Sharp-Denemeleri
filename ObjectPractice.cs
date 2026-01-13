

using System.Threading.Tasks.Dataflow;

public class ObjectPractice
{
    public static void Run(){

        var soru1 = new Soru(){
            SoruMetni = "Hangisi Programlama Dili Değildir?",
            Secenekler = new string[4] {"Python", "C#", "JAVA", "Void"},
            Cevap = "Void"};
        var soru2 = new Soru(){
            SoruMetni = "Hangisi En Popüler Programlama Dilidir?",
            Secenekler = new string[4] {"Python", "JAVA", "Void", "C#"},
            Cevap = "C#"};
        var soru3 = new Soru(){
            SoruMetni = "Hangisi wep programlama platformu değildir?",
            Secenekler = new string[4] {"django", "asp.net", "Spring", "Python"},
            Cevap = "Python"};

        var sorular = new Soru[]{ soru1, soru2, soru3 };

        foreach(var soru in sorular){
            Console.WriteLine(soru.SoruMetni);// soru.soruMetni yazmayı unuttun
            foreach (var secenek in soru.Secenekler)
            {
                Console.WriteLine(secenek);
            }
            Console.Write("Cevabınız: " ); 
            var sonuc = Console.ReadLine();
            if (soru.CevapKontol(sonuc))
                Console.WriteLine("Doğru");
            else
            {
                Console.WriteLine("Yanlış");  // aynı soru tekrar nasıl sorulur?

            }
                
            
            
        }
    }
    public class Soru {
        // properties
        public string SoruMetni { get; set; }   
        public string[] Secenekler { get; set; }  
        public string Cevap { get; set; }  
        // methodies
        public bool CevapKontol(string sonuc){
            return this.Cevap.ToLower() == sonuc.ToLower();
         } // string cevap alıp bool sonuc döndürdü
    }
}