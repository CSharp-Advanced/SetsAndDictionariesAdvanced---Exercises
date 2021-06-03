using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.PeriodicTable
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedSet<string> elements = new SortedSet<string>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();
                foreach (string element in input)
                {
                    elements.Add(element);
                }
            }
            foreach (string element in elements)
            {
                Console.Write($"{element} ");
            }
        }
    }
}
