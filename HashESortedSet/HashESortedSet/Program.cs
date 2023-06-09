﻿using HashESortedSet.Entities;
namespace HashESortedSet
{
    class Program
    {
        static void Main(string[] args)
        {
            /*HashSet<string> set = new HashSet<string>();

            set.Add("TV");
            set.Add("Notebook");
            set.Add("Tablet");

            Console.WriteLine(set.Contains("Computer"));

            foreach (string item in set)
            {
                Console.WriteLine(item);
            }

            //SortedSet
            Console.WriteLine();
            Console.WriteLine("*********SORTEDSET*********");
            Console.WriteLine();

            SortedSet<int> a = new SortedSet<int>() { 0, 2, 4, 5, 6, 8, 10 };
            SortedSet<int> b = new SortedSet<int>() { 5, 6, 7, 8, 9, 10 };

            //union

            SortedSet<int> c = new SortedSet<int>(a);
            c.UnionWith(b);

            PrintCollection(c);

            //intersection

            SortedSet<int> d = new SortedSet<int>(a);
            d.IntersectWith(b);

            PrintCollection(d);

            //difference

            SortedSet<int> e = new SortedSet<int>(a);
            e.ExceptWith(b);
            PrintCollection(e);*/

            HashSet<Product> products = new HashSet<Product>();
            products.Add(new Product("TV", 900.0));
            products.Add(new Product("Notebook", 1200.0));


            HashSet<Point> points = new HashSet<Point>();
            points.Add(new Point(3, 4));
            points.Add(new Point(5, 10));

            Product prod = new Product("Notebook", 1200.0);

            Console.WriteLine(products.Contains(prod));

            Point p = new Point(5, 10);
            Console.WriteLine(points.Contains(p));





        }

        static void PrintCollection<T>(IEnumerable<T> collection)
        {
        foreach (T item in collection)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }
}
