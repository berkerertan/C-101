using System;

namespace hazir_metotlar_string // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string degisken = "Dersimiz c# Hosgeldiniz";
            string degisken2 = "Dersimiz c#";


            //length;
            Console.WriteLine(degisken.Length);

            //toUpper,toLower
            Console.WriteLine(degisken.ToLower());
            Console.WriteLine(degisken.ToUpper());

            //Concat
            Console.WriteLine(string.Concat(degisken,"MERHABA"));

            //compare,CompareTo
            Console.WriteLine(degisken.CompareTo(degisken2));//0,1,-1
            Console.WriteLine(string.Compare(degisken,degisken2,true));
            Console.WriteLine(string.Compare(degisken,degisken2,false));

            //contains
            Console.WriteLine(degisken.Contains(degisken2));
            Console.WriteLine(degisken.EndsWith("Hosgeldiniz"));
            Console.WriteLine(degisken.StartsWith("Merhaba"));

            //IndexOf
            Console.WriteLine(degisken.IndexOf("cs"));
            Console.WriteLine(degisken.LastIndexOf("i"));

            //Insert
            Console.WriteLine(degisken.Insert(0,"Merhaba!"));
            
            //Padleft,PadRight
            Console.WriteLine(degisken+degisken2.PadLeft(30));
            Console.WriteLine(degisken+degisken2.PadLeft(30,'*'));
            Console.WriteLine(degisken.PadRight(30,'-')+degisken2);

            //remove
            Console.WriteLine(degisken.Remove(10));
            Console.WriteLine(degisken.Remove(5,3));
            Console.WriteLine(degisken.Remove(0,1));

            //replace
            Console.WriteLine(degisken.Replace("c#","CSharp"));

            //split
            Console.WriteLine(degisken.Split(' ')[1]);

            //substring
            Console.WriteLine(degisken.Substring(4));
            Console.WriteLine(degisken.Substring(4,6));



















            



        }
    }
}
