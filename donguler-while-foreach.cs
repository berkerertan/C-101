internal class Program
{
    static void Main(string[] args)
    {
        //while
        //1 den baslayarak konsoldan  girilen sayıya kadar ort. hesaplayıp konsola yazdırır.
        
        // Console.Write("Lutfen bır sayı girin:");

        // int sayi = Convert.ToInt32(Console.ReadLine());
        // int sayac =1;
        // int toplam = 0;
        // while (sayac<=sayi)
        // {
        //     toplam += sayac;
        //     sayac ++;
            
        // }
        
        // Console.WriteLine(toplam/sayac);

        // a' dan z'ye kadar olan tüm harfleri yazdır.
        char character = 'a';


        while (character<='z')
        {
            Console.Write(character);
            character ++;
        }

        //foreach

        string[] arabalar = {"BMW","MERCEDES","FORD","TOYOTA","NİSSAN"};

        foreach (var araba in arabalar)
        {
            Console.WriteLine(araba);
        }
    }
}