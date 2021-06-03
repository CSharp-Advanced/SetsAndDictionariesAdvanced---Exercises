using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.CountSymbols
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<char, int> info = new Dictionary<char, int>();
            string text = Console.ReadLine();

            for (int i = 0; i < text.Length; i++)
            {
                if (!info.ContainsKey(text[i]))
                {
                    info.Add(text[i],0);
                }
                info[text[i]]++;
            }
            info=info.OrderBy(x => x.Key).ToDictionary(x=>x.Key,x=>x.Value);

            foreach (var symbol in info)
            {
                Console.WriteLine($"{symbol.Key}: {symbol.Value} time/s");
            }
        }
    }
}
