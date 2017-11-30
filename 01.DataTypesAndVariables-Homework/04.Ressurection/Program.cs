using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Ressurection
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var totalLength = int.Parse(Console.ReadLine());
                decimal totalWidth = decimal.Parse(Console.ReadLine());
                var lenghtOfWing = int.Parse(Console.ReadLine());

                decimal length = (decimal)Math.Pow(totalLength, 2);
                decimal width = totalWidth + (2 * lenghtOfWing);
                decimal sum = length * width;

                Console.WriteLine(sum);
            }

        }
    }
}
