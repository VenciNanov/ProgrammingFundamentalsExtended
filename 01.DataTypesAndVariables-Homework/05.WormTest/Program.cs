using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.WormTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var lengthInM = int.Parse(Console.ReadLine());
            var width = double.Parse(Console.ReadLine());

            var length = lengthInM * 100;

            var divide = length % width;

            

            if (divide==0)
            {
               long sum = length * (int)width;
                Console.WriteLine($"{sum:f2}");
            }
            else
            {
               double sum = (length / (double)width) * 100;
                Console.WriteLine($"{sum:f2}%");
            }
        }
    }
}
