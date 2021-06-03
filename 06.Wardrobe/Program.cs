using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.Wardrobe
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string,int>> wardrobe = new Dictionary<string, Dictionary<string,int>>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] tokens = Console.ReadLine().Split(" -> ",StringSplitOptions.RemoveEmptyEntries);
                string color = tokens[0];

                if (true)
                {
                    if (!wardrobe.ContainsKey(color))
                    {
                        wardrobe.Add(color,new Dictionary<string,int>());
                    }
                }
                string[] items = tokens[1].Split(',',StringSplitOptions.RemoveEmptyEntries);

                foreach (var item in items)
                {
                    if (!wardrobe[color].ContainsKey(item))
                    {
                        wardrobe[color].Add(item, 0);
                    }
                    wardrobe[color][item]++;
                }
            }

            string[] toSearch = Console.ReadLine().Split();

            foreach (var item in wardrobe)
            {
                Console.WriteLine($"{item.Key} clothes:");
                foreach (var dress in item.Value)
                {
                    if (isFound(toSearch, item, dress))
                    {
                        Console.WriteLine($"* {dress.Key} - {dress.Value}");
                    }
                    else
                    {
                        Console.WriteLine($"* {dress.Key} - {dress.Value} (found!)");
                    }
                }
            }
        }

        private static bool isFound(string[] toSearch, KeyValuePair<string, Dictionary<string, int>> item, KeyValuePair<string, int> dress)
        {
            return !(toSearch[0] == item.Key && toSearch[1] == dress.Key);
        }
    }
}
