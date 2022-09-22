using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //erişim belirleyiciler public,private,internal,protected
            Console.WriteLine("*******Çalışan2*****");
            Calisan calisan1 = new Calisan("Ayşe","kara",12345678,"İnsan Kaynakları");
            calisan1.CalisanBilgileri();

            Console.WriteLine("*******Çalışan2*****");
            Calisan calisan2 = new Calisan();
            calisan2.Ad="Denis";
            calisan2.SoyAd="Arda";
            calisan2.No=87654321;
            calisan2.Departman="Satın-Alma";
            calisan2.CalisanBilgileri();

            Console.WriteLine("*******Çalışan3*****");
            Calisan calisan3 = new Calisan("Berker","Ertan");
            calisan3.CalisanBilgileri();




        }
    }
    class Calisan
    {
        public string Ad;
        public string SoyAd;
        public int No;
        public string Departman;

        public Calisan(string ad,string soyad,int no,string departman)
        {
            this.Ad=ad;
            this.SoyAd=ad;
            this.No=no;
            this.Departman=departman;

        }
        public Calisan(string ad,string soyad)
        {
            this.Ad=ad;
            this.SoyAd=ad;
            

        }
        public Calisan(){}

        public void CalisanBilgileri()
        {
            Console.WriteLine("Çalışan adı:{0}",Ad);
            Console.WriteLine("Çalışan adı:{0}",SoyAd);
            Console.WriteLine("Çalışan adı:{0}",No);
            Console.WriteLine("Çalışan adı:{0}",Departman);


        }



    }
}