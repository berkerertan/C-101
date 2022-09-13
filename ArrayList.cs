using System;
using System.Collections;
using System.Collections.Generic;


namespace arrayList // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //System.Collections namespace

            ArrayList liste =new ArrayList();
            // liste.Add("Ayşe");
            // liste.Add(2);
            // liste.Add(true);
            // liste.Add('A'); 

            // //içerisindekilere ulaşım
            // Console.WriteLine(liste[1]);
            // foreach (var item in liste)
            // {
            //     Console.WriteLine(item);
            // }

            //AddRange
            //string[] renkler={"kırmızı","sarı","yeşil"};
            List<int> sayılar = new List<int>(){1,8,3,7,9,92,5};
            //liste.AddRange(renkler);
            liste.AddRange(sayılar);
            foreach (var item in liste)
            {
                Console.WriteLine(item);
            }
            //sort
            Console.WriteLine();
            liste.Sort();
            foreach (var item in liste)
            {
                Console.WriteLine(item);
            }

            //binary Search

            Console.WriteLine(liste.BinarySearch(9));

            //reverse
            liste.Reverse();
            foreach (var item in liste)
            {
                Console.WriteLine(item);
            }

            //clear
            liste.Clear();
            






        }
    }
}
