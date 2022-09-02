internal class Program
{
    private static void Main(string[] args)
    {
        int x = 3;
        int y = 3;
        y = y +2;

        Console.WriteLine(y);
        y+=2;
        Console.WriteLine(y);

        y/=1;
        Console.WriteLine(y);
        
        x*=2;
        Console.WriteLine(x);

        //Mantıksal operatorler 

        // ||= VEYA , && = VE, !=DEĞİL-TERSİ

        bool isSuccess = true;
        bool isComleted = false;

        if(isSuccess && isComleted)
        {
            Console.WriteLine("Perfect!");
        }
        if(isSuccess || isComleted)
        {
            Console.WriteLine("Great!");
        }
        if(isSuccess && !isComleted)
        {
            Console.WriteLine("Fine!");
        }

        //İlişkisel operatorler

        // <, >, <=, >=, ==, != 
        
        int a = 3;
        int b = 4;
        bool sonuc= a<b;
        Console.WriteLine(sonuc);
        sonuc = a>b;
        Console.WriteLine(sonuc);
        sonuc= a>=b;
        Console.WriteLine(sonuc);
        sonuc= a<=b;
        Console.WriteLine(sonuc);
        sonuc= a==b;
        Console.WriteLine(sonuc);
        sonuc= a!=b;
        Console.WriteLine(sonuc);

        //Aritmetik Operatorler
        // /,*,+,-

        int sayi1= 10;
        int sayi2=5;
        int sonuc1 = sayi1 / sayi2;
        Console.WriteLine(sonuc1);
        sonuc1 = sayi1 * sayi2;
        Console.WriteLine(sonuc1);
        sonuc1 = sayi1 + sayi2;
        Console.WriteLine(sonuc1);
        sonuc1 = sayi1 - sayi2;
        Console.WriteLine(sonuc1);
        sonuc1 = sayi1++;
        Console.WriteLine(sonuc1);

        // % mod almak  kalanı getiren ifade

        int sonuc2 = 20 %3;
        Console.WriteLine(sonuc2);








        



    }
}