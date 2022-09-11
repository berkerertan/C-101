internal class Program
{
    private static void Main(string[] args)
    {
        //sort
        int[] sayiDizisi ={23,12,4,86,72,3,11,17};
            Console.WriteLine("*****sırasız dizi*****");

        foreach (var sayi in sayiDizisi)
        {
            Console.WriteLine(sayi);
        }
            Console.WriteLine("*****sıralı dizi*****");
            Array.Sort(sayiDizisi);

         foreach (var sayi in sayiDizisi)
        {
            Console.WriteLine(sayi);
        }
        Console.WriteLine("*****array clear*****");

        Array.Clear(sayiDizisi,2,2);
        //sayidizisi elemanlarını kullanarak 2. indexten itibaren 2 tane elemanı sıfırlar
        foreach (var sayi in sayiDizisi)
        {
            Console.WriteLine(sayi);
        }
        Console.WriteLine("*****array reverse*****");

        Array.Reverse(sayiDizisi);
        foreach (var sayi in sayiDizisi)
        {
            Console.WriteLine(sayi);
        }
        Console.WriteLine("*****array IndexOf*****");
        Console.WriteLine(Array.IndexOf(sayiDizisi,23));

        Console.WriteLine("*****resize*****");

        Array.Resize<int>(ref sayiDizisi,9);
        sayiDizisi[8] = 99;
        foreach (var sayi in sayiDizisi)
        {
            Console.WriteLine(sayi);
        }














    }
}