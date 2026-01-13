


//   Uygulama1.Run();
//   String.Run();
//   Date.Run();
//   Kitap.Run();
//   Array.Run(); 
//   Ogrenci.Run();
//   Uygulama2.Run();
//   Uygulama3.Run();
//   Files.Run();
//   ObjectOriented.Run();
//   ObjectPractice.Run();
//   Constructor.Run();
   var sonuc = Methods.karakter("ölçme ölderme");
   Console.WriteLine(sonuc);
   class Methods
   {
      public static string karakter(string t)
      {
         
         
         return
            t.Replace("ö", "o")
            .Replace("ğ", "g")
            .Replace(" ", "-");
      }
      

   }





