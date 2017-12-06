using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.LetterRepetition
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().ToCharArray();

            var dict = new Dictionary<char, int>();

            foreach (var letter in input)
            {
                if (!dict.ContainsKey(letter))
                {
                    dict[letter] = 0;
                }
                dict[letter]++;

            }
            foreach (var letter in dict)
            {
                Console.WriteLine($"{letter.Key} -> {letter.Value}");

            }

            
        }
    }
}
