using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Metini ve Sayıyı arasında ',' olacak şekilde girin: ");
            string input1 = Console.ReadLine();
            string[] words = input1.Split(",");
            int sayi = Convert.ToInt32(words[1]);
            Console.WriteLine(words[0].Remove(sayi,1));

        }
    }
}
