using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.GrabAndGo
{
    class Program
    {
        static void Main(string[] args)
        {
            long[] input = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();
            long n = int.Parse(Console.ReadLine());

            var count = 0;
            var tempC = 0;

            if (!input.Contains(n))
            {
                Console.WriteLine("No occurrences were found!");
            }
            else
            {
                for (int i = 0; i < input.Length; i++)
                {
                    count++;
                    if (input[i] == n)
                    {

                        tempC = count;
                    }
                }
                var numbers = input.Take(tempC-1);
           
                Console.WriteLine(numbers.Sum());
            }
            

        }
    }
}
