public class Date
{
    public static void Run()
    {
        var now = DateTime.Now;
        Console.WriteLine(now);
        Console.WriteLine(now.Year);
        Console.WriteLine(now.Month);
        Console.WriteLine(now.Day);
        Console.WriteLine(now.DayOfWeek);

        DateTime dt = new DateTime(2018, 6, 10, 12, 09, 45);
        Console.WriteLine(dt); // ayarladığım tarihi döndürdü
        Console.WriteLine(dt.Year);
        dt.AddYears(1); // 2018 üzerine bir yıl ekler ama yeni bir nesne oluşturman gerekir 
        DateTime dt2 = new DateTime(); // yeni nesne 
        dt2 = dt.AddYears(1);
        Console.WriteLine(dt2.Year);

        var fark = now - dt;
        Console.WriteLine(fark.TotalDays);
    }
    
}