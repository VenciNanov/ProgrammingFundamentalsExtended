using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.OddOcurencies
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> dict = new Dictionary<string, int>();


            var input = Console.ReadLine().ToLower().Split().ToArray();

            foreach (var word in input)
            {
                if (dict.ContainsKey(word))
                {
                    dict[word]++;
                }
                else
                {
                    dict[word] = 1;
                }
              
            }
            var results = new List<string>();

            foreach (var word in dict)
            {
                if (word.Value%2!=0)
                {
                    results.Add(word.Key);
                }
            }
            Console.WriteLine(string.Join(", ",results));
        }
    }
}
