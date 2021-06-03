using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.TheV_Logger
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, HashSet<string>>> platform = new Dictionary<string, Dictionary<string, HashSet<string>>>();

            string input = Console.ReadLine();

            while (input != "Statistics")
            {
                string[] tokens = input.Split();

                string vlogger = tokens[0];
                string command = tokens[1];

                if (command == "joined")
                {
                    if (!platform.ContainsKey(vlogger))
                    {
                        platform.Add(vlogger, new Dictionary<string, HashSet<string>>());
                        platform[vlogger].Add("followers", new HashSet<string>());
                        platform[vlogger].Add("following", new HashSet<string>());
                    }
                }
                else if (command == "followed")
                {
                    string followedVlogger = tokens[2];

                    if (vlogger != followedVlogger && platform.ContainsKey(vlogger) && platform.ContainsKey(followedVlogger))
                    {
                        platform[vlogger]["following"].Add(followedVlogger);
                        platform[followedVlogger]["followers"].Add(vlogger);
                    }
                }

                input = Console.ReadLine();
            }

            Console.WriteLine($"The V-Logger has a total of {platform.Count} vloggers in its logs.");

            int counter = 1;

            foreach (var vlogger in platform.OrderByDescending(v => v.Value["followers"].Count).ThenBy(v => v.Value["following"].Count))
            {
                Console.WriteLine($"{counter}. {vlogger.Key} : {vlogger.Value["followers"].Count} followers, {vlogger.Value["following"].Count} following");

                if (counter == 1)
                {
                    foreach (string follower in vlogger.Value["followers"].OrderBy(f => f))
                    {
                        Console.WriteLine($"*  {follower}");
                    }
                }

                counter++;
            }
        }
    }
}