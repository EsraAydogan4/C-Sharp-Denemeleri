

using System.Collections;

public class Collections
{
    public static void Run()
    {
        // farkı veri tiplerini aynı collection içerisinde saklanabilir
        // non-generic -> tipe bağlı kalınmaz generic -> tek tip tanımlanabilir
        ArrayList liste = new ArrayList();
        liste.Add(10);
        liste.Add("10");
        liste.Add(null);
        liste.Add(true);

        // ArrayList her elemanı obje türünde alır veri tipi obje olur kendin başk atipe çevirmelisin

        var liste2  = new ArrayList(){5, "esra", true, null};
        int[] sayilar = {10, 20, 30};
        liste.AddRange(sayilar);

        Console.WriteLine((string)liste[2]);

        // insert
        liste.Insert(1, "Esra");
        Console.WriteLine(liste[1]);

        liste.InsertRange(2, liste2); // liste üzerine liste ekler

        // remove

        liste.Remove(null); // ilk elemanı siler
        liste.RemoveAt(2); // belirtilen elemanı siler
        liste.RemoveRange(2,3); // 2 den 3 e kadar siler
        liste.Remove("esra"); // verilen elemanı siler

        // constains, indexof
        Console.WriteLine(liste.Contains(10)); //içeriyor mu
        Console.WriteLine(liste.IndexOf(10)); // verilen elemanın konumunu bulur
        // foreach(var item in liste)
        // {
        //     Console.WriteLine(item);
        // }
    }
}