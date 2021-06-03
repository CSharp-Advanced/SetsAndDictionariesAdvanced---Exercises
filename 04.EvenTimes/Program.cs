using System;
using System.Collections.Generic;

namespace _04.EvenTimes
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, int> info = new Dictionary<int, int>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());
                if (!info.ContainsKey(number))
                {
                    info.Add(number,0);
                }
                info[number]++;
            }
            foreach (var number in info)
            {
                if (number.Value%2==0)
                {
                    Console.WriteLine(number.Key);
                }
            }
        }
    }
}
