//--------hata yönetimi------------


/*
try
{
    Console.WriteLine("bir sayı giriniz:");
    int sayi = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Girmiş olduğunuz sayı: " + sayi);

}
catch (Exception ex)
{
    Console.WriteLine("Hata: " + ex.Message.ToString());

}
finally{

    Console.WriteLine("İşlem tamamlandı.");

}
*/

try{
   // int a = int.Parse(null);
  //  int b = Int32.Parse("buse");
  int c = Int32.Parse("-225555662555555");

}
catch(ArgumentNullException ex)
{
    Console.WriteLine("boş değer girdiniz.");
    Console.WriteLine(ex);
}
catch(FormatException ex)
{
    Console.WriteLine("veri tipi uygun değil.");
    Console.WriteLine(ex);

}
catch(OverflowException ex)
{
    Console.WriteLine("sayı çok küçük veya büyük");
    Console.WriteLine(ex);

}
finally{

    Console.WriteLine("İşlem başarıyla tamamlandı.");
}






Console.ReadLine();
