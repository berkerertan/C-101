using System;
using System.Collections;
internal class sa

{
    private static void Main(string[] args)
    {
        //Soru - 2: Klavyeden girilen 20 adet sayının en büyük 3 tanesi ve en küçük 3 tanesi bulan, her iki grubun kendi içerisinde ortalamalarını alan ve bu ortalamaları ve ortalama toplamlarını console'a yazdıran programı yazınız. (Array sınıfını kullanarak yazınız.)
        ArrayList sayilar = new ArrayList();
        ArrayList buyukler = new ArrayList();
        ArrayList kucukler = new ArrayList();

        Console.WriteLine("20 adet sayı giriniz.");
        
        for (int i = 0; i < 20; i++)
        {
            Console.WriteLine((i+1)+".Sayıyı girin:");
            int sayi = int.Parse(Console.ReadLine());
            sayilar.Add(sayi);
        }
        sayilar.Sort();
        buyukler.Add(sayilar[19]);
        buyukler.Add(sayilar[18]);
        buyukler.Add(sayilar[17]);
        kucukler.Add(sayilar[0]);
        kucukler.Add(sayilar[1]);
        kucukler.Add(sayilar[2]);

        int Kort=0;
        int Bort=0;
        foreach (var item in kucukler)
        {
            Kort += Convert.ToInt32(item);
        }
        foreach (var item in buyukler)
        {
            Bort += Convert.ToInt32(item);
        }
        Console.WriteLine("Kucuk Ortalaması:"+ Kort/kucukler.Count);
        Console.WriteLine("Buyuk Ortalaması:"+ Bort/buyukler.Count);
        Console.WriteLine("Ortalama Toplamları:"+ ((Bort/buyukler.Count)+(Kort/kucukler.Count)));
    }
}