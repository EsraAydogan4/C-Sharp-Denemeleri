public class GenericList
{
    public static void Run()
    {
        // generic list
        List<int> sayilar = new List<int>();

        sayilar.Add(10);
        sayilar.Add(20);

        List<string> isimler = new List<string>(){"ali", "ayşe", "fatma"};

        List<Product> urunler = new List<Product>();

        urunler.Add(new Product() {Id=1, Title="slf", Price=122});
        urunler.Add(new Product() {Id=2, Title="slf", Price=123});
        urunler.Add(new Product() {Id=3, Title="slf", Price=124});
        urunler.Insert(urunler.Count, new Product(){Id=4, Title="slf", Price=125});
        
        urunler.RemoveAt(1);
        urunler.Remove(urunler[0]);

        foreach(var urun in urunler)
        {
            Console.WriteLine(urun.Title + " " + urun.Price) ;
        }

    }
}
class Product
{
    public int Id { get; set; }
    public string Title { get; set; }
    public int Price { get; set; }
}