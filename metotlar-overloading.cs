using System;

namespace metotlar_overloading // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //out parametreler
            string sayi = "999";
            int outsayi;

        //    bool sonuc= int.TryParse(sayi,out outsayi);
        //    if(sonuc)
        //    {
        //     Console.WriteLine("başarılı");
        //     Console.WriteLine(outsayi);
        //    }
        //    else
        //    {
        //     Console.WriteLine("başarısız");

        //    }

        Metotlar instance = new Metotlar();
        instance.Topla(4,5,out int toplamSonuc);
        Console.WriteLine(toplamSonuc);

        //Metot aşırı yükleme -- Overloading

        int ifade = 999;
        instance.ekranaYazdır(Convert.ToString(ifade));
        instance.ekranaYazdır(ifade);

        //metot imzası 
        //metot adı + parametre sayısı+ parametre
        instance.ekranaYazdır("berker","ertan");







        }
    }
    class Metotlar
    {
        public int Topla(int a,int b,out int toplam)
        {
            return toplam=a+b;
        }

        public void ekranaYazdır(string veri)
        {
            Console.WriteLine(veri);
        }
        public void ekranaYazdır(int veri)
        {
            Console.WriteLine(veri);
        }
        public void ekranaYazdır(string veri1,string veri2)
        {
            Console.WriteLine(veri1+veri2);
        }
    } 
}
