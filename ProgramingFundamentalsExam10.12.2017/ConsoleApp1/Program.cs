using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var regions = int.Parse(Console.ReadLine());
            var denisty = decimal.Parse(Console.ReadLine());

            decimal sum = 0.0M;

            bool isPossible = true;

            for (int i = 0; i < regions; i++)
            {
                var input = Console.ReadLine().Split();
                var rainDropsCount = long.Parse(input[0]);
                var squareMeters = double.Parse(input[1]);

                if (rainDropsCount <= 0 || squareMeters == 0)
                {
                    isPossible = false;
                    break;
                }
                else
                {
                    sum += (decimal)rainDropsCount / (decimal)squareMeters;


                }
            }
            //if (!isPossible)
            //{
            //    Console.WriteLine($"{sum:f3}");
            //}
            if (denisty == 0)
            {
                Console.WriteLine($"{sum:f3}");
            }
            else
            {
                double total = (double)sum / (double)denisty;
                Console.WriteLine($"{total:f3}");
            }
        }
    }
}
