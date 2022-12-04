using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Eşkenar üçgenin kenar uzunluğunu giriniz: ");
            int x = Int32.Parse(Console.ReadLine());
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
