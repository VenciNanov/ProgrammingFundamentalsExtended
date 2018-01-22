using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Shellbound
{
    class Program
    {
        static void Main(string[] args)
        {
            var dict = new Dictionary<string, List<int>>();

            string inputArgs;

            while ((inputArgs=Console.ReadLine())!="Aggregate")
            {
                var input = inputArgs.Split().ToArray();

                var city = input[0];
                var shellSize = int.Parse(input[1]);

                if (dict.ContainsKey(city)&&dict[city].Contains(shellSize))
                {
                    continue;
                }

                if (!dict.ContainsKey(city))
                {
                    dict[city] = new List<int>();
                }
                dict[city].Add(shellSize);


            }

            foreach (var city in dict.Keys)
            {
                var sum = dict[city].Select(x => x).Sum();
                
                var giantShell = sum - (sum / dict[city].Count);

                Console.WriteLine($"{city} -> {string.Join(", ",dict[city])} ({giantShell}) ");

                
                //Console.Write($"({giantShell})");
            }
        }
    }
}
