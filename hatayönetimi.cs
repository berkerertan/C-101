internal class Program
{
    private static void Main(string[] args)
    {
        // try
        // {
        //     Console.WriteLine("bir sayı gir");
        //     int sayi = Convert.ToInt32(Console.ReadLine());
        //     Console.WriteLine("girmis oldugunuz sayı şudur: " + sayi);
        // }
        // catch (Exception ex)
        // {
        //     Console.WriteLine("hata:" + ex.Message.ToString());

        // }
        // finally
        // {
        //     Console.WriteLine("işlem tamamlandı");

        // }

        // ERROR

        try
        {
            //int a= int.Parse(null);
            //int a= int.Parse("test");
            int a= int.Parse("-20000000000");


        }
        catch (ArgumentNullException ex)
        {
            Console.WriteLine("bos deger girdiniz");
            Console.WriteLine(ex);

        }
        catch (FormatException ex){
            Console.WriteLine("veri tipi uygun değil");
            Console.WriteLine(ex);


        }
        catch (OverflowException ex){
            Console.WriteLine("cok kucuk veya cok buyuk bir değer girdiniz");
            Console.WriteLine(ex);



        }
        finally{
            Console.WriteLine("islem basarıyl tamamlandı");


        }
    }
}