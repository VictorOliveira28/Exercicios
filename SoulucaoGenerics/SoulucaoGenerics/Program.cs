﻿
using SoulucaoGenerics.Entities;
using System.Threading.Channels;

namespace SolucaoGenerics
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintService<int> printService = new PrintService<int>();


            Console.Write("How many values? ");
            int n = int.Parse(Console.ReadLine());

            for(int i = 0; i < n; i++)
            {
                int x = int.Parse(Console.ReadLine());
                printService.AddValue(x);
            }

            int a = printService.First();
            int b = a + 2;

            printService.Print();
            Console.WriteLine("First: " + printService.First());


        }
    }
}
