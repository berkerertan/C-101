internal class Program
{
    private static void Main(string[] args)
    {
        int deger;
        deger = 2;
        string degisken = null;
        Console.WriteLine(deger);

        byte b = 5; // 1 byte 
        sbyte c = 2; // 1 byte

        short s = 2; // 2 byte
        ushort us = 21; // 2 byte

        Int16 i16=2; // 2 byte

        int i = 2; // 4 byte

        Int32 i32 = 2; // 4 byte
        Int64 i64 = 2; // 8 byte
        long l = 2; // 4 byte
        ulong ul =2; // 8 byte

// Reel Sayılar
        float f = 5; //4 byte
        double d= 5;//8 byte
        decimal de = 2; // 16 byte

        char ce = '2';  // 2 byte
        string str = " berker"; //Sınırsız

        bool b1 = true; 

        DateTime dt = DateTime.Now;
        Console.WriteLine(dt);

        object o1 = "x";
        object o2 = 4.3;

        string str1 = string.Empty;
        str1="berker";
        string ad="berker";
        string soyad="ertan";
        string adsoyad = ad + " " + soyad;



        int integer1 = 5;
        int integer2 = 2;
        int integer3 = integer1*integer2;

// boolean
        bool bolts = 10<2;

        //değisken donusumlerı

        string str20 = "20";
        int int28 = 20;

        string newvalue= str20 + int28.ToString(); //cıktısı 40
        
        int i22 = int28 + int.Parse(str20); // cıktısı 40

        int dd = 5;
        string ddd = "merhaba";





    }
}