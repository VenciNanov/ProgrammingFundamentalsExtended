using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.SumMinMaxAverage
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var sum = new List<int>();

            for (int i = 0; i < n; i++)
            {
                sum.Add(int.Parse(Console.ReadLine()));

            }
            Console.WriteLine($"Sum = {sum.Sum()}");
            Console.WriteLine($"Min = {sum.Min()}");
            Console.WriteLine($"Max = {sum.Max()}");
            Console.WriteLine($"Average = {sum.Average()}");
        }
    }
}
