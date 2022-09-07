internal class Program
{
    static void Main(string[] args)
    {
        int time = DateTime.Now.Hour;

        if(time >=5 && time <11)
            Console.WriteLine("günaydın");

        else if(time <= 18)
            Console.WriteLine("iyi günler");
        
        else
            Console.WriteLine("iyi geceler");

        string sonuc = time <=18 ? "iyi günler": "iyi geceler";
            Console.WriteLine(sonuc);

        string sonuc2 =time>=6 && time <11 ? "Günaydın":time <= 18 ? "iyi geceler": "iyi geceler";
            Console.WriteLine(sonuc2);

        




    }
}