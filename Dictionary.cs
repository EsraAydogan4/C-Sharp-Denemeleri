public class Dictionary
{
    public static void Run()
    {
        // dictionary

        Dictionary<int, string> plakalar = new Dictionary<int, string>();
        plakalar.Add(41, "kocaeli");
        plakalar.Add(32, "isparta");
        plakalar.Add(06, "ankara");
        
        Dictionary<int, string> sayilar = new Dictionary<int, string>()
        {
            {1, "bir"},
            {2, "iki"},
            {3, "uc"}
        };
        if(plakalar.ContainsKey(41))
            Console.WriteLine(plakalar[41]);
        foreach(KeyValuePair<int, string> plaka in plakalar) // var daha kısa
        {
            Console.WriteLine(plaka.Key + " " + plaka.Value);
        }

        // update
        sayilar[1] = "one";
        Console.WriteLine(sayilar[1]);
        sayilar.Clear(); // listeyi temizler
    }
}