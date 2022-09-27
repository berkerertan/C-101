using System;

namespace StaticClass // Note: actual namespace depends on the project name.
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calısan Sayısı {0}", Calisan.CalisanSayisi);

            Calisan calisan = new Calisan("Ayşe","Yılmaz","IK");
            Console.WriteLine("Calısan Sayısı {0}", Calisan.CalisanSayisi);

            Calisan calisan1 = new Calisan("Deniz","Arda","IK");
            Calisan calisan2 = new Calisan("Berker","Ertan","IK");
            Console.WriteLine("Calısan Sayısı {0}", Calisan.CalisanSayisi);

            Console.WriteLine("Toplama İslemi Sonucu: "+ Islemler.Topla(100,200));
            Console.WriteLine("Cıkarma İslemi Sonucu: "+ Islemler.Cıkar(400,50));

            

        }
    }

    class Calisan
    {
        private static int calisanSayisi;

        public static int CalisanSayisi { get => calisanSayisi; }

        private string Isim;
        private string Soyisim;
        private string Departman;

        static Calisan()
        {
            calisanSayisi=0;

        } 

        public Calisan(string isim, string soyisim, string departman)
        {
            this.Isim=isim;
            this.Soyisim=soyisim;
            this.Departman=departman;
            calisanSayisi ++;
        }
    }
    static class Islemler
    {
        public static long Topla(int sayi1,int sayi2)
        {
            return sayi1+sayi2;
        }
        public static long Cıkar(int sayi1,int sayi2)
        {
            return sayi1-sayi2;
        }
    }
}
