using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.RainAir
{
    class Program
    {
        static void Main(string[] args)
        {
            var dict = new Dictionary<string, List<int>>();

            string str;

            while ((str = Console.ReadLine()) != "I believe I can fly!")
            {
                if (str.Contains(" = "))
                {
                    var input = str.Split(new[] { " = " },StringSplitOptions.RemoveEmptyEntries);
                    var customer1 = input[0];
                    var customer2 = input[1];

                    if (!dict.ContainsKey(customer2))
                    {
                        dict[customer1] = new List<int>();
                    }
                    dict[customer1].Clear();
                    dict[customer1].AddRange(dict[customer2]);
                    
                }
                else
                {
                    var input = str.Split();

                    var customer = input.First();
                    var flights = input.Skip(1).Take(input.Length - 1).Select(int.Parse).ToList();

                    if (!dict.ContainsKey(customer))
                    {
                        dict[customer] = new List<int>();
                    }
                    dict[customer].AddRange(flights);
                }
            }
            foreach (var customer in dict.OrderByDescending(x=>x.Value.Count).ThenBy(y=>y.Key).)
            {
                Console.WriteLine($"#{customer.Key} ::: {string.Join(", ",customer.Value.OrderBy(x=>x))}");
            }
        }
    }
}
