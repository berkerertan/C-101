using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //erişim belirleyiciler public,private,internal,protected

            Calisan calisan1 = new Calisan();
            calisan1.ad="Ayşe";
            calisan1.soyAd="kara";
            calisan1.no=12345678;
            calisan1.Departman="İnsan Kaynakları";

            calisan1.CalisanBilgileri();

            Calisan calisan2 = new Calisan();
            calisan2.ad="Denis";
            calisan2.soyAd="Arda";
            calisan2.no=87654321;
            calisan2.Departman="Satın-Alma";
            calisan2.CalisanBilgileri();



        }
    }
    class Calisan
    {
        public string ad;
        public string soyAd;
        public int no;
        public string Departman;

        public void CalisanBilgileri()
        {
            Console.WriteLine("Çalışan adı:{0}",ad);
            Console.WriteLine("Çalışan adı:{0}",soyAd);
            Console.WriteLine("Çalışan adı:{0}",no);
            Console.WriteLine("Çalışan adı:{0}",Departman);


        }



    }
}