using System.Collections;
internal class Program
{
    private static void Main(string[] args)
    {
        // 1-Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin(n). Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. Kullanıcının girmiş olduğu sayılardan çift olanlar console'a yazdırın.
        
        // int boyut;
        // ArrayList ciftSayilar = new ArrayList();
        // Console.Write("Dizi boyutunu giriniz = ");
        // boyut = int.Parse(Console.ReadLine());
        // int[] sayilar = new int[boyut];
        // for (int i = 0; i < sayilar.Length; i++)
        // { 
        //     Console.Write((i+1)+ ".Sayıyı giriniz = ");
        //     sayilar[i] = int.Parse(Console.ReadLine());
        //     if(sayilar[i]%2==0)
        //     {
        //         ciftSayilar.Add(sayilar[i]);
        //     }
        // }
        // Console.WriteLine("Girdiğiniz çift sayılar");
        // foreach (var item in ciftSayilar)
        // {
        //     Console.WriteLine(item);
        // }


        // 2-Bir konsol uygulamasında kullanıcıdan pozitif iki sayı girmesini isteyin (n, m). Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. Kullanıcının girmiş olduğu sayılardan m'e eşit yada tam bölünenleri console'a yazdırın.
        // int n;
        // int m;
        // ArrayList bolunenler = new ArrayList();
        // Console.Write("n sayısını giriniz= ");
        // n = int.Parse(Console.ReadLine());
        // Console.Write("m sayısını giriniz= ");
        // m = int.Parse(Console.ReadLine());
        // int[] sayilar = new int[n];
        // for (int i = 0; i < sayilar.Length; i++)
        // { 
        //     Console.Write((i+1)+ ".Sayıyı giriniz = ");
        //     sayilar[i] = int.Parse(Console.ReadLine());
        // }
        // foreach (var item in sayilar)
        // {
        //     if(item==m)
        //     {
        //         bolunenler.Add(item);
        //     }
        //     else if(m%item==0)
        //     {
        //         bolunenler.Add(item);
        //     }
        // }
        // Console.WriteLine("Eşit veya Tam bölenlerin listesi");
        // foreach (var item in bolunenler)
        // {
        //     Console.WriteLine(item);
        // }

        // 3-Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin (n). Sonrasında kullanıcıdan n adet kelime girmesi isteyin. Kullanıcının girişini yaptığı kelimeleri sondan başa doğru console'a yazdırın.

        // int sayi;
        // Console.WriteLine("Bir sayı giriniz");
        // sayi=int.Parse(Console.ReadLine());
        // string[] kelimeler = new string[sayi];
        // for (int i = 0; i < kelimeler.Length; i++)
        // {
        //     string kelime;
        //     Console.WriteLine((i+1)+".Kelimeyi giriniz");
        //     kelime=Console.ReadLine();
        //     kelimeler[i]=kelime;
        // }
        // kelimeler= kelimeler.Reverse().ToArray();
        // foreach (var item in kelimeler)
        // {
        //     Console.WriteLine(item);
        // }

        // 4-Bir konsol uygulamasında kullanıcıdan bir cümle yazması isteyin. Cümledeki toplam kelime ve harf sayısını console'a yazdırın.

        string cumle;
        Console.WriteLine("Bir cümle Yazınız:");
        cumle=Console.ReadLine();
        char[] character= cumle.ToCharArray();
        string[] kelimeler=cumle.Split(" ");
        Console.WriteLine("Cümledeki harf sayısı:"+ character.Length);
        Console.WriteLine("Cümledeki kelime sayısı:"+ kelimeler.Length);


        

    }
}