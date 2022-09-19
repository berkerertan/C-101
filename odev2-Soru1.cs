using System;
using System.Collections;

namespace Soru1 // Note: actual namespace depends on the project name.
{
    internal class Program1
    {
        static void Main(string[] args)
        {
             // Soru - 1: Klavyeden girilen 20 adet pozitif sayının asal ve asal olmayan olarak 2 ayrı listeye atın. (ArrayList sınıfını kullanara yazınız.)

            // -Negatif ve numeric olmayan girişleri engelleyin.
            // -Her bir dizinin elemanlarını büyükten küçüğe olacak şekilde ekrana yazdırın.
            // -Her iki dizinin eleman sayısını ve ortalamasını ekrana yazdırın. 

            ArrayList asal=new ArrayList();
            ArrayList Nasal=new ArrayList();
            int asalTop = 0;
            int NasalTop=0;
            Console.WriteLine("20 Adet Pozitif Sayı Giriniz:");
            for (int i = 0; i < 20; i++)
            { 
               
                Console.WriteLine((i+1) + ".Sayı:");
                int sayi;
                bool sayi1 = int.TryParse(Console.ReadLine(),out sayi);
                if(sayi1 && sayi>0)
                {
                    int sayac = 0;
                    for (int i2 = 2; i2 < sayi; i2++)
                    {
                        if(sayi%i2 == 0)
                        sayac++;
                            
                    }
                    if(sayac > 0){
                    Nasal.Add(sayi);
                    NasalTop += sayi;
                    }
                    else {
                        asal.Add(sayi);
                        asalTop += sayi;
                    }
                }
                else
                    Console.WriteLine("Yanlış Değer Girdiniz");
               

            }
            Nasal.Reverse();
            asal.Reverse();

            Console.WriteLine("****** Asal Sayılar: *****");
            Console.WriteLine("Asal Sayıların adeti ve Ort.:" + (asalTop/asal.Count)+" "+asal.Count);
            
            foreach (int item in asal)
            {
                
                Console.WriteLine(item);
            }
            Console.WriteLine("****** NNAsal Sayılar: *****");
            Console.WriteLine("Asal Olmayan Sayıların adeti ve Ort.:" + (NasalTop/Nasal.Count)+" "+Nasal.Count);
            
            foreach (int item in Nasal)
            {
                
                Console.WriteLine(item);
            }
            

           

        }
    }
}
