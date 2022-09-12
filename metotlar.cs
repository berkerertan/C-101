using System;
namespace metotlar
{
    class Program
    {
     static void Main(string[] args)
        {
        // erisim_belirteci geri_donustipi metot_adi(parametreListesi/arguman)
        // {
        //     komutlar;
        // }

        int a = 2;
        int b =3 ;
        Console.WriteLine(a+b);

        int sonuc=Topla(a,b);
        Console.WriteLine(sonuc);
        
        Metotlar ornek = new Metotlar();
        ornek.EkranaYazdir(Convert.ToString(sonuc));
        int sonuc2 = ornek.ArttırveTopla(a,b);


     }
     static int Topla(int deger1,int deger2)
     {
        return(deger1+deger2);
        }
    }
    class Metotlar
    {
     public void EkranaYazdir(string veri);
        {
        Console.WriteLine(veri);
        }
    public int ArttırveTopla(int deger1,int deger2)
    {
        deger1 += 1;
        deger2 += 1;
        return deger1+deger2;

    }
    }
}