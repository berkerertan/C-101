internal class Program
{
    private static void Main(string[] args)
    {
        // Console.WriteLine("Sayi girin:");
        
        // int sayac = Convert.ToInt32(Console.ReadLine());
        // for (int i = 1; i <= sayac; i++)
        // {
        //     if (i%2 == 1)
        //     {
        //         Console.WriteLine(i);
        //     }
        // }

        // 1 ve 100 arasındaki tek ve çift sayıların kendi içlerinde toplamlarını yazdır.
        // int TekToplam = 0;
        // int CiftToplam = 0;
        // for (int i = 1; i <= 1000; i++)
        // {
        //     if (i%2 == 1)
        //         TekToplam +=i;
        //     else
        //         CiftToplam +=i;
            
        // }
        // Console.WriteLine("TekToplam= "+TekToplam);
        // Console.WriteLine("CiftToplam= "+CiftToplam);

        // Break, Continue

        for (int i = 1; i < 10; i++)
        {
            if(i==4)
                break;
            Console.WriteLine(i);
        }
        for (int i = 1; i < 10; i++)
        {
            if(i==4)
                continue;
            Console.WriteLine(i);
        }
    }
}