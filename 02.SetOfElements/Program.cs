using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.SetOfElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int n = numbers[0];
            int m = numbers[1];

            HashSet<int> first = new HashSet<int>();
            HashSet<int> second = new HashSet<int>();
            List<int> similar = new List<int>();

            for (int i = 0; i < n; i++)
            {
                first.Add(int.Parse(Console.ReadLine()));
            }
            for (int i = 0; i < m; i++)
            {
                second.Add(int.Parse(Console.ReadLine()));
            }
            foreach (int number in first)
            {
                if (second.Contains(number))
                {
                    similar.Add(number);
                }
            }
            Console.WriteLine(string.Join(" ",similar)) ;
        }
    }
}
