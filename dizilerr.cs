internal class Program
{
    private static void Main(string[] args)
    {
        //diziler

        string[] renkler=new string[5];

        string[] hayvanlar = {"kedi","köpek","kuş","maymun"};

        int[] dizi;
        dizi=new int[5];

        //dizilerde değer atama ve değişiöm

        renkler[0]="mavi";
        Console.WriteLine(hayvanlar[1]);
        dizi[3]=10;

        Console.WriteLine(dizi[3]);
        Console.WriteLine(renkler[0]);

        //döngüler dizi kullanımı
        //klavyeden girilen n tane sayının ortalamasını hesaplar.
        Console.Write("lütfen dizinin eleman sayısını girin");
        int DiziUzunlugu = Convert.ToInt32(Console.ReadLine());
        int[] sayiDizisi = new int[DiziUzunlugu];

        for (int i = 0; i < DiziUzunlugu; i++)
        {
            Console.Write("lütfen {0}. sayısını giriniz", i+1);
            sayiDizisi[i]=Convert.ToInt32(Console.ReadLine());
        }

        int toplam=0;
        foreach (var sayi in sayiDizisi)
        {
            toplam += sayi;
        }
        Console.Write("ortalama: "+toplam/DiziUzunlugu);


    }
}