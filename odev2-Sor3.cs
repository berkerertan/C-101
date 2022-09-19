using System;
using System.Collections;
internal class Program
{
    private static void Main(string[] args)
    {
        //Soru - 3: Klavyeden girilen cümle içerisindeki sesli harfleri bir dizi içerisinde saklayan ve dizinin elemanlarını sıralayan programı yazınız.

        Console.WriteLine("Bir Cümle Giriniz:");
        string cumle = Console.ReadLine().ToLower();
        ArrayList unluHarfler = new ArrayList();
        foreach (var harf in cumle)
        {
            if(harf=='a'|| harf=='e'|| harf=='ı'|| harf=='i'|| harf=='u'|| harf=='ü'|| harf=='o'|| harf=='ö')
            {
                unluHarfler.Add(harf);
            }
          
           
        }
        unluHarfler.Sort();
        Console.WriteLine("Cumlede ki Sesli Harfler:");
        foreach (var item in unluHarfler)
        {
            Console.WriteLine(item);
        }

    }
}