

public class ObjectPractice
{
    public static void Run(){

        var soru1 = new Soru(){
            SoruMetni = "Hangisi Programlama Dili Değildir?",
            Secenekler = new string[4] {"Python", "C#", "JAVA", "Void"},
            Cevap = "Void"};
        var soru2 = new Soru(){
            SoruMetni = "Hangisi En Popüler Programlama Dilidir?",
            Secenekler = new string[4] {"Python", "C#", "JAVA", "Void"},
            Cevap = "C#"};
        var soru3 = new Soru(){
            SoruMetni = "Hangisi en popüler wep programlama platformudur?",
            Secenekler = new string[4] {"django", "asp.net", "Spring", "Python"},
            Cevap = "Python"};

        var sorular = new Soru[]{ soru1, soru2, soru3 };

        foreach(var soru in sorular){
            Console.WriteLine(soru.SoruMetni);// soru.soruMetni yazmayı unuttun
            foreach (var secenek in soru.Secenekler)
            {
                Console.WriteLine(secenek);   
            }
        }
    }
    public class Soru {
        // properties
        public string SoruMetni { get; set; }   
        public string[] Secenekler { get; set; }  
        public string Cevap { get; set; }  
        // methodies
        // public string CevapKontol(){
        //     return;
        // }
    }
}