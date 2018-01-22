using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.SoftUniKaraoke
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> participants = Console.ReadLine().Split(new[] { ", " },StringSplitOptions.RemoveEmptyEntries).ToList();
            List<string> songs = Console.ReadLine().Split(new[] { ", " }, StringSplitOptions.RemoveEmptyEntries).ToList();

            string str;

            var dict = new Dictionary<string, SortedSet<string>>();

            while ((str= Console.ReadLine())!="dawn")
            {
                var input = str.Split(new[] { ", " },StringSplitOptions.RemoveEmptyEntries);

                var name = input[0];
                var songName = input[1];
                var award = input[2];

                if (!participants.Contains(name)||!songs.Contains(songName))
                {
                    continue;
                }
                if (!dict.ContainsKey(name))
                {
                    dict.Add(name, new SortedSet<string>());
                }
                dict[name].Add(award);
            }
            if (dict.Count==0)
            {
                Console.WriteLine("No awards");
                return;
            }

            foreach (var participant in dict.OrderByDescending(x=>x.Value.Count).ThenBy(p=>p.Key))
            {
                Console.WriteLine($"{participant.Key}: {participant.Value.Count} awards");

                foreach (var award in participant.Value)
                {
                    Console.WriteLine($"--{award}");
                }
            }

        }
    }
}
