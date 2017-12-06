using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.DictRef
{
    class Program
    {
        static void Main(string[] args)
        {
            var dict = new Dictionary<string, int>();



            while (true)
            {
                var input = Console.ReadLine().Split(new string[] { " ", "=" }, StringSplitOptions.RemoveEmptyEntries).ToArray();

                if (input[0] == "end")
                {
                    break;
                }

                var leftSide = input[0];
                var rightSide = input[1];

                var valueNum = 0;
                bool isDigit = int.TryParse(rightSide, out valueNum);

                if (isDigit)
                {
                    if (!dict.ContainsKey(leftSide))
                    {
                        dict.Add(leftSide, 0);
                    }
                    dict[leftSide] = valueNum;
                }
                else
                {
                    if (dict.ContainsKey(rightSide))
                    {
                        if (!dict.ContainsKey(leftSide))
                        {
                            dict.Add(leftSide, 0);
                        }
                        dict[leftSide] = dict[rightSide];

                    }
                }

                
                
            }
            foreach (var word in dict)
            {
                Console.WriteLine($"{word.Key} === {word.Value}");
            }
        }
    }
}
