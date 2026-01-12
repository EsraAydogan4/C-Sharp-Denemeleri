
    //  SAYI TAHMİN UYGULAMASI  \\
public class Uygulama3
{
    public static void Run()
    {
        Random rnd = new Random();
        int sayi = rnd.Next(100);
        Console.WriteLine("Bir sayı tahmin edin: ");

        for (var i = 0; i<10 ; i++)
        {
            int tahmin = Convert.ToInt32(Console.ReadLine());
            //var sonuc = sayi > tahmin ? "yukarıda" : (sayi == tahmin ? "bingo" : "aşağıda"); // kısa ama eksik
            if (sayi > tahmin)
                Console.WriteLine("Yukarıda");
            if (sayi < tahmin) {
                Console.WriteLine("Aşağıda");
            }
            if (sayi == tahmin) {
                Console.WriteLine("Bingo");
                Console.WriteLine((i+1) + ". seferde bildiniz");
                break;
            }
            
        }
    }
}