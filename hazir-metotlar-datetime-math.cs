using System;

namespace hazir_metotlar_datetime_math // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DateTime.Now); //Tarih
            Console.WriteLine(DateTime.Now.Date); //
            Console.WriteLine(DateTime.Now.Day);
            Console.WriteLine(DateTime.Now.Month);
            Console.WriteLine(DateTime.Now.Year);
            Console.WriteLine(DateTime.Now.Hour);
            Console.WriteLine(DateTime.Now.Minute);
            Console.WriteLine(DateTime.Now.Second);

            Console.WriteLine(DateTime.Now.DayOfWeek);
            Console.WriteLine(DateTime.Now.DayOfYear);
            Console.WriteLine(DateTime.Now.ToLongDateString);
            Console.WriteLine(DateTime.Now.ToShortDateString);
            Console.WriteLine(DateTime.Now.ToLongTimeString);
            Console.WriteLine(DateTime.Now.ToShortTimeString);

            Console.WriteLine(DateTime.Now.AddDays(2));
            Console.WriteLine(DateTime.Now.AddSeconds(2));
            Console.WriteLine(DateTime.Now.AddMonths(5));
            Console.WriteLine(DateTime.Now.AddYears(10));

            //datetime format
            Console.WriteLine(DateTime.Now.ToString("dd"));//13
            Console.WriteLine(DateTime.Now.ToString("ddd"));//sat
            Console.WriteLine(DateTime.Now.ToString("dddd")); //saturday

            Console.WriteLine(DateTime.Now.ToString("MM"));//04
            Console.WriteLine(DateTime.Now.ToString("MMM"));//Ap
            Console.WriteLine(DateTime.Now.ToString("MMMM")); //April

            Console.WriteLine(DateTime.Now.ToString("yy"));//21
            Console.WriteLine(DateTime.Now.ToString("yyyy"));//2021


            //Math Kütüphanesi

            Console.WriteLine(Math.Abs(-25)); //mutlakdeğer   25;

            Console.WriteLine(Math.Sin(10)); //sinus
            Console.WriteLine(Math.Cos(10)); //cosinus
            Console.WriteLine(Math.Tan(10)); //tanjant

            Console.WriteLine(Math.Ceiling(22.3)); // yukarı yuvarlar
            Console.WriteLine(Math.Round(22.3));  // hangisine yakınsa ona yuvarlar
            Console.WriteLine(Math.Floor(22.7)); //aşagıya yuvarlar

            Console.WriteLine(Math.Min(2,6));
            Console.WriteLine(Math.Max(2,6));

            Console.WriteLine(Math.Pow(3,4)); // 3^4 ü verir üzeri sayılar
            Console.WriteLine(Math.Sqrt(9)); //karekök alır
            Console.WriteLine(Math.Log(9)); //logaritma işlemi 9 un e tabanındaki karşılığı
            Console.WriteLine(Math.Exp(3)); // e üzeri 3 verir
            Console.WriteLine(Math.Log10(10)); // log 10 tabanındaki karşılığı
            




















           















        }
    }
}
