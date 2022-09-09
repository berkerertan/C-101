internal class Program
{
    private static void Main(string[] args)
    {
        int mounth = DateTime.Now.Month;

        switch (mounth) // expression
        {
            case 1:
                Console.WriteLine("Ocak Ayı");
                break;
            case 2:
                Console.WriteLine("Şubat Ayı");
                break;
            case 3:
                Console.WriteLine("Mart Ayı");
                break;
            case 9:
                Console.WriteLine("Eylül Ayı");
                break;




            default:
                Console.WriteLine("yanlış değer");
                
            break;
        }

        switch (mounth)
        {
            case 12:
            case 1:
            case 2:
                Console.WriteLine("Kış ayındasınız");
                break;
            case 3:
            case 4:
            case 5:
                Console.WriteLine("ilk bahar ayındasınız");
                break;
            case 6:
            case 7:
            case 8:
                Console.WriteLine("yaz ayındasınız");
                break;
            case 9:
            case 10:
            case 11:
                Console.WriteLine("sonbahar ayındasınız");
                break;

            default:
            break;
        }
    }
}