using System;

namespace ortalama
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dizinin derinliğini giriniz:");
            int derinlik = Int32.Parse(Console.ReadLine());
            int x=1,y=1,t=0;
            

            for (int i = 0; i < derinlik; i++)
            {
                Console.WriteLine(t);
                t = x + y;
                x=y;
                y=t;
            }

            Console.WriteLine("Fibonacci dizisi= "+ (t));

        }
    }
}
