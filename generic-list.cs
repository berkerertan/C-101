using System;
using System.Collections.Generic;

namespace generic_list // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //List<T> class
            //system.collection.generic
            //T -->object türündedir.

            List<int> sayiListesi = new List<int>();
            sayiListesi.Add(23);
            sayiListesi.Add(10);
            sayiListesi.Add(4);
            sayiListesi.Add(5);
            sayiListesi.Add(92);
            sayiListesi.Add(34);

            List<string> renkListesi = new List<string>();
            renkListesi.Add("Kırmızı");
            renkListesi.Add("Mavi");
            renkListesi.Add("Turuncu");
            renkListesi.Add("Sarı");
            renkListesi.Add("Yeşil");

            //Count
            Console.WriteLine(renkListesi.Count);
            Console.WriteLine(sayiListesi.Count);

            //Foreach ve list.foreach ile elemanlara erişim
            foreach (var sayi in sayiListesi)
            {
                Console.WriteLine(sayi);
            }
            foreach (var renk in renkListesi)
            {
                Console.WriteLine(renk);
            }
            sayiListesi.ForEach(sayi=> Console.WriteLine(sayi));
            renkListesi.ForEach(renk=> Console.WriteLine(renk));

            //Listeden eleman çıkarma

            sayiListesi.Remove(4);
            renkListesi.Remove("Yeşil");
//index ile çıkarma
            sayiListesi.RemoveAt(0);
            renkListesi.RemoveAt(1);

            //Liste içerisinde arama
            if(sayiListesi.Contains(10))
            {
                Console.WriteLine("10 liste içerisinde buludu");
            }

            //Eleman ile index'e erişmek
            Console.WriteLine(renkListesi.BinarySearch("Sarı"));

            //Diziyi List'e çevirme
            string[] hayvanlar={"kedi","köpek","kuş"};

            List<string> hayvanlarList = new List<string>(hayvanlar);

            //Listeyi Temizlemek
            hayvanlarList.Clear();

            //liste içerisinde nesne tutmak
            List<kullanicilar> kullaniciListesi = new List<kullanicilar>();

            kullanicilar kullanici1 = new kullanicilar();
            kullanici1.Isim="Ayşe";
            kullanici1.Soyisim="Yılmaz";
            kullanici1.Yas = 26;

            kullanicilar kullanici2 = new kullanicilar();
            kullanici2.Isim="özcan";
            kullanici2.Soyisim="calıskan";
            kullanici2.Yas = 26;

            kullaniciListesi.Add(kullanici1);
            kullaniciListesi.Add(kullanici2);

            List<kullanicilar> yeniListe = new List<kullanicilar>();
            yeniListe.Add(new kullanicilar(){
                Isim="Deniz",
                Soyisim="Arda",
                Yas=24
            
            });

            foreach (var kullanici in kullaniciListesi)
            {
                Console.WriteLine("Kullanıcı adı:"+ kullanici.Isim);
                Console.WriteLine("Kullanıcı soyadı:"+ kullanici.Soyisim);
                Console.WriteLine("Kullanıcı yas:"+ kullanici.Yas);

            }
            yeniListe.Clear();

            


        }
    }
    public class kullanicilar
    {
        private string isim;
        private string soyisim;
        private int yas;

        public string Isim { get => isim; set => isim = value; }
        public string Soyisim { get => soyisim; set => soyisim = value; }
        public int Yas { get => yas; set => yas = value; }
    }
}
